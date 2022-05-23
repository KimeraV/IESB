using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercicio_Extra
{
    class Program
    {
        static void Main(string[] args)
        {


        }

        private static void LoadConfigs()
        {

            String diretorioRaizConfig = Directory.GetParent(
            Directory.GetCurrentDirectory()).Parent.FullName;

            var pastaConfig = Path.Combine(diretorioRaizConfig, "Config");
            if (!Directory.Exists(pastaConfig))
            {
                Directory.CreateDirectory(pastaConfig);
            }
            String nomeArquivo = "teste.txt";
            var nomeArquivoCompleto = Path.Combine(pastaConfig, nomeArquivo);
            if (!File.Exists(nomeArquivoCompleto))
            {
                File.Create(Path.Combine(pastaConfig, nomeArquivo));
            }
        }
    }
}
