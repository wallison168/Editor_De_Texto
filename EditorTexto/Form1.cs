using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EditorTexto
{
    public partial class F_principal : Form
    {
        StreamReader leitura = null;
        public F_principal()
        {
            InitializeComponent();
        }

        private void F_principal_Load(object sender, EventArgs e)
        {

        }
        private void Novo()
        {
            rtb_texto.Clear();
            rtb_texto.Focus();
        }

        private void tsb_novo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Novo();
        }
        private void Salvar()
        {
            try
            {
                //O if inserido dentro do tratamento de exeção serve pra realizar a chamada do metodo
                //saveFileDialog nesse caso se comprir a condição inserida o programa ira 
                //direcionar o usuario para a tela de arquivos do pc dele para selecionar o local em qeu ira salvar esse documento

                if(this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Esse parametro inserirdo dentro do if permite que o usuario salve seu arquivo sem que aja erro
                    // pelo fato de esta sendo inserido dentro do try catch isso premite que não aja erro
                    // caso ouver erro o programa emitira uma mensagem de erro

                    FileStream arquivo = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter escritor = new StreamWriter(arquivo);
                    escritor.Flush();
                    escritor.BaseStream.Seek(0, SeekOrigin.Begin);
                    escritor.Write(this.rtb_texto.Text);
                    escritor.Flush();
                    escritor.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao salvar" + ex.Message, "Erro ao gravar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsb_salvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Abrir()
        {
            this.openFileDialog1.Title = "Abrir arquivo";
            openFileDialog1.InitialDirectory = @"C:\Users\WALLISON GREGORIO\Desktop\C#\proj C#\editor de texto";
            openFileDialog1.Filter = "(*.TXT)|*.TXT";

            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream arq = new FileStream(openFileDialog1.FileName,FileMode.Open,FileAccess.Read);
                    StreamReader leitor = new StreamReader(arq);
                    leitor.BaseStream.Seek(0,SeekOrigin.Begin);
                    this.rtb_texto.Text = "";
                    string linha = leitor.ReadLine();

                    while(linha != null)
                    {
                        this.rtb_texto.Text += linha + "\n";
                        linha = leitor.ReadLine();
                    }

                    leitor.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro ao abrir arquivo" + ex.Message, "Erro ao abrir arquivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void tsb_abrir_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void Copiar()
        {
            if(rtb_texto.SelectionLength > 0)
            {
                rtb_texto.Copy();
            }
            else
            {
                MessageBox.Show("Nenhum elemento foi selecionado");
            }
        }

        private void Colar()
        {
            rtb_texto.Paste();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void tsb_copiar_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void tsb_colar_Click(object sender, EventArgs e)
        {
            Colar();
        }
        private void Negrito()
        {
            string nome_fonte = null;
            float tamanho_fonte = 0;
            bool n,i,s = false;

            nome_fonte = rtb_texto.Font.Name;
            tamanho_fonte = rtb_texto.Font.Size;
            n = rtb_texto.SelectionFont.Bold;
            i = rtb_texto.SelectionFont.Italic;
            s = rtb_texto.SelectionFont.Underline;

            rtb_texto.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Regular); 

            if (n == false)
            {
                if(i == true && s == true)
                {
                    rtb_texto.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (i == true && s == false)
                {
                    rtb_texto.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Bold | FontStyle.Italic);
                }
                else if (i == false && s == true)
                {
                    rtb_texto.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Bold | FontStyle.Underline);
                }
                else if (i == false && s == false)
                {
                    rtb_texto.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Bold);
                }
            }
            else
            {
                if (i == true && s == true)
                {
                    rtb_texto.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Italic | FontStyle.Underline);
                }
                else if (i == true && s == false)
                {
                    rtb_texto.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Italic);
                }
                else if (i == false && s == true)
                {
                    rtb_texto.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Underline);
                }
            }
        }
        private void Italico()
        {
            string nome_fonte = null;
            float tamanho_fonte = 0;
            bool n,i,s = false;

            nome_fonte = rtb_texto.Font.Name;
            tamanho_fonte = rtb_texto.Font.Size;
            n = rtb_texto.SelectionFont.Bold;
            i = rtb_texto.SelectionFont.Italic;
            s = rtb_texto.SelectionFont.Underline;

            rtb_texto.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Regular);

            if (i == false)
            {
                if (n == true && s == true)
                {
                    rtb_texto.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (n == true && s == false)
                {
                    rtb_texto.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Bold | FontStyle.Italic);
                }
                else if (n == false && s == true)
                {
                    rtb_texto.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Italic | FontStyle.Underline);
                }
                else if (n == false && s == false)
                {
                    rtb_texto.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Italic);
                }
            }
            else
            {
                if (n == true && s == true)
                {
                    rtb_texto.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Bold | FontStyle.Underline);
                }
                else if (n == true && s == false)
                {
                    rtb_texto.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Bold);
                }
                else if (n == false && s == true)
                {
                    rtb_texto.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Underline);
                }
            }
        }
        private void Sublinhado()
        {
            string nome_fonte = null;
            float tamanho_fonte = 0;
            bool n,i,s = false;

            nome_fonte = rtb_texto.Font.Name;
            tamanho_fonte = rtb_texto.Font.Size;
            n = rtb_texto.SelectionFont.Bold;
            i = rtb_texto.SelectionFont.Italic;
            s = rtb_texto.SelectionFont.Underline;

            rtb_texto.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Regular);

            if (s == false)
            {
                if (n == true && i == true)
                {
                    rtb_texto.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (n == true && i == false)
                {
                    rtb_texto.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Bold | FontStyle.Underline);
                }
                else if (n == false && i == true)
                {
                    rtb_texto.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Italic | FontStyle.Underline);
                }
                else if (n == false && s == false)
                {
                    rtb_texto.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Underline);
                }
            }
            else
            {
                if (n == true && i == true)
                {
                    rtb_texto.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Bold | FontStyle.Italic);
                }
                else if (n == true && i == false)
                {
                    rtb_texto.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Bold);
                }
                else if (n == false && i == true)
                {
                    rtb_texto.SelectionFont = new Font(nome_fonte, tamanho_fonte, FontStyle.Italic);
                }
            }
        }

        private void tsb_negrito_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        private void tsb_italico_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void tsb_sublinhado_Click(object sender, EventArgs e)
        {
            Sublinhado();
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        private void italicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sublinhado();
        }
    }
}
