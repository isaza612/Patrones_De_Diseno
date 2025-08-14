using System.ComponentModel;

namespace Patrones_De_Diseno.Ejercicio4
{
    public static class Client
    {
        public static long GetTotalSize(IComponent node) => node.Execute();

        public static void Delete(Folder from, IComponent item) => from.Remove(item);

        public static void Move(Folder from, IComponent item, Folder to, int? index = null)
        {
            from.Remove(item);
            if (index.HasValue) to.InsertAt(index.Value, item);
            else to.Add(item);
        }
    }
}
