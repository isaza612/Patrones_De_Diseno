namespace Patrones_De_Diseno.Ejercicio3
{
    internal class DeleteTaskCommand : ICommand
    {
        private readonly TaskService _taskService;
        private readonly int _id;
        private TaskItem? _backup;

        public DeleteTaskCommand(TaskService taskService, int id)
        {
            _taskService = taskService;
            _id = id;
        }

        public void Execute()
        {
            _backup = _taskService.Delete(_id);
            Console.WriteLine($"---Se elimina la tarea {_id}---");
        }

        public void Undo()
        {
            if (_backup != null)
            {
                _taskService.Restore(_backup);
                Console.WriteLine($"---Se reversa la eliminación de la tarea {_id}---");
            }
        }
    }
}
