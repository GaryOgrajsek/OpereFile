using System;
using System.Collections.Generic;
using System.IO;

namespace Opere {
    class GestioneFile {

        /*Il programma apre un file di nome "codice.txt" e legge il codice passato precedentemente
        dalla classe Museo per poter proseguire correttamente la numerazione*/ 
        public int CaricaCodice() {
            try {
                FileStream fs = new FileStream("codice.txt", FileMode.Open);
                BinaryReader br = new BinaryReader(fs);
                int c = br.ReadInt32();
                br.Close();
                fs.Close();
                return c;
            } //Se il file non esiste, il primo elemento sarà nella posizione 1.
            catch (Exception) {
                return 1;
            }
        }

        /*Il programma apre un file di nome "codice.txt" e inserisce il codice passato
        dalla classe Museo per poter salvare il codice e proseguire correttamente la numerazione*/
        public void SalvaCodice(int c) {
            FileStream fs = new FileStream("codice.txt", FileMode.OpenOrCreate);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(c);
            bw.Close();
            fs.Close();
        }

        public void Inserisci(Opera o) {
            //Apre il file
            FileStream fs = new FileStream("file.txt", FileMode.Append);
            BinaryWriter bw = new BinaryWriter(fs);

            //Inserisce i dati, spazia autorore e titolo di 50.
            bw.Write(o.Codice);
            bw.Write(o.Autore.PadRight(50, ' '));
            bw.Write(o.Titolo.PadRight(50, ' '));
            bw.Write(o.Anno);
            bw.Write(o.Tipo);

            bw.Close();
            fs.Close();
        }

        public List<Opera> visualizzaOpere() {
            try {
                //Apre i file e crea una lista
                FileStream fs = new FileStream("file.txt", FileMode.Open);
                BinaryReader br = new BinaryReader(fs);
                List<Opera> tmp = new List<Opera>();

                /*inché il binaryreader non arriva alla fine, legge i dati. Titolo e Autore vengono "trimmati"
                per poter tagliare i caratteri inseriti con PadRight*/
                while (br.PeekChar() != -1) {
                    tmp.Add(new Opera(br.ReadInt32(), br.ReadString().Trim(), br.ReadString().Trim(), br.ReadInt32(), br.ReadByte()));
                }

                br.Close();
                fs.Close();

                return tmp;
            } catch (Exception) {
                //Se il file non esiste, la lista restituita sarà vuota
                return null;
            }
        }

        public string Ricerca(string a) {
            try {
                FileStream fs = new FileStream("file.txt", FileMode.Open);
                BinaryReader br = new BinaryReader(fs);

                //Stringa per salvare gli autori che corrispondono alla ricerca richiesta
                string risultato = "";

                //Finchè non è finito il file, si crea una nuova opera con i dati presi dal file
                while (br.PeekChar() != -1) {
                    Opera tmp = new Opera(br.ReadInt32(), br.ReadString().Trim(), br.ReadString().Trim(), br.ReadInt32(), br.ReadByte());
                    if (tmp.Autore == a) {
                        //Il risultato è la ToString dell'Opera.
                        risultato += tmp.ToString();
                    }
                }
                //Se non si trovano autori, si informa l'utente
                if (risultato == "")
                    return "Nessun autore risponde ai requisiti";
                else
                    return risultato;
            } catch (Exception) {
                //Se non esiste il file, si informa l'utente
                return "File non presente.";
            }
        }

        public bool Modifica(int c, Opera o) {
            try {
                FileStream fs = new FileStream("file.txt", FileMode.Open, FileAccess.ReadWrite);
                BinaryReader br = new BinaryReader(fs);
                BinaryWriter bw = new BinaryWriter(fs);
                long posizione;

                while (br.PeekChar() != -1) {
                    posizione = fs.Position;
                    if (br.ReadInt32() == c) {
                        //Se viene trovata l'opera col codice corretto, viene modificata.
                        fs.Position = posizione;

                        bw.Write(o.Codice);
                        bw.Write(o.Autore.PadRight(50, ' '));
                        bw.Write(o.Titolo.PadRight(50, ' '));
                        bw.Write(o.Anno);
                        bw.Write(o.Tipo);

                        br.Close();
                        bw.Close();
                        fs.Close();
                        //Si ritorna vero alla Form per indicare che l'azione è andata a buon fine
                        return true;
                    }
                    //Altrimenti si sposta la corrente del flusso
                    br.ReadString().Trim();
                    br.ReadString().Trim();
                    br.ReadInt32();
                    br.ReadByte();
                }

                br.Close();
                bw.Close();
                fs.Close();
                //Si indica che il cpodice non è stato trovato
                return false;
            } catch (Exception) {
                //Si ritorna false anche se non è stato trovato il file
                return false;
            }
        }

        //Viene modificata l'opera da eliminare con dati fittizzi
        public bool Elimina(int c) => Modifica(c, new Opera(-1, "n", "n", 0, 0));
    }
}