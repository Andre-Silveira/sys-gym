using ApplicationCore.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Infrastructure.Entity;

public class Alunos
{
    [BsonId]
    public ObjectId Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public string CPF { get; set; }
    public string Endereco { get; set; }
    public List<Aula> Aula { get; set; }
    public decimal Mensalidade { get; set; }
    public DateTime DataNascimento { get; set; }
    public bool Ativo { get; set; }

}
