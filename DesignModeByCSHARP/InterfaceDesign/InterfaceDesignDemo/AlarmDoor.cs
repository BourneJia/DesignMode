using System;

public class AlarmDoor : Door,IAlarm
{
  public override void OpenDoor(){
    Console.WriteLine("AlarmDoor Open");
  }
  public void OpenAlarm(){
    Console.WriteLine("OpenAlarm");
  }
  public void CloseAlarm(){
    Console.WriteLine("CloseAlarm");
  }
}