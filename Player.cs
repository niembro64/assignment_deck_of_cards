using System;
using System.Collections.Generic;

namespace assignment_deck_of_cards
{
  class Player
  {

    public string Name;
    public List<Card> Hand;

    public Player(string n)
    {
      this.Name = n;
      this.Hand = new List<Card>();
    }

    public Card Draw(Deck d)
    {
      Card c = d.Deal();
      Hand.Insert(0, c);

      return this.Hand[0];
    }

    public Player Print()
    {
      h.p($"Player: {this.Name}");
      h.p("\n");
      foreach (Card c in this.Hand)
      {
        c.Print();
      }
      return this;
    }

    public Card Discard(int i)
    {

      if (this.Hand.Count >= i + 1)
      {
        // copy card
        Card c = new Card(this.Hand[i].Name, this.Hand[i].Suit, this.Hand[i].Value);
        // remove card
        this.Hand.RemoveAt(i);
        // return copy
        return c; 

      }
      else
      {
        // return null
        return null;
      }
    }


  }
}
