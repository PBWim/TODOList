# TODO List Manager

A console-based To-Do List Manager allows users to create, view, update, and delete tasks. You can add functionalities like setting deadlines, priorities, and marking tasks as complete.

## Features:
- ### Add a Task:
   - Prompt the user to enter a task description, priority level (Low, Medium, High), and deadline (optional).

- ### View All Tasks:
   - Display all tasks with their details, such as the description, priority, deadline, and completion status.

- ### Update a Task:
   - Allow the user to modify a task description, change its priority or deadline, or mark it as complete.

- ### Delete a Task:
   - Remove a task from the list.

- ### Save/Load Tasks:
   - Save the tasks to a file (e.g., in JSON or text format) and load them back when the application restarts.

- ### Search Tasks:
   - Add a search functionality to find tasks by keywords or priority.

## Sample Structure:
### Classes:
- <ins>Task</ins> class with properties like Description, Priority, Deadline, IsCompleted.

- <ins>TaskManager</ins> class to handle task operations (CRUD functionality).

----

## Deploy to AWS Using AWS EC2

1. Log in to AWS Management Console.
2. Go to the EC2 Dashboard.
3. Launch a New Instance. Click on "Launch Instance" and choose an <ins>Amazon Linux</ins> AMI (For .NET Core/6 applications, we can use either Amazon Linux 2 or Windows Server).
4. Name your instance: Enter a descriptive name : <ins>TODOList-instance</ins>.
5. Select <ins>Amazon Linux 2 AMI (HVM), SSD Volume Type – 64-bit (x86)</ins>. This is a lightweight, free-tier eligible option.
6. Instance Type : <ins>t2.micro or t3.micro (1 vCPU, 1 GB RAM).</ins>
7. Key Pair (Login) : You need a key pair to SSH into the instance (for Amazon Linux) or RDP (for Windows).
   - 7.1. Create a new key pair.
   - 7.2. Choose RSA for the key pair type.
   - 7.3. Download the key pair (it will be a .pem file).
8. Network Settings :
   - 8.1. Auto-assign Public IP : Ensure this is enabled so that your instance gets a public IP address. This allows you to access the instance over the internet.
   - 8.2. VPC : Choose the default VPC unless you’ve set up custom networking.
   - 8.3. Security Group : Create a new security group with SSH (port 22), RDP (port 3389), HTTP (port 80) or HTTPS (port 443)
9. Configure Storage : The default storage size (8 GB) is usually sufficient for running a .NET console application.

-----

#### Connect to Your EC2 Instance

1. Connect via SSH: Open a terminal and run the following command ```ssh -i "your-key.pem" ec2-user@your-ec2-public-ip```
```
ssh -i "C:\Users\PBWim\Downloads\TODOList-keypair.pem" ec2-user@18.141.139.166
```
* SSH encrypts the data transferred between your local machine and the remote server, ensuring that sensitive information, like passwords or commands, is protected.
* You use a command like ```ssh``` followed by the IP address or DNS name of the EC2 instance, and authenticate yourself using a private key (for key-based authentication) or a password.
* AWS generally provides an SSH key pair (.pem file) when you first launch the EC2 instance. You use this key to securely connect.
   - ```-i "your-key.pem"```: Specifies the private key file used to authenticate.
   - ```ec2-user```: The username for the EC2 instance (this could be different depending on the Linux distribution).
   - ```your-instance-public-ip```: The public IP address of your EC2 instance.
* SSH typically operates over port <ins>22</ins>, so this port needs to be open in the Security Group of your EC2 instance.
  
2. Once connected, install the .NET SDK using the following commands and check dotnet version:
```
sudo amazon-linux-extras enable dotnet6
sudo rpm -Uvh https://packages.microsoft.com/config/centos/7/packages-microsoft-prod.rpm
sudo yum install -y dotnet-sdk-8.0

dotnet --version
```

3. Clone your GitHub repository: Use Git to pull your code onto the EC2 instance:
   If git is not installed, install first.
```
sudo yum update -y
sudo yum install git -y

git clone https://github.com/PBWim/TODOList.git
```

4. Navigate to .csproj file folder :
```
cd TODOList/TODOList/TODOList
```

5. Run the application:
```
dotnet run
```
