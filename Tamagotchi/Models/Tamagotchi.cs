namespace TamagotchiGame.Models
{
  public class Tamagotchi
  {
    public string Name { get; set; }
    public string Food { get; set; }
    public int Attention { get; set; }
    public int Time { get; set; }

    public Tamagotchi(string name, string food, int attention, int time)
    {
      Name = name;
      Food = food;
      Attention = attention;
      Time = time;

    }
  }
}


//object 
// Timestamp "birth" of tamagotchi and use that as metric against current time. 
// So well need a form. 
// three tamagothci? display on index.html
//three buttons. each has a method to do something for the tamagotchi
// make time pass. dont let tamagochi die. 
