using System;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Windows.Forms;

public static class Validacao
{
    public static bool ValidaCPF(string cpf)
    {
        cpf = cpf.Replace(".", "");
        cpf = cpf.Replace("-", "");

        int[] cpf2 = new int[11];
        for (int i = 0; i < cpf2.Length; i++)
        {
            cpf2[i] = Convert.ToInt32(cpf[i].ToString());
        }

        if (cpf.Length != 11)
        {
            return false;
        }

        int[] caracteres = new int[9];

        for (int i = 0; i < caracteres.Length; i++)
        {
            caracteres[i] = Convert.ToInt32(cpf[i].ToString());
        }

        int soma = 0;

        for (int i = 0, j = 10; i < caracteres.Length && j > 1; i++, j--)
        {
            int calc = caracteres[i] * j;
            soma += calc;
        }


        int calc1 = soma % 11;
        int num10 = Convert.ToInt32(cpf2[9]);
        if (calc1 < 2)
        {
            if (num10 != 0)
            {
                return false;
            }
        }
        else if (calc1 >= 2)
        {
            if ((11 - calc1) != num10)
            {
                return false;
            }
        }

    //verificação 2
        int[] caracteres2 = new int[10];

        for (int i = 0; i < caracteres2.Length; i++)
        {
            caracteres2[i] = Convert.ToInt32(cpf[i].ToString());
        }

        int soma2 = 0;
        for (int i = 0, j = 11; i < caracteres2.Length && j > 1; i++, j--)
        {
            int calc = caracteres2[i] * j;
            soma2 += calc;

        }


        int calc2 = soma2 % 11;
        int num11 = Convert.ToInt32(cpf2[10]);
        if (calc2 < 2)
        {
            if (num11 != 0)
            {
                return false;
            }
        }

        else if (calc2 >= 2)
        {
            if ((11 - calc2) != num11)
            {
                return false;
            }
        }

        return true;
    }
}