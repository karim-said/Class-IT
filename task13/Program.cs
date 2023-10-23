namespace tassk_13
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Mouse mouse = new Mouse(100, 1, 5000, 100000, true);
            mouse.On();
            mouse.Off();
            mouse.Click();
            mouse.MoveBack();
            mouse.MoveFront();  
            mouse.MoveLeft();
            mouse.MoveRight();
            mouse.DoubleClick();
            mouse.EventKeyUp();
            mouse.EventKeyDown();
        }
    }
}