namespace Patrones_De_Diseno.Ejercicio2
{
    public class ReporteHTMLBuilder : IReporteBuilder
    {
        private ReporteHTML _reporteHTML;

        public ReporteHTMLBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _reporteHTML = new ReporteHTML();
        }

        public void AgregarAnalisisTendencias(string analisisTendencia)
        {
            _reporteHTML.analisisTendencias= $"Análisis: {analisisTendencia}";
        }

        public void AgregarGraficosEstadisticos(string datos)
        {
            _reporteHTML.graficos = $"Gráficos: {datos}";
        }

        public void AgregarPiePagina(string contacto)
        {
            _reporteHTML.piePagina = $"Contacto asesor: {contacto}";
        }

        public void AgregarPortada(string cliente)
        {
            _reporteHTML.portada = $"Portada para el cliente {cliente}";
        }

        public void AgregarTablaMovimientos(string tablaMovimientos)
        {
            _reporteHTML.tablaMovimientos= $"Tabla movimientos {tablaMovimientos}";
        }

        public ReporteHTML GetResult()
        {
            ReporteHTML reporteHTML = _reporteHTML;
            Reset();
            return reporteHTML;
        }
    }
}
