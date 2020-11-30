using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Sprint2
{
    class CatiaControl
    {
        CatiaControl()
        {
            CatiaConnection cc = new CatiaConnection();

            if (cc.CatiaLaeuft())
            {
                cc.ErzeugePart();


            }
        }
    }
}
