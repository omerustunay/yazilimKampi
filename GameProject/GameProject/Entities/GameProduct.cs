using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class GameProduct
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public double GamePrice { get; set; }
        public bool AnyDiscount { get; set; }
    }
}
