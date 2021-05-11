using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoliklinikaAPI.Interfaces
{
    public interface UserBaseInterface<T, TVM, TCreateVM>
    {
        public IList<TVM> GetAll();
        public TVM Get(int id);
        public TVM Insert(TCreateVM user);
        public TVM Update(int id, TVM user);
        public void Delete(int id);
    }
}
