using System;

namespace Pr06_1_1
{
    enum Frequency
    {
        Weekly,
        Monthly,
        Yearly
    };
    class Article
    {
        public Person Autor { get; set; }
        public string Artic { get; set; }
        public double Rait { get; set; }
        public Article(Person autor, string artic, double rait)
        {
            Autor = autor;
            Artic = artic;
            Rait = rait;
        }
        public Article()
        {
            Autor = null;
            Artic = "";
            Rait = 0;
        }
        public override string ToString()
        {
            return $"Автор:{Autor.ToString()}\nстатья:{Artic}\nРейтинг{Rait.ToString()}";
        }
    }
    class Magazine
    {
        private string NameMag;
        private Frequency Freque;
        private DateTime DataPub;
        private int Terag;
        private Article[] ListState;

        public string namemag
        {
            get
            {
                return this.NameMag;
            }
            set
            {
                this.NameMag = value;
            }
        }
        public Frequency freque
        {
            get
            {
                return this.Freque;
            }
            set
            {
                this.Freque = value;
            }
        }
        public DateTime datapub
        {
            get
            {
                return this.DataPub;
            }
            set
            {
                this.DataPub = value;
            }
        }
        public int terag
        {
            get
            {
                return this.Terag;
            }
            set
            {
                this.Terag = value;
            }
        }
        public Article[] liststate
        {
            get
            {
                return this.ListState;
            }
            set
            {
                this.ListState = value;
            }
        }
        public Magazine(string Namemag, Frequency Freque, DateTime Datapub, int Terag)
        {
            namemag = Namemag;
            freque = Freque;
            datapub = Datapub;
            terag = Terag;
        }
        public Magazine()
        {
            namemag = "";
            freque = new Frequency();
            datapub = new DateTime(0,0,0);
            terag = 0;
        }
        public double SRrat
        {
            get
            {
                double RT=0;
                for(int i=0;i<liststate.Length;i++)
                {
                    RT += liststate[i].Rait;
                }
                return RT / liststate.Length;
            }
        }
        bool this[Frequency freque]
        {
            get
            {
               
            }
        }
    }
    
    class Program
  {
    static void Main(string[] args)
    {
      
    }
  }
}
