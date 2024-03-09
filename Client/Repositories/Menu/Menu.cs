namespace Client.Repositories.Menu
{
  public record Menu
  {
    public int Id { get; set; }
    public string Name { get; set; }

    public string Scope { get; set; }

    public string Type { get; set; }
  }
}