namespace Patrones_De_Diseno.Ejercicio3
{
    internal class CompleteTaskCommand : ICommand
    {
        private readonly TaskService _taskService;
        private readonly int _id;
        private bool _isCompleted;

        public CompleteTaskCommand(TaskService taskService, int id)
        {
            _taskService = taskService;
            _id = id;
        }

        public void Execute()
        {
            TaskItem? item = _taskService.GetById(_id);

            if (item == null) return;

            _isCompleted = item.isCompleted;
            _taskService.Complete(_id);
            Console.WriteLine($"---Se completa la tarea {_id}---");
        }

        public void Undo()
        {
            if (!_isCompleted)
            {
                _taskService.Reopen(_id);
                Console.WriteLine($"---Se reversa la completada de la tarea {_id}---");
            }
        }
    }
}
