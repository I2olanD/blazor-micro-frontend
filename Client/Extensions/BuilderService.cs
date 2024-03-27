using Client.Repositories.Menu;

namespace Client.Extensions
{
  public static class Extensions
  {
    public static void AddMenuRepository(this IServiceCollection services)
    {
      services.AddScoped<IMenuRepository, MenuRepository>();
    }

    public static void AddAssemblyLoader(this IServiceCollection services)
    {
      services.AddSingleton<AssemblyLoader>();
    }
  }
}
