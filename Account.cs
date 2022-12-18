namespace BankSystem
{
    public class Account<IDType>
    {
        public IDType ID;
        public int Money;

        public Account(IDType id, int money = 0)
        {
            ID = id;
            Money = money;
        }
    }
}
