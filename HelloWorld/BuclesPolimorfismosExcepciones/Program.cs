var circ = new Circulo();

circ.Radio = 20;
var result_area = circ.Area();
var result_perim = circ.Perimetro();

Console.WriteLine($"El area es: {result_area} y el perimetro es: {result_perim} el nuevo radio es: {circ.Add10()}");

int prev = 0, next = 1, sum;
for (int i = 0; i < 10; i++){
    Console.WriteLine(prev);
    sum = prev + next;
    prev = next;
    next = sum;

}

try
{
    Console.WriteLine("Numero a dividir: ");
    double n = double.Parse(Console.ReadLine());
    Console.WriteLine("divisor: ");
    double divisor = double.Parse(Console.ReadLine());
    if (divisor == 0)
    {
        throw new DivideByZeroException();
}
    
    
   Console.WriteLine($"Resultado: {n/divisor}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Error: Divisor no puede ser 0");
}
catch (Exception)
{
    Console.WriteLine("Error Desconocido");
}

// abstract class Figura
// {
//     public abstract double Area();
//     public abstract double Perimetro();
// }