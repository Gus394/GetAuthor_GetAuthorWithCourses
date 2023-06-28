namespace Univali.Api.Features.Authors.Queries.GetAuthorWithCoursesDetail;

public class CourseForGetAuthorWithCoursesDetailDto {
    public int Id {get; set;}
    public string Title {get; set;} = string.Empty;
    public string Description {get; set;} = string.Empty;
    public double Price {get; set;}
    public List<AuthorForGetAuthorWithCoursesDetailDto> Authors {get; set;} = new();

    public CourseForGetAuthorWithCoursesDetailDto(string title, string description, double price)
    {
        Title = title;
        Description = description;
        Price = price;
    }
}