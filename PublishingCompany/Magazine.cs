namespace PublishingCompany
{
    public class Magazine : Publication
    {
        public Magazine(string title, string publisher, int volume) : base(title, publisher)
        {
            int year = DateTime.Now.Year;

            if (volume < 0 || volume > 52)
                throw new ArgumentOutOfRangeException($"Weeknumber must be between 0 and 52. Was {volume}");

            ArgumentOutOfRangeException.ThrowIfNegative(year);
            Volume = $"{volume}-{year}";
        }

        public string Volume { get; set; }
        public int SubscriptionCost { get; private set; }

        public int SetSubscriptionCost(int cost)
        {
            ArgumentOutOfRangeException.ThrowIfNegative(cost);
            SubscriptionCost = cost;
            return cost;
        }

        public override string ToString()
        {
            return base.ToString() + " " + Volume;
        }
    }
}
