namespace WriteOn.Models;

public class ArticleReviewHistory
{
    public required int ArticleReviewHistoryID { get; set; }  // Primary key for ArticleReviewHistory table
    public required int ArticleReviewID { get; set; }  // Foreign key referencing ArticleReview
    public required int RevisionNumber { get; set; }  // Tracks revision number within history
    public required string Content { get; set; }  // Content of the review at this point in history
    public required DateTime Timestamp { get; set; }  // Date and time of this revision
}