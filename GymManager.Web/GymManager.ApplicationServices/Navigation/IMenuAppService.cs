using GymManager.Core.Navigation;
using System.Collections.Generic;

namespace GymManager.ApplicationServices.Navigation
{
    public interface IMenuAppService
    {
        List<UserMenuItem> GetMenu();
    }
}
