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
    }
}
