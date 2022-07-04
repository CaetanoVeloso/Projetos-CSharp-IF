using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Eletrodomestico
{
    public UInt64 Codigo { get; set; }
    public String Nome { get; set; } = string.Empty;
    public Decimal Preco { get; set; }

    public override String ToString()
    {
        return String.Format("{0:##-####-#####-#}", Codigo) + ", " + Nome + ", " + "R$" + Preco;
    }
}