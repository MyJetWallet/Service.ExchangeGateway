using System.Runtime.Serialization;

namespace Service.ExchangeGateway.Grpc.Models.Exchange
{
    [DataContract]
    public class TransferFireblocksToBinanceRequest
    {
        [DataMember(Order = 1)]
        public string AssetSymbol { get; set; }

        [DataMember(Order = 2)]
        public string AssetNetwork { get; set; }

        [DataMember(Order = 3)]
        public int VaultAccountId { get; set; }

        [DataMember(Order = 4)]
        public decimal Amount { get; set; }

        [DataMember(Order = 5)]
        public string RequestId { get; set; }
    }
}
