using System;
using System.Xml;

namespace StoreApplication
{
    class MainDisplay
    {
         static void Main(string[] args)
        {
            string choice;
            bool shopMore = true;
            Console.WriteLine("\n\nProject 0: Store Application ");
           
            do
            {   
                Console.Write("\nSelect the right Option!:");
                Console.WriteLine("\n1. Customer's Options" + 
                             "\n2. Store's Options" +
                             "\n3. End Program");
                             
                choice = Console.ReadLine(); //Throw Exception
                switch (choice)
                {
                    case "1": 
                        string customerChoice;
                        Console.WriteLine("\n\nCustomer's Options" +
                                        "\n1.Register" +
                                        "\n2.Shop" +
                                        "\n3.Show Order" +
                                        "\n(Press any key to Exit)");
                        Console.Write("\nSelect the right option you want:");

                        //Throw Exception
                        customerChoice = Console.ReadLine();

                            if (customerChoice == "1")
                            {
                                var account = new Customer(Console.ReadLine());
                                Console.WriteLine($"Account number{account.ID} was created for {account.Name} with {account.Balance} Balance");

                            }
                        
                                else if (customerChoice == "2")
                            {
                                //Shop Here
                            }
                        
                                else if (customerChoice == "3")
                            {
                                //Show order
                            }

                                else
                            {
                                //Terminate Program
                            }

                        break;

                    case "2": //throw exception for wrong input
                        Console.WriteLine("\n\nOwner's Options" +
                                        "\n1.Add Store" +
                                        "\n2.Show Order History" +
                                        "\n3.Show Products" +
                                        "\n4.Add Products"+
                                        "\n(Press any key to Exit)");
                        string ownerChoice;
                        Console.Write("\nSelect the right option you want:");
                        
                        //Throw Exception
                        ownerChoice = Console.ReadLine();

                        if (ownerChoice == "1")
                            {
                                //add store
                            }
                        
                                else if (ownerChoice == "2")
                            {
                                //show order history
                            }
                        
                                else if (ownerChoice == "3")
                            {
                                //Show product
                            }
                                else if (ownerChoice == "4")
                            {
                                //add product
                            }

                                else
                            {
                                //Terminate Program
                            }
                
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
