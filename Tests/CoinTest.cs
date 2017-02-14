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
      int testChange = 25;
      Coin testCoin = new Coin(testChange);

      // act
      Dictionary<string, int> result = testCoin.Change(testChange);

      // assert
      Dictionary<string, int> testDictionary = new Dictionary<string, int>{};
      testDictionary.Add("quarters", 1);
      testDictionary.Add("dimes", 0);
      testDictionary.Add("nickles", 0);
      testDictionary.Add("pennies", 0);

      Assert.Equal(testDictionary, result);
    }

    [Fact]
    public void Change_returnDoubleCoin_twoQuarter()
    {
      // arrange\
      int testChange = 50;
      Coin testCoin = new Coin(testChange);

      // act
      Dictionary<string, int> result = testCoin.Change(testChange);

      // assert
      Dictionary<string, int> testDictionary = new Dictionary<string, int>{};
      testDictionary.Add("quarters", 2);
      testDictionary.Add("dimes", 0);
      testDictionary.Add("nickles", 0);
      testDictionary.Add("pennies", 0);

      Assert.Equal(testDictionary, result);
    }

    [Fact]
    public void Change_returnMultipleCoin_oneQuarterOneDime()
    {
      // arrange\
      int testChange = 35;
      Coin testCoin = new Coin(testChange);

      // act
      Dictionary<string, int> result = testCoin.Change(testChange);

      // assert
      Dictionary<string, int> testDictionary = new Dictionary<string, int>{};
      testDictionary.Add("quarters", 1);
      testDictionary.Add("dimes", 1);
      testDictionary.Add("nickles", 0);
      testDictionary.Add("pennies", 0);

      Assert.Equal(testDictionary, result);
    }
  }
}
