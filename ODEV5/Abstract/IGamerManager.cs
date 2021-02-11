using ODEV5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ODEV5.Abstract
{
    interface IGamerManager
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
