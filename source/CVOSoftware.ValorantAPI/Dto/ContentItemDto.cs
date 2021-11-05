using System.Text.Json.Serialization;

namespace CVOSoftware.ValorantAPI.Dto
{
    public sealed record ContentItemDto
    {
        [JsonPropertyName("id")]
        public string Id { get; init; }

        [JsonPropertyName("name")]
        public string Name { get; init; }

        /// <summary>
        /// This field is only included for maps and game modes. These values are used in the match response.
        /// </summary>
        [JsonPropertyName("assetName")]
        public string AssetName { get; init; }

        [JsonPropertyName("assetPath")]
        public string AssetPath { get; init; }

        /// <summary>
        /// This field is excluded from the response when a locale is set.
        /// </summary>
        [JsonPropertyName("localizedNames")]
        public LocalizedNamesDto LocalizedNames { get; init; }
    }
}