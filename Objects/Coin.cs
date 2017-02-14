using System;
using System.Collections.Generic;

namespace CoinApp.Objects
{
  public class Coin
  {
    private int _change;

    public Coin(int change)
    {
      _change = change;
    }

    public int GetChange()
    {
      return _change;
    }

    public Dictionary<string, int> Change(int money)
    {
      int quarters = 0;
      int dimes = 0;
      int pennies = 0;
      int nickles = 0;

      Dictionary<string, int> changeAmount = new Dictionary<string, int>();
      quarters = money / 25;
      money -= quarters * 25;
      dimes = money / 10;
      money -= dimes * 10;
      nickles = money / 5;
      money -= nickles * 5;
      pennies = money / 1;
      money -= pennies * 1;

      changeAmount.Add("quarters", quarters);
      changeAmount.Add("dimes", dimes);
      changeAmount.Add("nickles", nickles);
      changeAmount.Add("pennies", pennies);

      return changeAmount;

    }
  }
}
