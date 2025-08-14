namespace Patrones_De_Diseno.Ejercicio1
{
    public abstract class NotificadorDecorator : INotificador
    {
        protected INotificador _wrappee;

        protected NotificadorDecorator(INotificador wrappee)
        {
            _wrappee = wrappee;
        }

        public virtual void Enviar(string mensaje)
        {
            _wrappee.Enviar(mensaje);
        }
    }
}
