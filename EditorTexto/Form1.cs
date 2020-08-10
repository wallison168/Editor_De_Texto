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
        StringReader leitura = null;
        public F_principal()
        {
            InitializeComponent();
        }

        private void F_principal_Load(object sender, EventArgs e)
        {

        }

        // Inserindo funcionalidades no botão (Novo)

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

        // Inserindo funcionalidades no botão (Salvar)

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

        // Inserindo funcionalidades no botão (Abrir)

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

        // Inserindo funcionalidades no botão (Copiar)

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

        // Inserindo funcionalidades no botão (Colar)
        // Atribuindo as funcionalidades dos botões (copiar e colar)

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

        // Inserindo a funcionalidades nas opções de formatação de caracteres

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

        // Inserindo a funcionalidades nas opções de formatação de alinhamento de caracteres

        private void AlinhamentoEsquerda()
        {
            rtb_texto.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void AlinhamentoCentro()
        {
            rtb_texto.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void AlinhamentoDireita()
        {
            rtb_texto.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void tsb_direita_Click(object sender, EventArgs e)
        {
            AlinhamentoDireita();
        }

        private void tsb_centro_Click(object sender, EventArgs e)
        {
            AlinhamentoCentro();
        }

        private void tsb_esquerda_Click(object sender, EventArgs e)
        {
            AlinhamentoEsquerda();
        }

        private void centralizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlinhamentoCentro();
        }

        private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlinhamentoEsquerda();
        }

        private void direitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlinhamentoDireita();
        }

        // Inserindo a funcionalidade de Impressão

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            string texto = this.rtb_texto.Text;
            leitura = new StringReader(texto);

            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }

        // Configurando o tipo da impressão

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float linhaspag = 0;
            float pos_y = 0;
            int cont = 0;

            float marg_esquerda = e.MarginBounds.Left - 50;
            float marg_superior = e.MarginBounds.Top - 50;

            if (marg_esquerda < 5)
            {
                marg_esquerda = 20;
            }
            if (marg_superior < 5)
            {
                marg_superior = 20;
            }

            string linha = null;

            Font font = this.rtb_texto.Font;
            SolidBrush pincel = new SolidBrush(Color.Black);

            // Essa função ira calcular o numero de linhas por pagina 

            linhaspag = e.MarginBounds.Height / font.GetHeight(e.Graphics);

            linha = leitura.ReadLine();

            while(cont < linhaspag)
            {
                pos_y = (marg_superior + (cont * font.GetHeight(e.Graphics)));
                e.Graphics.DrawString(linha, font, pincel, marg_esquerda, pos_y, new StringFormat());
                cont += 1;
                linha = leitura.ReadLine();
            }

            if(linha != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }

            pincel.Dispose();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_principal f_Principal = new F_principal();
            f_Principal.Close();
        }
    }
}
