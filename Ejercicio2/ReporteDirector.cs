namespace Patrones_De_Diseno.Ejercicio2
{
    class ReporteDirector
    {
        public void ConstruirReporteBasico(IReporteBuilder builder)
        {
            builder.Reset();
            builder.AgregarPortada("Coca-Cola");
            builder.AgregarPiePagina("John Doe");
        }

        public void ConstruirReporteCompleto(IReporteBuilder builder)
        {
            builder.Reset();
            builder.AgregarPortada("Google");
            builder.AgregarGraficosEstadisticos("ventas");
            builder.AgregarTablaMovimientos("ventas mes de agosto");
            builder.AgregarAnalisisTendencias("mes de julio");
            builder.AgregarPiePagina("Pepito Perez");
        }
    }
}
