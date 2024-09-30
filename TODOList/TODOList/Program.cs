using TODOList;

public class Program
{
    public static void Main()
    {
        var taskManager = new TaskManager();
        taskManager.LoadTasks();  // Load tasks from file if available

        bool running = true;
        while (running)
        {
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Update Task");
            Console.WriteLine("4. Delete Task");
            Console.WriteLine("5. Save and Exit");
            Console.Write("Choose an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    taskManager.AddTask();
                    break;
                case "2":
                    taskManager.ViewTasks();
                    break;
                case "3":
                    taskManager.UpdateTask();
                    break;
                case "4":
                    taskManager.DeleteTask();
                    break;
                case "5":
                    taskManager.SaveTasks();
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option, try again.");
                    break;
            }
        }
    }
}