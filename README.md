# TODO List Manager

A console-based To-Do List Manager allows users to create, view, update, and delete tasks. You can add functionalities like setting deadlines, priorities, and marking tasks as complete.

## Features:
### Add a Task:
Prompt the user to enter a task description, priority level (Low, Medium, High), and deadline (optional).

### View All Tasks:
Display all tasks with their details, such as the description, priority, deadline, and completion status.

### Update a Task:
Allow the user to modify a task description, change its priority or deadline, or mark it as complete.

### Delete a Task:
Remove a task from the list.

### Save/Load Tasks:
Save the tasks to a file (e.g., in JSON or text format) and load them back when the application restarts.

### Search Tasks:
Add a search functionality to find tasks by keywords or priority.

## Sample Structure:
### Classes:
<ins>Task</ins> class with properties like Description, Priority, Deadline, IsCompleted.

<ins>TaskManager</ins> class to handle task operations (CRUD functionality).

----

## Deploy to AWS Using AWS EC2

1. Log in to AWS Management Console.
2. Go to the EC2 Dashboard.
3. Launch a New Instance. Click on "Launch Instance" and choose an <ins>Amazon Linux</ins> AMI (For .NET Core/6 applications, we can use either Amazon Linux 2 or Windows Server).
4. Name your instance: Enter a descriptive name : <ins>TODOList-instance</ins>.
5. 
