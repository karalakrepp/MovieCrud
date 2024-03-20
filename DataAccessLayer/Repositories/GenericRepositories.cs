using DataAccessLayer.Concretes;
using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories;

public class GenericRepositories<T> : IGenericDal<T> where T : class
{
    public List<T> GetAll()
    {
       Context ctx = new Context();

        return ctx.Set<T>().ToList();
    }

    public void Insert(T t)
    {
        Context ctx = new Context();
        ctx.Add(t);
        ctx.SaveChanges();
    }

    public void Remove(T t)
    {
        Context ctx = new Context();
        ctx.Remove(t);
        ctx.SaveChanges();
    }

    public void Update(T t)
    {
        Context ctx = new Context();
        ctx.Update(t);
        ctx.SaveChanges();
    }

    public T GetById<S>(S id)
    {
        Context ctx = new Context();

        return ctx.Set<T>().Find(id);
}

}