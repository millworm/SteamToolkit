using Newtonsoft.Json;

namespace SteamToolkit.Trading
{
    [JsonObject(Title = "RootObject")]
    public class Trade
    {
        [JsonProperty("tradeid")]
        public ulong? TradeId { get; set; }
        [JsonProperty("needs_mobile_confirmation")]
        public bool MobileConfirmation { get; set; }
        [JsonProperty("needs_email_confirmation")]
        public bool EmailConfirmation { get; set; }
    }
}