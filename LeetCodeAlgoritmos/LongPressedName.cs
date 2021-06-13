namespace LeetCodeAlgoritmos
{
    public class LongPressedName
    {
        public bool IsLongPressedName(string name, string typed)
        {
            int tamanhoNome = name.Length, tamanhoDigitado = typed.Length;

            if (tamanhoDigitado < tamanhoNome)
            {
                return false;
            }

            int indiceNome = 0, indiceDigitado = 0;

            while (indiceDigitado < tamanhoDigitado)
            {
                if (indiceNome < tamanhoNome && name[indiceNome] == typed[indiceDigitado])
                {
                    indiceNome++;
                }
                else if (indiceDigitado == 0 || typed[indiceDigitado] != typed[indiceDigitado - 1])
                {
                    return false;
                }
                indiceDigitado++;
            }

            return indiceNome == tamanhoNome;
        }
    }
}
