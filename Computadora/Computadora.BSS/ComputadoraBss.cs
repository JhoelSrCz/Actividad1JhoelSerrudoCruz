using Computadora.DAL;
using Computadora.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadora.BSS
{
    public class ComputadoraBss
    {
        ComputadoraDal dal = new ComputadoraDal();
        public DataTable ListarComputadoraBss()
        {
            return dal.ListarComputadoraDal();
        }
        public void InsertarComputadoraBss(Computadoras computadoras)
        {
            dal.InsertarComputadoraDal(computadoras);
        }
        public Computadoras ObtenerIdBss(int id)
        {
            return dal.ObtenerPersonaId(id);
        }
    }
}
