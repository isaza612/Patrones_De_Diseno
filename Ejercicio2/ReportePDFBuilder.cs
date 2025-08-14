namespace Patrones_De_Diseno.Ejercicio2
{
    public class ReportePDFBuilder : IReporteBuilder
    {
        private ReportePDF _reportePDF;

        public ReportePDFBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _reportePDF = new ReportePDF();
        }

        public void AgregarAnalisisTendencias(string analisisTendencia)
        {
            _reportePDF.analisisTendencias = $"Análisis: {analisisTendencia}";
        }

        public void AgregarGraficosEstadisticos(string datos)
        {
            _reportePDF.graficos = $"Gráficos: {datos}";
        }

        public void AgregarPiePagina(string contacto)
        {
            _reportePDF.piePagina = $"Contacto asesor: {contacto}";
        }

        public void AgregarPortada(string cliente)
        {
            _reportePDF.portada = $"Portada para el cliente {cliente}";
        }

        public void AgregarTablaMovimientos(string tablaMovimientos)
        {
            _reportePDF.tablaMovimientos = $"Tabla movimientos {tablaMovimientos}";
        }

        public ReportePDF GetResult()
        {
            ReportePDF reportePDF = _reportePDF;
            Reset();
            return reportePDF;
        }
    }
}
