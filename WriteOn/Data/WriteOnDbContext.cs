using Microsoft.EntityFrameworkCore;
using WriteOn.Models;

namespace WriteOn.Data;

public class WriteOnDbContext : DbContext
{
  public WriteOnDbContext(DbContextOptions options) : base(options)
  {
  }

  public DbSet<User> Users { get; set; }
  public DbSet<UserCredentials> UserCredentials { get; set; }
  public DbSet<UserAccount> UserAccounts { get; set; }
  public DbSet<Article> Articles { get; set; }
  public DbSet<ArticleReview> ArticleReviews { get; set; }
  public DbSet<ArticleComment> ArticleComments { get; set; }
  public DbSet<Admin> Admins { get; set; }
  public DbSet<AdminAccount> AdminAccounts { get; set; }
  public DbSet<AdminCredentials> AdminCredentials { get; set; }
  public DbSet<Moderator> Moderators { get; set; }
  public DbSet<ModAccount> ModAccounts { get; set; }
  public DbSet<ModCredentials> ModCredentials { get; set; }
  public DbSet<AccessRights> AccessRights { get; set; }
}