using ODEV5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ODEV5.Abstract
{
    interface IGameService
    {
        void Add(Game game);
        void Update(Game game);
        void Sold(Game game);
    }
}
