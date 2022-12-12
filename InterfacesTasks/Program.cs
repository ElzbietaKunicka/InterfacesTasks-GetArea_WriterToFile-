namespace InterfacesTasks
{
    internal class Program
    {
        //Sukurkite interface’ą IAnimal, jis turės metodus visus būdingus visiems gyvūnams, pvz Eat().
        //Sukurkite interface’ą IMammal, jis turės metodus būdingus žinduoliams, pvz GiveBirth()
        //Sukurkite interface’ą IFish, jis turės metodus būdingus žuvims, pvz Swim().

        //Sukurkite klasę Dog, kuri paveldės tiek iš IAnimal, tiek iš IMammal.
        //Sukurkite klasę Cat, kuri paveldės tiek iš IAnimal, tiek iš IMammal.
        //Sukurkite klasę Bass, kuri paveldės tiek iš IAnimal, tiek iš IFish.
        //Sukurkite klasę Carp, kuri paveldės tiek iš IAnimal, tiek iš IFish.
        //Implementuokite reikiamus metodus sukurtose klasėse.

        //Sukurkite sąrašą IAnimal, IMammal, IFish, iteruokite per sąrašus
        //ir paleiskite metodus būdingus tiems interface’ams.

        //Implementuokite IComparable interface’ą visoms
        //klasėms(pagal kokį property lyginti, pasirinkite patys,
        //paprasčiau pagal vardą)
        static void Main(string[] args)
        {
            //List<IAnimal> iAnimal = new List<IAnimal>();

            var iiAnimal = new List<IAnimal> { new Dog("Tomas"), new Dog("Aga"), new Cat("Pukis"), new Bass("Like"), new Carp("Akute") };
            iiAnimal.ForEach(animal => animal.Eat());

            var iMammal = new List<IMammal> { new Dog("Bomas"), new Cat("Pukis") };
            iMammal.ForEach(mammal => mammal.GiveBirth());

            var iFish = new List<IFish> { new Bass("Like"), new Carp("Akute") };
            iFish.ForEach(fish => fish.Swim());

            var animalComparer = new AnimalComparer();
            iiAnimal.Sort(animalComparer);
            iiAnimal.ForEach(x => Console.WriteLine(x.Name));

        }
    }
}