using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Code_Editor {
    public partial class ActiveCode : TabPage {
        public ActiveCode() {
            InitializeComponent();
        }

        public ActiveCode(IContainer container) {
            container.Add(this);
            InitializeComponent();
        }

        public string Header {
            get {
                return this.Text;
            }
            set {
                this.Text = value;
            }
        }

        private void CodeType(object sender, KeyPressEventArgs e) { 
            if (this.saved) {
                this.saved = false;
                this.Header += '*';
            }
        }
        public void HasSaved() {
            this.saved = true;
            this.Header = this.Header.Remove(this.Header.Length - 1); 
        }
    }
}