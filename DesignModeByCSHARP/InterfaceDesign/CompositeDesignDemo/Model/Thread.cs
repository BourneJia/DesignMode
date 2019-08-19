using System;

public class Thread:AbstractThread
{
    public override void RenderContent()
    {
        Console.WriteLine(" Thread:" + this.Content);
        foreach(IThread t in this.Children)
        {
            t.RenderContent();
        }
    }
}