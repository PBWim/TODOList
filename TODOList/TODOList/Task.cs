namespace TODOList
{
    public class Task
    {
        public string Description { get; set; }
        public string Priority { get; set; }
        public DateTime? Deadline { get; set; }
        public bool IsCompleted { get; set; }

        public override string ToString()
        {
            return $"Task: {Description}, Priority: {Priority}, Deadline: {Deadline?.ToShortDateString()}, Completed: {IsCompleted}";
        }
    }
}