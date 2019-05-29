using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Opere {
    public partial class Form1 : Form {
        private int codice;
        GestioneFile file;
        public Form1() {
            InitializeComponent();
            file = new GestioneFile();
            //Il codice progressivo viene caricato da un file esterno
            codice = file.CaricaCodice();
        }

        //Quando si carica il Form, si imposta il RadioButtonQuadro su vero per evitare problemi nell'inserimento
        private void Form1_Load(object sender, EventArgs e) => rbt_qadro.Checked = true;

        private void btn_aggiungi_Click_1(object sender, EventArgs e) {
            if (txb_titolo.Text != "" && txb_autore.Text != "" && txb_anno.Text != "") {
                //Il tipo viene indicatop dal RadioButton selezionato
                byte tipo = Convert.ToByte(decidiTipo());

                try {
                    //Inserisce nel file una nuova opera
                    file.Inserisci(new Opera(codice++, txb_autore.Text, txb_titolo.Text, Convert.ToInt16(txb_anno.Text), tipo));
                    //Vengono resetettate le textbox
                    txb_autore.Text = txb_titolo.Text = txb_anno.Text = "";
                } catch (Exception) {
                    //Il programma va in eccezione solo se l'anno inserito è errato
                    MessageBox.Show("ATTENZIONE! Anno non corretto.");
                }

            } else {
                //Se i campi non sono compilati, si informa l'utente tramite MessageBox
                MessageBox.Show("Compilare tutti i campi!");
            }
        }

        //Apre una MessageBox con il risultato di file.Ricerca
        private void btn_cerca_Click(object sender, EventArgs e) => MessageBox.Show(file.Ricerca(txb_autore_cerca.Text));

        //Informa l'utente se la modifica è stata eseguita con successo
        private void btn_modifica_Click(object sender, EventArgs e) {
            if (file.Modifica(Convert.ToInt32(txb_codice_modifica.Text), new Opera(Convert.ToInt32(txb_codice_modifica.Text), txb_autore.Text, txb_titolo.Text, Convert.ToInt16(txb_anno.Text), Convert.ToByte(decidiTipo()))))
                MessageBox.Show("Modifica eseguita con successo!");
            else
                MessageBox.Show("Opera non trovata!");
        }

        //Informa l'utente se l'eliminazione è stata eseguita con successo
        private void btn_elimina_Click(object sender, EventArgs e) {
            if (file.Elimina(Convert.ToInt32(txb_elimina.Text)))
                MessageBox.Show("Opera eliminata con successo!");
            else
                MessageBox.Show("Opera non trovata!");
        }

        //Ritorna un valore a seconda del RadioButton del tipo
        private int decidiTipo() => rbt_qadro.Checked ? 1 : (rbt_scultura.Checked ? 2 : 3);

        //Visualizza nella DataGrid le opere
        private void btn_visualizza_Click(object sender, EventArgs e) {
            //Per una visualizzazione più facile da gestire, viene usata la lista
            List<Opera> l = file.visualizzaOpere();
            string[] riga = new string[5];

            foreach(Opera o in l) {
                riga = o.ToString().Split('|');
            }

            grid_opere.Rows.Add(riga);
        }
    }
}