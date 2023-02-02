namespace WebServices.Models;

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