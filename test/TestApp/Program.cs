using System;
using System.Threading.Tasks;
using ProtoBuf.Grpc.Client;
using Service.ExchangeGateway.Client;
using Service.ExchangeGateway.Grpc.Models;

namespace TestApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            GrpcClientFactory.AllowUnencryptedHttp2 = true;

            Console.Write("Press enter to start");
            Console.ReadLine();


            var factory = new ExchangeGatewayClientFactory("http://localhost:5001");
            var client = factory.GetExchangeGateway();

            //Console.WriteLine(resp?.Message);

            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
