namespace EnumSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ToDo> ToDo = new List<ToDo>()
            {
                new ToDo {Description = "Task 1", EstimatedHours = 6, Status = Status.Completed},
                new ToDo {Description = "Task 2", EstimatedHours = 2, Status = Status.InProgress},
                new ToDo {Description = "Task 3", EstimatedHours = 8, Status = Status.NotStarted},
                new ToDo {Description = "Task 4", EstimatedHours = 12, Status = Status.Deleted},
                new ToDo {Description = "Task 5", EstimatedHours = 6, Status = Status.InProgress},
                new ToDo {Description = "Task 6", EstimatedHours = 2, Status = Status.NotStarted},
                new ToDo {Description = "Task 7", EstimatedHours = 14, Status = Status.OnHold},
                new ToDo {Description = "Task 8", EstimatedHours = 8, Status = Status.Completed},
                new ToDo {Description = "Task 9", EstimatedHours = 8, Status = Status.Deleted},
                new ToDo {Description = "Task 10", EstimatedHours = 8, Status = Status.iN},
                new ToDo {Description = "Task 11", EstimatedHours = 4, Status = Status.NotStarted},
                new ToDo {Description = "Task 12", EstimatedHours = 10, Status = Status.Completed},
                new ToDo {Description = "Task 13", EstimatedHours = 12, Status = Status.Deleted},
                new ToDo {Description = "Task 14", EstimatedHours = 6, Status = Status.Completed},
            };

            AssessToDo(ToDo);
            Console.ReadLine();
        }

        private static void AssessToDo(List<ToDo> todos)
        {
            foreach (var todo in todos)
            {
                switch (todo.Status)
                {
                    case Status.NotStarted:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case Status.InProgress:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                    case Status.OnHold:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    case Status.Completed:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case Status.Deleted:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    default:
                        break;
                }

                Console.WriteLine(todo.Description);
            }

           
        }
    }

    class ToDo
    {
        public string Description { get; set; }
        public int EstimatedHours { get; set; }
        public Status Status { get; set; }
    }

    enum Status {
        NotStarted ,
        InProgress,
        OnHold,
        Completed,
        Deleted
    }
}