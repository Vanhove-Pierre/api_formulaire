using Microsoft.AspNetCore.Mvc;

namespace APIFormulaire.Controllers;

[ApiController]
[Route("questions")]
public class QuestionsController : ControllerBase
{
    [HttpGet("getAll")]
    public string GetAll()
    {
        return "test";
    }
}