using System;
using System.Collections.Generic;
using System.Text;
using Core;

namespace Entities.DTOs
{
    public class CarImageDetailDto: IDto
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public DateTime Date { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public int ModelYear { get; set; }
        public int DailyPrice { get; set; }
    }
}
