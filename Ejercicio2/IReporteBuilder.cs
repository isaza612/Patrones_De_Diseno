namespace Patrones_De_Diseno.Ejercicio2
{
    public interface IReporteBuilder
    {
        void Reset();
        void AgregarPortada(string cliente);
        void AgregarGraficosEstadisticos(string datos);
        void AgregarTablaMovimientos(string tablaMovimientos);
        void AgregarAnalisisTendencias(string analisisTendencia);
        void AgregarPiePagina(string contacto);
    }
}
