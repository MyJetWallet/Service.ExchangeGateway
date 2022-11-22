using Autofac;
using Autofac.Core;
using Autofac.Core.Registration;
using Service.Fireblocks.Signer.Client;

namespace Service.ExchangeGateway.Modules
{
    public class ServiceModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterFireblocksSignerClient(Program.Settings.FireblocksSignerGrpcServiceUrl);
        }
    }
}