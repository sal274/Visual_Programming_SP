namespace WriteOn.Models;

public class ArticleHistory
{
    public required int ArticleHistoryID { get; set; }  // Primary key for ArticleHistory table
    public required int ArticleID { get; set; }  // Foreign key referencing Article
    public required int RevisionNumber { get; set; }  // Tracks revision number within history
    public required string Content { get; set; }  // Content of the article at this point in history
    public required DateTime Timestamp { get; set; }  // Date and time of this revision
}