
using Examen1PrograII;

Alumno alumno = new Alumno();
alumno.Nombre = "Kaine";
alumno.NumeroCuenta = "123456";
alumno.Email = "Kaine@ceutec.com";

Asignatura asignatura = new Asignatura();
asignatura.NombreAsignatura = "Programación II";
asignatura.NombreDocente = "Prof. Roger Guardian";

Matricula matricula = new Matricula();
matricula.Alumno = alumno;
matricula.Asignatura = asignatura;
matricula.NotasParciales = new List<double>();

try
{
    Console.WriteLine("Ingrese sus 3 notas parciales: ");
    for (int i = 1; i <= 3; i++)
    {
        Console.Write($"Nota {i}: ");
        double nota = double.Parse(Console.ReadLine());
        matricula.NotasParciales.Add(nota);
    }

    double notaFinal = matricula.CalcularNotaFinal();
    Console.WriteLine($"La nota final es: {notaFinal}");
    Console.WriteLine($"Resultado: {matricula.ObtenerMensajeNota(notaFinal)}");

   
}
catch (FormatException)
{
    Console.WriteLine("Ingrese una nota valida");
}

try
{
    //Utilizando el método sobrecargado
    double n1 = 15;
    double n2 = 20;
    double n3 = 45;

    matricula.ValidarNotas(n1, n2, n3);

    double notaFinal2 = matricula.CalcularNotaFinal(n1, n2, n3);
    Console.WriteLine($"La nota final es: {notaFinal2}");
    Console.WriteLine($"Resultado: {matricula.ObtenerMensajeNota(notaFinal2)}");
}
catch(ArgumentException ex)
{
    Console.WriteLine($"{ex.Message}");
}