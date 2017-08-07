using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Billing
{
    class Validation
    {
        public static void nokey(KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        public static void validdec(KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.')
                    e.Handled = true;

            }
            catch
            {
                throw;
            }
        }

        public static void validnum(KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                    e.Handled = true;

            }
            catch
            {
                throw;
            }
        }
        public static void validchar(KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '@' && e.KeyChar != ' ')
                    e.Handled = true;

            }
            catch
            {
                throw;
            }
        }
        public static void validcharnum(KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8)
                    e.Handled = true;

            }
            catch
            {
                throw;
            }
        }
    }
}
