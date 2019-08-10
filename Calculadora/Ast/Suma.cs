namespace Calculadora.Ast
{
    public class Suma : Operacion
    {
        public override double Run()
        {
            return expresion1.Run() + expresion2.Run();
        }
    }
}
