using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Dado
{
    class Dado
    {
        private int[] dado;
        private int[] Velores;
        private int num;
        public Dado()
        {
            dado = new int[6];
            Velores = new int[11];
            Thread.Sleep(1);
            num = 0;
        }
        Random ran = new Random(DateTime.Now.Millisecond);
        Random ran2 = new Random(DateTime.Now.Millisecond);
       
          
        
        public void Lanzar()
        {
            num = 0;
            num = ran.Next(1, 7);
            switch (num) 
            {
                case 1:
                    dado[num - 1] += 1;
                    break;
                case 2:
                    dado[num - 1] += 1;
                    break;
                case 3:
                    dado[num - 1] += 1;
                    break;
                case 4:
                    dado[num - 1] += 1;
                    break;
                case 5:
                    dado[num - 1] += 1;
                    break;
                case 6:
                    dado[num - 1] += 1;
                    break;
            }                     
        }
        public override string ToString()
        {
            string Ret="";
            for (int a = 0; a < 6; a++)
            {
                Ret += "Cara " + (a + 1) + " cayo " + dado[a]+" veces."+Environment.NewLine;
            }

            return Ret;
        }
        public void Ran2()
        {
            num = ran.Next(1, 7);
            num += ran.Next(1, 7);
        }

        public void Ran3()
        {            
            num = ran.Next(1, 7);
            num += ran2.Next(1, 7);
        }

        public void Lanzar2()
        {
           
            switch (num)
            {
                case 2:
                    Velores[num - 2] += 1;
                    break;
                case 3:
                    Velores[num - 2] += 1;
                    break;
                case 4:
                    Velores[num - 2] += 1;
                    break;
                case 5:
                    Velores[num - 2] += 1;
                    break;
                case 6:
                    Velores[num - 2] += 1;
                    break;
                case 7:
                    Velores[num - 2] += 1;
                    break;
                case 8:
                    Velores[num - 2] += 1;
                    break;
                case 9:
                    Velores[num - 2] += 1;
                    break;
                case 10:
                    Velores[num - 2] += 1;
                    break;
                case 11:
                    Velores[num - 2] += 1;
                    break;
                case 12:
                    Velores[num - 2] += 1;
                    break;
            }
            
        }
        public void clear()
        {
            dado = new int[6];
            Velores = new int[11];
        }
        public string toStringVelores()
        {
            string Ret = "";
            for (int a = 0; a < 11; a++)
            {
                Ret += "El valor " + (a + 2) + " cayo " + Velores[a] + " veces." + Environment.NewLine;
            }
            return Ret;
        }
    }
}

    

