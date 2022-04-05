using System;
using System.Collections.Generic;

namespace assignment_deck_of_cards
{
  public class Card
  {
    public string Name;
    public string Suit;
    public int Value;

    public Card(string n, string s, int v)
    {
      this.Name = n;
      this.Suit = s;
      this.Value = v;
    }

    public static string getSuitFromNumber(int a)
    {
      string[] suits = { "hearts", "diamonds", "clubs", "spades" };
      string s = "";
      switch (a)
      {
        case 0:
          s = suits[0];
          break;
        case 1:
          s = suits[1];
          break;
        case 2:
          s = suits[2];
          break;
        case 3:
          s = suits[3];
          break;
        default:
          s = suits[3];
          break;
      }

      return s;
    }

    public void Print()
    {
      h.p($"Name: {Name} Suit: {Suit} Value: {Value} \n");
    }
  }
}
