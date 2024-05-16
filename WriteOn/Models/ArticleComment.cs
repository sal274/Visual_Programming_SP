using System.ComponentModel.DataAnnotations;

namespace WriteOn.Models;

public class ArticleComment
{
    [Key]
    public required string ArticleCommentID { get; set; }  // Primary key for ArticleComments table
    public required string ArticleID { get; set; }  // Foreign key referencing Article
    public required string CommenterUsername { get; set; }  // Foreign key referencing User who wrote the comment
    public required string Content { get; set; }  // Content of the comment
    public required string CommentDate { get; set; }  // Date and time the comment was written
}