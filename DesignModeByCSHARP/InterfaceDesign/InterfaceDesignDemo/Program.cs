using System;

namespace InterfaceDesignDemo
{
  class Program
  {
    static void Main(string[] args)
    {
      AlarmDoor alarmDoor = new AlarmDoor();
      IAlarm IAlarm = new AlarmDoor();

      alarmDoor.OpenDoor();
      alarmDoor.CloseDoor();
      IAlarm.OpenAlarm();

      Console.WriteLine("Hello World!");
    }
  }
}
