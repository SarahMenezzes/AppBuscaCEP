using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BuscaCEPWF
{
    interface ICepApiService
    {
        [Get("/ws/{cep}/json")]

        Task<CepResponse>GetAddressAsync(string cep);
    }
}
