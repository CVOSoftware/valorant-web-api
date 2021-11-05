using System.Text.Json.Serialization;

namespace CVOSoftware.ValorantAPI.Dto
{
    public sealed record AbilityCastsDto
    {
        [JsonPropertyName("grenadeCasts")]
        public int GrenadeCasts { get; init; }

        [JsonPropertyName("ultimateCasts")]
        public int UltimateCasts { get; init; }

        [JsonPropertyName("ability1Casts")]
        public int Ability1Casts { get; init; }

        [JsonPropertyName("ability2Casts")]
        public int Ability2Casts { get; init; }
    }
}