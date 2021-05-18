using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoliklinikaAPI.Interfaces
{
    public interface BaseInterface<T, TVM>
    {
        public List<TVM> GetAll();
        public TVM GetById(int id);
        public TVM insert(TVM model);
        public TVM update(TVM model);
        public void Delete(int id);
    }
}
