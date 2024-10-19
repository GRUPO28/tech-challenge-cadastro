﻿using Cadastro.Application.Abstractions;
using Cadastro.Domain.Abstractions;
using Cadastro.Domain.ValueObjects;

namespace Cadastro.Application.UseCases.GravarCadastro;

public class GravarCadastroUseCase : IUseCase<GravaCadastrorRequest>
{
    private readonly ICadastroRepository _cadastroRepository;

    public GravarCadastroUseCase(ICadastroRepository cadastroRepository)
    {
        _cadastroRepository = cadastroRepository;
    }
    public async Task ExecuteAsync(GravaCadastrorRequest request)
    {
        var cadastroDomain = new Domain.Entities.Cadastro(
            null,
            DateTime.UtcNow,
            new Email(request.Email),
            new CPF(request.CPF),
            request.Nome
         );

        await _cadastroRepository.CadastrarAsync(cadastroDomain);
    }
}
