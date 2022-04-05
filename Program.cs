using System;
using System.Collections.Generic;

namespace assignment_deck_of_cards
{
  class Program
  {
    static void Main(string[] args)
    {

      // Card c1 = new Card("king", "diamond", 10);

      // c1.Print();

      Deck d1 = new Deck();
      d1.Print();
      d1.Shuffle();
      h.p("________________________ \n");
      d1.Print();

      h.p("________________________ \n");
      h.p("dealing: \n");
      d1.Deal().Print();

      h.p("________________________ \n");
      d1.Reset();
      d1.Print();

      Player p1 = new Player("Roby");

      h.p("________________________ \n");

      d1.Count();

      h.p("\n");
      h.p("________________________ \n");

      p1.Draw(d1);
      p1.Draw(d1);
      p1.Draw(d1);
      
      p1.Print(); 
      d1.Count();
      h.p("\n");
      h.p("________________________ \n");

      p1.Discard(1);
      p1.Print(); 
      d1.Count();
      h.p("\n");



    }
  }
}
