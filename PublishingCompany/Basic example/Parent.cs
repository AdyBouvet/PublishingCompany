namespace PublishingCompany.Basic_example
{
    public class Parent
    {

        public string ParentName { get; set; } = "Parent";
        public string Name { get; set; } = "Parent";
        public virtual string VirtualName { get; set; } = "VirtualParent";

        public virtual string Sing()
        {
            return "Never gonna give you up. ";
        }
    }
}
