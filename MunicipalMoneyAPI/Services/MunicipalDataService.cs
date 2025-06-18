using MunicipalMoneyApi.Models;
using System.Threading.Tasks;

namespace MunicipalMoneyApi.Services
{
    public class MunicipalDataService : IMunicipalDataService
    {
        public async Task<CubeFactsResponse> GetCubeFactsAsync(string cubeName, string? cut = null, string? order = null, int page = 1, int pageSize = 10000)
        {
            // Simulate async data fetch with Task.FromResult
            var response = new CubeFactsResponse
            {
                Id = 1,
                Name = cubeName,
                Description = $"Description for {cubeName}"
            };

            return await Task.FromResult(response);
        }
    }
}
