using System.Text.Json.Serialization;

namespace CVOSoftware.ValorantAPI.Dto
{
    public sealed record PlayerRoundStatsDto
    {
        [JsonPropertyName("score")]
        public int Score { get; init; }

        [JsonPropertyName("puuid")]
        public string Puuid { get; init; }

        [JsonPropertyName("ability")]
        public AbilityDto Ability { get; init; }

        [JsonPropertyName("economy")]
        public EconomyDto Economy { get; init; }

        [JsonPropertyName("kills")]
        public KillDto[] Kills { get; init; }

        [JsonPropertyName("damage")]
        public DamageDto[] Damage { get; init; }
    }
}