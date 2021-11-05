using System.Text.Json.Serialization;

namespace CVOSoftware.ValorantAPI.Dto
{
    public sealed record ContentDto
    {
        [JsonPropertyName("version")]
        public string Version { get; init; }

        [JsonPropertyName("acts")]
        public ActDto[] Acts { get; init; }

        [JsonPropertyName("characters")]
        public ContentItemDto[] characters { get; init; }

        [JsonPropertyName("maps")]
        public ContentItemDto[] maps { get; init; }

        [JsonPropertyName("chromas")]
        public ContentItemDto[] chromas { get; init; }

        [JsonPropertyName("skins")]
        public ContentItemDto[] skins { get; init; }

        [JsonPropertyName("skinLevels")]
        public ContentItemDto[] skinLevels { get; init; }

        [JsonPropertyName("equips")]
        public ContentItemDto[] equips { get; init; }

        [JsonPropertyName("gameModes")]
        public ContentItemDto[] gameModes { get; init; }

        [JsonPropertyName("sprays")]
        public ContentItemDto[] sprays { get; init; }

        [JsonPropertyName("sprayLevels")]
        public ContentItemDto[] sprayLevels { get; init; }

        [JsonPropertyName("charms")]
        public ContentItemDto[] charms { get; init; }

        [JsonPropertyName("charmLevels")]
        public ContentItemDto[] charmLevels { get; init; }

        [JsonPropertyName("playerCards")]
        public ContentItemDto[] playerCards { get; init; }

        [JsonPropertyName("playerTitles")]
        public ContentItemDto[] playerTitles { get; init; }
    }
}