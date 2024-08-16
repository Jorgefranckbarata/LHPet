namespace LHPet.Models;


public class Cliente 
{
    public int Id {get; set;}
    public string? Nome { get; set; }
    public string? Cpf { get; set; }
    public string? Email { get; set; }
    public string? Paciente { get; set; }

    public Cliente (int id, string nome, string Cpf,  string email , string Paciente)
     {
        this.Id = id;
        this.Nome = nome;
        this.Cpf = Cpf;
        this.Email = email;
        this.Paciente = Paciente; 
    }
    
    
    
    
    
    
    
    
}