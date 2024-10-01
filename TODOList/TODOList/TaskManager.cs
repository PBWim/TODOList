using System.Text.Json;

namespace TODOList
{
    public class TaskManager
    {
        private List<Task> tasks = new();
        private readonly string filePath = "tasks.json";

        public void AddTask()
        {
            var task = new Task();
            Console.Write("Enter task description: ");
            task.Description = Console.ReadLine();

            Console.Write("Enter task priority (Low, Medium, High): ");
            task.Priority = Console.ReadLine();

            Console.Write("Enter task deadline (optional, leave blank for no deadline): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime deadline))
                task.Deadline = deadline;

            task.IsCompleted = false;
            tasks.Add(task);
        }

        public void ViewTasks()
        {
            foreach (var task in tasks)
            {
                Console.WriteLine(task.ToString());
            }
        }

        public void UpdateTask()
        {
            Console.Write("Enter task number to update: ");
            if (int.TryParse(Console.ReadLine(), out int taskIndex) && taskIndex > 0 && taskIndex <= tasks.Count)
            {
                Task task = tasks[taskIndex - 1];

                Console.Write($"Update description ({task.Description}): ");
                string newDescription = Console.ReadLine();
                if (!string.IsNullOrEmpty(newDescription))
                    task.Description = newDescription;

                Console.Write($"Update priority ({task.Priority}): ");
                string newPriority = Console.ReadLine();
                if (!string.IsNullOrEmpty(newPriority))
                    task.Priority = newPriority;

                Console.Write($"Update deadline ({task.Deadline?.ToShortDateString()}): ");
                if (DateTime.TryParse(Console.ReadLine(), out DateTime newDeadline))
                    task.Deadline = newDeadline;

                Console.Write("Mark as completed (y/n): ");
                task.IsCompleted = Console.ReadLine().ToLower() == "y";
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }

        public void DeleteTask()
        {
            Console.Write("Enter task number to delete: ");
            if (int.TryParse(Console.ReadLine(), out int taskIndex) && taskIndex > 0 && taskIndex <= tasks.Count)
            {
                tasks.RemoveAt(taskIndex - 1);
                Console.WriteLine("Task deleted.");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }

        public void SaveTasks()
        {
            string json = JsonSerializer.Serialize(tasks);
            File.WriteAllText(filePath, json);
            Console.WriteLine("Tasks saved.");
        }

        public void LoadTasks()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                tasks = JsonSerializer.Deserialize<List<Task>>(json);
            }
        }
    }
}