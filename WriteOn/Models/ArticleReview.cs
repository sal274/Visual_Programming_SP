namespace WriteOn.Models;

public class ArticleReview
{
    public required int ArticleReviewID { get; set; }  // Primary key for ArticleReviews table
    public required int ArticleID { get; set; }  // Foreign key referencing Article
    public required int ReviewerID { get; set; }  // Foreign key referencing User who wrote the review
    public required string Content { get; set; }  // Content of the review
    public required string ReviewDate { get; set; }  // Date and time the review was written
}