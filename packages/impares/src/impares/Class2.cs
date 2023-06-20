using Pares.Pares;

namespace Impares.Impares;

public static class Class2
{
    public static bool EsImPar(int number)
    {
        if (!Class1.EsPar(number))
        {
            return true;

        }
        return false;
    }
}