namespace Calculadora.Ast
{
    public class Resta : Operacion
    {
        public override double Run()
        {
            return expresion1.Run() - expresion2.Run();
        }
    }
}
