
public class Program
{
    public static void Main(string[] args)
    {

        string userName = null, password = null;

        Console.WriteLine("\n************R | M BANK**********");
        Console.WriteLine("::Login page::\n");

        Console.Write("Username: ");
        userName = Console.ReadLine();

        if (userName != "")
        {
            Console.Write("Password: ");
            password = Console.ReadLine();
        }

        if (userName == "system" && password == "manager")
        {
            int mainMenuChoice = -1;
            do
            {
                Console.WriteLine("\nTo do: Main menu");
                Console.WriteLine("1. Customers");
                Console.WriteLine("2. Accounts");
                Console.WriteLine("3. Funds Transfer");
                Console.WriteLine("4. Funds Transfer Statement");
                Console.WriteLine("5. Account Statement");
                Console.WriteLine("0. Exit");


                Console.Write("Enter choice: ");
                mainMenuChoice = int.Parse(Console.ReadLine());

                switch (mainMenuChoice)
                {
                    case 1:
                        CustomersMenu();
                        break;
                    case 2:
                        Console.WriteLine("choice 2");
                        break;
                    case 3:
                        Console.WriteLine("choice 3");
                        break;
                    case 4:
                        Console.WriteLine("choice 4");
                        break;
                    case 5:
                        Console.WriteLine("choice 5");
                        break;
                    case 0:
                        mainMenuChoice = 0;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            } while (mainMenuChoice != 0);

        }
        else
        {
            Console.WriteLine("Invalid username or password");
        }

        Console.WriteLine("\nThank you, visit again\n");

    }

    static void CustomersMenu()
    {

        int customerMenuChoice = -1;
        do
        {
            Console.WriteLine("\n::Customers Menu::");
            Console.WriteLine("1) Add Customer");
            Console.WriteLine("2) Delete Customer");
            Console.WriteLine("3) Update Customer");
            Console.WriteLine("4) View Customers");
            Console.WriteLine("0) Back to Main Menu");

            Console.Write("Enter choice from customer menu: ");
            customerMenuChoice = System.Convert.ToInt32(Console.ReadLine());

            if (customerMenuChoice == 1)
            {
                Console.WriteLine("\nadded customer");
            }
            else if (customerMenuChoice == 2)
            {
                Console.WriteLine("\ndeleted customer");
            }
            else if (customerMenuChoice == 3)
            {
                Console.WriteLine("\nupdated customer");
            }
            else if (customerMenuChoice == 4)
            {
                Console.WriteLine("\nall customers");
            }
            else if (customerMenuChoice == 0)
            {
                customerMenuChoice = 0;
            }
        } while (customerMenuChoice != 0);


    }
}