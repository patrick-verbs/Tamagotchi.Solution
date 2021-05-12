using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class Pet
  {
    private static List<Pet> _allPets = new List<Pet> { };
    public string Name { get; set; }
    public string Food { get; set; }
    public int Attention { get; set; }
    public int Time { get; set; }
    public int Id { get; }

    public Pet(string name, string food, int attention, int time)
    {
      Name = name;
      Food = food;
      Attention = attention;
      Time = time;
      _allPets.Add(this);
      Id = _allPets.Count;
    }
    public static List<Pet> GetAll()
    {
      return _allPets;
    }

    public static void ClearAll()
    {
      _allPets.Clear();
    }

    
  }
}


//object 
// Timestamp "birth" of tamagotchi and use that as metric against current time. 
// So well need a form. 
// three tamagothci? display on index.html
//three buttons. each has a method to do something for the tamagotchi
// make time pass. dont let tamagochi die. 
