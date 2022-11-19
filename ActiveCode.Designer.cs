namespace Generic_Code_Editor {
    partial class ActiveCode {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public RichTextBox Code;
        private bool saved;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            this.Code = new() {
                Parent = this,
                Dock = DockStyle.Fill,
            };
            this.Code.AcceptsTab = true;
            this.Code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodeType);
            this.saved = false;
        }
        #endregion
    }
}
