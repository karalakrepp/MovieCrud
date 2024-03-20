using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EFRepositories;

public class EFMovieDal: GenericRepositories<Movie>,IMovieDal
{
}
