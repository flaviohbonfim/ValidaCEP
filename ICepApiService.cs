using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidaCEP
{
    public interface ICepApiService
    {
        [Get("/ws/{cep}/json")]
        Task<CEPResponse> GetAddressAsync(string cep);
    }
}
