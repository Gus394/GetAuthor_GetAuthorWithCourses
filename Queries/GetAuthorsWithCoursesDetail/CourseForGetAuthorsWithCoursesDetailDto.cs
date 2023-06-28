namespace Univali.Api.Features.Authors.Queries.GetAuthorsWithCoursesDetail;

public class CourseForGetAuthorsWithCoursesDetailDto {
    public int Id {get; set;}
    public string Title {get; set;} = string.Empty;
    public string Description {get; set;} = string.Empty;
    public double Price {get; set;}
    public List<AuthorForGetAuthorsWithCoursesDetailDto> Authors {get; set;} = new();

    public CourseForGetAuthorsWithCoursesDetailDto(string title, string description, double price)
    {
        Title = title;
        Description = description;
        Price = price;
    }
}