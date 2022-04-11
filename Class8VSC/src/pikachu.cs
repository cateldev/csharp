using System;

namespace Class8VSC.src
{
  public class pokemon
  {
    public string name {get;set;}
    public string color {get;set;}
    public int power {get;set;}
    public pokemon (string _name, string _color, int _power)
    {
      name = _name;
      color = _color;
      power = _power;
    }
    public void say()
    {
      Console.WriteLine("Pika-pika!");
    }
    public void attack()
    {
      Console.WriteLine($"Pika-CHUUUU!");
    }
  }
}
 