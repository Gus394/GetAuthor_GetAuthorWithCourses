// =================================================

// Profiles para serem inseridos em AuthorProfile.cs

// =================================================

CreateMap<Entities.Author, Univali.Api.Features.Authors.Queries.GetAuthorDetail.GetAuthorDetailDto>();

CreateMap<Entities.Author, Univali.Api.Features.Authors.Queries.GetAuthorsDetail.GetAuthorsDetailDto>();

CreateMap<Entities.Author, Univali.Api.Features.Authors.Queries.GetAuthorWithCoursesDetail.AuthorForGetAuthorWithCoursesDetailDto>();

CreateMap<Entities.Author, Univali.Api.Features.Authors.Queries.GetAuthorsWithCoursesDetail.AuthorForGetAuthorsWithCoursesDetailDto>();

// ==========================================

// Métodos para serem inseridos na Controller

// ==========================================

[HttpGet]
public async Task<ActionResult<IEnumerable<AuthorDto>>> GetAuthorsAsync()
{
    GetAuthorsDetailQuery getAuthorsDetailQuery = new GetAuthorsDetailQuery();
    IEnumerable<GetAuthorsDetailDto?> authorsToReturn = await _mediator.Send(getAuthorsDetailQuery);

    return Ok(authorsToReturn);
}

[HttpGet("{id}", Name = "GetAuthorById")]
public async Task<ActionResult<AuthorDto>> GetAuthorByIdAsync(int id)
{
    GetAuthorDetailQuery getAuthorDetailQuery = new GetAuthorDetailQuery {Id = id};
    GetAuthorDetailDto? authorToReturn = await _mediator.Send(getAuthorDetailQuery);

    if (authorToReturn == null) return NotFound();

    return Ok(authorToReturn);
}

//

[HttpGet("with-courses")]
public async Task<ActionResult<IEnumerable<AuthorForGetAuthorsWithCoursesDetailDto>>> GetAuthorsWithCoursesAsync()
{
    GetAuthorsWithCoursesDetailQuery getAuthorsWithCoursesDetailQuery = new GetAuthorsWithCoursesDetailQuery();
    IEnumerable<AuthorForGetAuthorsWithCoursesDetailDto> authorsToReturn = await _mediator.Send(getAuthorsWithCoursesDetailQuery);

    return Ok(authorsToReturn);
}

[HttpGet("with-courses/{id}", Name = "GetAuthorWithCoursesById")]
public async Task<ActionResult<IEnumerable<AuthorWithCoursesDto>>> GetAuthorWithCoursesByIdAsync(int id)
{
    GetAuthorWithCoursesDetailQuery getAuthorWithCoursesDetailQuery = new GetAuthorWithCoursesDetailQuery {Id = id};
    AuthorForGetAuthorWithCoursesDetailDto authorToReturn = await _mediator.Send(getAuthorWithCoursesDetailQuery);

    if (authorToReturn == null) return NotFound();

    return Ok(authorToReturn);
}