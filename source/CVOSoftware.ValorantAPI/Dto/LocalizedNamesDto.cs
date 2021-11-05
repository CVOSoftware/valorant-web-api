using System.Text.Json.Serialization;

namespace CVOSoftware.ValorantAPI.Dto
{
    public sealed record LocalizedNamesDto
    {
        /// <summary>
        /// ar-AE
        /// </summary>
        [JsonPropertyName("ar-AE")]
        public string AE { get; init; }

        /// <summary>
        /// de-DE
        /// </summary>
        [JsonPropertyName("de-DE")]
        public string DE { get; init; }

        /// <summary>
        /// en-GB
        /// </summary>
        [JsonPropertyName("en-GB")]
        public string GB { get; init; }

        /// <summary>
        /// en-US
        /// </summary>
        [JsonPropertyName("en-US")]
        public string US { get; init; }

        /// <summary>
        /// es-ES
        /// </summary>
        [JsonPropertyName("es-ES")]
        public string ES { get; init; }

        /// <summary>
        /// es-MX
        /// </summary>
        [JsonPropertyName("es-MX")]
        public string MX { get; init; }

        /// <summary>
        /// fr-FR
        /// </summary>
        [JsonPropertyName("fr-FR")]
        public string FR { get; init; }

        /// <summary>
        /// id-ID
        /// </summary>
        [JsonPropertyName("id-ID")]
        public string ID { get; init; }

        /// <summary>
        /// it-IT
        /// </summary>
        [JsonPropertyName("it-IT")]
        public string IT { get; init; }

        /// <summary>
        /// ja-JP
        /// </summary>
        [JsonPropertyName("ja-JP")]
        public string JP { get; init; }

        /// <summary>
        /// ko-KR
        /// </summary>
        [JsonPropertyName("ko-KR")]
        public string KR { get; init; }

        /// <summary>
        /// pl-PL
        /// </summary>
        [JsonPropertyName("pl-PL")]
        public string PL { get; init; }

        /// <summary>
        /// pt-BR
        /// </summary>
        [JsonPropertyName("pt-BR")]
        public string BR { get; init; }

        /// <summary>
        /// ru-RU
        /// </summary>
        [JsonPropertyName("ru-RU")]
        public string RU { get; init; }

        /// <summary>
        /// th-TH
        /// </summary>
        [JsonPropertyName("th-TH")]
        public string TH { get; init; }

        /// <summary>
        /// tr-TR
        /// </summary>
        [JsonPropertyName("tr-TR")]
        public string TR { get; init; }

        /// <summary>
        /// vi-VN
        /// </summary>
        [JsonPropertyName("vi-VN")]
        public string VN { get; init; }

        /// <summary>
        /// zh-CN
        /// </summary>
        [JsonPropertyName("zh-CN")]
        public string CN { get; init; }

        /// <summary>
        /// zh-TW
        /// </summary>
        [JsonPropertyName("zh-TW")]
        public string TW { get; init; }
    }
}