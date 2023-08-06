﻿namespace ApplicationCore.Models;
public class Aluno
{
    public string Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public string CPF { get; set; }
    public string Endereco { get; set; }
    public List<Aula> Aula { get; set; }
    public DateTime DataNascimento { get; set; }
    public bool Ativo { get; set; }


}