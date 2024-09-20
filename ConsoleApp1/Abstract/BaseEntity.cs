public class BaseEntity
{
    public int Id { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public DateTime DeletedDate { get; set; }
    public string Text { get; set; }
    public string Comment { get; set; }
    public int LikeCount { get; set; }
    public int ViewCount { get; set; }
}