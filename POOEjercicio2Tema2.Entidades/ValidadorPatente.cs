namespace POOEjercicio2Tema2.Entidades
{
    public static class ValidadorPatente
    {

        public static bool Validar(string patente)
        {
            if (patente == null || (patente.Length != 7 && patente.Length != 9))
            {
                return false;
            }
            if (patente.Length == 7)
            {
                return ValidarPatenteVieja(patente);
            }
            else
            {
                return ValidarPatenteNueva(patente);
            }

        }

        private static bool ValidarPatenteNueva(string patente)
        {
            var array = patente.Split(' ');
            var parteAlfa1 = array[0];
            var parteNum = array[1];
            var parteAlfa2 = array[2];
            return ValidarParteAlfa(parteAlfa1)
                && ValidarParteNum(parteNum)
                && ValidarParteAlfa(parteAlfa2);

        }

        private static bool ValidarPatenteVieja(string patente)//AAA NNN
        {
            var array = patente.Split(' ');
            var parteAlfa = array[0];
            var parteNum = array[1];
            return ValidarParteAlfa(parteAlfa) && ValidarParteNum(parteNum);
        }
        private static bool ValidarParteAlfa(string parteAlfa)
        {
            foreach (var item in parteAlfa)
            {
                if (!char.IsLetter(item))
                {
                    return false;
                }
            }
            return true;
        }
        private static bool ValidarParteNum(string parteNum)
        {
            foreach (var item in parteNum)
            {
                if (!char.IsNumber(item))
                {
                    return false;
                }
            }
            return true;
        }


        public static string GetTipo(string patente)
        {
            if (patente == null)
            {
                return "Patente no ingresada";
            }

            else if (patente.Length == 7)
            {
                return "Patente Vieja";
            }
            else if (patente.Length == 9)
            {
                return "Patente Nueva";
            }
            else
            {
                return "Formato no válido";
            }

        }
    }    
}