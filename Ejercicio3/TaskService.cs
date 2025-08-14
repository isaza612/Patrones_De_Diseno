namespace Patrones_De_Diseno.Ejercicio3
{
    internal class TaskService
    {
        private readonly Dictionary<int, TaskItem> _tasks = new();
        private int _numTask = 1;

        public TaskItem Create(string title)
        {
            TaskItem task = new TaskItem(_numTask++, title);
            _tasks[task.id] = task;
            return task;
        }

        public void Edit(int id, string newTitle)
        {
            if (_tasks.TryGetValue(id, out TaskItem? t))
                t.Edit(newTitle);
        }

        public TaskItem? Delete(int id)
        {
            if (_tasks.TryGetValue(id, out TaskItem? t))
            {
                _tasks.Remove(id);
                return t;
            }
            return null;
        }

        public void Restore(TaskItem task) => _tasks[task.id] = task;

        public void Complete(int id)
        {
            if (_tasks.TryGetValue(id, out TaskItem? t))
                t.Complete();
        }

        public void Reopen(int id)
        {
            if (_tasks.TryGetValue(id, out TaskItem? t))
                t.Reopen();
        }

        public TaskItem? GetById(int id) => _tasks.TryGetValue(id, out TaskItem? t) ? t : null;

        public void PrintAll()
        {
            Console.WriteLine("\nLista de tareas");
            foreach (TaskItem item in _tasks.Values)
                Console.WriteLine(item.ToString());
            Console.WriteLine("");
        }
    }
}
