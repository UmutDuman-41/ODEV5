using ODEV5.Abstract;
using ODEV5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ODEV5.Concerete
{
    class GamerManager : IGamerManager
    {
        public GamerManager(UserValidationManager userValidationManager)
        {
        }

        public void Add(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Eklendi : " + gamer.FirstName + " " + gamer.LastName + " " + gamer.TcNo);
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Silindi : " + gamer.FirstName + " " + gamer.LastName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Güncellendi : " + gamer.TcNo);
        }
    }
}
