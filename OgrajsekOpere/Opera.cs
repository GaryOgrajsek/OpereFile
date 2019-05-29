namespace Opere {
    class Opera {
        private int codice;
        private string autore;
        private string titolo;
        private int anno;
        private byte tipo;

        //Incapsulamento degli attributi Codice, Autore, Titolo, Anno, Tipo
        public int Codice { get => codice; set => codice = value; }
        public string Autore { get => autore; set => autore = value; }
        public string Titolo { get => titolo; set => titolo = value; }
        public int Anno { get => anno; set => anno = value; }
        public byte Tipo { get => tipo; set => tipo = value; }

        //Costruttore generico
        public Opera() {}

        //Costruttore che permette l'inizializzazione degli attributi
        public Opera(int c, string a, string t, int an, byte ti) {
            Codice = c;
            Autore = a;
            Titolo = t;
            Anno = an;
            Tipo = ti;
        }

        //ToString per permettere la visualizzazione nella DataGridView o nella funzione ricerca
        public override string ToString() => Codice + "|" + Autore + "|" + Titolo + "|" + Anno + "|" + Tipo + "\n";
    }
}