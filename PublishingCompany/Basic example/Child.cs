namespace PublishingCompany.Basic_example
{
    public class Child : Parent
    {
        public string ChildName { get; set; } = "Child";
        public string Name { get; set; } = "Child";
        public override string VirtualName { get; set; } = "VirtualChild";

        public override string Sing()
        {
            return base.Sing() + "Never gonne let you down. ";
        }

    }
}
