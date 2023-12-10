namespace WebCourse_Sample_01.Data.Entities;

public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }
    public DateTime Created { get; set; }


    public List<Comment> Comments { get; set; }


}