using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.MyBirthDayYear == 1990 && gamer.FistName == "Omer" && 
                gamer.LastName=="Ustunay" && gamer.IdentityNumber == "23653")
            {
                return true;
            }

            return false;
        }
    }
}
