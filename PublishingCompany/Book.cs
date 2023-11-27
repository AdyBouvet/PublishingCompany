namespace PublishingCompany
{
    public class Book : Publication
    {
        public Book(string title, string publisher, string author) : base(title, publisher)
        {
            Author = author;
        }

        public int Price { get; private set; }
        public string Currency { get; private set; } = string.Empty;
        public string Author { get; private set; }

        public int SetPrice(int price, string currency)
        {
            if (price < 0)
                throw new ArgumentOutOfRangeException(nameof(price), "The price cannot be negative.");
            if (currency.Length != 3)
                throw new ArgumentException("The ISO currency symbol is a 3-character string.");

            Price = price;
            Currency = currency;

            return price;
        }

        public override string ToString()
        {
            return base.ToString() + $" by {Author}";
        }
    }
}
