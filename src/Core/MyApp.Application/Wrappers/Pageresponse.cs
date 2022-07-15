using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Wrappers
{
    public class Pageresponse<T>:ServiceResponse<T>
    {
        public int PageNumber{ get; set; }
        public int PageSize{ get; set; }

        public Pageresponse(T value):base(value)
        {

        }
        public Pageresponse()
        {
            PageNumber = 1;
            PageSize = 10;
        }

        public Pageresponse(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
    }
}
