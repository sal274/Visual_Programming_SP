namespace WriteOn.Models;

public class ArticleCommentHistory
{
    public required int ArticleCommentHistoryID { get; set; }  // Primary key for ArticleCommentHistory table
    public required int ArticleCommentID { get; set; }  // Foreign key referencing ArticleComment
    public required int RevisionNumber { get; set; }  // Tracks revision number within history
    public required string Content { get; set; }  // Content of the comment at this point in history
    public required DateTime Timestamp { get; set; }  // Date and time of this revision
}