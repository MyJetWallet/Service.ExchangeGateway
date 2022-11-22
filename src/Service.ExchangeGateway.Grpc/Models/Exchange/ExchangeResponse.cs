using Service.ExchangeGateway.Grpc.Models.Common;
using System.Runtime.Serialization;

namespace Service.ExchangeGateway.Grpc.Models.Exchange
{
    [DataContract]
    public class ExchangeResponse
    {
        [DataMember(Order = 1)]
        public ErrorResponse Error { get; set; }
    }
}
