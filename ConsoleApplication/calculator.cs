namespace ConsoleApplication

{

    public class Calculator
    {
        int _resultat = 0;

        public void Add(int X)
        {
            _resultat = _resultat + X;
        }

public void Minus(int x)
{
_resultat = _resultat - x;
}

public void Multiply(int x)
{
_resultat = _resultat * x;
}

public void Divide(int x)
{
_resultat = _resultat / x;

}








        public int Resultat()
        {
            return _resultat;
        }
    }
}

