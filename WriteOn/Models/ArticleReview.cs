namespace WriteOn.Models;

public class ArticleReview
{
    public required int ArticleReviewID { get; set; }  // Primary key for ArticleReviews table
    public required int ArticleID { get; set; }  // Foreign key referencing Article
    public required int ReviewerID { get; set; }  // Foreign key referencing User who wrote the review
    public required string Content { get; set; }  // Content of the review
    public required int Rating { get; set; }  // Rating for the article (e.g., 1-5 stars)
    public required DateTime ReviewDate { get; set; }  // Date and time the review was written
    public required bool IsPublic { get; set; }  // Flag to control review visibility
    public List<ArticleReviewHistory> History { get; set; } = new List<ArticleReviewHistory>();
}