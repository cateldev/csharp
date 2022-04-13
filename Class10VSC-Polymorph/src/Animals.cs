using System;
using System.Collections.Generic;

namespace Class10VSC_Polymorph.src
{
  public class Animals
  {
    public string name { get; set; }
    public string species { get; set; }
    public string color { get;  set; }

    public Animals()
    {

    }
    public Animals (string _name, string _species, string _color)
    {
      name = _name;
      species = _species;
      color = _color;
    }
    public virtual void message(string information)
    {
      Console.WriteLine($"{name} {information}");  
    }
  }
}