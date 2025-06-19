using Api.DTO;

namespace Api.Repository.Interface
{
    public interface IUserRepository
    {
        Task<User> RegisterUser(userSignup signup);
        Task<User> LoginUser(userSignIn signin);
        Task<IEnumerable<User>> GetAllUsers();

    }
}
