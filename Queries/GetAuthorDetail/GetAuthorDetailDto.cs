namespace Univali.Api.Features.Authors.Queries.GetAuthorDetail;

public class GetAuthorDetailDto
{
    public int Id {get; set;}
    public string FirstName {get; set;} = string.Empty;
    public string LastName {get; set;} = string.Empty;
    public List<Course> Courses {get; set;} = new();

    public GetAuthorDetailDto(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public override string ToString()
    {
        return $"Id: {Id}\nFirstName: {FirstName}\nLastName: {LastName}";
    }
}