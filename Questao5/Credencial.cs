using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Credencial
{
    public String Identificacao { get; set; } = string.Empty;
    public Boolean Ativo { get; set; }
    public String Senha { private get; set; } = string.Empty;
    public Usuario ?Usuario { get; set; }
    public Boolean Autenticar(String senha = "asdf123"){
		return senha == Senha;
	}


    // public Boolean Autenticar(String senha = "asdf123")
    // {

    //     if (senha == Senha)
    //     {

    //         return true;
    //     }
    //     else
    //     {

    //         return false;
    //     }
    // }
}