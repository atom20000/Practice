using Microsoft.VisualBasic.FileIO;
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
            return $"Автор:{Autor.ToString()}\nстатья:{Artic}\nРейтинг{Rait}\n";
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
                this.ListState=value;
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
            datapub = new DateTime();
            terag = 0;
            liststate = null;
        }
        public double SRrat
        {
            get
            {
                double RT=0;
                for(int i=0;i < (liststate?.Length ?? 0);i++)
                {
                    RT += liststate[i].Rait;
                }
                return RT / liststate?.Length ?? 0;
            }
        }
        public bool this[Frequency fReque]
        {
            get
            {
                if(freque==fReque) {
                    return true;
                }
                else return false;
            }
        }
        public void AddArticles(params Article[] articles)
        {
            Article[] promeg = new Article[liststate.Length + articles.Length];
            for(int i = 0; i < liststate.Length; i++)
            {
                promeg[i] = liststate[i];
            }
            for (int i = 0; i < articles.Length; i++)
            {
                promeg[liststate.Length + i] = articles[i];
            }
            liststate = promeg;
        }
        public override string ToString()
        {
            string yse="";
            yse += $"Название:{namemag}\nПереодичность выхода:{freque}\nДата выхода:{datapub.Date}\nТираж:{terag}\nРейтинг:{SRrat}\nСтатьи:\n";
            if (liststate != null)
            {
                foreach (Article article in liststate)
                {
                    yse += article.ToString();
                }
            }
            return yse;
        }
        public virtual string ToShortString()
        {
            return $"Название:{namemag}\nПереодичность выхода:{freque}\nДата выхода:{datapub.Date}\nТираж:{terag}\nРейтинг:{SRrat}\n";
        }
    }
    
    class Program
  {
    static void Main(string[] args)
    {
            Magazine mag = new Magazine();
            Console.WriteLine(mag.ToShortString());
            Console.WriteLine(mag[Frequency.Weekly]);
            Console.WriteLine(mag[Frequency.Monthly]);
            Console.WriteLine(mag[Frequency.Yearly]);
            mag.namemag = "zver";
            mag.terag = 5;
            mag.freque = Frequency.Monthly;
            mag.datapub = new DateTime(2015, 6, 8);
            Article[] articles = new Article[5];
            Person[] autor = new Person[3];
            autor[0] = new Person("Nom","Nomuch",new DateTime(1990,8,19));
            autor[1] = new Person("Tom", "Tomuch", new DateTime(1980, 12, 26));
            autor[2] = new Person("NoK", "NoKuch", new DateTime(1940, 2, 29));
            articles[0] = new Article(autor[0], "Volk", 7.9);
            articles[1] = new Article(autor[1], "Bear", 9.9);
            articles[2] = new Article(autor[2], "Karac", 5.5);
            articles[3] = new Article(autor[2], "Vorober", 6.9);
            articles[4] = new Article(autor[1], "Fish", 8.9);
            mag.liststate = articles;
            Console.WriteLine(mag.ToString());
            articles = new Article[2];
            articles[0] = new Article(autor[1], "Sazan", 1.9);
            articles[1] = new Article(autor[0], "Hunter", 9.9);
            mag.AddArticles(articles);
            Console.WriteLine(mag.ToString());
        }
  }
}
