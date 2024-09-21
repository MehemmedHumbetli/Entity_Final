using ClassLibrary.Abstract;

namespace ClassLibrary.Concrate;
public class CommentClass:BaseEntity
{
    public int Id { get; set; }
    public string Text { get; set; }
    public string Comment { get; set; }
    public int LikeCount { get; set; }
    public int ViewCount { get; set; }
    //Navigation Property
    public ICollection<Post> Posts { get; set; }
}
