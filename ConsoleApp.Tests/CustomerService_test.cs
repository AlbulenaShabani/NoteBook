

using LibraryApp.Interfaces;
using LibraryApp.Models;
using LibraryApp.Services;

namespace ConsoleApp.Tests;

public class CustomerService_test
{

    [Fact]

    public void AddACustomer_ToTheCustomerList_ThenReturnTrue()
    {
        //Arrange
        ICustomer customer = new PrivateCustomer { FirstName = "", LastName = "", Address = "", Email = "", PhoneNumber = "", };
        ICustomerServices customerServices = new CustomerServices();
        //Act
        bool result = customerServices.AddCustomerToList(customer);
        //Assert
        Assert.True(result);
    }


    [Fact]

    public void GetCustomers_FromCustomerList_ThenReturnListOfCustomer()
    {
        //Arrange 
        ICustomer customer = new PrivateCustomer { Email = "" };
        ICustomerServices customerServices = new CustomerServices();
        customerServices.AddCustomerToList(customer);
        //Act 
        IEnumerable<ICustomer> result = customerServices.GetCustomersFromList();
        //Assert
        Assert.NotNull(result); 
        Assert.True(result.Any());
    }   
}
