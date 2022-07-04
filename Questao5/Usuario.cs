using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Usuario
    {
        public String Nome { get; set; } = string.Empty;
        public String Email { get; set; } = string.Empty;
        public DateTime Nascimento { get; set; }
        public Byte Idade { get{
            return Convert.ToByte(new DateTime((DateTime.Now - Nascimento).Ticks).Year - 1);
        }}
        public Credencial ?Credencial { get; set; }
        public override String ToString() {

    // TimeSpan Intervalo = DateTime.Now - Nascimento;
    // Idade = Convert.ToByte(Math.Floor(Intervalo.TotalDays / 365.25));
        //Idade = Convert.ToByte(Math.Floor((DateTime.Now - Nascimento).TotalDays / 365.2425));
        // m2Idade = Convert.ToByte(new DateTime((DateTime.Now - Nascimento).Ticks).Year);
        //var timeSpan = DateTime.Now - Nascimento;
        //Idade = Convert.ToByte(new DateTime((DateTime.Now - Nascimento).Ticks).Year - 1);
        //TimeSpan I = DateTime.Now - Nascimento;
        //Idade = Convert.ToByte(DateTime.Now - Nascimento);
        // if (DateTime.Now.DayOfYear < Nascimento.DayOfYear){
        //     Idade = I - 1;
        //Idade = Convert.ToByte(I.TotalYears);
    
    return ($"** Usuário **\n\nNome = {Nome}\nEmail = {Email}\nData de Nascimento = {Nascimento:dd/MM/yyyy}\nIdade = {Idade}\n\n** Credenciais **\n\nIdentificação = {Credencial.Identificacao}\nStatus = {(Credencial.Ativo ? "Ativo" : "Inativo")}\n{(Credencial.Autenticar() ? "Senha Correta!":"Senha Incorreta!")}");
    }
        
}