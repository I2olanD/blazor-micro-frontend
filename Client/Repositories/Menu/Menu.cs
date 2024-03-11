namespace Client.Repositories.Menu
{
  public record Menu
  {
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public string Scope { get; set; } = string.Empty;

    public string Type { get; set; } = string.Empty;
  }
}