namespace BankingModel
{
    public interface IBank
    {
       // IAccount SelectAccount(int accountID);
        bool MoneyDeposit( decimal money);

        bool MoneyWithdraw(decimal money);

        void MoneyTransfer( decimal money);
    }
}
