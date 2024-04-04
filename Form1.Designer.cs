namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            tableLayoutPanel1 = new TableLayoutPanel();
            listViewFiles = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            contextMenuStripListView = new ContextMenuStrip(components);
            removerToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            abrirLocalToolStripMenuItem = new ToolStripMenuItem();
            buttonSelectFiles = new Button();
            label1 = new Label();
            buttonStart = new Button();
            textFormat = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            statusStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            contextMenuStripListView.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripProgressBar1 });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(82, 17);
            toolStripStatusLabel1.Text = "Aguardando...";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Alignment = ToolStripItemAlignment.Right;
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 16);
            toolStripProgressBar1.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 148F));
            tableLayoutPanel1.Controls.Add(listViewFiles, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonSelectFiles, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonStart, 1, 3);
            tableLayoutPanel1.Controls.Add(textFormat, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 428);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // listViewFiles
            // 
            listViewFiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewFiles.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewFiles.ContextMenuStrip = contextMenuStripListView;
            listViewFiles.FullRowSelect = true;
            listViewFiles.GridLines = true;
            listViewFiles.Location = new Point(3, 56);
            listViewFiles.Name = "listViewFiles";
            tableLayoutPanel1.SetRowSpan(listViewFiles, 3);
            listViewFiles.Size = new Size(646, 369);
            listViewFiles.Sorting = SortOrder.Ascending;
            listViewFiles.TabIndex = 0;
            listViewFiles.UseCompatibleStateImageBehavior = false;
            listViewFiles.View = View.Details;
            listViewFiles.DoubleClick += abrirLocalToolStripMenuItem_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Arquivo";
            columnHeader1.Width = 450;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tamanho";
            columnHeader2.TextAlign = HorizontalAlignment.Right;
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Caminho";
            columnHeader3.Width = 90;
            // 
            // contextMenuStripListView
            // 
            contextMenuStripListView.Items.AddRange(new ToolStripItem[] { removerToolStripMenuItem, toolStripSeparator1, abrirLocalToolStripMenuItem });
            contextMenuStripListView.Name = "contextMenuStripListView";
            contextMenuStripListView.Size = new Size(132, 54);
            // 
            // removerToolStripMenuItem
            // 
            removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            removerToolStripMenuItem.Size = new Size(131, 22);
            removerToolStripMenuItem.Text = "Remover";
            removerToolStripMenuItem.Click += removerToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(128, 6);
            // 
            // abrirLocalToolStripMenuItem
            // 
            abrirLocalToolStripMenuItem.Name = "abrirLocalToolStripMenuItem";
            abrirLocalToolStripMenuItem.Size = new Size(131, 22);
            abrirLocalToolStripMenuItem.Text = "Abrir Local";
            abrirLocalToolStripMenuItem.Click += abrirLocalToolStripMenuItem_Click;
            // 
            // buttonSelectFiles
            // 
            buttonSelectFiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonSelectFiles.Location = new Point(655, 56);
            buttonSelectFiles.Name = "buttonSelectFiles";
            buttonSelectFiles.Size = new Size(142, 43);
            buttonSelectFiles.TabIndex = 1;
            buttonSelectFiles.Text = "Selecionar Arquivos";
            buttonSelectFiles.UseVisualStyleBackColor = true;
            buttonSelectFiles.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(646, 53);
            label1.TabIndex = 3;
            label1.Text = "Conversor de Media";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonStart
            // 
            buttonStart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonStart.Location = new Point(655, 387);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(142, 38);
            buttonStart.TabIndex = 2;
            buttonStart.Text = "Converter";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // textFormat
            // 
            textFormat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textFormat.BorderStyle = BorderStyle.FixedSingle;
            textFormat.Location = new Point(655, 358);
            textFormat.Name = "textFormat";
            textFormat.Size = new Size(142, 23);
            textFormat.TabIndex = 4;
            textFormat.Text = "wav";
            textFormat.TextAlign = HorizontalAlignment.Center;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Multiselect = true;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ValidateNames = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(statusStrip1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "App";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            contextMenuStripListView.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripProgressBar toolStripProgressBar1;
        private TableLayoutPanel tableLayoutPanel1;
        private ListView listViewFiles;
        private Button buttonSelectFiles;
        private Button buttonStart;
        private Label label1;
        private TextBox textFormat;
        private OpenFileDialog openFileDialog1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ContextMenuStrip contextMenuStripListView;
        private ToolStripMenuItem removerToolStripMenuItem;
        private ToolStripMenuItem abrirLocalToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}
