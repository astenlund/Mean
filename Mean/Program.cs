using System;
using System.Windows.Forms;

namespace Mean
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var sum = 0;
            var denom = 0;

            foreach (var s in args)
            {
                int term;

                if (int.TryParse(s, out term))
                {
                    sum += term;
                    ++denom;
                }
            }

            if (denom > 0)
            {
                var mean = sum/denom;

                Clipboard.SetText(mean.ToString());
                Console.WriteLine(mean);
            }
        }
    }
}
