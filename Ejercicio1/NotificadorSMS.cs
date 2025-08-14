namespace Patrones_De_Diseno.Ejercicio1
{
    public class NotificadorSMS : NotificadorDecorator
    {
        private readonly string _numeroCelular;

        public NotificadorSMS(INotificador wrappee, string numeroCelular) : base(wrappee)
        {
            _numeroCelular = numeroCelular;
        }

        public override void Enviar(string mensaje)
        {
            base.Enviar(mensaje);

            Console.WriteLine($"SMS enviado a {_numeroCelular}: {mensaje}");
        }
    }
}
