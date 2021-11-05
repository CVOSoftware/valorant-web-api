using System.Text.Json.Serialization;

namespace CVOSoftware.ValorantAPI.Dto
{
    public sealed record AbilityDto
    {
        [JsonPropertyName("grenadeEffects")]
        public string GrenadeEffects { get; init; }

        [JsonPropertyName("ultimateEffects")]
        public string UltimateEffects { get; init; }

        [JsonPropertyName("ability1Effects")]
        public string Ability1Effects { get; init; }

        [JsonPropertyName("ability2Effects")]
        public string Ability2Effects { get; init; }
    }
}