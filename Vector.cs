using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexLayout
{
    internal class Vector
    {
        int[] v = new int[100];
        int n;

        public Vector()
        {
            n = 0;
        }

        public void Insert(int value)
        {
            v[n] = value;
            n++;
        }

        public int MaxPos()
        {
            int p = 0, max = v[0];

            for (int i = 1; i < n; i++)
                if (v[i] > max)
                {
                    max = v[i];
                    p = i;
                }

            return p;
        }

        public float Average()
        {
            int sum = 0;

            for (int i = 0; i < n; i++)
                sum = sum + v[i];

            sum = sum / n;

            return sum;
        }

        public int DeleteElement(int pos)
        {
            if (pos < n)
            {
                for (int i = pos; i < n; i++)
                    if (i != n - 1)
                        v[i] = v[i + 1];
                    else
                        Array.Resize<int>(ref v, n);
                n--;
                return 0;
            }
            else
                return -1;
        }

        public string VecToString()
        {
            string str = "";
            for (int i = 0; i < n; i++)
                str = str + v[i] + "\n";
            return str;
        }

        public string ToStringPos(int pos)
        {
            string str;
            if (pos < n)
                return str = v[pos].ToString();
            else
                return str = $"Posizione {pos} inesistente";
        }
    }
}
