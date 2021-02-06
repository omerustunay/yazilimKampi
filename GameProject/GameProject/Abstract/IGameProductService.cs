using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    interface IGameProductService
    {
        void Add(GameProduct gamerProduct);
        void Update(GameProduct gamerProduct);
        void Delete(GameProduct gamerProduct);
    }
}
