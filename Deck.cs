using System;
using System.Collections.Generic;

namespace assignment_deck_of_cards
{
  public class Deck
  {
    public List<Card> c = new List<Card>();

    public Deck()
    {
      string[] names = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

      for (int i = 0; i < 4; i++)
      {
        for (int j = 1; j <= 13; j++)
        {
          c.Add(new Card(names[j - 1], Card.getSuitFromNumber(i), j));
        }
      }
    }

    public void Print()
    {
      for (var i = 0; i < this.c.Count; i++)
      {
        c[i].Print();
      }
    }

    public List<Card> Shuffle()
    {
      List<Card> b = new List<Card>();
      Random rand = new Random();
      int il = this.c.Count;
      for (int i = 0; i < il; i++)
      {
        b.Insert(0, this.c[rand.Next(0, this.c.Count)]);
        this.c.Remove(b[0]);
      }

      this.c = b;

      return this.c;
    }

    public Card Deal()
    {

      Card a = new Card(this.c[0].Name, this.c[0].Suit, this.c[0].Value);

      this.c.RemoveAt(0);
      
      return a;
    }

    public Deck Reset(){

      Deck a = new Deck();

      this.c = a.c;
      return this; 
    }

    public int Count(){
      h.p(this.c.Count);
      return this.c.Count; 
    }

  }
}