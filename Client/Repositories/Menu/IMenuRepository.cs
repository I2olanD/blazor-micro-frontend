namespace Client.Repositories.Menu
{
  public interface IMenuRepository
  {
    IEnumerable<Menu> GetAll();
    Menu GetBy(string Scope);
  }
}
