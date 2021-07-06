using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Bobrossrtx
{
  public class Shop
  {
    private static Random _random = new Random();

    private string GetRandomIpAddress()
    {
      return string.Format($"{_random.Next(0,255)}.{_random.Next(0, 255)}.{_random.Next(0, 255)}.{_random.Next(0, 255)}");
    }

    public Shop(string shopName)
    {
      this.ShopName = shopName;
      this.Address = GetRandomIpAddress();
    }

    public Shop(string shopName, int products)
    {
      this.ShopName = shopName;
      this.Address = GetRandomIpAddress();
      this.Products = products;
    }

    public Shop(string shopName, string address, int products)
    {
      this.ShopName = shopName;
      this.Address = address;
      this.Products = products;

    }

    public string ShopName { get; private set; }
    public string Address { get; private set; }
    public int Products { get; set; }
  }
}
