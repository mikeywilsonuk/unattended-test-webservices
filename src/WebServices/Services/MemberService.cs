using WebServices.Models;

namespace WebServices.Services;

/** 
Create an in-memory data store for member resources.
Member resources include string and int data types.
'memberNumber' is the unique identifier and will be a hard coded string data type of 10 numbers.
Create a parent/child nested list to store member data and any products associated with the member.
**/

public static class MemberService
{
    static List<Member> Members { get; }
    static MemberService()
    {   
        Members = new List<Member>
        {
        
            new Member 
            { 
                memberNumber = "1234567890", 
                forename = "Timmy", 
                surname = "Taylors",
                products = new List<Product>
                {
                    new Product
                    {
                        name = "Healthcare",
                        cost = 100
                    },
                    new Product
                    {
                        name = "Travel Insurance",
                        cost = 150
                    }
                }
            },

            new Member 
            { 
                memberNumber = "0987654321", 
                forename = "Yorkshire", 
                surname = "Guzzler", 
                products = new List<Product>
                {
                    new Product
                    {
                        name = "Healthcare",
                        cost = 100
                    },
                    new Product
                    {
                        name = "Travel Insurance",
                        cost = 150
                    }
                }
            },
            
            new Member 
            { 
                memberNumber = "6398592763", 
                forename = "Theakstons", 
                surname = "Best",
                products = new List<Product>
                {
                    new Product
                    {
                        name = "Healthcare",
                        cost = 100
                    },
                }
            },

            new Member 
            { 
                memberNumber = "3986271583", 
                forename = "Beavertown", 
                surname = "IPA",
                products = new List<Product>
                {
                    new Product
                    {
                        name = "Travel Insurance",
                        cost = 150
                    }
                }
            },

            new Member 
            { 
                memberNumber = "3986271583", 
                forename = "Yorkshire", 
                surname = "Blonde",
                products = new List<Product>
                {
                    new Product
                    {
                        name = "Healthcare",
                        cost = 100
                    },
                    new Product
                    {
                        name = "Travel Insurance",
                        cost = 150
                    }
                }
            }
        };
    }

    public static List<Member> GetAll() => Members;

    public static Member? Get(string memberNumber) => Members.FirstOrDefault(p => p.memberNumber == memberNumber);

}