using System;
using System.Data;
using System.Collections.Generic;

public class ThreadFactory
{
    DataTable table = new DataTable();

    public ThreadFactory()
    {
        table.Columns.Add("Content");
        table.Columns.Add("IsTop");
        table.Columns.Add("IsMessage");
        table.Columns.Add("ID");
        table.Columns.Add("ParentID");
        DataRow row = table.NewRow();

        row["Content"] = "test";
        row["IsTop"] = false;
        row["IsMessage"] = false;
        row["ID"] = 1;
        row["ParentID"] = 0;
        table.Rows.Add(row);

        row = table.NewRow();
        row["Content"] = "test1";
        row["IsTop"] = true;
        row["IsMessage"] = false;
        row["ID"] = 0;
        row["ParentID"] = -1;
        table.Rows.Add(row);

        row = table.NewRow();
        row["Content"] = "test2";
        row["IsTop"] = false;
        row["IsMessage"] = true;
        row["ID"] = 2;
        row["ParentID"] = 0;
        table.Rows.Add(row);

        row = table.NewRow();
        row["Content"] = "test3";
        row["IsTop"] = false;
        row["IsMessage"] = true;
        row["ID"] = 3;
        row["ParentID"] = 0;
        table.Rows.Add(row);
    }
    public List<IThread> GetTopThreads()
    {
        List<IThread> list = new List<IThread>();
        DataRow[] rows = table.Select("IsTop = true");

        foreach(DataRow row in rows)
        {
            Thread t = new Thread();
            t.Content = row["Content"].ToString();
            t.IsTop = true;
            DataRow[] cs = table.Select("ParentID =" + Convert.ToInt32(row["ID"]));
            foreach(DataRow r in cs)
            {
                if(Convert.ToBoolean(r["IsMessage"]))
                {
                    Message m = new Message();
                    m.Content = r["Content"].ToString();
                    m.IsTop = false;
                    t.Add(m);
                }
                else
                {
                    Thread tt = new Thread();
                    tt.Content = r["Content"].ToString();
                    tt.IsTop = false;
                    t.Add(tt);
                }
            }
            list.Add(t);
        }
        return list;
    }
}