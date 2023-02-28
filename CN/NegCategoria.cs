using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CE;
using CD;

namespace CN
{
    public class NegCategoria
    {
        AbmCategoria ObjDatosCategorias = new AbmCategoria();
        //LISTADO DE DATOS
        public List<Categorias> ObtenerCategorias()
        {
            return ObjDatosCategorias.ObtenerCategorias();
        }
    }
}
