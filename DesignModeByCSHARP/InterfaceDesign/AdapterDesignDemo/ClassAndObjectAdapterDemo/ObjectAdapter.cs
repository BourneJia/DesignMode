public class ObjectAdapter:ITarget
{
    public void Request(){
        Adaptee _Adaptee = new Adaptee();

        _Adaptee.ResultWay();
    }
}