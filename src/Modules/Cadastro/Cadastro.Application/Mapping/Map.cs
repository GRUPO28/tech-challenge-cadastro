using Cadastro.Application.UseCases.ObterCadastro;
using Mapster;

namespace Cadastro.Application.Mapping;

public class Map : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Domain.Entities.Cadastro, ObterCadastroResponse>()
            .Map(dest => dest.CPF, src => src.CPF.Numero)
            .Map(dest => dest.Email, src => src.Email.Endereco);
    }
}
