using Cadastro.Application.Abstractions;
using Cadastro.Application.UseCases.ObterCadastro;
using Cadastro.Domain.ValueObjects;
using Common.Exceptions;
using Moq;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Cadastro.Test.Unit.Steps.Domain.Entities;

[Binding]
[ExcludeFromCodeCoverage]
public class CadastroDomain
{
    private static Cadastro.Domain.Entities.Cadastro CriarCadastro()
    {
        string id = Guid.NewGuid().ToString();
        string nome = "Felipe";
        DateTime dataDeCriacao = DateTime.Now;
        string email = "felipe@gmail.com";
        string cpf = "179.938.500-02";

        return new Cadastro.Domain.Entities.Cadastro(
            id,
            dataDeCriacao,
            new Cadastro.Domain.ValueObjects.Email(email),
            new Cadastro.Domain.ValueObjects.Cpf(cpf),
        nome);
    }

    private Cadastro.Domain.Entities.Cadastro? _entidade;
    private Action? act;





}
