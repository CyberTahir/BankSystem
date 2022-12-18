namespace BankSystem
{
    interface IClientDataReading<IDType>
    {
        string Read(Client<IDType> client, string field);
    }
}
