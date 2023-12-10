namespace WebCourse_Sample_01.Data.Entities;

public class Comment
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public string CreatorName { get; set; }

    public DateTime CreatorDate { get; set;}




    public Post Post { get; set; }
    public int PostId { get; set; }

}