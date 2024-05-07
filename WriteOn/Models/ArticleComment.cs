namespace WriteOn.Models;

public class ArticleComment
{
    public required int ArticleCommentID { get; set; }  // Primary key for ArticleComments table
    public required int ArticleID { get; set; }  // Foreign key referencing Article
    public required int CommenterID { get; set; }  // Foreign key referencing User who wrote the comment
    public required string Content { get; set; }  // Content of the comment
    public required DateTime CommentDate { get; set; }  // Date and time the comment was written
    public List<ArticleCommentHistory> History { get; set; } = new List<ArticleCommentHistory>();  // One-to-Many with ArticleCommentHistory
}