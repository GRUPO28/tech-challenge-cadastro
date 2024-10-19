using Cadastro.Application.DTO;

namespace Cadastro.Application.Abstractions;

public interface ICadastroService
{
    Task<bool> CadastrarAsync(CadastroRequest cadastro);
    Task<CadastroResponse> ObterCadastroAsync(string cpf);
}
