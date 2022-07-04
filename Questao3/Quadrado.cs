using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class Quadrado
{
    public Double Lado { get; set; }
    public Double CalcularArea()
    {
        return Math.Pow(2, Lado);
    }
    public override string ToString()
    {
        return "Lado = " + Lado + "\nArea = " + CalcularArea();
    }
}
