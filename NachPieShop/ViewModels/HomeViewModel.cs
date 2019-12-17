using System.Collections.Generic;
using NachPieShop.Models;

namespace NachPieShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }
    }
}