using System;
using System.Collections.Generic;

namespace CoinApp.Objects
{
  public class Coin
  {
    private double _change;

    public Coin(int change)
    {
      _change = change;
    }

    public double GetChange()
    {
      return _change;
    }

    public Dictionary<int, string> Change(double money)
    {
      int quarters = 0;
      int dimes = 0;
      int pennies = 0;
      int nickles = 0;

      Dictionary<int, string> changeAmount = new Dictionary<int, string>();
      quarters = (int) (money / .25);
      money -= (int) (quarters * .25);
      dimes = (int) (money / .10);
      money -= (int) (dimes * .10);
      nickles = (int) (money / .05);
      money -= (int) (nickles * .05);
      pennies = (int) (money / .01);
      money -= (int) (pennies * .01);

      changeAmount.Add(quarters, "quarters");
      changeAmount.Add(dimes, "dimes");
      changeAmount.Add(nickles, "nickles");
      changeAmount.Add(pennies, "pennies");

      return changeAmount;

    }
  }
}
