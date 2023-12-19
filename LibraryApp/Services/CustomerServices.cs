
using Newtonsoft.Json;
using System.Diagnostics;
using LibraryApp.Interfaces;

namespace LibraryApp.Services;

public class CustomerServices : ICustomerServices

{

    private readonly IFileService _fileService = new FileServices();
    private List<ICustomer> _customers = new List<ICustomer>();
    private readonly string _filePath = @"c:\projects\contact.json";



  
 
    public ICustomer GetCustomerFromList(string email)
    {
        try
        {
            GetCustomersFromList();

            var customer = _customers.FirstOrDefault(x => x.Email == email);
            return customer ??= null!;


        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;
    }

    public IEnumerable<ICustomer> GetCustomersFromList()
    {
        try
        {

            var content = _fileService.GetContentFromFile(_filePath);
            if (!string.IsNullOrEmpty(content))
            {
                _customers = JsonConvert.DeserializeObject<List<ICustomer>>(content, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All })!;
                return _customers;
            }

        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;

    }

    public bool RemoveCustomer(string email)
    {
        try
        {
            GetCustomersFromList();

            foreach (var customer in _customers)
            {
                if (customer.Email == email)
                {
                    _customers.Remove(customer);
                    string json = JsonConvert.SerializeObject(_customers, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });
                    File.WriteAllText(_filePath, json);
                    return true;
                }
            }

        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        Console.WriteLine("Kunden kunde ej hittas");
        return false;
    }

    public bool AddCustomerToList(ICustomer customer)
    {
        try
        {
            if (!_customers.Any(x => x.Email == customer.Email))
            {
                _customers.Add(customer);


                string json = JsonConvert.SerializeObject(_customers, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });

                var result = _fileService.SaveContentToFile(_filePath, json);
                return result;

            }


        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return false;
    }
}