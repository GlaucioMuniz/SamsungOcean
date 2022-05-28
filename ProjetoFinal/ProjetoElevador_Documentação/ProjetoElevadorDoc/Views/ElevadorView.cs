using ProjetoElevadorDoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevadorDoc.Views
{
    public class ElevadorView
    {
        Models.Elevador elevador = new Elevador();

        public void Tela()
        {
            elevador.Menu();
        }



    }
}
