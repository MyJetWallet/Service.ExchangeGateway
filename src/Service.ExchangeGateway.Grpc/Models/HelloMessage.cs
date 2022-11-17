using System.Runtime.Serialization;
using Service.ExchangeGateway.Domain.Models;

namespace Service.ExchangeGateway.Grpc.Models
{
    [DataContract]
    public class HelloMessage : IHelloMessage
    {
        [DataMember(Order = 1)]
        public string Message { get; set; }
    }
}