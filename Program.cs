using System;
using System.Text;


using System;
public class Program
{
    public static void Main(String[] args)
    {
        ProcessarQuestao1();
        ProcessarQuestao2();
        ProcessarQuestao3();
        ProcessarQuestao4();
        ProcessarQuestao5();
    }
    private static void ProcessarQuestao1()
    {
        // Todo o código de resolução da Questão 1 aqui dentro
        Paciente p1 = new Paciente();
        p1.Nome = "Beatriz Yana";
        p1.CnS = 227683387130006;
        Console.WriteLine($"------------------------------\nResposta da Questão 1\n------------------------------\nObjeto: Paciente\nToString():\n{p1}\n");
    }
    private static void ProcessarQuestao2()
    {
        // Todo o código de resolução da Questão 2 aqui dentro
        Eletrodomestico e1 = new Eletrodomestico();
        e1.Codigo = 851796157395;
        e1.Nome = "Refrigerador";
        e1.Preco = 3253.12m;

        Console.WriteLine($"------------------------------\nResposta da Questão 2\n------------------------------\nObjeto: Paciente\nToString():\n{e1}\n");
    }
    // Demais métodos aqui
    private static void ProcessarQuestao3()
    {
        // Todo o código de resolução da Questão 2 aqui dentro

        Circulo circulo = new Circulo();
        circulo.Raio = 2.0;

        Quadrado quadrado = new Quadrado();
        quadrado.Lado = 2.0;

        Retangulo retangulo = new Retangulo();
        retangulo.LadoA = 2.0;
        retangulo.LadoB = 3.0;

        Losango losango = new Losango();
        losango.DiagonalA = 2.0;
        losango.DiagonalB = 3.0;

        Console.WriteLine($"------------------------------\nResposta da Questão 3\n------------------------------\nObjeto: Círculo\nToString():\n{circulo}\n\nObjeto: Quadrado\nToString():\n{quadrado}\n\nObjeto: Retângulo\nToString():\n{retangulo}\n\nObjeto: Losango\nToString():\n{losango}\n\n");
    }
    private static void ProcessarQuestao4()
    {
        // Todo o código de resolução da Questão 2 aqui dentro
    }
    private static void ProcessarQuestao5()
    {
        // Todo o código de resolução da Questão 2 aqui dentro\
        Credencial cLuis = new Credencial();
        cLuis.Identificacao = "luis.guisso";
        cLuis.Senha = "asdf123";
        cLuis.Ativo = true;

        Usuario luis = new Usuario();
        luis.Credencial = cLuis;
        luis.Nome = "Luis Guisso";
        luis.Email = "luis.guisso@ifnmg.edu.br";
        luis.Nascimento = new DateTime(1982, 1, 1);

        Console.WriteLine($"------------------------------\nResposta da Questão 5\n------------------------------\nObjeto:Usuário\nToString():\n\n{luis}\n\n\n\n");

        //Teste com a Senha Incorreta.
        // cLuis.Senha = "123";
        // cLuis.Ativo = false;
        // Console.WriteLine(luis);
    }
}

// class Program
// {
//     public static void Main(string[] args)
//     {
//         // Console.WriteLine("Pass");
//         ContaBancaria n1 = new ContaBancaria();
//         ContaBancaria n2 = new ContaBancaria(1337, 5000.6789m);
//         // Console.WriteLine($"Conta: {n1.Numero}\nSaldo: {n1.Saldo}");
//         // Console.WriteLine($"Conta: {n2.Numero}\nSaldo: {n2.Saldo}");
//         // n1.Depositar(100m);
//         // n2.Depositar(300m);
//         // Console.WriteLine($"Conta: {n1.Numero}\nSaldo: {n1.Saldo}");
//         // Console.WriteLine($"Conta: {n2.Numero}\nSaldo: {n2.Saldo}");
//         // try
//         // {
//         //     n1.Sacar(1500m);
//         // }
//         // catch (Exception ex)
//         // {
//         //     Console.WriteLine(ex.Message);
//         // }
//         // Console.WriteLine($"Conta: {n1.Numero}\nSaldo: {n1.Saldo}");
//         n1.Senha = "1337";
//         if (n1.SenhaValida("1338"))
//         {
//             Console.WriteLine("Senha Correta");
//         }
//         else
//         {
//             Console.WriteLine("Senha Incorreta");
//         }
//     }
// }