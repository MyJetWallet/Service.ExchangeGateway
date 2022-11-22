using JetBrains.Annotations;
using MyJetWallet.Sdk.Grpc;
using Service.ExchangeGateway.Grpc;

namespace Service.ExchangeGateway.Client
{
    [UsedImplicitly]
    public class ExchangeGatewayClientFactory: MyGrpcClientFactory
    {
        public ExchangeGatewayClientFactory(string grpcServiceUrl) : base(grpcServiceUrl)
        {
        }

        public IExchangeGateway GetExchangeGateway() => CreateGrpcService<IExchangeGateway>();
    }
}
