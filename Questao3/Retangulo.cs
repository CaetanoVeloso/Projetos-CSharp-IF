using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Retangulo
{
    public Double LadoA { get; set; }
    public Double LadoB { get; set; }
    public Double CalcularArea()
    {
        return LadoA * LadoB;
    }
    public override string ToString()
    {
        return "LadoA = " + LadoA + "\nLadoB = " + LadoB + "\nArea = " + CalcularArea();
    }
}
