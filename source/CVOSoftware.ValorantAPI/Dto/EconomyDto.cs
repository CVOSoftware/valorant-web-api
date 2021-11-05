using System.Text.Json.Serialization;

namespace CVOSoftware.ValorantAPI.Dto
{
    public sealed record EconomyDto
    {
        [JsonPropertyName("loadoutValue")]
        public int LoadoutValue { get; init; }

        [JsonPropertyName("remaining")]
        public int Remaining { get; init; }

        [JsonPropertyName("spent")]
        public int Spent { get; init; }

        [JsonPropertyName("weapon")]
        public string Weapon { get; init; }

        [JsonPropertyName("armor")]
        public string Armor { get; init; }
    }
}