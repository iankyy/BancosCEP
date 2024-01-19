using BancosCEP.Dtos;
using BancosCEP.Models;

namespace BancosCEP.Interfaces
{
    public interface IEnderecoService
    {
        Task<ResponseGenerico<EnderecoResponse>> BuscarEnderecoPorCEP(string cep);
    }
}
