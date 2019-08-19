public class ClientDemo
{
    public void TestClassAdapter(){
        ITarget _ITarget = new ClassAdapter();

        _ITarget.Request();
    }

    public void TestObjectAdapter(){
        ITarget _ITarget = new ObjectAdapter();

        _ITarget.Request();
    }
}