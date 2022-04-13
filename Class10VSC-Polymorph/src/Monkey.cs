using System;
using System.Collections.Generic;

namespace Class10VSC_Polymorph.src
{
  class Monkey : Animals
  {
    public Monkey ()
    {

    }
    public Monkey(string _name, string _species, string _color) : base(_name, _species, _color)
    {

    }
    public override void message(string information)
    {
      Console.WriteLine($"{name} {information}");
    }
  }
}