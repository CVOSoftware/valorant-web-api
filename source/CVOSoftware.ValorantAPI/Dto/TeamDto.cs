using System.Text.Json.Serialization;

namespace CVOSoftware.ValorantAPI.Dto
{
    public sealed record TeamDto
    {
        [JsonPropertyName("won")]
        public int W { get; init; }

        /// <summary>
        /// Team points scored. Number of kills in deathmatch.
        /// </summary>
        [JsonPropertyName("numPoints")]
        public int NumPoints { get; init; }

        [JsonPropertyName("roundsWon")]
        public int RoundsWon { get; init; }

        [JsonPropertyName("roundsPlayed")]
        public int RoundsPlayed { get; init; }

        /// <summary>
        /// This is an arbitrary string. Red and Blue in bomb modes. The puuid of the player in deathmatch.
        /// </summary>
        [JsonPropertyName("teamId")]
        public string TeamId { get; init; }
    }
}