using WebServices.Models;
using WebServices.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebServices.Controllers;

[ApiController]
[Route("[controller]")]
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