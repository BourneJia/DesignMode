using System;

public class Message:AbstractThread
{
    public override void RenderContent()
    {
        Console.WriteLine(" Message:" + this.Content);
        foreach(IThread t in this.Children)
        {
            t.RenderContent();
        }
    }
}