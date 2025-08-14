namespace Patrones_De_Diseno.Ejercicio1
{
    public class NotificadorWhatsApp : NotificadorDecorator
    {
        private readonly string _numeroWhatsApp;

        public NotificadorWhatsApp(INotificador wrappee, string numeroWhatsApp) : base(wrappee)
        {
            _numeroWhatsApp = numeroWhatsApp;
        }

        public override void Enviar(string mensaje)
        {
            base.Enviar(mensaje);
            Console.WriteLine($"WhatsApp enviado a {_numeroWhatsApp}: {mensaje}");
        }
    }
}
