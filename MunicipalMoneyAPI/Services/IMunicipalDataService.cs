using MunicipalMoneyApi.Models;
using System.Threading.Tasks;

namespace MunicipalMoneyApi.Services
{
    public interface IMunicipalDataService
    {
        Task<CubeFactsResponse> GetCubeFactsAsync(string cubeName, string? cut = null, string? order = null, int page = 1, int pageSize = 10000);
    }
}
