using ODEV5.Abstract;
using ODEV5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ODEV5.Concerete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyun Eklendi : " + game.GameName);
        }

        public void Sold(Game game)
        {
            Console.WriteLine("Oyun Satıldı : " + game.GameName + " " +  game.GamePrice);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun Silindi : " + game.GameName); ;
        }
    }
}
