using Nancy;
using CoinApp.Objects;
using System;
using System.Collections.Generic;

namespace CoinApp
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Post["/result"] = _ => {
        Coin userCoin = new Coin();
        int input = Int32.Parse(Request.Form["amount"]);
        Dictionary<string, int> changeCounter = userCoin.Change(input);
        return View["index.cshtml", changeCounter];
      };
    }
  }
}
