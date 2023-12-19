using LibraryApp.Interfaces;

namespace LibraryApp.Models;

public class PrivateCustomer : IPrivateCustomer

{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Email { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public string Address { get; set; } = null!;
}
