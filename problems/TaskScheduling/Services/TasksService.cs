using TaskScheduling.Models;

namespace TaskScheduling.Services
{
    public class TasksService
    {
        public DataStructures.Queue.Queue<Tasks> taskQueue { get; set; }
        public TasksService()
        {
            taskQueue = new DataStructures.Queue.Queue<Tasks>();
        }
    }
}
