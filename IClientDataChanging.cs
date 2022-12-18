using System.Collections.Generic;

namespace BankSystem
{
    public interface IClientDataChanging<IDType>
    {
        void ChangeDataOf(Client<IDType> client, Dictionary<string, string> data);
    }
}
