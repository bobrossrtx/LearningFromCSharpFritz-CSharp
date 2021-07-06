using System;

/**
  * This app uses fake IP Addresses, The Ip Addresses used were generated at complete random
  */
namespace Classes.Bobrossrtx
{
  class Program
  {
    static void Main(string[] args)
    {
      Shop myShop = new Shop("Bobross's Shop");
      myShop.Products = 30;

      Shop otherShop = new Shop("Random Shop", "199.117.207.32" , 10);

      Shop[] allShops = { myShop, otherShop };

      foreach(Shop shop in allShops)
      {
        Console.WriteLine($"Shop: {shop.ShopName}\nIpAddress: {shop.Address}\nProducts: {shop.Products}\r\n");
      }

      Console.ReadLine();
    }
  }
}
