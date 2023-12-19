namespace LibraryApp.Interfaces;

public interface ICustomer
{
    Guid Id { get; set; }

    string Email { get; set; }

    string PhoneNumber { get; set; }

    string Address { get; set; }


}