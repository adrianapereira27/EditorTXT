namespace EditorTXT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuBar = new MenuStrip();
            mArquivo = new ToolStripMenuItem();
            mArquivoNovo = new ToolStripMenuItem();
            mArquivoNovaJanela = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mArquivoAbrir = new ToolStripMenuItem();
            mArquivoSalvar = new ToolStripMenuItem();
            mArquivoSalvarComo = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            mArquivoSair = new ToolStripMenuItem();
            mEditar = new ToolStripMenuItem();
            mEditarDesfazer = new ToolStripMenuItem();
            mEditarRefazer = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            mEditarRecortar = new ToolStripMenuItem();
            mEditarCopiar = new ToolStripMenuItem();
            mEditarColar = new ToolStripMenuItem();
            mEditarExcluir = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            mEditarDataHora = new ToolStripMenuItem();
            mFormatar = new ToolStripMenuItem();
            mFormatarQuebraAutLinha = new ToolStripMenuItem();
            mFormatarFonte = new ToolStripMenuItem();
            mExibir = new ToolStripMenuItem();
            mExibirZoom = new ToolStripMenuItem();
            mExibirZoomAmpliar = new ToolStripMenuItem();
            mExibirZoomReduzir = new ToolStripMenuItem();
            mExibirZoomRestaurar = new ToolStripMenuItem();
            mExibirBarraStatus = new ToolStripMenuItem();
            mAjuda = new ToolStripMenuItem();
            mAjudaExibirAjuda = new ToolStripMenuItem();
            mAjudaSobre = new ToolStripMenuItem();
            statusBar = new StatusStrip();
            statusBarLabel = new ToolStripStatusLabel();
            txtConteudo = new RichTextBox();
            menuBar.SuspendLayout();
            statusBar.SuspendLayout();
            SuspendLayout();
            // 
            // menuBar
            // 
            menuBar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuBar.Items.AddRange(new ToolStripItem[] { mArquivo, mEditar, mFormatar, mExibir, mAjuda });
            menuBar.Location = new Point(0, 0);
            menuBar.Name = "menuBar";
            menuBar.Size = new Size(784, 29);
            menuBar.TabIndex = 0;
            menuBar.Text = "menuStrip1";
            // 
            // mArquivo
            // 
            mArquivo.DropDownItems.AddRange(new ToolStripItem[] { mArquivoNovo, mArquivoNovaJanela, toolStripSeparator1, mArquivoAbrir, mArquivoSalvar, mArquivoSalvarComo, toolStripSeparator2, mArquivoSair });
            mArquivo.Name = "mArquivo";
            mArquivo.Size = new Size(80, 25);
            mArquivo.Text = "Arquivo";
            // 
            // mArquivoNovo
            // 
            mArquivoNovo.Name = "mArquivoNovo";
            mArquivoNovo.Size = new Size(171, 26);
            mArquivoNovo.Text = "Novo";
            mArquivoNovo.Click += mArquivoNovo_Click;
            // 
            // mArquivoNovaJanela
            // 
            mArquivoNovaJanela.Name = "mArquivoNovaJanela";
            mArquivoNovaJanela.Size = new Size(171, 26);
            mArquivoNovaJanela.Text = "Nova Janela";
            mArquivoNovaJanela.Click += mArquivoNovaJanela_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(168, 6);
            // 
            // mArquivoAbrir
            // 
            mArquivoAbrir.Name = "mArquivoAbrir";
            mArquivoAbrir.Size = new Size(171, 26);
            mArquivoAbrir.Text = "Abrir";
            mArquivoAbrir.Click += mArquivoAbrir_Click;
            // 
            // mArquivoSalvar
            // 
            mArquivoSalvar.Name = "mArquivoSalvar";
            mArquivoSalvar.Size = new Size(171, 26);
            mArquivoSalvar.Text = "Salvar";
            mArquivoSalvar.Click += mArquivoSalvar_Click;
            // 
            // mArquivoSalvarComo
            // 
            mArquivoSalvarComo.Name = "mArquivoSalvarComo";
            mArquivoSalvarComo.Size = new Size(171, 26);
            mArquivoSalvarComo.Text = "Salvar Como";
            mArquivoSalvarComo.Click += mArquivoSalvarComo_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(168, 6);
            // 
            // mArquivoSair
            // 
            mArquivoSair.Name = "mArquivoSair";
            mArquivoSair.Size = new Size(171, 26);
            mArquivoSair.Text = "Sair";
            mArquivoSair.Click += mArquivoSair_Click;
            // 
            // mEditar
            // 
            mEditar.DropDownItems.AddRange(new ToolStripItem[] { mEditarDesfazer, mEditarRefazer, toolStripSeparator3, mEditarRecortar, mEditarCopiar, mEditarColar, mEditarExcluir, toolStripSeparator4, mEditarDataHora });
            mEditar.Name = "mEditar";
            mEditar.Size = new Size(64, 25);
            mEditar.Text = "Editar";
            // 
            // mEditarDesfazer
            // 
            mEditarDesfazer.Name = "mEditarDesfazer";
            mEditarDesfazer.Size = new Size(166, 26);
            mEditarDesfazer.Text = "Desfazer";
            // 
            // mEditarRefazer
            // 
            mEditarRefazer.Name = "mEditarRefazer";
            mEditarRefazer.Size = new Size(166, 26);
            mEditarRefazer.Text = "Refazer";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(163, 6);
            // 
            // mEditarRecortar
            // 
            mEditarRecortar.Name = "mEditarRecortar";
            mEditarRecortar.Size = new Size(166, 26);
            mEditarRecortar.Text = "Recortar";
            // 
            // mEditarCopiar
            // 
            mEditarCopiar.Name = "mEditarCopiar";
            mEditarCopiar.Size = new Size(166, 26);
            mEditarCopiar.Text = "Copiar";
            // 
            // mEditarColar
            // 
            mEditarColar.Name = "mEditarColar";
            mEditarColar.Size = new Size(166, 26);
            mEditarColar.Text = "Colar";
            // 
            // mEditarExcluir
            // 
            mEditarExcluir.Name = "mEditarExcluir";
            mEditarExcluir.Size = new Size(166, 26);
            mEditarExcluir.Text = "Excluir";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(163, 6);
            // 
            // mEditarDataHora
            // 
            mEditarDataHora.Name = "mEditarDataHora";
            mEditarDataHora.Size = new Size(166, 26);
            mEditarDataHora.Text = "Data e Hora";
            // 
            // mFormatar
            // 
            mFormatar.DropDownItems.AddRange(new ToolStripItem[] { mFormatarQuebraAutLinha, mFormatarFonte });
            mFormatar.Name = "mFormatar";
            mFormatar.Size = new Size(88, 25);
            mFormatar.Text = "Formatar";
            // 
            // mFormatarQuebraAutLinha
            // 
            mFormatarQuebraAutLinha.Name = "mFormatarQuebraAutLinha";
            mFormatarQuebraAutLinha.Size = new Size(280, 26);
            mFormatarQuebraAutLinha.Text = "Quebra automática de linha";
            // 
            // mFormatarFonte
            // 
            mFormatarFonte.Name = "mFormatarFonte";
            mFormatarFonte.Size = new Size(280, 26);
            mFormatarFonte.Text = "Fonte";
            // 
            // mExibir
            // 
            mExibir.DropDownItems.AddRange(new ToolStripItem[] { mExibirZoom, mExibirBarraStatus });
            mExibir.Name = "mExibir";
            mExibir.Size = new Size(62, 25);
            mExibir.Text = "Exibir";
            // 
            // mExibirZoom
            // 
            mExibirZoom.DropDownItems.AddRange(new ToolStripItem[] { mExibirZoomAmpliar, mExibirZoomReduzir, mExibirZoomRestaurar });
            mExibirZoom.Name = "mExibirZoom";
            mExibirZoom.Size = new Size(188, 26);
            mExibirZoom.Text = "Zoom";
            // 
            // mExibirZoomAmpliar
            // 
            mExibirZoomAmpliar.Name = "mExibirZoomAmpliar";
            mExibirZoomAmpliar.Size = new Size(149, 26);
            mExibirZoomAmpliar.Text = "Ampliar";
            // 
            // mExibirZoomReduzir
            // 
            mExibirZoomReduzir.Name = "mExibirZoomReduzir";
            mExibirZoomReduzir.Size = new Size(149, 26);
            mExibirZoomReduzir.Text = "Reduzir";
            // 
            // mExibirZoomRestaurar
            // 
            mExibirZoomRestaurar.Name = "mExibirZoomRestaurar";
            mExibirZoomRestaurar.Size = new Size(149, 26);
            mExibirZoomRestaurar.Text = "Restaurar";
            // 
            // mExibirBarraStatus
            // 
            mExibirBarraStatus.Checked = true;
            mExibirBarraStatus.CheckOnClick = true;
            mExibirBarraStatus.CheckState = CheckState.Checked;
            mExibirBarraStatus.Name = "mExibirBarraStatus";
            mExibirBarraStatus.Size = new Size(188, 26);
            mExibirBarraStatus.Text = "Barra de status";
            // 
            // mAjuda
            // 
            mAjuda.DropDownItems.AddRange(new ToolStripItem[] { mAjudaExibirAjuda, mAjudaSobre });
            mAjuda.Name = "mAjuda";
            mAjuda.Size = new Size(64, 25);
            mAjuda.Text = "Ajuda";
            // 
            // mAjudaExibirAjuda
            // 
            mAjudaExibirAjuda.Name = "mAjudaExibirAjuda";
            mAjudaExibirAjuda.Size = new Size(214, 26);
            mAjudaExibirAjuda.Text = "Exibir Ajuda";
            // 
            // mAjudaSobre
            // 
            mAjudaSobre.Name = "mAjudaSobre";
            mAjudaSobre.Size = new Size(214, 26);
            mAjudaSobre.Text = "Sobre o EditorTXT";
            // 
            // statusBar
            // 
            statusBar.Items.AddRange(new ToolStripItem[] { statusBarLabel });
            statusBar.Location = new Point(0, 539);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(784, 22);
            statusBar.TabIndex = 1;
            statusBar.Text = "statusStrip1";
            // 
            // statusBarLabel
            // 
            statusBarLabel.Name = "statusBarLabel";
            statusBarLabel.Size = new Size(38, 17);
            statusBarLabel.Text = "100 %";
            // 
            // txtConteudo
            // 
            txtConteudo.Dock = DockStyle.Fill;
            txtConteudo.Location = new Point(0, 29);
            txtConteudo.Name = "txtConteudo";
            txtConteudo.Size = new Size(784, 510);
            txtConteudo.TabIndex = 2;
            txtConteudo.Text = "";
            txtConteudo.TextChanged += txtConteudo_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(txtConteudo);
            Controls.Add(statusBar);
            Controls.Add(menuBar);
            MainMenuStrip = menuBar;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editor TXT";
            menuBar.ResumeLayout(false);
            menuBar.PerformLayout();
            statusBar.ResumeLayout(false);
            statusBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuBar;
        private ToolStripMenuItem mArquivo;
        private ToolStripMenuItem mEditar;
        private ToolStripMenuItem mFormatar;
        private ToolStripMenuItem mExibir;
        private ToolStripMenuItem mAjuda;
        private ToolStripMenuItem mArquivoNovo;
        private ToolStripMenuItem mArquivoNovaJanela;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mArquivoAbrir;
        private ToolStripMenuItem mArquivoSalvar;
        private ToolStripMenuItem mArquivoSalvarComo;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem mArquivoSair;
        private ToolStripMenuItem mEditarDesfazer;
        private ToolStripMenuItem mEditarRefazer;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem mEditarRecortar;
        private ToolStripMenuItem mEditarCopiar;
        private ToolStripMenuItem mEditarColar;
        private ToolStripMenuItem mEditarExcluir;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem mEditarDataHora;
        private ToolStripMenuItem mFormatarQuebraAutLinha;
        private ToolStripMenuItem mFormatarFonte;
        private ToolStripMenuItem mExibirZoom;
        private ToolStripMenuItem mExibirZoomAmpliar;
        private ToolStripMenuItem mExibirZoomReduzir;
        private ToolStripMenuItem mExibirZoomRestaurar;
        private ToolStripMenuItem mExibirBarraStatus;
        private ToolStripMenuItem mAjudaExibirAjuda;
        private ToolStripMenuItem mAjudaSobre;
        private StatusStrip statusBar;
        private ToolStripStatusLabel statusBarLabel;
        private RichTextBox txtConteudo;
    }
}