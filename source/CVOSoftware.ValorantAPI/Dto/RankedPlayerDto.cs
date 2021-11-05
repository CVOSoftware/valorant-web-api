using System.Text.Json.Serialization;

namespace CVOSoftware.ValorantAPI.Dto
{
    public sealed record RankedPlayerDto
    {
        /// <summary>
        /// This field may be omitted if the player has been anonymized.
        /// </summary>
        [JsonPropertyName("puuid")]
        public string Puuid { get; init; }

        /// <summary>
        /// This field may be omitted if the player has been anonymized.
        /// </summary>
        [JsonPropertyName("gameName")]
        public string GameName { get; init; }

        /// <summary>
        /// This field may be omitted if the player has been anonymized.
        /// </summary>
        [JsonPropertyName("tagLine")]
        public string TagLine { get; init; }

        [JsonPropertyName("leaderboardRank")]
        public long LeaderboardRank { get; init; }

        [JsonPropertyName("rankedRating")]
        public long RankedRating { get; init; }

        [JsonPropertyName("numberOfWins")]
        public long NumberOfWins { get; init; }
    }
}