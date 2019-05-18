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


            Button[] B = new Button[6] { Button1, Button2, Button3, Button4, Button5, Button6 };
   


            System.Console.WriteLine(Button1.GetButtonStatus());
            System.Console.WriteLine(Button2.GetButtonStatus());
            System.Console.WriteLine(Button3.GetButtonStatus());
            System.Console.WriteLine(Button4.GetButtonStatus());
            System.Console.WriteLine(Button5.GetButtonStatus());
            System.Console.WriteLine(Button6.GetButtonStatus());


            System.Console.WriteLine();
            System.Console.WriteLine();


         //   System.Console.Write("Button1.Name is " + Button1.Name);

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
                if (userInput <= 6 && userInput >= 1)
                {
                    wrong = false;

                }

            }
            int num = B[userInput -1].Num;
            string name = B[(userInput -1)].Name;
            bool isAvailable = B[userInput -1].isLit;
            double price = B[userInput -1].Price;
            

            System.Console.WriteLine("Your selected beverage is " + name);
            if (isAvailable == false)
            {
                System.Console.WriteLine("Sorry, that beverage is unavailable at this time.");
                Environment.Exit(0);
            }
            else
            {
                System.Console.WriteLine("That will be $" + price + "! please insert money");
            }

            Console.Write("$");
            string askForMoney = System.Console.ReadLine();
            double moneyGiven = double.Parse(askForMoney);
            double moneyRequired = price;
            System.Console.Write("You entered $" +moneyGiven + " ");

            if (moneyGiven == moneyRequired)
            {
                System.Console.WriteLine();

                System.Console.WriteLine("Here is your " + name + ". Have a great day and please hire me!;");
                Environment.Exit(0);
            }

            while (moneyGiven <= moneyRequired || moneyGiven > 5)
            {
                if (moneyGiven > 5)
                {
                    System.Console.WriteLine("Sorry, I only accept $1 bills, $5 bills and change, please give me smaller change");
                    askForMoney = System.Console.ReadLine();
                    moneyGiven = double.Parse(askForMoney);
                }

                if (moneyGiven < moneyRequired)
                {
                    moneyRequired = (moneyRequired - moneyGiven);
                    System.Console.WriteLine("Thank you, please insert $" + moneyRequired);
                    Console.Write("$");
                    askForMoney = System.Console.ReadLine();
                    moneyGiven = double.Parse(askForMoney);
                }
                else
                {
                    break;
                }

            }

            if (moneyGiven > moneyRequired)
            {
                double change = moneyGiven - moneyRequired;
                System.Console.WriteLine("Thank you, here is your change: $" + change);

            }
            System.Console.WriteLine();

            System.Console.WriteLine("Here is your " + name +". Have a great day and please hire me!;");
            Environment.Exit(0);



        }

    }



}








