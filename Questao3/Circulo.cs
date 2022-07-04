using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class Circulo
{
    public Double Raio { get; set; }
    public Double CalcularArea()
    {
        return Math.PI * Math.Pow(2, Raio);
    }
    public override string ToString()
    {
        return "Raio = " + Raio + "\nArea = " + CalcularArea();
    }
}
