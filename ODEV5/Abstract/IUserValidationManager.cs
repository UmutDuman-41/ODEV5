using ODEV5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ODEV5.Abstract
{
   public interface IUserValidationManager
    {
        bool Validate(Gamer gamer);
    }
}
