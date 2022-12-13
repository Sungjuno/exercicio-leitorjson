using System.Text.Json;

namespace LeitorJson;

    class Program

    {

        public static void Main(string[] args)

        {
        var quantidadeArquivo = Directory.GetFiles("/Users/sung/Projects/exercicioCsharp00/exercicioCsharp00/imports");
        var listaClientes = new List<Cliente>() { };

        for ( int i = 1; i <= quantidadeArquivo.Length; i++)
        {
            var text = File.ReadAllText($"/Users/sung/Projects/exercicioCsharp00/exercicioCsharp00/imports/clientes{i}.json");
            var jsonClienteObjeto = JsonSerializer.Deserialize<Cliente>(text, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            if(jsonClienteObjeto != null)
            {
                listaClientes.Add(jsonClienteObjeto);
            }
            Console.WriteLine(listaClientes[i-1].Nome + "  ----  " + listaClientes[i-1].Telefone);
        }

        foreach( var arquivo in quantidadeArquivo) { }

    }


    }

    class Cliente

    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
    }
