using Service.ExchangeGateway.Grpc.Models.Exchange;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Service.ExchangeGateway.Grpc
{
    [ServiceContract]
    public interface IExchangeGateway
    {
        [OperationContract]
        Task<ExchangeResponse> TransferBinanceMainToMargin(TransferBinanceMainToMarginRequest request);

        [OperationContract]
        Task<ExchangeResponse> TransferBinanceMarginToMain(TransferBinanceMarginToMainRequest request);

        [OperationContract]
        Task<ExchangeResponse> TransferFireblocksToBinance(TransferFireblocksToBinanceRequest request);

        [OperationContract]
        Task<ExchangeResponse> TransferFromBinanceMarginToFireblocks(TransferFromBinanceMarginToFireblocksRequest request);
    }
}