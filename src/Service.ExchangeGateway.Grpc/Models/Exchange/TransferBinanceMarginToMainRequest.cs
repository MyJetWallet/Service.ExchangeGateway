using System.Runtime.Serialization;

namespace Service.ExchangeGateway.Grpc.Models.Exchange
{
    [DataContract]
    public class TransferBinanceMarginToMainRequest
    {
        [DataMember(Order = 1)]
        public string AssetSymbol { get; set; }

        [DataMember(Order = 2)]
        public decimal Amount { get; set; }

        [DataMember(Order = 3)]
        public string RequestId { get; set; }
    }
}
