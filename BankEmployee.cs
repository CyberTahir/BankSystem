using System;

namespace BankSystem
{
    public abstract class BankEmployee<IDType>
    {
        public void Replenish(Account<IDType> account, int money)
        {
            if (money < 0)
            {
                throw new Exception("Incorrect ammount of money.");
            }
            account.Money += money;
        }
    }
}
