Using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace FriendLetter
{
  public class Program
  {
    public static void Main(string[] args)
    {
      WebHostBuilder host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .UseStartup<Startup>()
        .Build();

      host.Run()
    }
  }
}