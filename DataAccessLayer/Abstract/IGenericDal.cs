using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Abstract;

public interface IGenericDal<T> where T : class
{
    public void Insert (T t);
    public void Remove (T t);

    public void Update (T t);

    public List<T> GetAll();
    public T GetById<S>(S id);

}
