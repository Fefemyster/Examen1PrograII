
using Examen1PrograII;
using static System.Runtime.InteropServices.JavaScript.JSType;

Alumno alumno = new Alumno();
alumno.Nombre = "Kaine";
alumno.NumeroCuenta = "123456";
alumno.Email = "Kaine@ceutec.com";

Asignatura asignatura = new Asignatura();
asignatura.NombreAsignatura = "Programación II";
asignatura.NombreDocente = "Prof. Roger Guardian";
asignatura.Horario = "Lunes, Miércoles y Viernes de 06:00 a 07:30 PM";

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
  
    Console.WriteLine($"EL estudiante {alumno.Nombre} ha sido matriculado en la asignatura {asignatura.NombreAsignatura} en el horario {asignatura.Horario} con el docente {asignatura.NombreDocente}.");
    Console.WriteLine($"El correo del estudiante es: {alumno.Email}");
    Console.WriteLine($"La nota final es: {notaFinal}");
    Console.WriteLine($"Resultado: {matricula.ObtenerMensajeNota(notaFinal)}");
   

}
catch (FormatException)
{
    Console.WriteLine("Ingrese una nota valida");
}


Console.WriteLine();
Console.WriteLine("Utilizando el método sobrecargado (siempre dara error hasta que se cambien los valores de las notas)");

try
{
    
    double n1 = 15;
    double n2 = 20;
    double n3 = 45;

    matricula.ValidarNotas(n1, n2, n3);

    double notaFinal2 = matricula.CalcularNotaFinal(n1, n2, n3);
    Console.WriteLine($"La nota final es: {notaFinal2}");
    Console.WriteLine($"Resultado: {matricula.ObtenerMensajeNota(notaFinal2)}");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"{ex.Message}");
}