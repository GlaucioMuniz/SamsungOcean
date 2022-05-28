using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoElevadorDoc.Models;
using ProjetoElevadorDoc.Views;

namespace ProjetoElevadorDoc.Controllers
{
    internal class ElevadorController
    {

        ElevadorView elevadorView = new ElevadorView();

        public void MostrarTela()
        {
            elevadorView.Tela();
        }

    }
}
