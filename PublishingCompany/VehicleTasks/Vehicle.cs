namespace PublishingCompany.VehicleTasks
{
    public class Vehicle
    {
        public Vehicle(string name) 
        {
            Name = name;
        }

        public string Name { get; private set; }
        public string Start() => "Starting engine";
        public virtual string Describe() =>
            $"This is a vehicle with name {Name}";
    }
}
