using Cadastro.Application.UseCases.GravarCadastro;
using Cadastro.Application.UseCases.ObterCadastro;
using Cadastro.Domain.Abstractions;
using Cadastro.Domain.ValueObjects;
using Common.Exceptions;
using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Cadastro.Test.Unit.Steps.UseCases;

[Binding]
[ExcludeFromCodeCoverage]
public class GravarCadastroSteps
{
    private readonly GravarCadastroUseCase _useCase;
    private readonly Mock<ICadastroRepository> _cadastroRepositoryMock;

    private GravarCadastroRequest? _request;

    public GravarCadastroSteps()
    {
        _cadastroRepositoryMock = new();
        _useCase = new(_cadastroRepositoryMock.Object);
    }


   
}
