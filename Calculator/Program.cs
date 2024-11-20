using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // soma();
            // subtracao();
            // Divisao();
            //multiplicacao();
            TelaDeBoasVindas();
            Menu(); 

        }
        
        static void TelaDeBoasVindas()
        {
            Console.Clear();
            Console.WriteLine("seja bem vindo");
            Console.WriteLine("Digite seu Nome e Sobrenome, para fazer login");
            string usuario = "";
            string  Senha = "";

            while (usuario != "Paulo" && Senha != "040704Pc")
            {
                Console.WriteLine("Digite seu usuario: ");
                usuario = (Console.ReadLine());
                Console.WriteLine("Digite sua senha: ");
               Senha = (Console.ReadLine());

               if (usuario != "Paulo" || Senha != "040704Pc")
               {
                   Console.WriteLine("Digite a senha novamente, ocorreu um erro! ");   
               }

            }
            Console.WriteLine("Parabens voce entrou.");


        }

        static void Menu()
        {
            
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");
            

            Console.WriteLine("---------");
            Console.WriteLine("Selecione uma das opições:");
            
            short resultado = short.Parse(Console.ReadLine()); // Aqui usamos o short.Parse , porque ela e uma String, fazendo a converção

            switch (resultado)// Fazer com que seja feito as operações
            {
                case 1: Soma();
                    break;
                case 2: Subtracao();
                    break;
                case 3: Divisao();
                    break;
                case 4: Multiplicacao();
                    break;
                case 5: 
                    TelaDeAgradecimento();  break;// tou chamando a tela de agradecimento, assim que a pessoa apertar em Sair.
                default: 
                   Menu(); break;
                
            }

        }

        static void Soma()
        {
            Console.Clear();
            
            Console.WriteLine("Digite o primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            var resultado = v1 + v2;
            Console.WriteLine($"Soma total è:  {resultado}");

            Console.ReadKey();
            Menu();// estamos chamando novamente o Menu(); para que nosso programa nao feche ao aertarmos Enter, ele sempre voltara para o Menu.

        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o primeiro valor:");
            float v2 = float.Parse(Console.ReadLine());

            var resultado = v1 - v2;
            Console.WriteLine($"o resultado dessa subtração e : {resultado}");
            
            Console.ReadKey();
            Menu();// estamos chamando novamente o Menu(); para que nosso programa nao feche ao aertarmos Enter, ele sempre voltara para o Menu.
        }

        static void Divisao()
        {
            Console.Clear();
            
            Console.WriteLine("Digite o primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o primeiro valor:");
            float v2 = float.Parse(Console.ReadLine());

            var resultado = v1 / v2;
            Console.WriteLine($"Valor total dessa divisão è: {resultado}");
            
            Console.ReadKey();
            Menu();// estamos chamando novamente o Menu(); para que nosso programa nao feche ao aertarmos Enter, ele sempre voltara para o Menu.

        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o primeiro valor:");
            float v2 = float.Parse(Console.ReadLine());

            var resultado = v1 * v2;
            Console.WriteLine($"o resultado dessa subtração e : {resultado}");
            
            Console.ReadKey();
            Menu();// estamos chamando novamente o Menu(); para que nosso programa nao feche ao aertarmos Enter, ele sempre voltara para o Menu.
        }

        static void  TelaDeAgradecimento()
        {
            Console.Clear();
            Console.WriteLine("Obrigado por utilizar nossa Calculadora!");
            Console.WriteLine("Espero que sua esperiencia tenha cido gratificante");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
           System.Environment.Exit(0);
           /*
            * Colocamos o System.Enviroment.Exit(0); na tela de agradecimento , poque eu ao terminar 
            */
           
        }

        
    }
}