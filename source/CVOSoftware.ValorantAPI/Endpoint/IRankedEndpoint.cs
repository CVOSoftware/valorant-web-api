using System.Threading.Tasks;

using CVOSoftware.ValorantAPI.Dto;
using CVOSoftware.ValorantAPI.Type;

namespace CVOSoftware.ValorantAPI.Endpoint
{
    public interface IRankedEndpoint
    {
        internal const string Endpoint = "/val/ranked/v1/leaderboards/by-act/";

        /// <param name="size">Defaults to 200. Valid values: 1 to 200.</param>
        /// <param name="startIndex">Defaults to 0.</param>
        Task<Result<LeaderboardDto>> GetLeaderboard(string actId, int size = 200, int startIndex = 0);
    }
}