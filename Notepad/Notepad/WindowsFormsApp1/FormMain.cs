﻿using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace Notepad_2021
{
    public partial class FormMain : Form
    {

        #region variables

        string fileName;
        string filePath;
        string savedContent;
        int m_nFirstCharOnPage;

        #endregion

        #region initialization

        public FormMain()
        {
            InitializeComponent();
            pageSetupDialogMain.Document = printDocumentMain;
            printDialogMain.Document = printDocumentMain;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            initializeVariables();
        }

        private void initializeVariables()
        {
            fileName = "Senza nome";
            filePath = "";
            savedContent = "";
            richTextBoxMain.Clear();
            setFormTitle();
        }

        private void setFormTitle()
        {
            this.Text = fileName + this.Tag;
        }

        #endregion

        #region menu-item handlers

        private void nuovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBoxMain.Text != savedContent)
            {
                DialogResult result = checkIfUserWantToSave();
                if (result == DialogResult.Cancel) return;
                else if (result == DialogResult.Yes)
                {
                    if (filePath != "") saveDocument(filePath);
                    else
                    {
                        DialogResult saveResponse = saveFileDialogMain.ShowDialog();
                        if (saveResponse == DialogResult.Cancel) return;
                        else saveDocument(saveFileDialogMain.FileName);
                    }
                }
            }
            initializeVariables();
        }

        private void apriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBoxMain.Text != savedContent)
            {
                DialogResult result = checkIfUserWantToSave();
                if (result == DialogResult.Cancel) return;
                else if (result == DialogResult.Yes)
                {
                    if (filePath != "") saveDocument(filePath);
                    else
                    {
                        DialogResult saveResponse = saveFileDialogMain.ShowDialog();
                        if (saveResponse == DialogResult.Cancel) return;
                        else saveDocument(saveFileDialogMain.FileName);
                    }
                }
            }
            if (openFileDialogMain.ShowDialog() == DialogResult.OK)
            {
                openDocument(openFileDialogMain.FileName);
                openFileDialogMain.FileName = "";
            }
        }

        private void salvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filePath.Length == 0)
                salvaconnomeToolStripMenuItem_Click(sender, e);
            else
                saveDocument(filePath);
        }

        private void salvaconnomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialogMain.ShowDialog() == DialogResult.OK)
                saveDocument(saveFileDialogMain.FileName);
        }

        private void impostapaginaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialogMain.ShowDialog();
        }

        private void stampaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocumentMain.DocumentName = fileName;
            if (printDialogMain.ShowDialog() == DialogResult.OK)
            {
                printDocumentMain.Print();
            }
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region event handlers

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (richTextBoxMain.Text != savedContent)
            {
                DialogResult result = checkIfUserWantToSave();
                if (result == DialogResult.Cancel) e.Cancel = true;
                else if (result == DialogResult.Yes)
                {
                    if (filePath != "") saveDocument(filePath);
                    else
                    {
                        DialogResult saveResponse = saveFileDialogMain.ShowDialog();
                        if (saveResponse == DialogResult.Cancel) e.Cancel = true;
                        else saveDocument(saveFileDialogMain.FileName);
                    }
                }
            }
        }

        private void richTextBoxMain_TextChanged(object sender, EventArgs e)
        {
            if (richTextBoxMain.Text != savedContent && fileName[0] != '*')
            {
                fileName = "*" + fileName;
                setFormTitle();
            }
            else if (richTextBoxMain.Text == savedContent && fileName[0] == '*')
            {
                fileName = fileName.Remove(0, 1);
                setFormTitle();
            }
        }

        private void printDocumentMain_BeginPrint(object sender, PrintEventArgs e)
        {
            // Start at the beginning of the text
            m_nFirstCharOnPage = 0;

        }

        private void printDocumentMain_EndPrint(object sender, PrintEventArgs e)
        {
            // Clean up cached information
            richTextBoxMain.FormatRangeDone();
        }
        private void printDocumentMain_PrintPage(object sender, PrintPageEventArgs e)
        {
            string content = richTextBoxMain.Text;
            Font font = richTextBoxMain.Font;
            e.Graphics.DrawString(
                content,
                font,
                new SolidBrush(Color.Black),
                e.MarginBounds.X,
                e.MarginBounds.Y);

            m_nFirstCharOnPage = myRichTextBoxEx.FormatRange(false,
                                e,
                                m_nFirstCharOnPage,
                                myRichTextBoxEx.TextLength);

            // check if there are more pages to print
            if (m_nFirstCharOnPage < myRichTextBoxEx.TextLength)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;
        }

        #endregion

        #region helper functions

        private DialogResult checkIfUserWantToSave()
        {
            return MessageBox.Show(
                    "Salvare le modifiche a " + fileName + "?",
                    "Blocco note",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);
        }

        private string getFileNameFromPath(string fp)
        {
            string[] mySplit = fp.Split('\\');
            return mySplit[mySplit.Length - 1];
        }

        private void openDocument(string fp)
        {
            try
            {
                richTextBoxMain.Text = File.ReadAllText(fp);
                savedContent = richTextBoxMain.Text;
                filePath = fp;
                fileName = getFileNameFromPath(fp);
                setFormTitle();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Problemi durante l'apertura del file.",
                    "ATTENZIONE!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void saveDocument(string fp)
        {
            try
            {
                string content = richTextBoxMain.Text;
                File.WriteAllText(fp, content);
                savedContent = content;
                filePath = fp;
                fileName = getFileNameFromPath(fp);
                setFormTitle();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Problemi durante il salvataggio del file.",
                    "ATTENZIONE!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        #endregion

    }
}