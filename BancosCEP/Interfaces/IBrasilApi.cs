using BancosCEP.Dtos;
using BancosCEP.Models;

namespace BancosCEP.Interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCEP(string cep);
        Task<ResponseGenerico<List<BancoModel>>> BuscarTodosBancos();

        Task<ResponseGenerico<BancoModel>> BuscarBancoPorCodigoBancario(int code);
    }
}
