namespace PublishingCompany.Interface
{
    public class Goose : IAnimal, IBird
    {
        public string Fly() => "It flew away";

        public string Name() => "Goose";

        public string Sound() => "Honk";

        public string Attack() => "It hurt";
    }
}
