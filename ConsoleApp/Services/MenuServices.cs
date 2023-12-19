

using LibraryApp.Interfaces;
using LibraryApp.Models;
using LibraryApp.Services;

namespace ConsoleApp.Services;

public class MenuServices
{
    private static readonly ICustomerServices _customerservice = new CustomerServices();

    public static void AddPrivateCustomers()
    {
        IPrivateCustomer customer = new PrivateCustomer();
        Console.Clear();

        Console.WriteLine(" Firstname: ");
        customer.FirstName = Console.ReadLine()!;

        Console.WriteLine(" Lastname: ");
        customer.LastName = Console.ReadLine()!;

        Console.WriteLine(" Address: ");
        customer.Address = Console.ReadLine()!;

        Console.WriteLine(" Phonenumber: ");
        customer.PhoneNumber = Console.ReadLine()!;

        Console.WriteLine(" Email: ");
        customer.Email = Console.ReadLine()!;

        _customerservice.AddCustomerToList(customer);


    }

    public static void ShowAllCustomers()
    {

        var customers = _customerservice.GetCustomersFromList();
        Console.Clear();
        foreach (IPrivateCustomer customer in customers)
        {
            Console.WriteLine($"""
                Firstname: {customer.FirstName}         Lastname: {customer.LastName}

                Address: {customer.Address}         
                
                Phonenumber: {customer.PhoneNumber}     Email: {customer.Email}

                ------------------------------------------------------------------


             """);
            Console.WriteLine("Choose another option \n");

        }
    }


    public static void GetCustomer()
    {
        Console.WriteLine("Email: ");
        var customer = (IPrivateCustomer)_customerservice.GetCustomerFromList(Console.ReadLine());
        Console.Clear();
        Console.WriteLine($"""
               Firstname: {customer.FirstName}      Lastname: {customer.LastName}
            
               Address: {customer.Address}
            
               Phonenumber: {customer.PhoneNumber}  Email: {customer.Email}
            
               ------------------------------------------------------------------



            """);
        Console.WriteLine("Choose another option");
    }


    public static void DeleteCustomer()
    {
        Console.WriteLine("Email: ");
        _customerservice.RemoveCustomer(Console.ReadLine());

    }


}
