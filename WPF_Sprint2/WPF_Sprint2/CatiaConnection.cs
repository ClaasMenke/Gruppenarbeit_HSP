using INFITF;
using MECMOD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Sprint2
{
    class CatiaConnection
    {
        INFITF.Application hsp_catiaApp;
        MECMOD.PartDocument hsp_catiaPart;

        internal bool CatiaLaeuft()
        {
            try
            {
                object catiaObj = System.Runtime.InteropServices.Marshal.GetActiveObject("CATIA.Application");
                hsp_catiaApp = (INFITF.Application)catiaObj;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        internal void ErzeugePart()
        {
            Documents catDocuments = hsp_catiaApp.Documents;
            hsp_catiaPart = (PartDocument)catDocuments.Add("Part");
        }
    }
}
