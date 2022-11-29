using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio03_fixacao
{
    internal class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;


        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public double PontosFaltantes()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - NotaFinal();
            }
        }

        public bool Aprovado()
        {
            if (NotaFinal() > 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
