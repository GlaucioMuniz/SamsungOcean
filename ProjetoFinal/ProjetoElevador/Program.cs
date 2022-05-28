using System;
using ProjetoElevador.Controllers;

namespace ProjetoElevador
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            ElevadorController controller = new ElevadorController();

            controller.MostrarTela();
            
        }
    }
}
