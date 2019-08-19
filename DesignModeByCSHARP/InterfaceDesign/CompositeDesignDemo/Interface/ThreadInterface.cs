public interface IThread
{
    void Add(IThread thread);
    void Remove(IThread thread);
    void RenderContent();
}