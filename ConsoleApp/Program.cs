
namespace ConsoleApp.Services;
public class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my address book");
        Console.WriteLine("Select an option");
        bool active = true;
        while (active)
        {
            Console.WriteLine("1. Register \n");
            Console.WriteLine("2. Show all members \n");
            Console.WriteLine("3. Show a member \n");
            Console.WriteLine("4. Delete a customer \n");
            Console.WriteLine("5. Exit! \n");

            string result = Console.ReadLine()!;
            switch (result)
            {
                case "1":
                    MenuServices.AddPrivateCustomers();
                    Console.Clear();
                    break;
                case "2":
                    MenuServices.ShowAllCustomers();
                    break;
                case "3":
                    MenuServices.GetCustomer();
                    break;
                case "4":
                    MenuServices.DeleteCustomer();
                    Console.Clear();
                    break;
                case "5":
                    active = false;
                    break;
                default:
                    Console.Clear();
                    break;
            }
        }
    }









}