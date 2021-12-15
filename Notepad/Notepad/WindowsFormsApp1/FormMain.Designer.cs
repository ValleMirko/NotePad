﻿namespace Notepad_2021
{
    partial class FormMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaconnomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.impostapaginaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stampaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annullaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tagliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incollaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cercaConBingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trovaSuccessivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trovaPrecedenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sostituisciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vaiAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.selezionatuttoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oraDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acapoautomaticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carattereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomAvantiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomIndietroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ripristinaZoomPredefinitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barraDistatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sommarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.informazionisuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarMain = new System.Windows.Forms.StatusStrip();
            this.saveFileDialogMain = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogMain = new System.Windows.Forms.OpenFileDialog();
            this.fontDialogMain = new System.Windows.Forms.FontDialog();
            this.pageSetupDialogMain = new System.Windows.Forms.PageSetupDialog();
            this.printDialogMain = new System.Windows.Forms.PrintDialog();
            this.printDocumentMain = new System.Drawing.Printing.PrintDocument();
            this.richTextBoxMain = new Notepad_2021.RichTextBoxEx();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.modificaToolStripMenuItem,
            this.formatoToolStripMenuItem,
            this.visualizzaToolStripMenuItem,
            this.ToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(784, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuovoToolStripMenuItem,
            this.apriToolStripMenuItem,
            this.salvaToolStripMenuItem,
            this.salvaconnomeToolStripMenuItem,
            this.toolStripSeparator1,
            this.impostapaginaToolStripMenuItem,
            this.stampaToolStripMenuItem,
            this.toolStripSeparator2,
            this.esciToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // nuovoToolStripMenuItem
            // 
            this.nuovoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuovoToolStripMenuItem.Image")));
            this.nuovoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nuovoToolStripMenuItem.Name = "nuovoToolStripMenuItem";
            this.nuovoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuovoToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.nuovoToolStripMenuItem.Text = "&Nuovo";
            this.nuovoToolStripMenuItem.Click += new System.EventHandler(this.nuovoToolStripMenuItem_Click);
            // 
            // apriToolStripMenuItem
            // 
            this.apriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("apriToolStripMenuItem.Image")));
            this.apriToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.apriToolStripMenuItem.Name = "apriToolStripMenuItem";
            this.apriToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.apriToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.apriToolStripMenuItem.Text = "&Apri...";
            this.apriToolStripMenuItem.Click += new System.EventHandler(this.apriToolStripMenuItem_Click);
            // 
            // salvaToolStripMenuItem
            // 
            this.salvaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salvaToolStripMenuItem.Image")));
            this.salvaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvaToolStripMenuItem.Name = "salvaToolStripMenuItem";
            this.salvaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvaToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.salvaToolStripMenuItem.Text = "&Salva";
            this.salvaToolStripMenuItem.Click += new System.EventHandler(this.salvaToolStripMenuItem_Click);
            // 
            // salvaconnomeToolStripMenuItem
            // 
            this.salvaconnomeToolStripMenuItem.Name = "salvaconnomeToolStripMenuItem";
            this.salvaconnomeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.salvaconnomeToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.salvaconnomeToolStripMenuItem.Text = "Salva &con nome...";
            this.salvaconnomeToolStripMenuItem.Click += new System.EventHandler(this.salvaconnomeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(264, 6);
            // 
            // impostapaginaToolStripMenuItem
            // 
            this.impostapaginaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.impostapaginaToolStripMenuItem.Name = "impostapaginaToolStripMenuItem";
            this.impostapaginaToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.impostapaginaToolStripMenuItem.Text = "&Imposta pagina...";
            this.impostapaginaToolStripMenuItem.Click += new System.EventHandler(this.impostapaginaToolStripMenuItem_Click);
            // 
            // stampaToolStripMenuItem
            // 
            this.stampaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stampaToolStripMenuItem.Image")));
            this.stampaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stampaToolStripMenuItem.Name = "stampaToolStripMenuItem";
            this.stampaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.stampaToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.stampaToolStripMenuItem.Text = "&Stampa...";
            this.stampaToolStripMenuItem.Click += new System.EventHandler(this.stampaToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(264, 6);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.esciToolStripMenuItem.Text = "&Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.annullaToolStripMenuItem,
            this.toolStripSeparator3,
            this.tagliaToolStripMenuItem,
            this.copiaToolStripMenuItem,
            this.incollaToolStripMenuItem,
            this.eliminaToolStripMenuItem,
            this.toolStripSeparator4,
            this.cercaConBingToolStripMenuItem,
            this.trovaToolStripMenuItem,
            this.trovaSuccessivoToolStripMenuItem,
            this.trovaPrecedenteToolStripMenuItem,
            this.sostituisciToolStripMenuItem,
            this.vaiAToolStripMenuItem,
            this.toolStripSeparator6,
            this.selezionatuttoToolStripMenuItem,
            this.oraDataToolStripMenuItem});
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.modificaToolStripMenuItem.Text = "&Modifica";
            // 
            // annullaToolStripMenuItem
            // 
            this.annullaToolStripMenuItem.Name = "annullaToolStripMenuItem";
            this.annullaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.annullaToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.annullaToolStripMenuItem.Text = "&Annulla";
            this.annullaToolStripMenuItem.Click += new System.EventHandler(this.annullaToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(232, 6);
            // 
            // tagliaToolStripMenuItem
            // 
            this.tagliaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tagliaToolStripMenuItem.Image")));
            this.tagliaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tagliaToolStripMenuItem.Name = "tagliaToolStripMenuItem";
            this.tagliaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tagliaToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.tagliaToolStripMenuItem.Text = "&Taglia";
            this.tagliaToolStripMenuItem.Click += new System.EventHandler(this.tagliaToolStripMenuItem_Click);
            // 
            // copiaToolStripMenuItem
            // 
            this.copiaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copiaToolStripMenuItem.Image")));
            this.copiaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copiaToolStripMenuItem.Name = "copiaToolStripMenuItem";
            this.copiaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiaToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.copiaToolStripMenuItem.Text = "&Copia";
            this.copiaToolStripMenuItem.Click += new System.EventHandler(this.copiaToolStripMenuItem_Click);
            // 
            // incollaToolStripMenuItem
            // 
            this.incollaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("incollaToolStripMenuItem.Image")));
            this.incollaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.incollaToolStripMenuItem.Name = "incollaToolStripMenuItem";
            this.incollaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.incollaToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.incollaToolStripMenuItem.Text = "&Incolla";
            this.incollaToolStripMenuItem.Click += new System.EventHandler(this.incollaToolStripMenuItem_Click);
            // 
            // eliminaToolStripMenuItem
            // 
            this.eliminaToolStripMenuItem.Name = "eliminaToolStripMenuItem";
            this.eliminaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.eliminaToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.eliminaToolStripMenuItem.Text = "E&limina";
            this.eliminaToolStripMenuItem.Click += new System.EventHandler(this.eliminaToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(232, 6);
            // 
            // cercaConBingToolStripMenuItem
            // 
            this.cercaConBingToolStripMenuItem.Name = "cercaConBingToolStripMenuItem";
            this.cercaConBingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.cercaConBingToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.cercaConBingToolStripMenuItem.Text = "Cerca con Bing...";
            this.cercaConBingToolStripMenuItem.Click += new System.EventHandler(this.cercaConBingToolStripMenuItem_Click);
            // 
            // trovaToolStripMenuItem
            // 
            this.trovaToolStripMenuItem.Name = "trovaToolStripMenuItem";
            this.trovaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.trovaToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.trovaToolStripMenuItem.Text = "Trova...";
            this.trovaToolStripMenuItem.Click += new System.EventHandler(this.trovaToolStripMenuItem_Click);
            // 
            // trovaSuccessivoToolStripMenuItem
            // 
            this.trovaSuccessivoToolStripMenuItem.Name = "trovaSuccessivoToolStripMenuItem";
            this.trovaSuccessivoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.trovaSuccessivoToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.trovaSuccessivoToolStripMenuItem.Text = "Trova Successivo";
            this.trovaSuccessivoToolStripMenuItem.Click += new System.EventHandler(this.trovaSuccessivoToolStripMenuItem_Click);
            // 
            // trovaPrecedenteToolStripMenuItem
            // 
            this.trovaPrecedenteToolStripMenuItem.Name = "trovaPrecedenteToolStripMenuItem";
            this.trovaPrecedenteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
            this.trovaPrecedenteToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.trovaPrecedenteToolStripMenuItem.Text = "Trova precedente";
            this.trovaPrecedenteToolStripMenuItem.Click += new System.EventHandler(this.trovaPrecedenteToolStripMenuItem_Click);
            // 
            // sostituisciToolStripMenuItem
            // 
            this.sostituisciToolStripMenuItem.Name = "sostituisciToolStripMenuItem";
            this.sostituisciToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.sostituisciToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.sostituisciToolStripMenuItem.Text = "Sostituisci...";
            this.sostituisciToolStripMenuItem.Click += new System.EventHandler(this.sostituisciToolStripMenuItem_Click);
            // 
            // vaiAToolStripMenuItem
            // 
            this.vaiAToolStripMenuItem.Enabled = false;
            this.vaiAToolStripMenuItem.Name = "vaiAToolStripMenuItem";
            this.vaiAToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.vaiAToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.vaiAToolStripMenuItem.Text = "Vai a...";
            this.vaiAToolStripMenuItem.Click += new System.EventHandler(this.vaiAToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(232, 6);
            // 
            // selezionatuttoToolStripMenuItem
            // 
            this.selezionatuttoToolStripMenuItem.Name = "selezionatuttoToolStripMenuItem";
            this.selezionatuttoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selezionatuttoToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.selezionatuttoToolStripMenuItem.Text = "Seleziona &tutto";
            this.selezionatuttoToolStripMenuItem.Click += new System.EventHandler(this.selezionatuttoToolStripMenuItem_Click);
            // 
            // oraDataToolStripMenuItem
            // 
            this.oraDataToolStripMenuItem.Name = "oraDataToolStripMenuItem";
            this.oraDataToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.oraDataToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.oraDataToolStripMenuItem.Text = "Ora/Data";
            this.oraDataToolStripMenuItem.Click += new System.EventHandler(this.oraDataToolStripMenuItem_Click);
            // 
            // formatoToolStripMenuItem
            // 
            this.formatoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acapoautomaticoToolStripMenuItem,
            this.carattereToolStripMenuItem});
            this.formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
            this.formatoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.formatoToolStripMenuItem.Text = "F&ormato";
            // 
            // acapoautomaticoToolStripMenuItem
            // 
            this.acapoautomaticoToolStripMenuItem.CheckOnClick = true;
            this.acapoautomaticoToolStripMenuItem.Name = "acapoautomaticoToolStripMenuItem";
            this.acapoautomaticoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.acapoautomaticoToolStripMenuItem.Text = "A capo au&tomatico";
            this.acapoautomaticoToolStripMenuItem.Click += new System.EventHandler(this.acapoautomaticoToolStripMenuItem_Click);
            // 
            // carattereToolStripMenuItem
            // 
            this.carattereToolStripMenuItem.Name = "carattereToolStripMenuItem";
            this.carattereToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.carattereToolStripMenuItem.Text = "Cara&ttere...";
            this.carattereToolStripMenuItem.Click += new System.EventHandler(this.carattereToolStripMenuItem_Click);
            // 
            // visualizzaToolStripMenuItem
            // 
            this.visualizzaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem,
            this.barraDistatoToolStripMenuItem});
            this.visualizzaToolStripMenuItem.Name = "visualizzaToolStripMenuItem";
            this.visualizzaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.visualizzaToolStripMenuItem.Text = "&Visualizza";
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomAvantiToolStripMenuItem,
            this.zoomIndietroToolStripMenuItem,
            this.ripristinaZoomPredefinitoToolStripMenuItem});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zoomToolStripMenuItem.Text = "&Zoom";
            // 
            // zoomAvantiToolStripMenuItem
            // 
            this.zoomAvantiToolStripMenuItem.Name = "zoomAvantiToolStripMenuItem";
            this.zoomAvantiToolStripMenuItem.ShortcutKeyDisplayString = "CTRL+segno più";
            this.zoomAvantiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.zoomAvantiToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.zoomAvantiToolStripMenuItem.Text = "&Zoom avanti";
            // 
            // zoomIndietroToolStripMenuItem
            // 
            this.zoomIndietroToolStripMenuItem.Name = "zoomIndietroToolStripMenuItem";
            this.zoomIndietroToolStripMenuItem.ShortcutKeyDisplayString = "CTRL+segno meno";
            this.zoomIndietroToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.zoomIndietroToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.zoomIndietroToolStripMenuItem.Text = "&Zoom indietro";
            // 
            // ripristinaZoomPredefinitoToolStripMenuItem
            // 
            this.ripristinaZoomPredefinitoToolStripMenuItem.Name = "ripristinaZoomPredefinitoToolStripMenuItem";
            this.ripristinaZoomPredefinitoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.ripristinaZoomPredefinitoToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.ripristinaZoomPredefinitoToolStripMenuItem.Text = "&Ripristina zoom predefinito";
            // 
            // barraDistatoToolStripMenuItem
            // 
            this.barraDistatoToolStripMenuItem.CheckOnClick = true;
            this.barraDistatoToolStripMenuItem.Name = "barraDistatoToolStripMenuItem";
            this.barraDistatoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.barraDistatoToolStripMenuItem.Text = "Barra di &stato";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sommarioToolStripMenuItem,
            this.indiceToolStripMenuItem,
            this.toolStripSeparator5,
            this.informazionisuToolStripMenuItem});
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(24, 20);
            this.ToolStripMenuItem.Text = "&?";
            // 
            // sommarioToolStripMenuItem
            // 
            this.sommarioToolStripMenuItem.Name = "sommarioToolStripMenuItem";
            this.sommarioToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.sommarioToolStripMenuItem.Text = "&Guida";
            // 
            // indiceToolStripMenuItem
            // 
            this.indiceToolStripMenuItem.Name = "indiceToolStripMenuItem";
            this.indiceToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.indiceToolStripMenuItem.Text = "&Invia feedback";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(219, 6);
            // 
            // informazionisuToolStripMenuItem
            // 
            this.informazionisuToolStripMenuItem.Name = "informazionisuToolStripMenuItem";
            this.informazionisuToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.informazionisuToolStripMenuItem.Text = "Informazioni &su Blocco note";
            // 
            // statusBarMain
            // 
            this.statusBarMain.Location = new System.Drawing.Point(0, 419);
            this.statusBarMain.Name = "statusBarMain";
            this.statusBarMain.Size = new System.Drawing.Size(784, 22);
            this.statusBarMain.TabIndex = 2;
            this.statusBarMain.Text = "statusStrip1";
            // 
            // saveFileDialogMain
            // 
            this.saveFileDialogMain.DefaultExt = "txt";
            this.saveFileDialogMain.FileName = "*.txt";
            this.saveFileDialogMain.Filter = "Documenti di testo|*.txt|Tutti i file|*.*";
            // 
            // openFileDialogMain
            // 
            this.openFileDialogMain.DefaultExt = "txt";
            this.openFileDialogMain.Filter = "Documenti di testo|*.txt|Tutti i file|*.*";
            // 
            // pageSetupDialogMain
            // 
            this.pageSetupDialogMain.EnableMetric = true;
            // 
            // printDialogMain
            // 
            this.printDialogMain.UseEXDialog = true;
            // 
            // printDocumentMain
            // 
            this.printDocumentMain.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocumentMain_BeginPrint);
            this.printDocumentMain.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocumentMain_EndPrint);
            this.printDocumentMain.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentMain_PrintPage);
            // 
            // richTextBoxMain
            // 
            this.richTextBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxMain.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxMain.Location = new System.Drawing.Point(0, 24);
            this.richTextBoxMain.Name = "richTextBoxMain";
            this.richTextBoxMain.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.richTextBoxMain.Size = new System.Drawing.Size(784, 395);
            this.richTextBoxMain.TabIndex = 1;
            this.richTextBoxMain.Text = "";
            this.richTextBoxMain.SelectionChanged += new System.EventHandler(this.enableDisableCopyCutRemove);
            this.richTextBoxMain.TextChanged += new System.EventHandler(this.richTextBoxMain_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.richTextBoxMain);
            this.Controls.Add(this.statusBarMain);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.Tag = " - Blocco note di Windows";
            this.Activated += new System.EventHandler(this.FormMain_Load_Acdtiveted);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuovoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvaconnomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem stampaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impostapaginaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annullaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tagliaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incollaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selezionatuttoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acapoautomaticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carattereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sommarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem informazionisuToolStripMenuItem;
        private RichTextBoxEx richTextBoxMain;
        private System.Windows.Forms.StatusStrip statusBarMain;
        private System.Windows.Forms.ToolStripMenuItem visualizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cercaConBingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trovaSuccessivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trovaPrecedenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sostituisciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vaiAToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem oraDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomAvantiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomIndietroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ripristinaZoomPredefinitoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barraDistatoToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMain;
        private System.Windows.Forms.OpenFileDialog openFileDialogMain;
        private System.Windows.Forms.FontDialog fontDialogMain;
        private System.Windows.Forms.PageSetupDialog pageSetupDialogMain;
        private System.Windows.Forms.PrintDialog printDialogMain;
        private System.Drawing.Printing.PrintDocument printDocumentMain;
    }
}