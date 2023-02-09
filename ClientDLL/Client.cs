using System.Runtime.CompilerServices;

namespace ClientDLL
{
    public class Client
    {
        private int num;
        private string nom;
        private float ca;
        private int cat;

        public int Num { get => num; }
        public string Nom { get => nom; }
        public float Ca { get => ca; }
        public int Cat { get => cat; }

        public Client(int numC, string nomC, float caC, int catC)
        {
            this.num = numC;
            this.nom = nomC;
            this.ca = caC;
            if (catC >= 1 && catC <= 3)
            {
                this.cat = catC;
            }
        }
    }
}