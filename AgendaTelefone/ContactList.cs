
namespace AgendaTelefone
{
    internal class ContactList
    {
        Contact? headList;
        Contact? tailList; 

        public ContactList()
        {
            this.headList = null;
            this.tailList = null;
            
        }

        public void Add(Contact contact)
        {
            if (isEmpty())
            {
                this.headList = contact;
                this.tailList = contact;
            }
            else
            {
                int compare = string.Compare(contact.GetName(), headList.GetName(), comparisonType: StringComparison.OrdinalIgnoreCase);
                if (compare <= 0)
                {
                    Contact aux = headList;
                    headList = contact;
                    headList.SetNext(aux);
                }
                else
                {
                    Contact aux = headList;
                    Contact prev = headList;

                    do
                    {
                        compare = string.Compare(contact.GetName(), aux.GetName());
                        if (compare > 0)
                        {
                            prev = aux;
                            aux = aux.GetNext();
                        }

                    } while (aux != null && compare > 0);
                    prev.SetNext(contact);
                    contact.SetNext(aux);
                    if (aux == null)
                    {
                        tailList = contact;
                    }
                }

            }
        }



        public void RemoveByName(string name)
        {
            if (!isEmpty())
            {
                if (name == headList.GetName())
                {
                    if (headList == tailList)
                    {
                        tailList = null;
                    }
                    else
                    {
                        headList = headList.GetNext();
                    }

                }

                else if (name == tailList.GetName())
                {
                    Contact aux = headList;
                    Contact prev = headList;
                    bool compare;
                    do
                    {
                        compare = name.Equals(aux.GetName());
                        if (!compare)
                        {
                            prev = aux;
                            aux = aux.GetNext();
                        }
                        else
                        {
                            prev.SetNext(aux.GetNext());
                            if (prev.GetNext() == null)
                            {
                                tailList = prev;
                            }

                        }

                    } while (compare == false && aux != null);

                    if (aux == null)
                    {
                        Console.WriteLine("\nNão existe o contato na lista.");
                    }

                }

                
            }
        }

        bool isEmpty()
        {
            if (this.headList == null && this.tailList == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ShowAll()
        {
            Contact aux = headList;
            while (aux != null)
            {
                Console.WriteLine(aux.ToString()); // Imprime os detalhes básicos do contato
                ContactList phoneList = aux.GetListPhones(); // Obtém a lista de telefones do contato
                if (phoneList != null && phoneList.GetContacts().Count > 0)
                {
                    Console.WriteLine("Telefones:");
                    foreach (Contact phoneContact in phoneList.GetContacts())
                    {
                        Console.WriteLine(phoneContact.ToString()); // Imprime cada número de telefone
                    }
                }
                Console.WriteLine(); // Adiciona uma linha em branco para separar os contatos
                aux = aux.GetNext();
            }
        }


        public List<Contact> GetContacts()
{
    List<Contact> contactList = new List<Contact>();
    Contact currentContact = headList;

    while (currentContact != null)
    {
        contactList.Add(currentContact);
        currentContact = currentContact.GetNext();
    }

    return contactList;
}

        public Contact FindByName(string name)
        {
            Contact aux = headList;
            while (aux != null)
            {
                if (aux.GetName().Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return aux;
                }
                aux = aux.GetNext();
            }
            return null; 
        }

        

    }
}
