using AutoMapper;
using Zedcrest_Task.Data;
using Zedcrest_Task.DTO;
using Zedcrest_Task.Models;
using Zedcrest_Task.Repository.Interface;

namespace Zedcrest_Task.Repository
{
    public class WalletRepository : IWalletRepository
    {
        private readonly IMapper _Mapper;
        private readonly ILogger _logger;
        private readonly DatabaseContext _dbContext;
        public WalletRepository(IMapper mapper, DatabaseContext dbContext)
        {
            _Mapper = mapper;
            _dbContext = dbContext;
        }

        

        public async Task<WalletDTO> createWallet(WalletDTO walletDTO)
        {
            var userwallet = _dbContext.Wallets.Where(x => x.Id == walletDTO.Id);
            if (userwallet.Any())
            {
                return (WalletDTO)userwallet.Where(x => x.Id == walletDTO.Id);
            }
            var Mapwallet1 = _Mapper.Map< WalletDTO, Wallet>(walletDTO);
            var Mapwallet2 = _Mapper.Map< WalletDTO, Wallet>(walletDTO);
            Mapwallet1.Balance = 0;
            Mapwallet1.currency = Currency.USD;
            Mapwallet1.CreatedAt = DateTime.Now;

            Mapwallet2.Balance = 0;
            Mapwallet2.currency = Currency.USD;
            Mapwallet2.CreatedAt = DateTime.Now;

            _dbContext.Wallets.Add(Mapwallet1);
            _dbContext.Wallets.Add(Mapwallet2);

            await _dbContext.SaveChangesAsync();

            return walletDTO;
        }

        public Task DeleteWallet(WalletDTO wallet)
        {
            throw new NotImplementedException();
        }

        public Task<WalletDTO> GetWalletbyEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<WalletDTO> updateWallet(WalletDTO wallet)
        {
            throw new NotImplementedException();
        }

        public Task<WalletDTO> FundWallet(double amount, Currency currency)
        {

        }
    }
}
