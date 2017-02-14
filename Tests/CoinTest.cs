using Xunit;
using CoinApp.Objects;
using System;
using System.Collections.Generic;

namespace CoinApp
{
  public class CoinTest
  {
    [Fact]
    public void Change_returnSingleCoin_oneQuarter()
    {
      // arrange\
      double testChange = .25;
      Coin testCoin = new Coin(testChange);

      // act
      Dictionary<int, string> result = testCoin.Change(testChange);

      // assert
      Dictionary<int, string> testDictionary = new Dictionary<int, string>{};
      testDictionary.Add(1, "quarters");
      testDictionary.Add(0, "dimes");
      testDictionary.Add(0, "nickles");
      testDictionary.Add(0, "pennies");

      Assert.Equal(testDictionary, result);
    }
  }
}
