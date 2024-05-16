using System.ComponentModel.DataAnnotations;

namespace WriteOn.Models;

public class Article
{
    [Key]
    public required string ArticleID { get; set; }  // Primary key for Articles table
    public required string AuthorUsername { get; set; }  // Foreign key referencing User (who wrote it)
    public required string Title { get; set; }
    public required string Content { get; set; }
    public required string PublishDate { get; set; }
    public required string Category { get; set; }  // Fiction, Non-Fiction, Poetry etc.
}