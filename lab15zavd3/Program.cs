using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Globalization;

namespace lab15zavd3
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = "";
            string txt;

            txt = Interaction.InputBox("...", "Введіть текст: ", ".капец.");
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            char[] arr = txt.ToCharArray();
            
            arr[0] = ti.ToUpper(arr[0]);

            for (int i = 0; i < arr.Length - 1; i++)
                if (arr[i] == ' ')
                    arr[i+1] = ti.ToUpper(arr[i+1]);

            foreach (char j in arr)
                output += j;

            MessageBox.Show($"Вхідний рядок: {txt}\nОброблений рядок: {output}", "Результат", MessageBoxButtons.OK);

        }
    }
}
