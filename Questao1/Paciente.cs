using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class Paciente
{
    public String Nome { get; set; } = string.Empty;
    public UInt64 CnS { get; set; }
    public override String ToString()
    {
    // return Nome + ". " 
    //   + Nome
    //   + String.Format(" ({0}) {1}",
    //                   FonePrincipal.Ddd,
    //                   FonePrincipal.Numero);
    //   //+ " (" + FonePrincipal.Ddd + ") "
    //   //+ FonePrincipal.Numero;
    return Nome +", " + String.Format("{0:### #### #### ####}", CnS);
    }
}