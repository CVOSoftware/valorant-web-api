using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace CVOSoftware.ValorantAPI.Dto
{
    public sealed record RecentMatchesDto
    {
        [JsonPropertyName("currentTime")]
        public long CurrentTime { get; init; }

        /// <summary>
        /// A list of recent match ids.
        /// </summary>
        [JsonPropertyName("matchIds")]
        public string[] MatchIds { get; init; }
    }
}