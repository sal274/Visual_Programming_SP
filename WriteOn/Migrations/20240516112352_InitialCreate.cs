using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WriteOn.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccessRights",
                columns: table => new
                {
                    AccessRightsID = table.Column<string>(type: "TEXT", nullable: false),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    IsAdmin = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsModerator = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessRights", x => x.AccessRightsID);
                });

            migrationBuilder.CreateTable(
                name: "AdminAccounts",
                columns: table => new
                {
                    AdminAccountID = table.Column<string>(type: "TEXT", nullable: false),
                    AdminUsername = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminAccounts", x => x.AdminAccountID);
                });

            migrationBuilder.CreateTable(
                name: "AdminCredentials",
                columns: table => new
                {
                    AdminCredentialsID = table.Column<string>(type: "TEXT", nullable: false),
                    AdminUsername = table.Column<string>(type: "TEXT", nullable: false),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminCredentials", x => x.AdminCredentialsID);
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    AdminCredentialsID = table.Column<string>(type: "TEXT", nullable: false),
                    AdminAccountID = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Username);
                });

            migrationBuilder.CreateTable(
                name: "ArticleComments",
                columns: table => new
                {
                    ArticleCommentID = table.Column<string>(type: "TEXT", nullable: false),
                    ArticleID = table.Column<string>(type: "TEXT", nullable: false),
                    CommenterUsername = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    CommentDate = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleComments", x => x.ArticleCommentID);
                });

            migrationBuilder.CreateTable(
                name: "ArticleReviews",
                columns: table => new
                {
                    ArticleReviewID = table.Column<string>(type: "TEXT", nullable: false),
                    ArticleID = table.Column<string>(type: "TEXT", nullable: false),
                    ReviewerUsername = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    ReviewDate = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleReviews", x => x.ArticleReviewID);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    ArticleID = table.Column<string>(type: "TEXT", nullable: false),
                    AuthorUsername = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    PublishDate = table.Column<string>(type: "TEXT", nullable: false),
                    Category = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.ArticleID);
                });

            migrationBuilder.CreateTable(
                name: "ModAccounts",
                columns: table => new
                {
                    ModAccountID = table.Column<string>(type: "TEXT", nullable: false),
                    ModeratorUsername = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModAccounts", x => x.ModAccountID);
                });

            migrationBuilder.CreateTable(
                name: "ModCredentials",
                columns: table => new
                {
                    ModCredentialsID = table.Column<string>(type: "TEXT", nullable: false),
                    ModeratorUsername = table.Column<string>(type: "TEXT", nullable: false),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModCredentials", x => x.ModCredentialsID);
                });

            migrationBuilder.CreateTable(
                name: "Moderators",
                columns: table => new
                {
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    ModCredentialsID = table.Column<string>(type: "TEXT", nullable: false),
                    ModAccountID = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moderators", x => x.Username);
                });

            migrationBuilder.CreateTable(
                name: "UserAccounts",
                columns: table => new
                {
                    UserAccountID = table.Column<string>(type: "TEXT", nullable: false),
                    Username = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccounts", x => x.UserAccountID);
                });

            migrationBuilder.CreateTable(
                name: "UserCredentials",
                columns: table => new
                {
                    UserCredentialsID = table.Column<string>(type: "TEXT", nullable: false),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCredentials", x => x.UserCredentialsID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    UserCredentialsID = table.Column<string>(type: "TEXT", nullable: false),
                    UserAccountID = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Username);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccessRights");

            migrationBuilder.DropTable(
                name: "AdminAccounts");

            migrationBuilder.DropTable(
                name: "AdminCredentials");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "ArticleComments");

            migrationBuilder.DropTable(
                name: "ArticleReviews");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "ModAccounts");

            migrationBuilder.DropTable(
                name: "ModCredentials");

            migrationBuilder.DropTable(
                name: "Moderators");

            migrationBuilder.DropTable(
                name: "UserAccounts");

            migrationBuilder.DropTable(
                name: "UserCredentials");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
