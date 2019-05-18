using System;

namespace VendingSimulator
{
    class Program
    {
        static void Main(string[] args)
        {



            Button Button1 = new Button();
            Button1.Num = 1;
            Button1.Name = "Coke";
            Button1.isLit = false;
            Button1.Price = 1.25;

            Button Button2 = new Button();
            Button2.Num = 2;
            Button2.Name = "Sprite";
            Button2.isLit = true;
            Button2.Price = 1.25;

            Button Button3 = new Button();
            Button3.Num = 3;
            Button3.Name = "Dr Pepper";
            Button3.isLit = false;
            Button3.Price = 1.25;

            Button Button4 = new Button();
            Button4.Num = 4;
            Button4.Name = "Mr Pibb";
            Button4.isLit = true;
            Button4.Price = 1.25;

            Button Button5 = new Button();
            Button5.Num = 5;
            Button5.Name = "Mellow Yellow";
            Button5.isLit = true;
            Button5.Price = 1.25;

            Button Button6 = new Button();
            Button6.Num = 6;
            Button6.Name = "Water";
            Button6.isLit = true;
            Button6.Price = 1.50;
               

            Button[] B = new Button[6];
            B[0] = Button1;
            B[1] = Button2;
            B[2] = Button3;
            B[3] = Button4;
            B[4] = Button5;
            B[5] = Button6;


            System.Console.WriteLine(Button1.GetButtonStatus());
            System.Console.WriteLine(Button2.GetButtonStatus());
            System.Console.WriteLine(Button3.GetButtonStatus());
            System.Console.WriteLine(Button4.GetButtonStatus());
            System.Console.WriteLine(Button5.GetButtonStatus());
            System.Console.WriteLine(Button6.GetButtonStatus());


            System.Console.WriteLine();
            System.Console.WriteLine();

            System.Console.Write("Enter the number of the beverage you would like :");
            string askUser = System.Console.ReadLine();
            int userInput = int.Parse(askUser);

            bool wrong = true;
            while (wrong == true)
            {

                if (userInput > 6)
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine("That is not a valid selection. Please select a number 1-6");
                    wrong = true;
                    askUser = System.Console.ReadLine();
                    userInput = int.Parse(askUser);
                }

                if (userInput < 1)
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine("That is not a valid selection. Please select a number 1-6");
                    wrong = true;
                    askUser = System.Console.ReadLine();
                    userInput = int.Parse(askUser);

                };
                if (userInput < 6 && userInput > 1)
                {
                    wrong = false;

                }

            }
            int num = B[userInput].Num;
            string name = B[userInput].Name;
            bool isAvailable = B[userInput].isLit;
            double price = B[userInput].Price;
            

            System.Console.WriteLine("Your selected beverage is is " + name);
            if (isAvailable == false)
            {
                System.Console.WriteLine("Sorry, that beverage is unavailable at this time.");
            }
            else
            {
                System.Console.WriteLine("That will be $" + price + " please insert money below");
            }


        }

        public static int userInput { get; private set; }
        // I don't feel the need to account for decimals because we are assuming a physical input, and no one is going to hit button 1.5
    }
            //  public double user selected = 0;

        }


            


    


