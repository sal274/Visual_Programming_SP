namespace WriteOn.Models;

public class ArticleComment
{
    public required int ArticleCommentID { get; set; }  // Primary key for ArticleComments table
    public required int ArticleID { get; set; }  // Foreign key referencing Article
    public required string CommenterUsername { get; set; }  // Foreign key referencing User who wrote the comment
    public required string Content { get; set; }  // Content of the comment
    public required string CommentDate { get; set; }  // Date and time the comment was written
}