using EFDataAuth.Test.Domain.Data;
using MiniApps.Core.Interface;
using MiniApps.Core.Services;

namespace DataTest.Domain.Mapping
{
    public interface IUserService : IBaseService<Users> { }
    public class UserService : MiniAppService<Users>, IUserService
    {
        public UserService(IRepository<Users> repository) : base(repository)
        {
        }
    }
}
