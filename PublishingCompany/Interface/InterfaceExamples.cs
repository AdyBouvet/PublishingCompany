namespace PublishingCompany.Interface
{
    public static class InterfaceExamples
    {
        public static void InterfaceList()
        {
            List<IAnimal> list = [new Duck(), new Pig(), new Dog(), new Duck(), new Goose()];
            foreach (var animal in list)
            {
                Console.WriteLine(animal.Sound());
                //Console.WriteLine(animal.Fly);
            }

            IAnimal duck = new Duck();
            IBird goose = new Goose();
            Goose goose2 = new Goose();

            //goose.Attact();
            goose2.Attack();
            goose.Fly();
            //goose.Sound();
            goose2.Sound();
        }
    }
}
