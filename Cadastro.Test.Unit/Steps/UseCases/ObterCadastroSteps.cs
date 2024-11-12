using Cadastro.Application.UseCases.ObterCadastro;
using Cadastro.Domain.Abstractions;
using Cadastro.Domain.Entities;
using Cadastro.Domain.ValueObjects;
using Moq;
using TechTalk.SpecFlow;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace Cadastro.Test.Unit.Steps.UseCases
{
    [Binding]
    [ExcludeFromCodeCoverage]
    public class ObterCadastroSteps
    {
        private readonly ObterCadastroUseCase _useCase;
        private readonly Mock<ICadastroRepository> _cadastroRepositoryMock;

        private string _CPF;
        private ObterCadastroResponse? _cadastroEncontrado;

        public ObterCadastroSteps()
        {
            _cadastroRepositoryMock = new Mock<ICadastroRepository>();
            _useCase = new ObterCadastroUseCase(_cadastroRepositoryMock.Object);
        }
        
    }
}
