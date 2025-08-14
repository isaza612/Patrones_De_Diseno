namespace Patrones_De_Diseno.Ejercicio1
{
    public class NotificadorBase : INotificador
    {
        public void Enviar(string mensaje)
        {
            Console.WriteLine("Registro en sistema: " + mensaje);
        }
    }
}
