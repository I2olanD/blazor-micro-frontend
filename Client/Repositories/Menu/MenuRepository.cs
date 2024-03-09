namespace Client.Repositories.Menu
{
  public class MenuRepository : IMenuRepository
  {
    private readonly List<Menu> _menus = new()
    {
      new Menu {Id = 1, Name= "Weather", Scope = "weather", Type = "internal"},
      new Menu {Id = 2, Name="Counter", Scope = "counter", Type = "external" }
    };

    public IEnumerable<Menu> GetAll() => _menus;
    public Menu GetBy(string Scope) => _menus.SingleOrDefault(menu => menu.Scope.Equals(Scope));
  }
}