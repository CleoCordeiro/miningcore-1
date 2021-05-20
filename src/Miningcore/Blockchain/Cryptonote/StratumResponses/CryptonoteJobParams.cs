

using Newtonsoft.Json;

namespace Miningcore.Blockchain.Cryptonote.StratumResponses
{
    public class CryptonoteJobParams
    {
        [JsonProperty("job_id")]
        public string JobId { get; set; }

        public string Blob { get; set; }
        public string Target { get; set; }

        [JsonProperty("seed_hash")]
        public string SeedHash { get; set; }

        /// <summary>
        /// Introduced for CNv4 (aka CryptonightR)
        /// </summary>
        public ulong Height { get; set; }
    }
}
