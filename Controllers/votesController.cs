using Microsoft.AspNetCore.Mvc;

namespace DotNetTutorialVSCode.Controllers;

[ApiController]
[Route("[controller]")]
public class VotesController : ControllerBase
{

    [HttpGet]
    [Route("~/api/votes")]
    public ActionResult<List<votes>> GetVotes()
    {
        using (AppContext context = new AppContext())
        {
            return context.votes.ToList();
        }
    }

    [HttpPost]
    [Route("~/api/votes")]
    public IActionResult Addvote(votes vote)
    {
        try
        {
            using (AppContext context = new AppContext())
            {
                context.votes.Add(vote);
                context.SaveChanges();
            }

            return Ok(vote);
        }
        catch (Exception ex)
        {
            return BadRequest($"Error: {ex.Message}");
        }
    }
}
