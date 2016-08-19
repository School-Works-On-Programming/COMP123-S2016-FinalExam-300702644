namespace COMP123_S2016_FinalExam
{
    partial class GenerateNameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // GenerateNameForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "GenerateNameForm";
            this.Load += new System.EventHandler(this.GenerateNameForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox NameListGroupBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.ListBox FirstNameListBox;
        private System.Windows.Forms.Label LastNameLabel2;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label FirstNameLabel2;
        private System.Windows.Forms.TextBox textBox1;
        protected System.Windows.Forms.Button NextButton;
        protected System.Windows.Forms.Button GenerateButton;
    }
}