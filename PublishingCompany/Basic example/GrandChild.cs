namespace PublishingCompany.Basic_example
{
    public class GrandChild : Child
    {
        public string GrandChildName { get; set; } = "GrandChild";
        public string Name { get; set; } = "GrandChild";
        public override string VirtualName { get; set; } = "VirtualGrandChild";

        public override string Sing()
        {
            return base.Sing() + "Never gonna run around and desert you.";
        }

    }
}
