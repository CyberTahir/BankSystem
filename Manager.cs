using System;
using System.Collections.Generic;
using System.Reflection;

namespace BankSystem
{
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
