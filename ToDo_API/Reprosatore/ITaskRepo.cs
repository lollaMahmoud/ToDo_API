using ToDo_API.DTOs;
using ToDo_API.Models;

namespace ToDo_API.Reprosatore
{
	public interface ITaskRepo
	{
		public List<_Task> GetTasks();
		public void Post(TaskDTO dto);
		public void Delete(int id);
	}
}
