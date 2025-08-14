namespace Patrones_De_Diseno.Ejercicio3
{
    internal class TaskItem
    {
        public int id { get; }
        public string title { get; private set; }
        public bool isCompleted { get; private set; }

        public TaskItem(int id, string title)
        {
            this.id = id;
            this.title = title;
        }

        public void Edit(string title) => this.title = title;
        public void Complete() => isCompleted = true;
        public void Reopen() => isCompleted = false;

        public override string ToString()
        {
            return $"{id}: {title} (Completada: {(isCompleted ? "Si" : "No")})";
        }
    }
}
