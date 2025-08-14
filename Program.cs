// See https://aka.ms/new-console-template for more information


using Patrones_De_Diseno.Ejercicio1;
using Patrones_De_Diseno.Ejercicio2;
using Patrones_De_Diseno.Ejercicio3;
using Patrones_De_Diseno.Ejercicio4;
using File = Patrones_De_Diseno.Ejercicio4.File;

Console.WriteLine("--------------------Inicio ejercicio 1--------------------");
Console.WriteLine("Patrón estructural -> Decorator\n");

INotificador cliente1 = new NotificadorEmail(new NotificadorSMS(new NotificadorBase(), "+573113508967"), "andres@gmail.com");
cliente1.Enviar("Pedido completo");

Console.WriteLine("");

INotificador cliente2 = new NotificadorWhatsApp(new NotificadorBase(), "+57 310 439 4545");
cliente2.Enviar("Pedido enviado");

Console.WriteLine("--------------------Fin ejercicio 1--------------------\n\n");


Console.WriteLine("--------------------Inicio ejercicio 2--------------------");
Console.WriteLine("Patrón creacional -> Builder\n");

ReportePDFBuilder reportePDFBuilder = new ReportePDFBuilder();

reportePDFBuilder.AgregarPortada("Ingelam");
reportePDFBuilder.AgregarGraficosEstadisticos("gráfica de ahorros");
reportePDFBuilder.AgregarPiePagina("Pepito Perez");

ReportePDF reportePDF = reportePDFBuilder.GetResult();
Console.WriteLine(reportePDF);

//Usando director
ReporteDirector director = new ReporteDirector();
director.ConstruirReporteCompleto(reportePDFBuilder);
reportePDF = reportePDFBuilder.GetResult();
Console.WriteLine(reportePDF);


ReporteHTMLBuilder reporteHTMLBuilder = new ReporteHTMLBuilder();

reporteHTMLBuilder.AgregarPortada("Coca-Cola");
reporteHTMLBuilder.AgregarGraficosEstadisticos("gráfica de inversión");
reporteHTMLBuilder.AgregarTablaMovimientos("mes de de diciembre");
reporteHTMLBuilder.AgregarAnalisisTendencias("Ventas");
reporteHTMLBuilder.AgregarPiePagina("Pepito Perez");

ReporteHTML reporteHTML = reporteHTMLBuilder.GetResult();
Console.WriteLine(reporteHTML);

//Usando director
director.ConstruirReporteBasico(reporteHTMLBuilder);
reporteHTML = reporteHTMLBuilder.GetResult();
Console.WriteLine(reporteHTML);

Console.WriteLine("--------------------Fin ejercicio 2--------------------\n\n");


Console.WriteLine("--------------------Inicio ejercicio 3--------------------");
Console.WriteLine("Patrón comportamiento -> Command\n");


TaskService taskService = new TaskService();
CommandInvoker commandInvoker = new CommandInvoker();

commandInvoker.Execute(new CreateTaskCommand(taskService, "Descargar el trabajo de patrones"));
commandInvoker.Execute(new CreateTaskCommand(taskService, "Entender el trabajo"));
commandInvoker.Execute(new CreateTaskCommand(taskService, "Realizar el punto 1"));
commandInvoker.Execute(new CreateTaskCommand(taskService, "Realizar el punto 20"));
commandInvoker.Execute(new CreateTaskCommand(taskService, "Realizar el punto 3"));
commandInvoker.Execute(new CreateTaskCommand(taskService, "Realizar el punto 4"));
commandInvoker.Execute(new CreateTaskCommand(taskService, "Otra tarea"));

taskService.PrintAll();

commandInvoker.Execute(new EditTaskCommand(taskService, 4, "Realizar el punto 200"));

taskService.PrintAll();
commandInvoker.Undo();
taskService.PrintAll();

commandInvoker.Execute(new EditTaskCommand(taskService, 4, "Realizar el punto 2"));
commandInvoker.Execute(new CompleteTaskCommand(taskService, 1));
commandInvoker.Execute(new CompleteTaskCommand(taskService, 2));
commandInvoker.Execute(new CompleteTaskCommand(taskService, 3));
commandInvoker.Execute(new CompleteTaskCommand(taskService, 4));
commandInvoker.Execute(new CompleteTaskCommand(taskService, 5));
commandInvoker.Execute(new CompleteTaskCommand(taskService, 6));

taskService.PrintAll();

commandInvoker.Execute(new DeleteTaskCommand(taskService, 7));
commandInvoker.Execute(new DeleteTaskCommand(taskService, 6));

taskService.PrintAll();
commandInvoker.Undo();
taskService.PrintAll();

Console.WriteLine("--------------------Fin ejercicio 3--------------------\n\n");


Console.WriteLine("--------------------Inicio ejercicio 4--------------------");
Console.WriteLine("Patrón comportamiento -> Command\n");

var root = new Folder("root");
var docs = new Folder("docs");
var img = new Folder("img");

var readme = new File("readme.txt", 1200);
var manual = new File("manual.pdf", 50000);
var photo = new File("foto1.jpg", 2000000);

root.Add(docs);
root.Add(img);
docs.Add(readme);
docs.Add(manual);
img.Add(photo);

Console.WriteLine("=== Tamaños ===");
Console.WriteLine($"root: {Client.GetTotalSize(root)} B");
Console.WriteLine($"docs: {Client.GetTotalSize(docs)} B");
Console.WriteLine($"img : {Client.GetTotalSize(img)} B");

Console.WriteLine("\n=== Árbol ===");
Console.WriteLine(root.ToTreeString());

readme.Rename("README.txt");
Client.Move(docs, manual, img);
Client.Delete(img, photo);

Console.WriteLine("\n=== Después de cambios ===");
Console.WriteLine(root.ToTreeString());
Console.WriteLine($"\nroot (nuevo tamaño): {Client.GetTotalSize(root)} B");



Console.WriteLine("--------------------Fin ejercicio 4--------------------");
