using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV();
            ICommand tvON = new TVonCommand(tv);
            ICommand tvRaiseLevel = new TVlevelCommand(tv);
            RemoteControl remoteControl = new RemoteControl();
            remoteControl.SetCommand(0, tvON);
            remoteControl.SetCommand(1, tvRaiseLevel);
            remoteControl.PressButton(0);
            remoteControl.PressButton(1);
            remoteControl.PressButton(1);
            remoteControl.PressButton(1);
            remoteControl.PressButton(1);
            remoteControl.PressUndoButton();
            remoteControl.PressUndoButton();
            remoteControl.PressUndoButton();
            remoteControl.PressUndoButton();
            remoteControl.PressUndoButton();
            Microwave microwave = new Microwave();
            ICommand microwaveCommand = new MicrowaveCommand(5000, microwave);
            remoteControl.SetCommand(0, microwaveCommand);
            remoteControl.PressButton(0);
            Console.WriteLine("wait...");
            remoteControl.PressUndoButton();
            Console.ReadKey();
        }
    }
}
