using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IGameSaleService
    {
        void Sale(Gamer gamer, Game game, Campaigns campaign);
    }
}
