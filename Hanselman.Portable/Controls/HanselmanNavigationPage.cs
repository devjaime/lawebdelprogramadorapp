using System;
using Xamarin.Forms;

namespace Hanselman.Portable.Controls
{
    public class HanselmanNavigationPage :NavigationPage
    {
        public HanselmanNavigationPage(Page root) : base(root)
        {
            Init();
        }

        public HanselmanNavigationPage()
        {
            Init();
        }

        void Init()
        {

            BarBackgroundColor = Color.FromHex("#088DA5");
            BarTextColor = Color.White;
        }
    }
}

