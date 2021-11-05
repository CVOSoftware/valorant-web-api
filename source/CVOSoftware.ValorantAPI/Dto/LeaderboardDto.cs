using System.Text.Json.Serialization;

namespace CVOSoftware.ValorantAPI.Dto
{
    public sealed record LeaderboardDto
    {
        /// <summary>
        /// The act id for the given leaderboard. Act ids can be found using the val-content API.
        /// </summary>
        [JsonPropertyName("actId")]
        public string ActId { get; init; }

        /// <summary>
        /// The shard for the given leaderboard.
        /// </summary>
        [JsonPropertyName("shard")]
        public string Shard { get; init; }

        /// <summary>
        /// The total number of players in the leaderboard.
        /// </summary>
        [JsonPropertyName("totalPlayers")]
        public long TotalPlayers { get; init; }

        [JsonPropertyName("players")]
        public RankedPlayerDto[] Players { get; init; }
    }
}