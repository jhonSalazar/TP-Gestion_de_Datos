using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using FrbaHotel.AbmHabitacion.Clases;
using System.Windows.Forms;
using System.Drawing;
using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace FrbaHotel.Validadores
{
    class ValidadorFormatoEmail: Validador, Validaciones
    {
        private TextBox txt_Email;
        private Label labelEmail;

        bool invalido = false;

        public ValidadorFormatoEmail()
        {
            txt_Email = new TextBox();
        }

        public Boolean validar()
        {
            invalido = false;
            if (String.IsNullOrEmpty(txt_Email.Text))
                return false;

                // Use IdnMapping class to convert Unicode domain names.
                string mail = Regex.Replace(txt_Email.Text, @"(@)(.+)$", this.DomainMapper);
                if (invalido)
                    labelEmail.Text = "El formato de Mail es incorrecto, ingrese algo similar a xxxxx@yyyyy.zzz";
                    labelEmail.ForeColor = System.Drawing.Color.Red;
                    return false;

                    // Return true if strIn is in valid e-mail format.
                    if (!(Regex.IsMatch(mail,
                            @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                            @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$",
                            RegexOptions.IgnoreCase)))
                    {
                        labelEmail.Text = "El formato de Mail es incorrecto, ingrese algo similar a xxxxx@yyyyy.zzz";
                        labelEmail.ForeColor = System.Drawing.Color.Red;
                        return false;
                    }
                    else
                    {
                        return true;
                    }
          }

        private string DomainMapper(Match match)
        {
            // IdnMapping class with default property values.
            IdnMapping idn = new IdnMapping();

            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                invalido = true;
            }
            return match.Groups[1].Value + domainName;
        }

        public void agregarEmail(TextBox email)
        {
            //txt_Email = email;
        }

        public void limpiarLabel()
        {
           // labelEmail.Text = "";
        }


        public void limpiar()
        {
           // txt_Email.Clear();
        }
    }
}
