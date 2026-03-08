int tipoSolicitante;
int historial;
int antiguedad;

double ingreso;
double monto;

string fiador;

string resultado = "";
string motivo = "";

Console.WriteLine("Tipo de solicitante:");
Console.WriteLine("1 Empleado fijo");
Console.WriteLine("2 Temporal");
Console.WriteLine("3 Independiente");
Console.WriteLine("4 Estudiante");
tipoSolicitante = int.Parse(Console.ReadLine());

Console.Write("Ingreso mensual: ");
ingreso = double.Parse(Console.ReadLine());

Console.Write("Antiguedad laboral en meses: ");
antiguedad = int.Parse(Console.ReadLine());

Console.Write("Monto solicitado: ");
monto = double.Parse(Console.ReadLine());

Console.WriteLine("Historial crediticio:");
Console.WriteLine("1 Excelente");
Console.WriteLine("2 Bueno");
Console.WriteLine("3 Regular");
Console.WriteLine("4 Malo");
historial = int.Parse(Console.ReadLine());

Console.Write("Tiene fiador (S/N): ");
fiador = Console.ReadLine();
