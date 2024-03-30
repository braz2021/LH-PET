using Microsoft.AspNetCore.Mvc;

namespace LHPet.Models;

public class Cliente // modelo 
// atributos
{
    public int     Id       { get; set; }
    public string? Nome     { get; set; }
    public string? Cpf      { get; set; }
    public string? Email    { get; set; }
    public string? Paciente { get; set; }

    public Cliente(int id, string Nome, string cpf, string email, string paciente)
    {
        this.Id = id;
        this.Nome = Nome;
         this.Cpf = cpf;
        this.Email = email;
        this.Paciente = paciente;
    }

}