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
            this._regelnBtn = new System.Windows.Forms.Button();
            this._startBtn = new System.Windows.Forms.Button();
            this._stopBtn = new System.Windows.Forms.Button();
            this._weiterBtn = new System.Windows.Forms.Button();
            this._resetBtn = new System.Windows.Forms.Button();
            this._farbeLebBtn = new System.Windows.Forms.Button();
            this._farbeLebendLbl = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this._farbeTotLbl = new System.Windows.Forms.Label();
            this._farbeTotBtn = new System.Windows.Forms.Button();
            this._anzLebendeLbl = new System.Windows.Forms.Label();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this._anzGenLbl = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this._comboBox = new System.Windows.Forms.ComboBox();
            this.GridPanel = new System.Windows.Forms.Panel();
            this._textBoxDimension = new System.Windows.Forms.TextBox();
            this._saveBtn = new System.Windows.Forms.Button();
            this._deleteBtn = new System.Windows.Forms.Button();
            this._loadBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _regelnBtn
            // 
            this._regelnBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._regelnBtn.BackColor = System.Drawing.Color.White;
            this._regelnBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this._regelnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._regelnBtn.Location = new System.Drawing.Point(652, 579);
            this._regelnBtn.Name = "_regelnBtn";
            this._regelnBtn.Size = new System.Drawing.Size(193, 43);
            this._regelnBtn.TabIndex = 0;
            this._regelnBtn.Text = "Regeln";
            this._regelnBtn.UseVisualStyleBackColor = false;
            this._regelnBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // _startBtn
            // 
            this._startBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._startBtn.BackColor = System.Drawing.Color.White;
            this._startBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this._startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._startBtn.Location = new System.Drawing.Point(652, 22);
            this._startBtn.Name = "_startBtn";
            this._startBtn.Size = new System.Drawing.Size(92, 43);
            this._startBtn.TabIndex = 1;
            this._startBtn.Text = "Start";
            this._startBtn.UseVisualStyleBackColor = false;
            this._startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // _stopBtn
            // 
            this._stopBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._stopBtn.BackColor = System.Drawing.Color.White;
            this._stopBtn.Enabled = false;
            this._stopBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this._stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._stopBtn.Location = new System.Drawing.Point(753, 22);
            this._stopBtn.Name = "_stopBtn";
            this._stopBtn.Size = new System.Drawing.Size(92, 43);
            this._stopBtn.TabIndex = 2;
            this._stopBtn.Text = "Stop";
            this._stopBtn.UseVisualStyleBackColor = false;
            this._stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // _weiterBtn
            // 
            this._weiterBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._weiterBtn.BackColor = System.Drawing.Color.White;
            this._weiterBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this._weiterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._weiterBtn.Location = new System.Drawing.Point(652, 141);
            this._weiterBtn.Name = "_weiterBtn";
            this._weiterBtn.Size = new System.Drawing.Size(92, 43);
            this._weiterBtn.TabIndex = 3;
            this._weiterBtn.Text = "weiter";
            this._weiterBtn.UseVisualStyleBackColor = false;
            this._weiterBtn.Click += new System.EventHandler(this.schrittBtn_Click);
            // 
            // _resetBtn
            // 
            this._resetBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._resetBtn.BackColor = System.Drawing.Color.White;
            this._resetBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this._resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._resetBtn.Location = new System.Drawing.Point(710, 81);
            this._resetBtn.Name = "_resetBtn";
            this._resetBtn.Size = new System.Drawing.Size(135, 43);
            this._resetBtn.TabIndex = 4;
            this._resetBtn.Text = "Reset";
            this._resetBtn.UseVisualStyleBackColor = false;
            this._resetBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // _farbeLebBtn
            // 
            this._farbeLebBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._farbeLebBtn.BackColor = System.Drawing.Color.Orange;
            this._farbeLebBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this._farbeLebBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._farbeLebBtn.Location = new System.Drawing.Point(795, 190);
            this._farbeLebBtn.Name = "_farbeLebBtn";
            this._farbeLebBtn.Size = new System.Drawing.Size(51, 47);
            this._farbeLebBtn.TabIndex = 5;
            this._farbeLebBtn.UseVisualStyleBackColor = false;
            this._farbeLebBtn.Click += new System.EventHandler(this.farbeBtn_Click);
            // 
            // _farbeLebendLbl
            // 
            this._farbeLebendLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._farbeLebendLbl.AutoSize = true;
            this._farbeLebendLbl.Location = new System.Drawing.Point(649, 203);
            this._farbeLebendLbl.Name = "_farbeLebendLbl";
            this._farbeLebendLbl.Size = new System.Drawing.Size(112, 20);
            this._farbeLebendLbl.TabIndex = 6;
            this._farbeLebendLbl.Text = "Farbe lebende";
            // 
            // _farbeTotLbl
            // 
            this._farbeTotLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._farbeTotLbl.AutoSize = true;
            this._farbeTotLbl.Location = new System.Drawing.Point(649, 256);
            this._farbeTotLbl.Name = "_farbeTotLbl";
            this._farbeTotLbl.Size = new System.Drawing.Size(83, 20);
            this._farbeTotLbl.TabIndex = 9;
            this._farbeTotLbl.Text = "Farbe tote";
            // 
            // _farbeTotBtn
            // 
            this._farbeTotBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._farbeTotBtn.BackColor = System.Drawing.Color.White;
            this._farbeTotBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this._farbeTotBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._farbeTotBtn.Location = new System.Drawing.Point(795, 243);
            this._farbeTotBtn.Name = "_farbeTotBtn";
            this._farbeTotBtn.Size = new System.Drawing.Size(51, 47);
            this._farbeTotBtn.TabIndex = 8;
            this._farbeTotBtn.UseVisualStyleBackColor = false;
            this._farbeTotBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // _anzLebendeLbl
            // 
            this._anzLebendeLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._anzLebendeLbl.AutoSize = true;
            this._anzLebendeLbl.Location = new System.Drawing.Point(648, 501);
            this._anzLebendeLbl.Name = "_anzLebendeLbl";
            this._anzLebendeLbl.Size = new System.Drawing.Size(170, 20);
            this._anzLebendeLbl.TabIndex = 10;
            this._anzLebendeLbl.Text = "Anzahl lebende Zellen:";
            // 
            // _anzGenLbl
            // 
            this._anzGenLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._anzGenLbl.AutoSize = true;
            this._anzGenLbl.Location = new System.Drawing.Point(648, 530);
            this._anzGenLbl.Name = "_anzGenLbl";
            this._anzGenLbl.Size = new System.Drawing.Size(164, 20);
            this._anzGenLbl.TabIndex = 11;
            this._anzGenLbl.Text = "Anzahl Generationen:";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // _comboBox
            // 
            this._comboBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._comboBox.FormattingEnabled = true;
            this._comboBox.Location = new System.Drawing.Point(653, 305);
            this._comboBox.Name = "_comboBox";
            this._comboBox.Size = new System.Drawing.Size(192, 28);
            this._comboBox.TabIndex = 14;
            // 
            // GridPanel
            // 
            this.GridPanel.Location = new System.Drawing.Point(13, 22);
            this.GridPanel.Margin = new System.Windows.Forms.Padding(0);
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Size = new System.Drawing.Size(632, 613);
            this.GridPanel.TabIndex = 15;
            this.GridPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GridPanel_MouseClick);
            // 
            // _textBoxDimension
            // 
            this._textBoxDimension.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._textBoxDimension.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._textBoxDimension.Location = new System.Drawing.Point(653, 90);
            this._textBoxDimension.Name = "_textBoxDimension";
            this._textBoxDimension.Size = new System.Drawing.Size(51, 26);
            this._textBoxDimension.TabIndex = 16;
            // 
            // _saveBtn
            // 
            this._saveBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._saveBtn.BackColor = System.Drawing.Color.White;
            this._saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this._saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._saveBtn.Location = new System.Drawing.Point(653, 397);
            this._saveBtn.Name = "_saveBtn";
            this._saveBtn.Size = new System.Drawing.Size(94, 43);
            this._saveBtn.TabIndex = 17;
            this._saveBtn.Text = "speichern";
            this._saveBtn.UseVisualStyleBackColor = false;
            this._saveBtn.Click += new System.EventHandler(this._saveBtn_Click);
            // 
            // _deleteBtn
            // 
            this._deleteBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._deleteBtn.BackColor = System.Drawing.Color.White;
            this._deleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this._deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._deleteBtn.Location = new System.Drawing.Point(753, 397);
            this._deleteBtn.Name = "_deleteBtn";
            this._deleteBtn.Size = new System.Drawing.Size(91, 43);
            this._deleteBtn.TabIndex = 18;
            this._deleteBtn.Text = "löschen";
            this._deleteBtn.UseVisualStyleBackColor = false;
            this._deleteBtn.Click += new System.EventHandler(this._deleteBtn_Click);
            // 
            // _loadBtn
            // 
            this._loadBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._loadBtn.BackColor = System.Drawing.Color.White;
            this._loadBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this._loadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._loadBtn.Location = new System.Drawing.Point(653, 348);
            this._loadBtn.Name = "_loadBtn";
            this._loadBtn.Size = new System.Drawing.Size(193, 43);
            this._loadBtn.TabIndex = 19;
            this._loadBtn.Text = "laden";
            this._loadBtn.UseVisualStyleBackColor = false;
            this._loadBtn.Click += new System.EventHandler(this._loadBtn_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(753, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 43);
            this.button1.TabIndex = 20;
            this.button1.Text = "zurück";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(868, 644);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._loadBtn);
            this.Controls.Add(this._deleteBtn);
            this.Controls.Add(this._saveBtn);
            this.Controls.Add(this._textBoxDimension);
            this.Controls.Add(this.GridPanel);
            this.Controls.Add(this._comboBox);
            this.Controls.Add(this._anzGenLbl);
            this.Controls.Add(this._anzLebendeLbl);
            this.Controls.Add(this._farbeTotLbl);
            this.Controls.Add(this._farbeTotBtn);
            this.Controls.Add(this._farbeLebendLbl);
            this.Controls.Add(this._farbeLebBtn);
            this.Controls.Add(this._resetBtn);
            this.Controls.Add(this._weiterBtn);
            this.Controls.Add(this._stopBtn);
            this.Controls.Add(this._startBtn);
            this.Controls.Add(this._regelnBtn);
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

        private System.Windows.Forms.Button _regelnBtn;
        private System.Windows.Forms.Button _startBtn;
        private System.Windows.Forms.Button _stopBtn;
        private System.Windows.Forms.Button _weiterBtn;
        private System.Windows.Forms.Button _resetBtn;
        private System.Windows.Forms.Button _farbeLebBtn;
        private System.Windows.Forms.Label _farbeLebendLbl;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label _farbeTotLbl;
        private System.Windows.Forms.Button _farbeTotBtn;
        private System.Windows.Forms.Label _anzLebendeLbl;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Label _anzGenLbl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox _comboBox;
        private System.Windows.Forms.Panel GridPanel;
        private System.Windows.Forms.TextBox _textBoxDimension;
        private System.Windows.Forms.Button _saveBtn;
        private System.Windows.Forms.Button _deleteBtn;
        private System.Windows.Forms.Button _loadBtn;
        private System.Windows.Forms.Button button1;
    }
}

