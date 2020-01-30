using Animal.interfaces;

namespace Animal.dto {
  class AnimalDto : IAnimal {
    public string Name { get; set; }
    public int Age { get; set; }
    public string Color { get; set; }

    public void Scream() {
      System.Console.WriteLine("YEEEEAAAAAH!");
    }
  }
}