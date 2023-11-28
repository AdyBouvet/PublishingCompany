namespace PublishingCompany.Interface
{
    public class Duck : IAnimal, IBird
    {
        public string Fly() => "It flew away";

        public string Name() => "Duck";

        public string Sound() => "Quack";
    }
}
