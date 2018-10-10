namespace Zellensimulation
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.regelnBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.schrittBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.farbeBtn = new System.Windows.Forms.Button();
            this.lebendLbl = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.anzLebendeLbl = new System.Windows.Forms.Label();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.anzGenLbl = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.GridPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // regelnBtn
            // 
            this.regelnBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.regelnBtn.BackColor = System.Drawing.Color.White;
            this.regelnBtn.Location = new System.Drawing.Point(652, 579);
            this.regelnBtn.Name = "regelnBtn";
            this.regelnBtn.Size = new System.Drawing.Size(193, 43);
            this.regelnBtn.TabIndex = 0;
            this.regelnBtn.Text = "Regeln";
            this.regelnBtn.UseVisualStyleBackColor = false;
            this.regelnBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // startBtn
            // 
            this.startBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.startBtn.BackColor = System.Drawing.Color.White;
            this.startBtn.Location = new System.Drawing.Point(652, 22);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(193, 43);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.stopBtn.BackColor = System.Drawing.Color.White;
            this.stopBtn.Enabled = false;
            this.stopBtn.Location = new System.Drawing.Point(652, 88);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(193, 43);
            this.stopBtn.TabIndex = 2;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // schrittBtn
            // 
            this.schrittBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.schrittBtn.BackColor = System.Drawing.Color.White;
            this.schrittBtn.Location = new System.Drawing.Point(652, 152);
            this.schrittBtn.Name = "schrittBtn";
            this.schrittBtn.Size = new System.Drawing.Size(193, 43);
            this.schrittBtn.TabIndex = 3;
            this.schrittBtn.Text = " 1 weiter";
            this.schrittBtn.UseVisualStyleBackColor = false;
            this.schrittBtn.Click += new System.EventHandler(this.schrittBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.clearBtn.BackColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(652, 214);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(193, 43);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Reset";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // farbeBtn
            // 
            this.farbeBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.farbeBtn.BackColor = System.Drawing.Color.Black;
            this.farbeBtn.Location = new System.Drawing.Point(794, 352);
            this.farbeBtn.Name = "farbeBtn";
            this.farbeBtn.Size = new System.Drawing.Size(51, 47);
            this.farbeBtn.TabIndex = 5;
            this.farbeBtn.UseVisualStyleBackColor = false;
            this.farbeBtn.Click += new System.EventHandler(this.farbeBtn_Click);
            // 
            // lebendLbl
            // 
            this.lebendLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lebendLbl.AutoSize = true;
            this.lebendLbl.Location = new System.Drawing.Point(648, 365);
            this.lebendLbl.Name = "lebendLbl";
            this.lebendLbl.Size = new System.Drawing.Size(112, 20);
            this.lebendLbl.TabIndex = 6;
            this.lebendLbl.Text = "Farbe lebende";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(648, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Farbe tote";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(794, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 47);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // anzLebendeLbl
            // 
            this.anzLebendeLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.anzLebendeLbl.AutoSize = true;
            this.anzLebendeLbl.Location = new System.Drawing.Point(648, 491);
            this.anzLebendeLbl.Name = "anzLebendeLbl";
            this.anzLebendeLbl.Size = new System.Drawing.Size(170, 20);
            this.anzLebendeLbl.TabIndex = 10;
            this.anzLebendeLbl.Text = "Anzahl lebende Zellen:";
            this.anzLebendeLbl.Click += new System.EventHandler(this.anzLebendeLbl_Click);
            // 
            // anzGenLbl
            // 
            this.anzGenLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.anzGenLbl.AutoSize = true;
            this.anzGenLbl.Location = new System.Drawing.Point(648, 530);
            this.anzGenLbl.Name = "anzGenLbl";
            this.anzGenLbl.Size = new System.Drawing.Size(164, 20);
            this.anzGenLbl.TabIndex = 11;
            this.anzGenLbl.Text = "Anzahl Generationen:";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // comboBox
            // 
            this.comboBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(652, 284);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(192, 28);
            this.comboBox.TabIndex = 14;
            this.comboBox.Text = "Muster";
            // 
            // GridPanel
            // 
            this.GridPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GridPanel.Location = new System.Drawing.Point(13, 22);
            this.GridPanel.Margin = new System.Windows.Forms.Padding(0);
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Size = new System.Drawing.Size(600, 600);
            this.GridPanel.TabIndex = 15;
            this.GridPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GridPanel_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(868, 644);
            this.Controls.Add(this.GridPanel);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.anzGenLbl);
            this.Controls.Add(this.anzLebendeLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lebendLbl);
            this.Controls.Add(this.farbeBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.schrittBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.regelnBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(890, 700);
            this.MinimumSize = new System.Drawing.Size(890, 700);
            this.Name = "Form1";
            this.Text = "Zellensimulation v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regelnBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button schrittBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button farbeBtn;
        private System.Windows.Forms.Label lebendLbl;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label anzLebendeLbl;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Label anzGenLbl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Panel GridPanel;
    }
}

