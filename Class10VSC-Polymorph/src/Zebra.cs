using System;
using System.Collections.Generic;

namespace Class10VSC_Polymorph.src
{
  class Zebra : Animals
  {
    public Zebra ()
    {

    }
    public Zebra(string _name, string _species, string _color) : base(_name, _species, _color)
    {

    }
    public override void message(string information)
    {
      Console.WriteLine($"{name} {information}");
    }
  }
}