using Autofac;
using Service.ExchangeGateway.Grpc;

// ReSharper disable UnusedMember.Global

namespace Service.ExchangeGateway.Client
{
    public static class AutofacHelper
    {
        public static void RegisterExchangeGatewayClient(this ContainerBuilder builder, string grpcServiceUrl)
        {
            var factory = new ExchangeGatewayClientFactory(grpcServiceUrl);

            builder.RegisterInstance(factory.GetExchangeGateway()).As<IHelloService>().SingleInstance();
        }
    }
}
