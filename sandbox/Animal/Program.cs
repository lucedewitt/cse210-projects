using System.Diagnostics.Contracts;

namespace Animal;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, Animal World!");
        Mammal myPet = new Mammal("Ali");
        myPet.MakeNoise();
        Mammal myLagomorph = new Rabbit("Shadow");
        myLagomorph.MakeNoise();
        Mammal myFeline = new Tiger("Hobbes");
        myFeline.MakeNoise();
        Mammal myFox = new Fox("Ylvis");
        myFox.MakeNoise();
    }
}
