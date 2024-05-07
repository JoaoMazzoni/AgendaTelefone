
using System.Threading.Tasks;

namespace AgendaTelefone
{
    internal class Contact
    {
        string name;
        string email;
        Address adress;
        Phone phone;
        ContactList phones;
        Contact? next;

        public Contact(string name, string email, Address address, ContactList phones)
        {
            this.name = name;
            this.email = email;
            this.adress = address;
            this.phones = phones;
            
            this.next = null;
            
            
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public string SetEmail()
        {
            return this.email;
        }

        public void SetNext(Contact next)
        {
            this.next = next;
        }
        public Contact GetNext()
        {
            return this.next;
        }
     
        public void SetListPhones(ContactList phones)
        {
            this.phones = phones;
        }

        public ContactList GetListPhones()
        {
            return this.phones;
        }

        public void SetPhone(Phone phone)
        {
            this.phone = phone;
        }

        public Phone GetPhone()
        {
            return this.phone;
        }

        public void AddPhone(string phoneNumber)
        {
            this.phone = new Phone(phoneNumber);
        }

        public override string? ToString()
        {
            if (string.IsNullOrEmpty(this.name))
            {
                return ""; // Retorna uma string vazia se o contato não tiver nome
            }

            string contactInfo = $"Nome: {this.name}\n";
            contactInfo += $"Email: {this.email}\n";
            contactInfo += $"Endereco: {this.adress}\n";

            // Adiciona os números de telefone apenas se houver pelo menos um
            if (this.phones != null && this.phones.GetContacts().Count > 0)
            {
                contactInfo += "Telefones:\n";
                foreach (Contact phoneContact in this.phones.GetContacts())
                {
                    contactInfo += $"- {phoneContact.GetPhone().GetPhone()}\n";
                }
            }

            return contactInfo;
        }







    }
}
