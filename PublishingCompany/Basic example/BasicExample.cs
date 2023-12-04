namespace PublishingCompany.Basic_example
{
    public static class BasicExample
    {

        public static void BasicExampleMain()
        {
            RunParentChildExample();
            //RunParentChildGrandchildExample();
            //RunBase();
        }

        public static void RunParentChildExample()
        {

            Parent parent = new Parent();
            Child child = new Child();
            Parent parentChild = new Child();

            Console.WriteLine("Parent parent = new Parent();");
            Console.WriteLine("Child child = new Child();");

            Console.WriteLine($"\nparent.ParentName");
            Console.WriteLine(parent.ParentName);
            Console.WriteLine($"\nchild.ChildName");
            Console.WriteLine(child.ChildName);
            Console.WriteLine($"\nchild.ParentName");
            Console.WriteLine(child.ParentName);
            Console.WriteLine($"\nparent.ChildName");
            Console.WriteLine("Parent does not contain method ChildName");

            Console.WriteLine("\n\n\n\n\n");

            Console.WriteLine("Parent parentChild = new Child();");

            Console.WriteLine($"\nparent.Name");
            Console.WriteLine(parent.Name);
            Console.WriteLine($"\nchild.Name");
            Console.WriteLine(child.Name);
            Console.WriteLine($"\nparentChild.Name");
            Console.WriteLine(parentChild.Name);

            Console.WriteLine("\n\n");

            Console.WriteLine($"\nparent.VirtualName");
            Console.WriteLine(parent.VirtualName);
            Console.WriteLine($"\nchild.VirtualName");
            Console.WriteLine(child.VirtualName);
            Console.WriteLine($"\nparentChild.VirtualName");
            Console.WriteLine(parentChild.VirtualName);
        }
        public static void RunParentChildGrandchildExample()
        {
            GrandChild grandChild = new GrandChild();


            Console.WriteLine("\ngrandChild.GrandChildName");   
            Console.WriteLine(grandChild.GrandChildName);   
            Console.WriteLine("\ngrandChild.ChildName");
            Console.WriteLine(grandChild.ChildName);
            Console.WriteLine("\ngrandChild.ParentName");
            Console.WriteLine(grandChild.ParentName);
            Console.WriteLine("\ngrandChild.VirtualName");
            Console.WriteLine(grandChild.VirtualName);
        }

        public static void RunBase()
        {
            GrandChild grandChild = new();
            Console.WriteLine("grandChild.Sing()");
            Console.WriteLine(grandChild.Sing());
        }
    }
}
