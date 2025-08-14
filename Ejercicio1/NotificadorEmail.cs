namespace Patrones_De_Diseno.Ejercicio1
{
    public class NotificadorEmail : NotificadorDecorator
    {
        private readonly string _correoDestino;

        public NotificadorEmail(INotificador wrappee, string correoDestino) : base(wrappee)
        {
            _correoDestino = correoDestino;
        }

        public override void Enviar(string mensaje)
        {
            base.Enviar(mensaje);

            Console.WriteLine($"Email enviado a {_correoDestino}: {mensaje}");
        }
    }
}
