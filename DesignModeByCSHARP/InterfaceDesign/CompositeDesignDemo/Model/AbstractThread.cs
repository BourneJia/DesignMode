using System.Collections.Generic;

public abstract class AbstractThread : IThread
{
    public bool IsTop { get; set; }

    public List<IThread> Children { get; set;}

    public string Content { get ; set ; }

    public void Add(IThread _IThread)
    {
        Children.Add(_IThread);
    }

    public void Remove(IThread _IThread)
    {
        Children.Remove(_IThread);
    }

    public abstract void RenderContent();
}