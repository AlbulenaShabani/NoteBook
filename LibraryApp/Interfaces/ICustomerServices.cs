namespace LibraryApp.Interfaces;

public interface ICustomerServices
{
    bool AddCustomerToList(ICustomer customer);

    IEnumerable<ICustomer> GetCustomersFromList();

    ICustomer GetCustomerFromList(string email);

    bool RemoveCustomer(string email);
}
