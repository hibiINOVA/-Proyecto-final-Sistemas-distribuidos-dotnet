using Distribuidos.Api.Models.Pipedream;

namespace Distribuidos.Api.Services.Pipedream
{
    public interface IPipedreamService
    {
        Task<bool> setWelcomeData(WelcomeModel body);
        Task<bool> setCode(WelcomeModel body);
        Task<bool> checkCode(CheckCodeModel body);
    }
}