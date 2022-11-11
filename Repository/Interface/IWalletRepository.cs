using Zedcrest_Task.DTO;

namespace Zedcrest_Task.Repository.Interface
{
    public interface IWalletRepository
    {
        Task<WalletDTO> createWallet(WalletDTO wallet);
        Task<WalletDTO> updateWallet(WalletDTO wallet);
        Task DeleteWallet(WalletDTO wallet);
        Task<WalletDTO> GetWalletbyEmail(string email);

    }
}
