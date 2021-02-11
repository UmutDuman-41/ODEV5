using ODEV5.Abstract;
using ODEV5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ODEV5.Concerete
{
    public class NewStateUserValidationManager : IUserValidationManager
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
