using MySqlX.XDevAPI;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using static Atividade1Matheus.API;

namespace Atividade1Matheus
{
    internal class API
    {
        public class Endereco
        {
            public string Cep { get; set; }
            public string Logradouro { get; set; }
            public string Complemento { get; set; }
            public string Unidade { get; set; }
            public string Bairro { get; set; }
            public string Localidade { get; set; }
            public string Uf { get; set; }
            public string Estado { get; set; }
            public string Regiao { get; set; }
            public string Ibge { get; set; }
            public string Gia { get; set; }
            public string Ddd { get; set; }
            public string Siafi { get; set; }
        }

        public static async Task<Endereco> getDados()
        {
            Endereco e = new Endereco();
            using HttpClient client = new ();
            var endereco = await client.GetFromJsonAsync<Endereco>("https://viacep.com.br/ws/01001000/json/");
            e.Cep = endereco.Cep;
            e.Logradouro = endereco.Logradouro;
            e.Bairro = endereco.Bairro;
            
            return e;
        }
    }
}
