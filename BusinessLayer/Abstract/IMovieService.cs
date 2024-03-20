using BusinessLayer.Dtos.Request;
using BusinessLayer.Dtos.Response;
using DataAccessLayer.Abstract;
using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMovieService
    {
        MovieResponse Add(MovieReq req);
        MovieResponse Update(Guid id,MovieReq req);

        MovieResponse Delete(Guid Id);

        List<GetAllMovieResponse> GetAllMovie();

        GetResponse GetMovieById(Guid Id);





    }
}
