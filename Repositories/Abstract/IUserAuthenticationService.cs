using MovieStoreMvc.Models.DTO;

namespace MovieStoreMvc.Repositories.Abstract
{
    public interface IUserAuthenticationService
    {
        Task<Status> LoginAsync(Login model);
        Task LogoutAsync();
        Task<Status> RegisterAsync(Registeration model);
        //Task<Status> ChangePasswordAsync(ChangePasswordModel model, string username);
    }
}
