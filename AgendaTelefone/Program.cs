using AgendaTelefone;
using System;
using System.Runtime.CompilerServices;

public class Program
{
    internal static void Main(string[] args)
    {
        ContactList contactList = new ContactList();
        int opc;

        do
        {
            Console.Clear();
            Console.WriteLine("   ---- MENU ----\n");
            Console.WriteLine("|1| - Adicionar Contato");
            Console.WriteLine("|2| - Remover Contato");
            Console.WriteLine("|3| - Editar Contato");
            Console.WriteLine("|4| - Mostrar Contatos");
            Console.WriteLine("|5| - Sair");
            Console.Write("\nDigite a opção desejada: ");
            opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("---- Registrar Contato ----");
                    contactList.Add(RegisterContact());
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("---- Remover Contato ----");
                    Console.Write("\nInforme o nome do contato: ");
                    string contact = Console.ReadLine();
                    contactList.RemoveByName(contact);
                    break;

                case 3:
                    // Adicione aqui a lógica para editar contato, se necessário
                    break;

                case 4:
                    Console.Clear();
                    int option;
                    Console.WriteLine("|1| - Imprimir Lista Completa");
                    Console.WriteLine("|2| - Imprimir Contato");
                    option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.Clear();
                            contactList.ShowAll();
                            Console.ReadLine();
                            break;

                        case 2:
                            Console.WriteLine("\nInforme o nome do contato: ");
                            string name = Console.ReadLine();
                            Contact auxContact = contactList.FindByName(name);
                            if (auxContact != null)
                            {
                                Console.Clear();
                                Console.WriteLine(auxContact);
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Contato não encontrado.");
                            }
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("\nOpção Inválida");
                            break;
                    }
                    break;

                case 5:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("\nOpção Inválida");
                    break;
            }
        } while (opc != 5);
    }

    static Contact RegisterContact()
    {
        string name;
        string email;

        Console.Write("\nInforme o nome: ");
        name = Console.ReadLine();

        Console.Write("\nInforme o email: ");
        email = Console.ReadLine();

        Address address = RegisterAddress();
        ContactList phone = RegisterPhone();

        return new Contact(name, email, address, phone);
    }

    static Address RegisterAddress()
    {
        string city;
        string street;
        string number;
        string neighborhood;
        string postcode;

        Console.Write("\nInforme a cidade: ");
        city = Console.ReadLine();

        Console.Write("\nInforme o nome da rua/avenida: ");
        street = Console.ReadLine();

        Console.Write("\nInforme o número do endereço: ");
        number = Console.ReadLine();

        Console.Write("\nInforme o bairro: ");
        neighborhood = Console.ReadLine();

        Console.Write("\nInforme o CEP: ");
        postcode = Console.ReadLine();

        return new Address(city, street, number, neighborhood, postcode);
    }

    static ContactList RegisterPhone()
    {
        ContactList phones = new ContactList();

        bool addAnother = true;
        do
        {
            Console.WriteLine("\nInforme o número de telefone: ");
            string phoneNumber = Console.ReadLine();

            Contact contact = new Contact("", "", null, phones);
            contact.AddPhone(phoneNumber);
            phones.Add(contact);

            Console.Clear();
            Console.WriteLine("\nDeseja cadastrar outro número de telefone?");
            Console.WriteLine("|1| - SIM");
            Console.WriteLine("|2| - NÃO");
            Console.Write("\nDigite sua resposta: ");
            int option = int.Parse(Console.ReadLine());
            if (option != 1)
            {
                addAnother = false;
            }

        } while (addAnother);

        return phones;
    }


}
