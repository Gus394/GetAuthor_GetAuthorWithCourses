namespace Univali.Api.Features.Authors.Queries.GetAuthorWithCoursesDetail;

public class AuthorForGetAuthorWithCoursesDetailDto
{
    public int Id {get; set;}
    public string FirstName {get; set;} = string.Empty;
    public string LastName {get; set;} = string.Empty;
    public List<CourseForGetAuthorWithCoursesDetailDto> Courses {get; set;} = new();

    public AuthorForGetAuthorWithCoursesDetailDto(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public override string ToString()
    {
        return $"Id: {Id}\nFirstName: {FirstName}\nLastName: {LastName}";
    }
}