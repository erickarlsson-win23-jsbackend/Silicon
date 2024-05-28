namespace BlazorApp.Client.Models;

public class Course
{
    public string? Id { get; set; }
    public string? Title { get; set; }
    public string? ImageUri { get; set; }
    public string? Author { get; set; }
    public bool IsBestseller { get; set; }
    public string? Hours { get; set; }
    public double OriginalPrice { get; set; }
    public double DiscountPrice { get; set; }
    public string? LikesInPercent { get; set; }
    public string? LikesInNumbers { get; set; }
    public string? Link { get; set; }
}