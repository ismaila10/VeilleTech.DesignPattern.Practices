namespace VeilleTech.DesignPattern.Practices.CreationalDesignPattern.SimpleFactoryPattern
{
    public class SimpleFactory : ISimpleFactory
    {
        public override IAnimal CreateAnimal(int selectedAnimal)
        {
            IAnimal? intendedAnimal = null;

            intendedAnimal = selectedAnimal switch
            {

                0 => new Cat(),
                1 => new Tiger(),
                _ => throw new ApplicationException(string.Format(" Unknown Animal cannot be instantiated"))
            };

            return intendedAnimal;
        }
    }
}
