using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    interface IOrderService
    {
        void Sales(Gamer gamer, GameProduct gameProduct);
    }
}
