namespace WriteOn.Models;

public class ArticleReward
{
    public required int ArticleRewardID { get; set; }  // Primary key for ArticleRewards table
    public required int ArticleID { get; set; }  // Foreign key referencing Article
    public required string RewardType { get; set; }  // Type of reward (e.g., "Featured Article", "Editor's Choice")
    public required DateTime AwardedDate { get; set; }  // Date and time the reward was awarded
}