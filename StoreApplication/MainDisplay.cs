using System;
using StoreLibrary;
using System.Xml;

namespace StoreConsoleApplication
{
    class MainDisplay
    {
        static void Main(string[] args)
        {
            //string writepath = @"../../../../../Data/WriteStoreData.xml";
            //string readpath = @"../../../../../Data/ReadStoreData.xml";

            string choice;
            bool shopMore = true;
            Console.WriteLine("\n\nProject 0: Store Application ");
            ///<summary>
            ///Created Main Display with two options 1. Customer's View and 2. Owners View.
            ///In Customer's View we have register and shop option, show order option and exit program.
            ///In Owner's View we have Add Store, Show Transaction History and Show Products.
            ///
            /// This program will at least run once until customer or owner wants to end the program.
            /// </summary>
            do
            {
                Console.WriteLine("\n1. Customer's Options" +
                             "\n2. Owner's Options" +
                             "\n3. End Program");
                Console.Write("\nSelect the right Option!: ");
                choice = Console.ReadLine();
                
                switch (choice)
                {
                    case "1":
                        string customerChoice;
                        Console.WriteLine("\n\nCustomer's Options" +
                                        "\n1.Register and Shop" +
                                        "\n2.Show Order History of Store Locations" +
                                        "\n(Press any key to Exit)");
                        Console.Write("\nSelect the right option you want:");
                        customerChoice = Console.ReadLine();
                        //Throw Exception
                        /*try
                        {
                            
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine("It is not one of the choices given. Try again!");
                        }*/

                        if (customerChoice == "1")
                        {
                            bool repeat = true;
                            do { 
                                Console.Clear();
                                Console.WriteLine("\n\nWelcome Shopper!");
                                Console.WriteLine("Before you start shopping please READ the guidelines on how to Shop!" +
                                "\n\n1. First Register by entering your \"Full Name\". Next, open the list of products or store location name" +
                                "\n2.In order to Shop write down the \"Product ID\"" +
                                "\n3.To Remove Item write down the \"Product ID\"" +
                                "\n4.To Show list of items bought or in the cart open the list of transaction." +
                                "\n5. Don't Forget to checkout!" +
                                "\nThank you!");

                                Console.WriteLine("\n\nPlease Enter your Name: ");
                                Customer customer = new Customer(Console.ReadLine());


                                 //Shop method here
                                //Choice again
                                Console.WriteLine("\n 1. Add Product " +
                                                "\n 2. Remove Product" +
                                                "\n 3. Display Items" +
                                                "\n 4. Checkout!" +
                                                "\n\nPress any key to exit except above choices!");
                                Console.WriteLine("Please Enter the right option!");
                                string option;
                                option = Console.ReadLine();


                                switch (option)
                                {
                                    case "1":

                                        //add method
                                        Console.WriteLine("Enter the name of product");
                                        customer.AddItem(Console.ReadLine(), DateTime.Now);
                                        Console.WriteLine("Item Added");

                                        break;

                                    case "2":

                                        //remove method
                                        Console.WriteLine("Enter the name of product");
                                        customer.RemoveItem(Console.ReadLine(), DateTime.Now);
                                        Console.WriteLine("Item Removed");

                                        break;

                                    case "3":

                                        //Show cart
                                        //need method to go back to customer's option
                                        Console.WriteLine("List");
                                        customer.DisplayItems();

                                        break;

                                    case "4":

                                        //Checkout method
                                        //display receipt and then exit

                                        break;

                                    default:
                                        Console.WriteLine("Bye!");
                                        break;
                            }

                                Console.WriteLine("\n\nDo you want to Repeat Customer Choice? Press \"1\" for Yes or \"0\" For No");
                                string repeat1;
                                repeat1 = Console.ReadLine();
                                if (repeat1 == "1")
                                {
                                    repeat = true;
                                    Console.Clear();
                                }
                                else if (repeat1 == "0")
                                {
                                    repeat = false;
                                }
                                else
                                {
                                    Console.WriteLine("Bye!");
                                }
                            } while (repeat) ;
                        }
                        break;


                    case "2": //throw exception for wrong input
                        Console.WriteLine("\n\nOwner's Options" +
                                        "\n1.Add Store" +
                                        "\n2.Search Customer's name and Order History" +
                                        "\n3.Show Inventory" +
                                        "\n(Press any key to Exit)");
                        string ownerChoice;
                        Console.Write("\nSelect the right option you want:");

                        //Throw Exception
                        ownerChoice = Console.ReadLine();

                        if (ownerChoice == "1")
                        {
                            //add store and product method
                        }

                        else if (ownerChoice == "2")
                        {
                            //show order history
                        }

                        else if (ownerChoice == "3")
                        {
                            //Show inventory
                        }

                        else
                        {
                            //Terminate Program
                            Console.WriteLine("Bye!");
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
                    Console.Clear();
                }
                else if (pick == "0")
                {
                    shopMore = false;
                }
                else
                {
                    Console.WriteLine("Bye!");
                }

            } while (shopMore);
        }
    }
}
