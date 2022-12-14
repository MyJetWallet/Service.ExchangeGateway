using System.Runtime.Serialization;

namespace Service.ExchangeGateway.Grpc.Models.Common
{
    [DataContract]
    public class ErrorResponse
    {
        [DataMember(Order = 1)]
        public ErrorCode ErrorCode { get; set; }

        [DataMember(Order = 2)]
        public string Message { get; set; }
    }
}
