namespace WebServices.Models;

/**
Create model classes to represent a Member and Product.
These models pass data in the web API and persist Member and Product options in the MemberService data store.
**/

public class Product
{
    public string? name { get; set; }
    public int? cost { get; set; }
}

public class Member
{
    public string? memberNumber { get; set; }
    public string? forename { get; set; }
    public string? surname { get; set; }
    public List<Product>? products { get; set; }
}