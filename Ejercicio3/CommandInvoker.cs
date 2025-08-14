namespace Patrones_De_Diseno.Ejercicio3
{
    internal class CommandInvoker
    {
        private readonly Stack<ICommand> _history = new();

        public void Execute(ICommand command)
        {
            command.Execute();
            _history.Push(command);
        }

        public void Undo()
        {
            if (_history.Count == 0) return;
            
            ICommand command = _history.Pop();
            command.Undo();
        }
    }
}
