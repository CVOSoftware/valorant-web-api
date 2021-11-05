using System.Text.Json.Serialization;

namespace CVOSoftware.ValorantAPI.Dto
{
    public sealed record PlayerDto
    {
        [JsonPropertyName("competitiveTier")]
        public int CompetitiveTier { get; init; }

        [JsonPropertyName("puuid")]
        public string Puuid { get; init; }

        [JsonPropertyName("teamId")]
        public string TeamId { get; init; }

        [JsonPropertyName("partyId")]
        public string PartyId { get; init; }

        [JsonPropertyName("characterId")]
        public string CharacterId { get; init; }

        [JsonPropertyName("playerCard")]
        public string PlayerCard { get; init; }

        [JsonPropertyName("gameName")]
        public string GameName { get; init; }

        [JsonPropertyName("tagLine")]
        public string TagLine { get; init; }

        [JsonPropertyName("playerTitle")]
        public string PlayerTitle { get; init; }

        [JsonPropertyName("stats")]
        public PlayerStatsDto Stats { get; init; }
    }
}