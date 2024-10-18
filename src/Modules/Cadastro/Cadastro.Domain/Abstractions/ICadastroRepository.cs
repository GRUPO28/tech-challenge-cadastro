namespace Cadastro.Domain.Abstractions;

public interface ICadastroRepository
{
    Task<Entities.Cadastro> ObterCadastroAsync(string cpf);
    Task<List<Entities.Cadastro>> ObterTodosCadastrosAsync();
    Task CadastrarAsync(Entities.Cadastro cadastro);
}
