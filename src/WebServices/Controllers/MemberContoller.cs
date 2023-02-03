using WebServices.Models;
using WebServices.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebServices.Controllers;

[ApiController]
[Route("[controller]")]

/** 
Create MemberController class with public methods exposed as HTTP endpoints.
Create a public method to GETALL member resources.
Create a public method to GET unique member resource using 'memberNumber' as the identifier.
**/


public class MemberController : ControllerBase
{
    public MemberController() 
    {
    }

    [HttpGet]
    public ActionResult<List<Member>> GetAll() =>
    MemberService.GetAll();


    [HttpGet("{memberNumber}")]
    public ActionResult<Member> Get(string memberNumber)
    {
        var member = MemberService.Get(memberNumber);

        if(member == null)
            return NotFound();

        return member;
    }
}