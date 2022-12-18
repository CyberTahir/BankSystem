using System.Collections.Generic;
using System.Reflection;

namespace BankSystem
{
    public class Consultant<IDType> : BankEmployee<IDType>, IClientDataChanging<IDType>, IClientDataReading<IDType>
    {
        public void ChangeDataOf(Client<IDType> client, Dictionary<string, string> data)
        {
            if (data.ContainsKey("Phone"))
            {
                client.Phone = data["Phone"];
            }
        }

        public string Read(Client<IDType> client, string field)
        {
            PropertyInfo prop = client.GetType().GetProperty(field);

            return prop.GetValue(client).ToString();
        }
    }
}
