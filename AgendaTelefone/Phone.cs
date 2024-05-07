
namespace AgendaTelefone
{
    internal class Phone
    {
        string phone;

        public Phone(string phone)
        {
            this.phone = phone;
        }

        public void SetPhone(string phone) 
        {
            this.phone = phone;
        }

        public string GetPhone() 
        { 
            return this.phone;
        }

        public override string? ToString()
        {
            return $"\nTelefone: {this.phone}";
        }


    }
}
