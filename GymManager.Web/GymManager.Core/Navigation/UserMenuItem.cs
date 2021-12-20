using System.Collections.Generic;

namespace GymManager.Core.Navigation
{
    public class UserMenuItem
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public string DisplayName { get; set; }
        public int Order { get; set; }
        public string Url { get; set; }
        public IList<UserMenuItem> Items { get; set; }

        public UserMenuItem()
        {
            Items = new List<UserMenuItem>();
        }
    }
}
