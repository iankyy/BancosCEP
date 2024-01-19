using AutoMapper;
using BancosCEP.Dtos;
using BancosCEP.Interfaces;

namespace BancosCEP.Services
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;
        public async Task<ResponseGenerico<EnderecoResponse>> BuscarEnderecoPorCEP(string cep)
        {
            var endereco = await  _brasilApi.BuscarEnderecoPorCEP
        }
    }
}
