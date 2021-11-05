using System.Threading.Tasks;

using CVOSoftware.ValorantAPI.Dto;
using CVOSoftware.ValorantAPI.Type;

namespace CVOSoftware.ValorantAPI.Endpoint
{
    public interface IStatusEndpoint
    {
        internal const string Endpoint = "/val/status/v1/platform-data";

        Task<Result<PlatformDataDto>> GetPlatformData();
    }
}