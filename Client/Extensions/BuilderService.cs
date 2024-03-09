using Client.Repositories.Menu;

namespace Client.Extensions
{
  public static class Extensions
  {
    public static void AddNavigationMenu(this IServiceCollection services)
    {
      services.AddScoped<IMenuRepository, MenuRepository>();
    }
  }
}
