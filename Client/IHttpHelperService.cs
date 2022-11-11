using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client
{
    public interface IHttpHelperService
    {
        Task<ResponseDto> Post(string name);
    }
}
