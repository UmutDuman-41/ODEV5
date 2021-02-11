using ODEV5.Abstract;
using ODEV5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ODEV5.Concerete
{
    public class UserValidationManager : IUserValidationManager
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName =="Umut" && gamer.LastName == "Duman" && gamer.TcNo == "12345" && gamer.BirthDay ==1999)
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
