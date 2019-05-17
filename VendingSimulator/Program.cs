using System;

namespace VendingSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Button Button1 = new Button();
            Button1.Name = "Coke";
            Button1.isLit = false;
            Button1.Price = 1.25;

            Button Button2 = new Button();
            Button2.Name = "Sprite";
            Button2.isLit = true;
            Button2.Price = 1.25;

            Button Button3 = new Button();
            Button3.Name = "Dr Pepper";
            Button3.isLit = false;
            Button3.Price = 1.25;

            Button Button4 = new Button();
            Button4.Name = "Mr Pibb";
            Button4.isLit = true;
            Button4.Price = 1.25;

            Button Button5 = new Button();
            Button5.Name = "Mellow Yellow";
            Button5.isLit = true;
            Button5.Price = 1.25;

            Button Button6 = new Button();
            Button6.Name = "Water";
            Button6.isLit = true;
            Button6.Price = 1.50;


            System.Console.WriteLine(Button1.GetButtonStatus());
        }
    }
}
