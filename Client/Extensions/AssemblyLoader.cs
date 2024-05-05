using System.Reflection;

namespace Client.Extensions
{
  public class AssemblyLoader
  {
    async public static Task<Assembly> Load(string assemblyName)
    {
      var appUrl = $"http://localhost:3000/{assemblyName}.dll";
      var client = new HttpClient();
      var bytes = await client.GetByteArrayAsync(appUrl);

      return Assembly.Load(bytes);
    }
  }

}
