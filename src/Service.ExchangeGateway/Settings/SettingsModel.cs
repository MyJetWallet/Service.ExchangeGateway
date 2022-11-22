using MyJetWallet.Sdk.Service;
using MyYamlParser;

namespace Service.ExchangeGateway.Settings
{
    public class SettingsModel
    {
        [YamlProperty("ExchangeGateway.SeqServiceUrl")]
        public string SeqServiceUrl { get; set; }

        [YamlProperty("ExchangeGateway.ZipkinUrl")]
        public string ZipkinUrl { get; set; }

        [YamlProperty("ExchangeGateway.ElkLogs")]
        public LogElkSettings ElkLogs { get; set; }

        [YamlProperty("ExchangeGateway.FireblocksSignerGrpcServiceUrl")]
        public string FireblocksSignerGrpcServiceUrl { get; set; }

        [YamlProperty("ExchangeGateway.BinanceExchangeId")]
        public string BinanceExchangeId { get; set; }
    }
}
