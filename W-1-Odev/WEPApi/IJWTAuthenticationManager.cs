using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEPApi
{
    public interface IJWTAuthenticationManager
    {
        string Authenticat(string userName, string Password);
    }
}
