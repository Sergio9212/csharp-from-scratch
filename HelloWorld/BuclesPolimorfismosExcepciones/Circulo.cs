public class Circulo
{
    public double Radio { get; set; }

    public double Area()
    {
        return Math.PI * Radio * Radio;
    }

    public double Perimetro()
    {
        return 2 * Math.PI * Radio;
    }

    public double Add10()
    {
        Radio += 10;
        return Radio;
    }
}


