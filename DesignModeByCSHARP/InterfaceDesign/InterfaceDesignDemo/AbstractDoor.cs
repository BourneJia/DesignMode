using System;

public abstract class Door{
    public virtual void OpenDoor()
    {
        Console.WriteLine("OpenDoor");
    }

    public virtual void CloseDoor()
    {
        Console.WriteLine("CloseDoor");
    }
}