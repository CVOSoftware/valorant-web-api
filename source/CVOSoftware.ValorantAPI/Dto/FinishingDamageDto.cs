using System.Text.Json.Serialization;

namespace CVOSoftware.ValorantAPI.Dto
{
    public sealed record FinishingDamageDto
    {
        [JsonPropertyName("isSecondaryFireMode")]
        public bool IsSecondaryFireMode { get; init; }

        [JsonPropertyName("damageType")]
        public string DamageType { get; init; }

        [JsonPropertyName("damageItem")]
        public string DamageItem { get; init; }
    }
}