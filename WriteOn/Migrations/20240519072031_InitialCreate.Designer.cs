﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WriteOn.Data;

#nullable disable

namespace WriteOn.Migrations
{
    [DbContext(typeof(WriteOnDbContext))]
    [Migration("20240519072031_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.5");

            modelBuilder.Entity("WriteOn.Models.AccessRights", b =>
                {
                    b.Property<string>("AccessRightsID")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsModerator")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AccessRightsID");

                    b.ToTable("AccessRights");
                });

            modelBuilder.Entity("WriteOn.Models.Admin", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.Property<string>("AdminAccountID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("AdminCredentialsID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Username");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("WriteOn.Models.AdminAccount", b =>
                {
                    b.Property<string>("AdminAccountID")
                        .HasColumnType("TEXT");

                    b.Property<string>("AdminUsername")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AdminAccountID");

                    b.ToTable("AdminAccounts");
                });

            modelBuilder.Entity("WriteOn.Models.AdminCredentials", b =>
                {
                    b.Property<string>("AdminCredentialsID")
                        .HasColumnType("TEXT");

                    b.Property<string>("AdminUsername")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AdminCredentialsID");

                    b.ToTable("AdminCredentials");
                });

            modelBuilder.Entity("WriteOn.Models.Article", b =>
                {
                    b.Property<string>("ArticleID")
                        .HasColumnType("TEXT");

                    b.Property<string>("AuthorUsername")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PublishDate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ArticleID");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("WriteOn.Models.ArticleComment", b =>
                {
                    b.Property<string>("ArticleCommentID")
                        .HasColumnType("TEXT");

                    b.Property<string>("ArticleID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CommentDate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CommenterUsername")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ArticleCommentID");

                    b.ToTable("ArticleComments");
                });

            modelBuilder.Entity("WriteOn.Models.ArticleReview", b =>
                {
                    b.Property<string>("ArticleReviewID")
                        .HasColumnType("TEXT");

                    b.Property<string>("ArticleID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ReviewDate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ReviewerUsername")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ArticleReviewID");

                    b.ToTable("ArticleReviews");
                });

            modelBuilder.Entity("WriteOn.Models.CurrentUserState", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.Property<bool>("LoggedIn")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Username");

                    b.ToTable("UserState");
                });

            modelBuilder.Entity("WriteOn.Models.ModAccount", b =>
                {
                    b.Property<string>("ModAccountID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ModeratorUsername")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ModAccountID");

                    b.ToTable("ModAccounts");
                });

            modelBuilder.Entity("WriteOn.Models.ModCredentials", b =>
                {
                    b.Property<string>("ModCredentialsID")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModeratorUsername")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ModCredentialsID");

                    b.ToTable("ModCredentials");
                });

            modelBuilder.Entity("WriteOn.Models.Moderator", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModAccountID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ModCredentialsID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Username");

                    b.ToTable("Moderators");
                });

            modelBuilder.Entity("WriteOn.Models.User", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserAccountID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserCredentialsID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Username");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WriteOn.Models.UserAccount", b =>
                {
                    b.Property<string>("UserAccountID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserAccountID");

                    b.ToTable("UserAccounts");
                });

            modelBuilder.Entity("WriteOn.Models.UserCredentials", b =>
                {
                    b.Property<string>("UserCredentialsID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserCredentialsID");

                    b.ToTable("UserCredentials");
                });
#pragma warning restore 612, 618
        }
    }
}
