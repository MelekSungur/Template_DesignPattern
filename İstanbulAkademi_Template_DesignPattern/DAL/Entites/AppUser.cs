using Microsoft.AspNetCore.Identity;
using System.Data.Common;

namespace İstanbulAkademi_Template_DesignPattern.DAL.Entites
{
    public class AppUser:IdentityUser<int >
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Image { get; set; }

        public string Description { get; set; }


    }
}
