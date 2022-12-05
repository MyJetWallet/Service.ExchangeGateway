using System;
using System.Globalization;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using MyJetWallet.Sdk.Service;
using Service.ExchangeGateway.Grpc;
using Service.ExchangeGateway.Grpc.Models.Exchange;
using Service.Fireblocks.Signer.Grpc;

namespace Service.ExchangeGateway.Services
{
    public class ExchangeGateway : IExchangeGateway
    {
        private readonly ILogger<ExchangeGateway > _logger;
        private readonly ITransactionService _transactionService;

        public ExchangeGateway (ILogger<ExchangeGateway > logger,
            ITransactionService transactionService)
        {
            _logger = logger;
            this._transactionService = transactionService;
        }

        public async Task<ExchangeResponse> TransferBinanceMainToMargin(TransferBinanceMainToMarginRequest request)
        {
            try
            {
                _logger.LogInformation("Request TransferBinanceMainToMargin {@context}", request.ToJson());

                var response = await _transactionService.CreateInternalTransferAsync(new ()
                {
                    Amount = request.Amount,
                    AssetSymbol = request.AssetSymbol,
                    DestType = MyJetWallet.Fireblocks.Domain.Models.ExchangeAccounts.TradingAccountType.MARGIN_CROSS,
                    SourceType = MyJetWallet.Fireblocks.Domain.Models.ExchangeAccounts.TradingAccountType.SPOT,
                    ExternalTransactionId = request.RequestId,
                    FromExchangeId = Program.Settings.BinanceExchangeId,
                    TreatAsGrossAmount = true
                });

                if (response.Error != null)
                {
                    return new()
                    {
                        Error = new Grpc.Models.Common.ErrorResponse
                        {
                            ErrorCode = Grpc.Models.Common.ErrorCode.Unknown,
                            Message = response.Error.Message
                        }
                    };
                }

                return new()
                {
                };

            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error creating TransferBinanceMainToMargin {@context}", request.ToJson());

                return new()
                {
                    Error = new Grpc.Models.Common.ErrorResponse
                    {
                        ErrorCode = Grpc.Models.Common.ErrorCode.Unknown,
                        Message = e.Message
                    }
                };
            }
        }

        public async Task<ExchangeResponse> TransferBinanceMarginToMain(TransferBinanceMarginToMainRequest request)
        {
            try
            {
                _logger.LogInformation("Request TransferBinanceMarginToMain {@context}", request.ToJson());

                var response = await _transactionService.CreateInternalTransferAsync(new()
                {
                    Amount = request.Amount,
                    AssetSymbol = request.AssetSymbol,
                    SourceType = MyJetWallet.Fireblocks.Domain.Models.ExchangeAccounts.TradingAccountType.MARGIN_CROSS,
                    DestType = MyJetWallet.Fireblocks.Domain.Models.ExchangeAccounts.TradingAccountType.SPOT,
                    ExternalTransactionId = request.RequestId,
                    FromExchangeId = Program.Settings.BinanceExchangeId,
                    TreatAsGrossAmount = true
                });

                if (response.Error != null)
                {
                    return new()
                    {
                        Error = new Grpc.Models.Common.ErrorResponse
                        {
                            ErrorCode = Grpc.Models.Common.ErrorCode.Unknown,
                            Message = response.Error.Message
                        }
                    };
                }

                return new()
                {
                };

            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error creating TransferBinanceMarginToMain {@context}", request.ToJson());

                return new()
                {
                    Error = new Grpc.Models.Common.ErrorResponse
                    {
                        ErrorCode = Grpc.Models.Common.ErrorCode.Unknown,
                        Message = e.Message
                    }
                };
            }
        }

        public async Task<ExchangeResponse> TransferFireblocksToBinance(TransferFireblocksToBinanceRequest request)
        {
            try
            {
                _logger.LogInformation("Request TransferFireblocksToBinance {@context}", request.ToJson());

                var response = await _transactionService.CreateTransactionToExchangeAsync(new()
                {
                    Amount = request.Amount,
                    AssetSymbol = request.AssetSymbol,
                    ExternalTransactionId = request.RequestId,
                    AssetNetwork = request.AssetNetwork,
                    DestinationExchangeId = Program.Settings.BinanceExchangeId,
                    ForceSweep = true,
                    FromVaultAccountId = request.VaultAccountId.ToString(CultureInfo.InvariantCulture),
                    TreatAsGrossAmount = true,
                });

                if (response.Error != null)
                {
                    return new()
                    {
                        Error = new Grpc.Models.Common.ErrorResponse
                        {
                            ErrorCode = Grpc.Models.Common.ErrorCode.Unknown,
                            Message = response.Error.Message
                        }
                    };
                }

                return new()
                {
                };

            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error creating TransferFireblocksToBinance {@context}", request.ToJson());

                return new()
                {
                    Error = new Grpc.Models.Common.ErrorResponse
                    {
                        ErrorCode = Grpc.Models.Common.ErrorCode.Unknown,
                        Message = e.Message
                    }
                };
            }
        }

        public async Task<ExchangeResponse> TransferFromBinanceMarginToFireblocks(TransferFromBinanceMarginToFireblocksRequest request)
        {
            try
            {
                _logger.LogInformation("Request TransferFromBinanceMarginToFireblocks {@context}", request.ToJson());

                var response = await _transactionService.CreateTransactionFromExchangeAsync(new()
                {
                    Amount = request.Amount,
                    AssetSymbol = request.AssetSymbol,
                    ExternalTransactionId = request.RequestId,
                    AssetNetwork = request.AssetNetwork,
                    FromExchangeId = Program.Settings.BinanceExchangeId,
                    ForceSweep = true,
                    DestinationVaultAccountId = request.VaultAccountId.ToString(CultureInfo.InvariantCulture),
                    TreatAsGrossAmount = false,
                });

                if (response.Error != null)
                {
                    return new()
                    {
                        Error = new Grpc.Models.Common.ErrorResponse
                        {
                            ErrorCode = Grpc.Models.Common.ErrorCode.Unknown,
                            Message = response.Error.Message
                        }
                    };
                }

                return new()
                {
                };

            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error creating TransferFromBinanceMarginToFireblocks {@context}", request.ToJson());

                return new()
                {
                    Error = new Grpc.Models.Common.ErrorResponse
                    {
                        ErrorCode = Grpc.Models.Common.ErrorCode.Unknown,
                        Message = e.Message
                    }
                };
            }
        }
    }
}
