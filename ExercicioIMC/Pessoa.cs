namespace ExercicioIMC
{
    public class Pessoa
    {
        public double peso, altura;
        public double IMC()
        {
            return peso / (altura * altura);
        }
        public string situacaoIMC(double imcPessoa)
        {
            string message = "";

            if (imcPessoa < 18.5)
            {
                return message = "Abaixo do peso";
            }
            else if (imcPessoa < 25)
            {
                return message = "Peso normal!";
            }
            else if (imcPessoa < 30)
            {
                return message = "Acima do peso";
            }
            else if (imcPessoa < 35)
            {
                return message = "Obesidade do tipo I";
            }
            else if (imcPessoa < 40)
            {
                return message = "Obesidade do tipo II";
            }
            else
            {
                return message = "Obesidade do tipo III";
            }
        }
        public void imprimirMessage()
        {
           
                double resultado;
                string situacao;

                resultado = IMC();
                situacao = situacaoIMC(resultado);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O resultado do cálculo do IMC é: " + resultado.ToString("F2") + "% gordura corporal\n\nSua situação de peso é: " + situacao+"\n\n");
                Console.ForegroundColor = ConsoleColor.White;
                
        }
    }
}