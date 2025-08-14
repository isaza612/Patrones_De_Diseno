using System.ComponentModel;
using System.Text;

namespace Patrones_De_Diseno.Ejercicio4
{
    public class Folder : IComponent
    {
        public string Name { get; private set; }
        private readonly List<IComponent> _children = new();

        public Folder(string name) => Name = name;

        public IReadOnlyList<IComponent> GetChildren() => _children;

        public void Add(IComponent c) => _children.Add(c);

        public void InsertAt(int index, IComponent c) => _children.Insert(index, c);

        public void Remove(IComponent c) => _children.Remove(c);

        public int IndexOf(IComponent c) => _children.IndexOf(c);

        public long Execute() => _children.Sum(x => x.Execute());

        public void Rename(string newName) => Name = newName;

        public string ToTreeString(int indent = 0)
        {
            var pad = new string(' ', indent * 2);
            var sb = new StringBuilder();
            sb.AppendLine($"{pad}+ {Name}/  [{Execute()} B]");
            foreach (var c in _children)
                sb.AppendLine(c.ToTreeString(indent + 1));
            return sb.ToString().TrimEnd();
        }
    }
}
