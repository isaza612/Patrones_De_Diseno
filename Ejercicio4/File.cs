namespace Patrones_De_Diseno.Ejercicio4
{
    public class File : IComponent
    {
        public string Name { get; private set; }
        private readonly long _bytes;

        public File(string name, long bytes)
        {
            Name = name;
            _bytes = bytes;
        }

        public long Execute() => _bytes;

        public void Rename(string newName) => Name = newName;

        public string ToTreeString(int indent = 0)
        {
            var pad = new string(' ', indent * 2);
            return $"{pad}- {Name} ({_bytes} B)";
        }
    }
}
