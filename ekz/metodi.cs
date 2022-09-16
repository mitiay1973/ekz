using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace ekz
{
    public class metodi
    {
        public double procent; 

        public double Vklad(double symma, double procent)
        {
            symma += symma * procent;
            return symma;
        }
        public double Komissia(double symma)
        {
            double kommisia=0;
            if (procent>0.13)
            {
                kommisia = Vklad(symma, procent);
            }
            return kommisia;
        }
        public double Procenti(double symma_vklada, int time_vklada) // Модуль нахождения процента по вкладу
        {
            if(symma_vklada < 700000)
            {
                if(symma_vklada >=0 & symma_vklada < 50000)
                {
                    procent = 0.01;
                }
                else if(symma_vklada >= 50000 & symma_vklada < 100000)
                {
                    procent = 0.02;
                }
                else if (symma_vklada >= 100000 & symma_vklada < 150000)
                {
                    procent = 0.03;
                }
                else if (symma_vklada >= 150000 & symma_vklada < 200000)
                {
                    procent = 0.04;
                }
                else if (symma_vklada >= 200000 & symma_vklada < 250000)
                {
                    procent = 0.05;
                }
                else if (symma_vklada >= 250000 & symma_vklada < 300000)
                {
                    procent = 0.06;
                }
                else if (symma_vklada >= 300000 & symma_vklada < 350000)
                {
                    procent = 0.07;
                }
                else if (symma_vklada >= 350000 & symma_vklada < 400000)
                {
                    procent = 0.08;
                }
                else if (symma_vklada >= 400000 & symma_vklada < 450000)
                {
                    procent = 0.09;
                }
                else if (symma_vklada >= 450000 & symma_vklada < 500000)
                {
                    procent = 0.1;
                }
                else if (symma_vklada >= 500000 & symma_vklada < 550000)
                {
                    procent = 0.11;
                }
                else if (symma_vklada >= 550000 & symma_vklada < 600000)
                {
                    procent = 0.12;
                }
                else if (symma_vklada >= 600000 & symma_vklada < 650000)
                {
                    procent = 0.13;
                }
                else if (symma_vklada >= 650000 & symma_vklada < 700000)
                {
                    procent = 0.14;
                }
            }
            else if(symma_vklada >= 700000 )
            {
                if (symma_vklada >= 700000 & symma_vklada < 750000)
                {
                    procent = 0.2;
                }
                else if (symma_vklada >= 750000 & symma_vklada < 800000)
                {
                    procent = 0.19;
                }
                else if (symma_vklada >= 800000 & symma_vklada < 850000)
                {
                    procent = 0.18;
                }
                else if (symma_vklada >= 850000 & symma_vklada < 900000)
                {
                    procent = 0.17;
                }
                else if (symma_vklada >= 900000 & symma_vklada < 950000)
                {
                    procent = 0.16;
                }
                else if (symma_vklada >= 950000 & symma_vklada < 1000000)
                {
                    procent = 0.15;
                }
            }
            for (int i = 0; i <= time_vklada; i++)
            {
                if(i % 3 == 0)
                {
                    procent += 0.5;
                }
            }
            return procent-0.5;
        }
    }
}
