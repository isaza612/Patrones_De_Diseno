namespace Patrones_De_Diseno.Ejercicio2
{
    public class ReportePDF
    {
        public string? portada;
        public string? graficos;
        public string? tablaMovimientos;
        public string? analisisTendencias;
        public string? piePagina;

        //Se hace solo para el ejemplo
        public override string ToString()
        {
            string resultado = "Contenido del Reporte PDF:\n\n";

            if (portada != null)
                resultado += $"{portada}\n";

            if (graficos != null)
                resultado += $"{graficos}\n";

            if (tablaMovimientos != null)
                resultado += $"{tablaMovimientos} \n";

            if (analisisTendencias != null)
                resultado += $"{analisisTendencias} \n";

            if (piePagina != null)
                resultado += $"{piePagina} \n";
            
            if (resultado.Trim() == "Contenido del Reporte PDF:")
                resultado += "No se configuró ninguna sección.\n";

            return resultado;
        }
    }

}
