using System.Threading.Channels;
using FigureAreaCalculator.Interfaces;

namespace FigureAreaCalculator.Figures;

public class Triangle : IFigure
{

    /// <summary>
    /// Вершина треугольника
    /// </summary>
    public double A { get; }
    
    /// <summary>
    /// Вершина треугольника
    /// </summary>
    public double B { get; }
    
    /// <summary>
    /// Вершина треугольника
    /// </summary>
    public double C { get; }
    
    /// <summary>
    /// Радиус треугольника
    /// </summary>
    public double Area => CalculateArea();
    
    /// <summary>
    /// Является ли треугольник прямоугольным
    /// </summary>
    public bool Rightangled => IsRightangled();

    
    /// <param name="a">Cторона треугольника</param>
    /// <param name="b">Cторона треугольника</param>
    /// <param name="c">Cторона треугольника</param>
    /// <exception cref="ArgumentOutOfRangeException">Одна из сторон
    /// треугольника меньше или равна нулю</exception>
    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;

        if (A <= 0 || B <= 0 || C <= 0)
        {
            throw new ArgumentOutOfRangeException(string.Empty,
                "Cторона треугольника не может быть меньше или равна нулю.");
        }
    }


    /// <summary>
    /// Проверяет является ли треугольник прямоугольным
    /// </summary>
    /// <returns>Bool</returns>
    protected bool IsRightangled()
    {
        var hypotenuse = new[] {A, B, C}.Max();
        
        var exponentedHypotenuse = Math.Pow(hypotenuse, 2);
        
        return exponentedHypotenuse == Math.Pow(A, 2) + Math.Pow(B, 2) + Math.Pow(C, 2) - exponentedHypotenuse;
    }
    
    /// <summary>
    /// Вычисляет площадь треугольника
    /// </summary>
    /// <returns>Площадь треугольника</returns>
    protected double CalculateArea()
    {
        var perimeter = (A + B + C) / 2;
        return Math.Sqrt(perimeter * (perimeter - A) * (perimeter - B) * (perimeter - C)); 
    }
}
