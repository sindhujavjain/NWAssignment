using NW.Models;

namespace NW.Repository
{
    public interface IJWTManagerRepository
    {
        Tokens Authenticate(User user);
    }
}
