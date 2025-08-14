namespace Patrones_De_Diseno.Ejercicio3
{
    internal class EditTaskCommand : ICommand
    {
        private readonly TaskService _taskService;
        private readonly int _id;
        private readonly string _newTitle;
        private string _oldTitle;

        public EditTaskCommand(TaskService taskService, int id, string newTitle)
        {
            _taskService = taskService;
            _id = id;
            _newTitle = newTitle;
        }

        public void Execute()
        {
            TaskItem? item = _taskService.GetById(_id);
            if (item == null) return;

            _oldTitle = item.title;
            _taskService.Edit(_id, _newTitle);
            Console.WriteLine($"---Se modifica la tarea {_id}---");
        }

        public void Undo()
        {
            if (_oldTitle != null)
            {
                _taskService.Edit(_id, _oldTitle);
                Console.WriteLine($"---Se reversa la modificación de la tarea {_id}---");
            }
        }
    }
}
