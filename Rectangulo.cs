public class Rectangulo
{
    private double largo;
    private double ancho;

    public Rectangulo(double largo, double ancho)
    {
        this.largo = largo;
        this.ancho = ancho;
    }

    public double CalcularArea()
    {
        return largo * ancho;
    }

    public double CalcularPerimetro()
    {
        return 2 * (largo + ancho);
    }
}
