namespace WriteOn.Models;

public class User
{
    public required int UserID { get; set; }
    public required string Username { get; set; }
    public required string Email { get; set; }
    public required UserCredentials Credentials { get; set; }  // One-to-One relationship with UserCredentials
    public required UserAccount UserAccount { get; set; }  // One-to-One relationship
    public required List<Article> Articles { get; set; }  // One-to-Many relationship with Articles
    public required List<ArticleReview> ArticleReviews { get; set; }  // One-to-Many relationship with ReviewArticles
}
