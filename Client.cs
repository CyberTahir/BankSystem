namespace BankSystem
{
    public class Client<IDType>
    {
        private string passport;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string Name { get => LastName + " " + FirstName + " " + FatherName; }
        public string Phone { get; set; }
        public string Passport { get => "**** ******"; set => passport = value; }
        public Account<IDType> Account { get; set; }

        public Client(string firstN, string lastN, string fatherN, string _phone, string passportID, Account<IDType> account)
        {
            FirstName = firstN;
            LastName = lastN;
            FatherName = fatherN;
            Phone = _phone;
            Passport = passportID;
            Account = account;
        }

        public string GetPassport()
        {
            return passport;
        }
    }
}
