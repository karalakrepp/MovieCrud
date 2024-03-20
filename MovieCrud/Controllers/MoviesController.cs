using BusinessLayer.Abstract;
using BusinessLayer.Dtos.Request;
using BusinessLayer.Dtos.Response;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MovieCrud.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MoviesController : ControllerBase
{


    private readonly IMovieService _movieService;

    public MoviesController(IMovieService movieService)
    {
        _movieService = movieService;
    }


    [HttpGet("{id}")]
    public IActionResult GetMovieById(Guid id)
    {
        GetResponse response = _movieService.GetMovieById(id);

        if (response != null)
        {
            return Ok(response); // 200 OK
        }
        else
        {
            return NotFound(); // 404 Not Found
        }
    }

    [HttpPost]

    public IActionResult AddMovie(MovieReq req)
    {
        MovieResponse resp = _movieService.Add(req);



        if (resp != null)
        {
            return Created(); // 200 OK
        }
        else
        {
            return NotFound(); // 404 Not Found
        }




    }

    [HttpPut("{id}")]

    public IActionResult UpdateMovie(Guid id,MovieReq req)
    {
        

        MovieResponse resp = _movieService.Update(id,req);
        if (resp != null)
        {
            return Ok(resp); // 200 OK
        }
        else
        {
            return NotFound(); // 404 Not Found
        }
    }

    [HttpDelete("{id}")]

    public IActionResult DeleteMovie(Guid id)
    {
        MovieResponse resp = _movieService.Delete(id);
        if (resp != null)
        {
            return Ok(resp); // 200 OK
        }
        else
        {
            return NotFound(); // 404 Not Found
        }
    }

    [HttpGet]

    public IActionResult GetAll()
    {
        List<GetAllMovieResponse> res= _movieService.GetAllMovie();

        return Ok(res);
    }
}






