using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    public class MenuRightFlyoutMenuItem
    {
        public MenuRightFlyoutMenuItem()
        {
            TargetType = typeof(MenuRightFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}