using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class TV
    {
        private const int LOW = 0;
        private const int HIGH = 15;
        public int _vlevel = 0;
        public void On()=> Console.WriteLine("Телевизор включен");
        public void Off() => Console.WriteLine("Телевизор выключается...");
        public void RaiseLevel()
        {
            if (_vlevel < HIGH)
                _vlevel++;
            Displaylevel();
        }
        public void DropLevel()
        {
            if (_vlevel > LOW)
                _vlevel--;
            Displaylevel();
        }
        private void Displaylevel() => Console.WriteLine($"Текущий уровень громкости:{_vlevel}");
    }
    class Microwave
    {
        public void StartCooking(int seconds)
        {
            Console.WriteLine("Подогреваем еду...");
            Task.Delay(seconds).GetAwaiter().GetResult();
        }
        public void StopCooking()
        {
            Console.WriteLine("Еда подогрета!");
        }
    }
    class RemoteControl
    {
        ICommand[] buttons;
        Stack<ICommand> history;
        public RemoteControl()
        {
            buttons = new ICommand[2];
            history = new Stack<ICommand>();
            for (int i = 0; i < buttons.Length; i++)
                buttons[i] = new NoCommand();
        }
        public void SetCommand(int numButton, ICommand command)
        {
            buttons[numButton] = command;
        }
        public void PressButton(int numButton)
        {
            buttons[numButton].Execute();
            history.Push(buttons[numButton]);
        }
        public void PressUndoButton()
        {
            if(history.Count>0)
            {
                // ???
                history.Pop().Undo();
            }
        }
    }
    interface ICommand
    {
        void Execute();
        void Undo();
    }
    class NoCommand: ICommand
    {
        public void Execute() { }
        public void Undo() { }
    }
    class TVonCommand:ICommand
    {
        TV _tv;
        public TVonCommand(TV tv)
        {
            _tv = tv;
        }
        public void Execute()
        {
            _tv.On();
        }
        public void Undo()
        {
            _tv.Off();
        }
    }
    class TVlevelCommand: ICommand
    {
        TV _tv;
        public TVlevelCommand(TV tv)
        {
            _tv = tv;
        }
        public void Execute()
        {
            _tv.RaiseLevel();
        }
        public void Undo()
        {
            _tv.DropLevel();
        }
    }
    class MicrowaveCommand: ICommand
    {
        private Microwave _microwave;
        private int _cooking_time;
        public MicrowaveCommand(int seconds,Microwave microwave)
        {
            _microwave = microwave;
            _cooking_time = seconds;
        }
        public void Execute()
        {
            _microwave.StartCooking(_cooking_time);
            _microwave.StopCooking();
        }
        public void Undo()
        {
            _microwave.StopCooking();
        }
    }
}
