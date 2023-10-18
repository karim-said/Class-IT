using System;

class WashMashine
{
    public string Name { get; set; } = "Samsung";
    public bool Status { get; set; } = false;
    public Mode WashingMode { get; set; } = Mode.Normal;
    int Speed = 0;

    public enum Mode
    {
        Normal,
        Quick,
        Wool,
        Allergen,
        SelfClean
    }

    public void Start()
    {
        if (Status == false)
        {
            Status = true;
            Console.WriteLine("WashMashine started.");
        }
        else
        {
            Console.WriteLine("WashMashine is already on.");
        }
    }

    public void Stop()
    {
        if (!Status)
        {
            Status = false;
            Console.WriteLine("WashMashine stopped.");
        }
        else
        {
            Console.WriteLine("WashMashine is already off.");
        }
    }

    public void ChooseMode(Mode mode)
    {
        switch (mode)
        {
            case Mode.Normal:
                Console.WriteLine($"Selected mode: {mode}");
                break;
            case Mode.SelfClean:
                Console.WriteLine($"Selected mode: {mode}");
                break;
            case Mode.Quick:
                Console.WriteLine($"Selected mode: {mode}");
                break;
            case Mode.Allergen:
                Console.WriteLine($"Selected mode: {mode}");
                break;
        }
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
        myWashMashine.ChooseMode(WashMashine.Mode.Normal);
        myWashMashine.AddWater();
        myWashMashine.CloseDoor();
        myWashMashine.Start(); 
        myWashMashine.Stop();
        myWashMashine.ClearWater();
        myWashMashine.OpenDoor();
        myWashMashine.Stop(); 
    }
}
