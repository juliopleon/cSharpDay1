namespace cSharpDay1.Controllers;

[ApiController]
[Route("api/todo")]
public class TodoController : ControllerBase
{
    private readonly TodosService _todosService;


    public TodoController(TodosService todosService)
    {
        this._todosService = todosService;
    }

    [HttpGet]
    public ActionResult<List<Todo>> Get()
    {
        try
        {
            List<Todo> todo = _todosService.Get();
            return Ok(todo);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

}