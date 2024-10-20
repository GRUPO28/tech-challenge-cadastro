using Cadastro.Domain.ValueObjects;
using Common.Entities;
using Common.Exceptions;

namespace Cadastro.Domain.Entities;

public class Cadastro : Entity, IAggregationRoot
{
    public Cadastro(string id, DateTime dataDeCriacao, Email email, CPF cpf, string nome): base(id, dataDeCriacao)
    {
        Email = email;
        CPF = cpf;
        Nome = nome;

        Validate();
    }

    public Email Email { get; set; }
    public CPF CPF { get; set; }
    public string Nome { get; set; }

    protected override void Validate()
    {
        if (string.IsNullOrWhiteSpace(Nome)) 
        {
            throw new DomainNotificationException("O nome é obrigatório.");
        }
    }
}
