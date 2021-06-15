using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D2Code {
    public static class FormHelper {
        public static void centerControlHalf(Form window, Control control) {
            //Point p = new Point();
            control.Left = (window.Width / 2) - (control.Width / 2) - 8;

            //control.Location = p;
        }
        
        // Center control at end of quartile 1
        public static void centerControlQ1(Form window, Control control) {
            control.Left = (window.Width / 4) - (control.Width / 2) - 8;
        }

        // Center control at end of quartile 3
        public static void centerControlQ3(Form window, Control control) {
            control.Left = (window.Width / 4) + (window.Width / 2) - (control.Width / 2) - 15;
        }

        // Splits date from date time - returning date
        public static String getDateFromDT(String date) {
            String[] tokens = date.Split(' '); 
            return tokens.Length == 0 ? "null" : tokens[0];
        }
    }
}
