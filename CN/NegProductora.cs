using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CE;
using CD;

namespace CN
{

    public class NegProductora
    {
        AbmProductora ObjDatosProductoras = new AbmProductora();
        //LISTADO DE DATOS
        public List<Productoras> ObtenerProductoras()
        {
            return ObjDatosProductoras.ObtenerProductoras();
        }
    }
}
