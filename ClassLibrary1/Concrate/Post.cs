using ClassLibrary.Abstract;

namespace ClassLibrary.Concrate;
public class Post:BaseEntity
{
    public int Id { get; set; }
    public string Text { get; set; }
    public string Comment { get; set; }
    public int LikeCount { get; set; }
    public int ViewCount { get; set; }
    //Foreign key
    public int UserId { get; set; }

    //Navigation property
    public User User { get; set; }
    
    public ICollection<CommentClass> Comments { get; set;}
}
