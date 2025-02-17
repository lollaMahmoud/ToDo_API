using ToDo_API.DTOs;
using ToDo_API.Models;

namespace ToDo_API.Reprosatore
{
	public class TaskRepo : ITaskRepo
	{
		private readonly AppdbContext db;
		public TaskRepo(AppdbContext _db)
		{
			db = _db;
		}

		
		public List<_Task> GetTasks()
		{
			var task = db.Tasks.ToList();
			return task;
		}

		public void Post(TaskDTO dto)
		{
			var task = new _Task()
			{
				TaskData = dto.TaskData
			};
			db.Tasks.Add(task);
			db.SaveChanges();
		}
		public void Delete(int id)
		{
			var task = db.Tasks.FirstOrDefault(x=>x.Id==id);
			db.Tasks.Remove(task);
			db.SaveChanges();
		}

	}
}
