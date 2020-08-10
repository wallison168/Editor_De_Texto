namespace EditorTexto
{
    partial class F_principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_principal));
            this.rtb_texto = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sublinhadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alinharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centralizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esquerdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.direitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_novo = new System.Windows.Forms.ToolStrip();
            this.tsb_novo = new System.Windows.Forms.ToolStripButton();
            this.tsb_abrir = new System.Windows.Forms.ToolStripButton();
            this.tsb_salvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_copiar = new System.Windows.Forms.ToolStripButton();
            this.tsb_colar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_negrito = new System.Windows.Forms.ToolStripButton();
            this.tsb_italico = new System.Windows.Forms.ToolStripButton();
            this.tsb_sublinhado = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_fontes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_direita = new System.Windows.Forms.ToolStripButton();
            this.tsb_centro = new System.Windows.Forms.ToolStripButton();
            this.tsb_esquerda = new System.Windows.Forms.ToolStripButton();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.ts_novo.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb_texto
            // 
            this.rtb_texto.Location = new System.Drawing.Point(0, 52);
            this.rtb_texto.Name = "rtb_texto";
            this.rtb_texto.Size = new System.Drawing.Size(647, 355);
            this.rtb_texto.TabIndex = 0;
            this.rtb_texto.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.formatarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(647, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem,
            this.colarToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.colarToolStripMenuItem.Text = "Colar";
            this.colarToolStripMenuItem.Click += new System.EventHandler(this.colarToolStripMenuItem_Click);
            // 
            // formatarToolStripMenuItem
            // 
            this.formatarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negritoToolStripMenuItem,
            this.italicoToolStripMenuItem,
            this.sublinhadoToolStripMenuItem,
            this.alinharToolStripMenuItem});
            this.formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            this.formatarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.formatarToolStripMenuItem.Text = "Formatar";
            // 
            // negritoToolStripMenuItem
            // 
            this.negritoToolStripMenuItem.Name = "negritoToolStripMenuItem";
            this.negritoToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.negritoToolStripMenuItem.Text = "Negrito";
            this.negritoToolStripMenuItem.Click += new System.EventHandler(this.negritoToolStripMenuItem_Click);
            // 
            // italicoToolStripMenuItem
            // 
            this.italicoToolStripMenuItem.Name = "italicoToolStripMenuItem";
            this.italicoToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.italicoToolStripMenuItem.Text = "Italico";
            this.italicoToolStripMenuItem.Click += new System.EventHandler(this.italicoToolStripMenuItem_Click);
            // 
            // sublinhadoToolStripMenuItem
            // 
            this.sublinhadoToolStripMenuItem.Name = "sublinhadoToolStripMenuItem";
            this.sublinhadoToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.sublinhadoToolStripMenuItem.Text = "Sublinhado";
            this.sublinhadoToolStripMenuItem.Click += new System.EventHandler(this.sublinhadoToolStripMenuItem_Click);
            // 
            // alinharToolStripMenuItem
            // 
            this.alinharToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centralizarToolStripMenuItem,
            this.esquerdaToolStripMenuItem,
            this.direitaToolStripMenuItem});
            this.alinharToolStripMenuItem.Name = "alinharToolStripMenuItem";
            this.alinharToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.alinharToolStripMenuItem.Text = "Alinhar";
            // 
            // centralizarToolStripMenuItem
            // 
            this.centralizarToolStripMenuItem.Name = "centralizarToolStripMenuItem";
            this.centralizarToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.centralizarToolStripMenuItem.Text = "Centralizar";
            this.centralizarToolStripMenuItem.Click += new System.EventHandler(this.centralizarToolStripMenuItem_Click);
            // 
            // esquerdaToolStripMenuItem
            // 
            this.esquerdaToolStripMenuItem.Name = "esquerdaToolStripMenuItem";
            this.esquerdaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.esquerdaToolStripMenuItem.Text = "Esquerda";
            this.esquerdaToolStripMenuItem.Click += new System.EventHandler(this.esquerdaToolStripMenuItem_Click);
            // 
            // direitaToolStripMenuItem
            // 
            this.direitaToolStripMenuItem.Name = "direitaToolStripMenuItem";
            this.direitaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.direitaToolStripMenuItem.Text = "Direita";
            this.direitaToolStripMenuItem.Click += new System.EventHandler(this.direitaToolStripMenuItem_Click);
            // 
            // ts_novo
            // 
            this.ts_novo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ts_novo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_novo,
            this.tsb_abrir,
            this.tsb_salvar,
            this.toolStripSeparator1,
            this.tsb_copiar,
            this.tsb_colar,
            this.toolStripSeparator2,
            this.tsb_negrito,
            this.tsb_italico,
            this.tsb_sublinhado,
            this.toolStripSeparator3,
            this.tsb_fontes,
            this.toolStripSeparator4,
            this.tsb_direita,
            this.tsb_centro,
            this.tsb_esquerda});
            this.ts_novo.Location = new System.Drawing.Point(0, 24);
            this.ts_novo.Name = "ts_novo";
            this.ts_novo.Size = new System.Drawing.Size(647, 25);
            this.ts_novo.TabIndex = 2;
            this.ts_novo.Text = "ts_new";
            // 
            // tsb_novo
            // 
            this.tsb_novo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_novo.Image = ((System.Drawing.Image)(resources.GetObject("tsb_novo.Image")));
            this.tsb_novo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_novo.Name = "tsb_novo";
            this.tsb_novo.Size = new System.Drawing.Size(23, 22);
            this.tsb_novo.Text = "Novo";
            this.tsb_novo.Click += new System.EventHandler(this.tsb_novo_Click);
            // 
            // tsb_abrir
            // 
            this.tsb_abrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_abrir.Image = ((System.Drawing.Image)(resources.GetObject("tsb_abrir.Image")));
            this.tsb_abrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_abrir.Name = "tsb_abrir";
            this.tsb_abrir.Size = new System.Drawing.Size(23, 22);
            this.tsb_abrir.Text = "Abrir";
            this.tsb_abrir.Click += new System.EventHandler(this.tsb_abrir_Click);
            // 
            // tsb_salvar
            // 
            this.tsb_salvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_salvar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_salvar.Image")));
            this.tsb_salvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_salvar.Name = "tsb_salvar";
            this.tsb_salvar.Size = new System.Drawing.Size(23, 22);
            this.tsb_salvar.Text = "Salvar";
            this.tsb_salvar.Click += new System.EventHandler(this.tsb_salvar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsb_copiar
            // 
            this.tsb_copiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_copiar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_copiar.Image")));
            this.tsb_copiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_copiar.Name = "tsb_copiar";
            this.tsb_copiar.Size = new System.Drawing.Size(23, 22);
            this.tsb_copiar.Text = "Copiar";
            this.tsb_copiar.Click += new System.EventHandler(this.tsb_copiar_Click);
            // 
            // tsb_colar
            // 
            this.tsb_colar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_colar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_colar.Image")));
            this.tsb_colar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_colar.Name = "tsb_colar";
            this.tsb_colar.Size = new System.Drawing.Size(23, 22);
            this.tsb_colar.Text = "Colar";
            this.tsb_colar.Click += new System.EventHandler(this.tsb_colar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsb_negrito
            // 
            this.tsb_negrito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_negrito.Image = ((System.Drawing.Image)(resources.GetObject("tsb_negrito.Image")));
            this.tsb_negrito.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_negrito.Name = "tsb_negrito";
            this.tsb_negrito.Size = new System.Drawing.Size(23, 22);
            this.tsb_negrito.Text = "Negrito";
            this.tsb_negrito.Click += new System.EventHandler(this.tsb_negrito_Click);
            // 
            // tsb_italico
            // 
            this.tsb_italico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_italico.Image = ((System.Drawing.Image)(resources.GetObject("tsb_italico.Image")));
            this.tsb_italico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_italico.Name = "tsb_italico";
            this.tsb_italico.Size = new System.Drawing.Size(23, 22);
            this.tsb_italico.Text = "Italico";
            this.tsb_italico.Click += new System.EventHandler(this.tsb_italico_Click);
            // 
            // tsb_sublinhado
            // 
            this.tsb_sublinhado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_sublinhado.Image = ((System.Drawing.Image)(resources.GetObject("tsb_sublinhado.Image")));
            this.tsb_sublinhado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_sublinhado.Name = "tsb_sublinhado";
            this.tsb_sublinhado.Size = new System.Drawing.Size(23, 22);
            this.tsb_sublinhado.Text = "Sublinhado";
            this.tsb_sublinhado.Click += new System.EventHandler(this.tsb_sublinhado_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsb_fontes
            // 
            this.tsb_fontes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_fontes.Image = ((System.Drawing.Image)(resources.GetObject("tsb_fontes.Image")));
            this.tsb_fontes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_fontes.Name = "tsb_fontes";
            this.tsb_fontes.Size = new System.Drawing.Size(23, 22);
            this.tsb_fontes.Text = "Fontes";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsb_direita
            // 
            this.tsb_direita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_direita.Image = ((System.Drawing.Image)(resources.GetObject("tsb_direita.Image")));
            this.tsb_direita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_direita.Name = "tsb_direita";
            this.tsb_direita.Size = new System.Drawing.Size(23, 22);
            this.tsb_direita.Text = "Direita";
            this.tsb_direita.Click += new System.EventHandler(this.tsb_direita_Click);
            // 
            // tsb_centro
            // 
            this.tsb_centro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_centro.Image = ((System.Drawing.Image)(resources.GetObject("tsb_centro.Image")));
            this.tsb_centro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_centro.Name = "tsb_centro";
            this.tsb_centro.Size = new System.Drawing.Size(23, 22);
            this.tsb_centro.Text = "Centro";
            this.tsb_centro.Click += new System.EventHandler(this.tsb_centro_Click);
            // 
            // tsb_esquerda
            // 
            this.tsb_esquerda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_esquerda.Image = ((System.Drawing.Image)(resources.GetObject("tsb_esquerda.Image")));
            this.tsb_esquerda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_esquerda.Name = "tsb_esquerda";
            this.tsb_esquerda.Size = new System.Drawing.Size(23, 22);
            this.tsb_esquerda.Text = "Esquerda";
            this.tsb_esquerda.Click += new System.EventHandler(this.tsb_esquerda_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "(*.TXT)|*.TXT";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // F_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 410);
            this.Controls.Add(this.ts_novo);
            this.Controls.Add(this.rtb_texto);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "F_principal";
            this.Text = "Editor de Texto";
            this.Load += new System.EventHandler(this.F_principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ts_novo.ResumeLayout(false);
            this.ts_novo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_texto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negritoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sublinhadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alinharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centralizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esquerdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem direitaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip ts_novo;
        private System.Windows.Forms.ToolStripButton tsb_novo;
        private System.Windows.Forms.ToolStripButton tsb_abrir;
        private System.Windows.Forms.ToolStripButton tsb_salvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsb_copiar;
        private System.Windows.Forms.ToolStripButton tsb_colar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsb_negrito;
        private System.Windows.Forms.ToolStripButton tsb_italico;
        private System.Windows.Forms.ToolStripButton tsb_sublinhado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsb_fontes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsb_centro;
        private System.Windows.Forms.ToolStripButton tsb_direita;
        private System.Windows.Forms.ToolStripButton tsb_esquerda;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

