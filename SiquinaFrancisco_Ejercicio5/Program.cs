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

if (historial == 4)
{
    if (fiador == "S" && monto <= 5000)
    {
        resultado = "Aprobado con condiciones";
        motivo = "Historial malo pero tiene fiador";
    }
    else
    {
        resultado = "Rechazado";
        motivo = "Historial crediticio malo";
    }
}
else
{
    switch (tipoSolicitante)
    {
        case 1: 
            if (antiguedad >= 12 && ingreso >= 2000)
            {
                resultado = "Aprobado";
                motivo = "Empleado estable";
            }
            else
            {
                resultado = "Aprobado con condiciones";
                motivo = "Poca antiguedad laboral";
            }
            break;

        case 2: 
            if (antiguedad >= 12 && ingreso >= 2500)
            {
                resultado = "Aprobado";
                motivo = "Ingreso suficiente";
            }
            else
            {
                resultado = "Rechazado";
                motivo = "Ingreso o antiguedad insuficiente";
            }
            break;

        case 3: 
            if (ingreso >= 3000)
            {
                resultado = "Aprobado";
                motivo = "Ingreso alto";
            }
            else
            {
                resultado = "Aprobado con condiciones";
                motivo = "Ingreso moderado";
            }
            break;

        case 4: 
            if (fiador == "S")
            {
                resultado = "Aprobado con condiciones";
                motivo = "Estudiante con fiador";
            }
            else
            {
                resultado = "Rechazado";
                motivo = "Estudiante sin fiador";
            }
            break;

        default:
            Console.WriteLine("Tipo de solicitante invalido");
            break;
    }
}

Console.WriteLine("Resultado del prestamo: " + resultado);
Console.WriteLine("Motivo principal: " + motivo);
