using CAECE.JL.Unter.Server.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Datos
{
    public class RepoMesa : RepoAbstracto, IRepoMesa
    {

        public RepoMesa(ContextoDatosUnter contextoDatosUnter):base(contextoDatosUnter)
        {
                
        }
      
    }
}
