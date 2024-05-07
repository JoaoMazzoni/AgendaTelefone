
namespace AgendaTelefone
{
    internal class Address
    {
        string street;
        string city;
        string number;
        string neighborhood;
        string postcode;

        public Address(string street, string city, string number, string neighborhood, string postcode)
        {
            this.street = street;
            this.city = city;
            this.number = number;
            this.neighborhood = neighborhood;
            this.postcode = postcode;
        }

        public void SetStret(string street)
        {
            this.street = street;
        }

        public string GetStreet()
        {
            return this.street;
        }

        public void SetCity(string city)
        {
            this.city = city;
        }

        public string GetCity()
        {
            return this.city;
        }

        public void SetNumber(string number)
        {
            this.number = number;
        }

        public string GetNumber()
        {
            return this.number;
        }

        public void SetNeighborhood(string neighborhood)
        {
            this.neighborhood = neighborhood;
        }

        public string GetNeighborhood()
        {
            return this.neighborhood;
        }

        public void SetPostCode(string postcode)
        {
            this.postcode = postcode;
        }

        public string GetPostCode()
        {
            return this.postcode;
        }



        public override string? ToString()
        {
            return $"\nCidade: {this.city}\nRua: {this.street}, {this.number}\nBairro: {this.neighborhood}\nCEP: {this.postcode}";
        }

    }

}
