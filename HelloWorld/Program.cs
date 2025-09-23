namespace HelloWorld
{
    class Program
    {

        static void Main()
        {
            DateOnly dateconverted = new DateOnly();
            string nameInput;
            string birthDateInput;
            Console.WriteLine("Hola, bienvenido al calculador de años!");
            Console.WriteLine("Escribe tu nombre: ");
            nameInput = Console.ReadLine();
            Console.WriteLine($"Un gusto conocerte {nameInput}");
            Console.WriteLine("Escribe tu fecha de nacimiento en formato dd/mm/yyyy");
            birthDateInput = Console.ReadLine();
            bool isDateValid = DateOnly.TryParse(birthDateInput, out dateconverted);
            if (isDateValid == false) Console.WriteLine($"La fecha de nacimiento es invalida, usted nos envio este dato erroneo: {birthDateInput}");
            var person = new Person
            {
                Name = nameInput,
                BirthDate = dateconverted,
                Age = DateTime.Now.Year - dateconverted.Year
            };
            Console.WriteLine($"Tu nombre: {nameInput}");
            Console.WriteLine($"Tu fecha de nacimiento: {person.BirthDate}");
            Console.WriteLine($"Tu edad es: {person.Age} años!");

            Console.ReadLine();
        }
    }
    public class Person
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public DateOnly BirthDate { get; set; }
    }

}
