using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun eklendi! /n" + "Fiyatı: " + game.GamePrice + "/n Kategori: " + game.GameCategory);

        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun kaldırıldı!");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun güncellendi!");
        }
    }
}
