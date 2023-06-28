namespace Univali.Api.Features.Authors.Queries.GetAuthorsDetail;

public class GetAuthorsDetailDto
{
    public int Id {get; set;}
    public string FirstName {get; set;} = string.Empty;
    public string LastName {get; set;} = string.Empty;
    public List<Course> Courses {get; set;} = new();

    public GetAuthorsDetailDto(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public override string ToString()
    {
        return $"Id: {Id}\nFirstName: {FirstName}\nLastName: {LastName}";
    }
}