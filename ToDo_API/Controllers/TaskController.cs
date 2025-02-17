using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using ToDo_API.DTOs;
using ToDo_API.Reprosatore;

namespace ToDo_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TaskController : ControllerBase
	{
		private readonly ITaskRepo rep;

		public TaskController(ITaskRepo _repo)
		{
	      rep = _repo;
		}

		[HttpGet]
		public IActionResult Get()
		{
			var task = rep.GetTasks();
			return Ok(task);
		}
		[HttpPost]
		public IActionResult Post(TaskDTO dto) 
		{
			rep.Post(dto);
			return Ok(dto);
		}
		[HttpDelete]
		public IActionResult Delete(int id)
		{
			rep.Delete(id);
			return Ok();
		}
	}
}
