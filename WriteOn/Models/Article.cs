namespace WriteOn.Models;

public class Article
{
    public required int ArticleID { get; set; }  // Primary key for Articles table
    public required int AuthorID { get; set; }  // Foreign key referencing User (who wrote it)
    public required string AuthorName { get; set; }
    public required string Title { get; set; }
    public required string Content { get; set; }
    public required DateTime PublishDate { get; set; }
    public required string Category { get; set; }  // Fiction, Non-Fiction, Poetry etc.
    public required bool IsDraft { get; set; }  // Flag to differentiate drafts from published articles
    public List<ArticleHistory> History { get; set; } = new List<ArticleHistory>();  // One-to-Many with ArticleHistory
    public List<ArticleReward> Rewards { get; set; } = new List<ArticleReward>();  // One-to-Many with ArticleRewards
    public List<ArticleReview> Reviews { get; set; } = new List<ArticleReview>();  // One-to-Many with ArticleReview
    public List<ArticleComment> Comments { get; set; } = new List<ArticleComment>();  // One-to-Many with Article Comment
}