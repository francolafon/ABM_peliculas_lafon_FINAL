using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CE;
using CD;

namespace CN
{
    public class NegDirector
    {
        AbmDirector ObjDatosDirectores = new AbmDirector();
        //LISTADO DE DATOS
        public List<Directores> ObtenerDirectores()
        {
            return ObjDatosDirectores.ObtenerDirectores();
        }
    }
}
