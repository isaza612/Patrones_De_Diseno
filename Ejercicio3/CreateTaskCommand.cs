namespace Patrones_De_Diseno.Ejercicio3
{
    internal class CreateTaskCommand : ICommand
    {
        private readonly TaskService _taskService;
        private readonly string _title;
        private int _createdId;

        public CreateTaskCommand(TaskService taskService, string title)
        {
            _taskService = taskService;
            _title = title;
        }

        public void Execute()
        {
            TaskItem item = _taskService.Create(_title);
            _createdId = item.id;
            Console.WriteLine($"---Se crea tarea {item.id}---");
        }

        public void Undo()
        {
            if (_createdId != 0)
            {
                _taskService.Delete(_createdId);
                Console.WriteLine($"---Se reversa la creación de la tarea {_createdId}---");
            }
        }
    }
}
