using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Losango
{
    public Double DiagonalA { get; set; }
    public Double DiagonalB { get; set; }
    public Double CalcularArea()
    {
        return (DiagonalA * DiagonalB) / 2;
    }
    public override string ToString()
    {
        return "Diagonal A = " + DiagonalA + "\nDiagonal B = " + DiagonalB + "\nArea = " + CalcularArea();
    }
}