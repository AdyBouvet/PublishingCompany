namespace PublishingCompany.Publication
{
    public class Journal : Publication
    {
        public Journal(string title, string publisher, int pages, List<string> authors) : base(title, publisher)
        {
            base.SetPages(pages);
            Authors = authors;
        }
        public List<string> Topics { get; set; } = [];
        public List<string> Authors { get; set; }
        public string AddTopic(string topic)
        {
            if (Topics.Contains(topic))
                throw new ArgumentException($"{topic} already exist");
            Topics.Add(topic);
            return topic;
        }
    }
}
