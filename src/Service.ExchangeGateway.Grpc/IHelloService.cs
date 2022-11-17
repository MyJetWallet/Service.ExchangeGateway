using System.ServiceModel;
using System.Threading.Tasks;
using Service.ExchangeGateway.Grpc.Models;

namespace Service.ExchangeGateway.Grpc
{
    [ServiceContract]
    public interface IHelloService
    {
        [OperationContract]
        Task<HelloMessage> SayHelloAsync(HelloRequest request);
    }
}