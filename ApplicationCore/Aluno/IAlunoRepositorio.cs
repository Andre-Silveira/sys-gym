using ApplicationCore.Models;

namespace ApplicationCore;

public interface IAlunoRepositorio
{
    void AtualizarAluno(Aluno aluno);
    Aluno BuscarAlunoById(string id);
    List<Aluno> BuscarAlunos();
    void CadastrarAluno(Aluno aluno);
    void DeletarAluno(string id);
}
