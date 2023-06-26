using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Types.Models;

namespace Types.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ContactController : ControllerBase
{
    [HttpPost]
    public IActionResult Create(Contact contact)
    {
        return Ok($"Created contact for {contact.Name} at {contact.Email} and phone {contact.Phone}");
    }
}
