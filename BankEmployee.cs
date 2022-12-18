using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

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

    public class Manager<IDType> : BankEmployee<IDType>, IClientDataChanging<IDType>, IClientDataReading<IDType>
    {
        public void ChangeDataOf(Client<IDType> client, Dictionary<string, string> data)
        {
            Type type = client.GetType();
            PropertyInfo prop;

            foreach (KeyValuePair<string, string> pair in data)
            {
                prop = type.GetProperty(pair.Key);
                prop.SetValue(client, pair.Value);
            }
        }

        public string Read(Client<IDType> client, string field)
        {
            if (field == "Passport")
            {
                return client.GetPassport();
            }

            PropertyInfo prop = client.GetType().GetProperty(field);

            return prop.GetValue(client).ToString();
        }
    }
}
