using System.ComponentModel.DataAnnotations;

namespace WriteOn.Models;

public class ArticleReview
{
    [Key]
    public required string ArticleReviewID { get; set; }  // Primary key for ArticleReviews table
    public required string ArticleID { get; set; }  // Foreign key referencing Article
    public required string ReviewerUsername { get; set; }  // Foreign key referencing User who wrote the review
    public required string Content { get; set; }  // Content of the review
    public required string ReviewDate { get; set; }  // Date and time the review was written
}