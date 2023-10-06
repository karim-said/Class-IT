using System;

class WashMashine
{
    public string Name { get; set; }
    public string State { get; set; }
    public string Mode { get; set; }
    public int Speed { get; set; }


    public WashMashine()
    {
        Name = "WashMashine";
        State = "Off";
        Mode = "Normal";
        Speed = 0;
    }

    public void Start()
    {
        if (State == "Off")
        {
            State = "On";
            Console.WriteLine("WashMashine started.");
        }
        else
        {
            Console.WriteLine("WashMashine is already on.");
        }
    }

    public void Stop()
    {
        if (State == "On")
        {
            State = "Off";
            Console.WriteLine("WashMashine stopped.");
        }
        else
        {
            Console.WriteLine("WashMashine is already off.");
        }
    }

    public void ChooseMode(string mode)
    {
        Mode = mode;
        Console.WriteLine($"Selected mode: {mode}");
    }

    public void AddWater()
    {
        Console.WriteLine("Water added to the WashMashine.");
    }

    public void OpenDoor()
    {
        Console.WriteLine("Door opened.");
    }

    public void CloseDoor()
    {
        Console.WriteLine("Door closed.");
    }

    public void ClearWater()
    {
        Console.WriteLine("Water cleared from the WashMashine.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        WashMashine myWashMashine = new WashMashine();
        myWashMashine.Start();
        myWashMashine.ChooseMode("Quick");
        myWashMashine.AddWater();
        myWashMashine.CloseDoor();
        myWashMashine.Start(); 
        myWashMashine.Stop();
        myWashMashine.ClearWater();
        myWashMashine.OpenDoor();
        myWashMashine.Stop(); 
    }
}
