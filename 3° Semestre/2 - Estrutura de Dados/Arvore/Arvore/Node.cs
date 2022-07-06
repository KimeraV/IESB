namespace Arvore
{
    class Node
    {
        public string Nome { get; private set; }
        public Node Esquerda { get; private set; }
        public Node Direita { get; private set; }

        public Node(string nome, Node esquerda = null, Node direita = null)
        {
            Nome = nome;
            Esquerda = esquerda;
            Direita = direita;
        }
    }
}
