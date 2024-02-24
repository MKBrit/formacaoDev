using System;

namespace Explicacoes
{
    class Publicador
    {
        public delegate void TrabalhoFeitoEventHandler(object sender, EventArgs args);
        public event TrabalhoFeitoEventHandler TrabalhoFeito;

        public void Processaumtrabalho()
        {
            Console.WriteLine("Publicador: Um trabalho foi concluído");
            OnTabalhoFeito();
        }
        protected virtual void OnTabalhoFeito()
        {
            if (TrabalhoFeito != null)
                TrabalhoFeito(this, EventArgs.Empty);
        }
    }

    class Subscritor
    { 
        public void OnTrabalhoFeitoEventHandler(object sender, EventArgs args) 
        {
            Console.WriteLine("O subscritor foi notificado");
        }
    }

    class Program 
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Evento exemplo");
            Publicador remetente = new Publicador();
            Subscritor receptor = new Subscritor();

            remetente.TrabalhoFeito += receptor.OnTrabalhoFeitoEventHandler;

            remetente.Processaumtrabalho();
            Console.ReadKey();
        }
    }
}