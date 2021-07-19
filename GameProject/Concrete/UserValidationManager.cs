using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 2001 && gamer.FirstName == "Ömer" && gamer.LastName == "Mermer" && gamer.IdentityNumber == 12345678911 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
