using BusinessLayer.Abstract;
using BusinessLayer.Dtos.Request;
using BusinessLayer.Dtos.Response;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace BusinessLayer.Concretes
{
    public class MovieService : IMovieService
    {
        private readonly IMovieDal _movieDal;


        public MovieService(IMovieDal _movieDal)
        {
            this._movieDal = _movieDal;
        }
        public MovieResponse Add(MovieReq req)
        {

            try
            {
                
                if (req == null)
                    Console.Write("myObj is NULL");
                Movie movie = new Movie(
                    name: req.Name,
                    req.Title,
                     req.Description,
                        req.Score,
                     req.Year,
                    req.Duration,
                    req.Country,
                     req.Director);

                movie.DeletedAt = DateTime.UtcNow; 
                movie.CreatedAt = DateTime.UtcNow;
                movie.UpdatedAt = DateTime.UtcNow;
                
                    
                   
            
        
                _movieDal.Insert(movie);

                MovieResponse res = new MovieResponse
                {
                    Message = "Added Success",
                    Status = 201

                };

                return res;
            }
            catch (Exception ex)
            {
                // Hata durumunda istisna bilgisini logla
                Console.WriteLine(ex.ToString());

                // Hata durumunda uygun bir yanıt dön
                return new MovieResponse
                {
                    Message = "An error occurred while adding the movie",
                    Status = 500 // Internal Server Error
                };

            }


        }

        public MovieResponse Delete(Guid Id)

        {

            try
            {
                Movie movie = _movieDal.GetById(Id);

                _movieDal.Remove(movie);

                MovieResponse res = new MovieResponse
                {
                    Message = "Remove Success",
                    Status = 201

                };

                return res;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return new MovieResponse
                {
                    Message = "An error occurred while adding the movie",
                    Status = 500 // Internal Server Error
                };

            }
           

        }

        public List<GetAllMovieResponse> GetAllMovie()
        {
            try
            {
                List<Movie> movies = _movieDal.GetAll();

                List<GetAllMovieResponse> responses = movies.Select(movie => new GetAllMovieResponse
                {
                    Id = movie.Id,
                    Name = movie.Name,
                    Title = movie.Title,
                    Description = movie.Description,
                    // Diğer özellikleri de buraya ekleyin
                }).ToList();

                return responses;
            }
            catch (Exception ex)
            {
                // Hata durumunda istisna bilgisini logla
                Console.WriteLine(ex.ToString());

                // Hata durumunda uygun bir yanıt dön
                return new List<GetAllMovieResponse>(); // veya başka bir uygun değer
            }
        }



        public GetResponse GetMovieById(Guid Id)
        {
         
               
                Movie movie = _movieDal.GetById(Id);
                GetResponse response = new GetResponse
                    {  
               
                        Name = movie.Name,
                        Description = movie.Description,
                        Title = movie.Title,
                        Country = movie.Country,
                        Director = movie.Director,
                        Score = movie.Score,
                        Year = movie.Year,
                        Duration    = movie.Duration,

                        CreatedAt = movie.CreatedAt,
                        UpdatedAt = movie.UpdatedAt,
                        DeletedAt = movie.DeletedAt,
                // Diğer özellikleri buraya ekleyin
            };

            return response;


            
        }

        public MovieResponse Update(Guid id,MovieReq req)
        {
            try
            {

                Movie movie = _movieDal.GetById(id);
                if (movie == null)
                {
                    return new MovieResponse
                    {
                        Message = "Movie not found",
                        Status = 404 // Not Found
                    };
                }


                movie.Name = req.Name;
                movie.Title = req.Title;
                movie.Description = req.Description;
                movie.Score = req.Score;
                movie.Year = req.Year;
                movie.Duration = req.Duration;
                movie.Country = req.Country;
                movie.Director = req.Director;
                movie.CreatedAt = DateTime.UtcNow;
                movie.UpdatedAt = DateTime.UtcNow;
                _movieDal.Update(movie);

                MovieResponse res = new MovieResponse
                {
                    Message = "Added Success",
                    Status = 201

                };

                return res;
            }
            catch (Exception ex)
            {
                // Hata durumunda istisna bilgisini logla
                Console.WriteLine(ex.ToString());

                // Hata durumunda uygun bir yanıt dön
                return new MovieResponse
                {
                    Message = "An error occurred while adding the movie",
                    Status = 500 // Internal Server Error
                };

            }
        }
    }
}
