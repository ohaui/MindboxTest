using FigureAreaCalculator;
using FigureAreaCalculator.Interfaces;

namespace FigureAreaCalculator.Figures;

public class Circle : IFigure
{

    /// <summary>
    /// Радиус круга
    /// </summary>
    public double Radius { get; }
    
    /// <summary>
    /// Площадь круга
    /// </summary>
    public double Area => CalculateArea();

    
    /// <param name="radius">Радиус круга</param>
    /// <exception cref="ArgumentOutOfRangeException">Радиус меньше нуля</exception>
    public Circle(double radius)
    {
        Radius = radius;

        if (radius < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(radius), "Радиус не может быть меньше нуля.");
        }
    }


    /// <summary>
    /// Вычисляет площадь круга
    /// </summary>
    /// <returns>Площадь круга</returns>
    protected double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    
}
