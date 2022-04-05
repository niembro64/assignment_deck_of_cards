using System;
using System.Collections.Generic;

namespace assignment_deck_of_cards
{
  public class Deck
  {
    public List<Card> c = new List<Card>();

    public Deck()
    {
      for (int i = 0; i < 4; i++)
      {
        for (int j = 1; j <= 13; j++)
        {
          c.Add(new Card(j.ToString(), Card.getSuitFromNumber(i), j));
        }
      }
    }
  }
}