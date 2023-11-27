namespace PublishingCompany
{
    public class Publication
    {

        public Publication(string title, string publisher) 
        {
            Title = title;
            Publisher = publisher;
        }

        public string Title { get; }
        public string Publisher { get; }
        public int Pages { get; private set; }
        public DateTime PublishDate { get; private set; }
        public bool Published { get; private set; } = false;

        public int SetPages(int pages)
        {
            if (pages < 0)
                throw new ArgumentOutOfRangeException($"Pages amount must be greater than 0. Was {pages}");
            Pages = pages;
            return Pages;            
        }

        public string Publish()
        {
            PublishDate = DateTime.Now;
            Published = true;
            return "Published";
        }

        public override string ToString()
        {
            return Title;
        }

    }
}
