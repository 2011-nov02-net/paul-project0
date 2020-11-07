using System;
using System.Xml;

namespace Main
{
    class MainDisplay
    {
         static void Main(string[] args)
        {
            string choice;
            bool shopMore = true;
            Console.WriteLine("\n\nProject 0: Store Application ");
           
            do
            {   //throw exception for wrong input
                Console.Write("\nSelect the right option you wanted to do:");
                Console.WriteLine("\n1. Customer's Options" + 
                             "\n2. Store's Options" +
                             "\n3. End Program");
                             
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": //throw exception for wrong input
                        Console.WriteLine("\n\nCustomer's Options" +
                                        "\n1.Register" +
                                        "\n2.Shop" +
                                        "\n3.Show Order" +
                                        "\n4.Exit");
                //other methods here
                        break;

                    case "2": //throw exception for wrong input
                        Console.WriteLine("\n\nOwner's Options" +
                                        "\n1.Add Store" +
                                        "\n2.Show Order History" +
                                        "\n3.Show Products" +
                                        "\n4.Add Products"+
                                        "\n4.Exit");
                //other methods here
                        break;
                    case "3":
                        Console.WriteLine("GoodBye Shopper!");
                        shopMore = false;
                        break;
                //force terminate here

                }
            //throw exception for wrong input
            Console.WriteLine("\n\nDo you want to shop more? Press \"1\" for Yes or \"0\" For No");
            string pick;
            pick = Console.ReadLine();
            if (pick == "1")
            {
                shopMore = true;
            }
            else
            {
                shopMore = false;
            }

            } while (shopMore);
        }
    }
}
