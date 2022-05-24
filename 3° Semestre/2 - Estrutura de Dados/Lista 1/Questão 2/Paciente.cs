
namespace Questão_2
{
    public class Paciente
    {
        public string Nome { get; private set; }
        public string Especialidade { get; private set; }
        
        public Paciente(string nome, string especialidade)
        {
            Nome = nome;
            Especialidade = especialidade;
        }

    }
}
