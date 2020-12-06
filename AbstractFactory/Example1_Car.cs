using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    
    abstract class Engine
    {
        public int Horspower { get; }
        public int Volume { get; }
        public Engine(int h, int v)
        {
            Horspower = h;
            Volume = v;
        }
        public string Info() => $"Объём двигателя: {Volume}, {Horspower} л.с.";
    }
    class V_engine : Engine
    {
        public V_engine(int a, int b) : base(a, b) { }
    }
    class R_engine : Engine
    {
        public R_engine(int e,int i): base(e, i) { }
    }
    abstract class Frame
    {
        public string name { get; }
        public Frame(string n) => name = n;
    }
    class V_frame : Frame
    {
        public V_frame(string s) : base(s) { }
    }
    class R_frame : Frame
    {
        public R_frame(string d) : base(d) { }
    }
    ////////////////////////////////////////////////
    
    abstract class Factory
    {
        /*public Engine engine { get; }
        public Frame frame { get; }*/
        public abstract Engine CreateEngine();
        public abstract Frame CreateFrame();
    }
    class FactoryV : Factory
    {
        public override Engine CreateEngine() => new V_engine(125, 2);
        public override Frame CreateFrame() => new V_frame("sedan");
    }
    class FactoryR : Factory
    {
        public override Engine CreateEngine() => new R_engine(8, 1);
        public override Frame CreateFrame() => new R_frame("universal");
    }
    ////////////////////////////////////////////////
    
    class Car
    {
        public Engine engine;
        public Frame frame;
        public Car(Factory factory)
        {
            engine = factory.CreateEngine();
            frame = factory.CreateFrame();
        }
        public string About() => $"Automobile with frame:\"{frame.name}\"; tth: {engine.Info()}";
    }

}
