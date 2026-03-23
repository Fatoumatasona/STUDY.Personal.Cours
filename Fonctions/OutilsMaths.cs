using System;
using System.Collections.Generic;
using System.Text;

namespace Fonctions
{

    /// <summary>
	/// Fournit des fonctions mathématiques supplémentaires par rapport à celles de .Net
	/// </summary>
    internal class OutilsMaths
    {
        public static double GetValeurMaxi(params double[] nombres)
        {
            double max = double.MinValue;
            for (int i = 0; i < nombres.Length; i++)
            {
                if (nombres[i] > max) max = nombres[i];
            }

            return max;
        }
    }
}
