namespace Patrones_De_Diseno.Ejercicio4
{
    public interface IComponent
    {
        string Name { get; }
        long Execute();
        void Rename(string newName);
        string ToTreeString(int indent = 0);
    }
}
