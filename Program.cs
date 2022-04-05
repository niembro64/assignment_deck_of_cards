using System;
using System.Collections.Generic;

namespace assignment_deck_of_cards
{
  class Program
  {
    static void Main(string[] args)
    {

      Card c1 = new Card("king", "diamond", 10);

      c1.Print();

      Deck d1 = new Deck();

      for (var i = 0; i < d1.c.Count; i++){
        d1.c[i].Print();
      }


    }
  }
}
