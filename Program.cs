using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApiSimplesConsultaCep
{
    class Program
    {
        const string BrasilApiCep = "https://brasilapi.com.br/api/cep/v1/"; // Usando a API do Brasil API
        static async Task Main()
        {
            Console.WriteLine("Bem vindo ao sistema de consulta de CEP. \n"+
                              "Pressione qualquer tecla para iniciar.");
            Console.ReadKey();

            while(true)
            {
                Console.Clear();
                Console.WriteLine("Escolha uma das seguintes opções e tecle ENTER");
                Console.Write("1: Para digitar o CEP. \n" +
                              "2: Para sair. \n" +
                              "Sua opção: ");
            
                int opcao = int.TryParse(Console.ReadLine(), out opcao) ? opcao : 0;
                Console.Clear();
                if (opcao != 0) Console.WriteLine($"Você digitou {opcao}! \n");

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o CEP com apenas números: ");
                        
                        if(uint.TryParse(Console.ReadLine(), out uint cepDigitado))
                            await ConsultaCep(cepDigitado.ToString());
                        else
                            Console.WriteLine("Erro de digitação!");

                        Console.WriteLine("\nPressione qualquer tecla para VOLTAR. \n");
                        Console.ReadKey();
                    break;

                    case 2:
                        Console.WriteLine("Obrigado por utilizar nossos serviços!");
                        Console.WriteLine("Pressione qualquer tecla para SAIR.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    break;
                    
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida! Pressione qualque tecla para VOLTAR. \n");
                        Console.ReadKey();
                    break;
                }          
                
            }
        }


        static async Task ConsultaCep(string cep)
        {
            // Cria uma instância de HttpClient 
            using (HttpClient client = new HttpClient())
            {
                Console.WriteLine();
                try
                {
                    // GET request para o endpoint da API
                    HttpResponseMessage response = await client.GetAsync(BrasilApiCep + cep);

                    // Verifica comunicação Ok (Status code 200)
                    if (response.IsSuccessStatusCode)
                    {
                        // Lê conteúdo como string
                        string responseBody = await response.Content.ReadAsStringAsync();
                    
                        // Imprime status com código e resultado da requisição
                        Console.WriteLine($"Resposta: {(int)response.StatusCode} = {response.StatusCode}");
                        Console.WriteLine($"{responseBody}");
                    }
                    else 
                    {
                        Console.WriteLine($"Request failed with status code:  {((int)response.StatusCode)} = {response.StatusCode}.");
                        Console.WriteLine($"*** CEP < {cep} > não encontrado ***");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            } // A instrução using chama automaticamente Dispose() na instância HttpClient
        }
    }
}


