namespace scene_it.Models
{
  public class Post
  {
    public int Id { get; set; }
    public string UserId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Img { get; set; }
    public bool IsPrivate { get; set; }

  }

}