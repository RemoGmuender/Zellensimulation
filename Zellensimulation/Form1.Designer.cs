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
            this._rulesBtn = new System.Windows.Forms.Button();
            this._startBtn = new System.Windows.Forms.Button();
            this._stopBtn = new System.Windows.Forms.Button();
            this._nextBtn = new System.Windows.Forms.Button();
            this._resetBtn = new System.Windows.Forms.Button();
            this._colorAliveBtn = new System.Windows.Forms.Button();
            this._colorAliveLbl = new System.Windows.Forms.Label();
            this._colorDialog1 = new System.Windows.Forms.ColorDialog();
            this._colorDeadLbl = new System.Windows.Forms.Label();
            this._colorDeadBtn = new System.Windows.Forms.Button();
            this._amountAliveLbl = new System.Windows.Forms.Label();
            this._colorDialog2 = new System.Windows.Forms.ColorDialog();
            this._amountGenLbl = new System.Windows.Forms.Label();
            this._backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this._comboBox = new System.Windows.Forms.ComboBox();
            this.GridPanel = new System.Windows.Forms.Panel();
            this._textBoxDimension = new System.Windows.Forms.TextBox();
            this._saveBtn = new System.Windows.Forms.Button();
            this._deleteBtn = new System.Windows.Forms.Button();
            this._loadBtn = new System.Windows.Forms.Button();
            this._previousBtn = new System.Windows.Forms.Button();
            this._speedTrackbar = new System.Windows.Forms.TrackBar();
            this._speedLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._speedTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // _rulesBtn
            // 
            this._rulesBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._rulesBtn.BackColor = System.Drawing.Color.White;
            this._rulesBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this._rulesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._rulesBtn.Location = new System.Drawing.Point(652, 589);
            this._rulesBtn.Name = "_rulesBtn";
            this._rulesBtn.Size = new System.Drawing.Size(193, 43);
            this._rulesBtn.TabIndex = 0;
            this._rulesBtn.Text = "Rules";
            this._rulesBtn.UseVisualStyleBackColor = false;
            this._rulesBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // _startBtn
            // 
            this._startBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._startBtn.BackColor = System.Drawing.Color.White;
            this._startBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this._startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._startBtn.Location = new System.Drawing.Point(652, 32);
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
            this._stopBtn.Location = new System.Drawing.Point(753, 32);
            this._stopBtn.Name = "_stopBtn";
            this._stopBtn.Size = new System.Drawing.Size(92, 43);
            this._stopBtn.TabIndex = 2;
            this._stopBtn.Text = "Stop";
            this._stopBtn.UseVisualStyleBackColor = false;
            this._stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // _nextBtn
            // 
            this._nextBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._nextBtn.BackColor = System.Drawing.Color.White;
            this._nextBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this._nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._nextBtn.Location = new System.Drawing.Point(652, 151);
            this._nextBtn.Name = "_nextBtn";
            this._nextBtn.Size = new System.Drawing.Size(92, 43);
            this._nextBtn.TabIndex = 3;
            this._nextBtn.Text = "weiter";
            this._nextBtn.UseVisualStyleBackColor = false;
            this._nextBtn.Click += new System.EventHandler(this.schrittBtn_Click);
            // 
            // _resetBtn
            // 
            this._resetBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._resetBtn.BackColor = System.Drawing.Color.White;
            this._resetBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this._resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._resetBtn.Location = new System.Drawing.Point(710, 91);
            this._resetBtn.Name = "_resetBtn";
            this._resetBtn.Size = new System.Drawing.Size(135, 43);
            this._resetBtn.TabIndex = 4;
            this._resetBtn.Text = "zurücksetzen";
            this._resetBtn.UseVisualStyleBackColor = false;
            this._resetBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // _colorAliveBtn
            // 
            this._colorAliveBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._colorAliveBtn.BackColor = System.Drawing.Color.Orange;
            this._colorAliveBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this._colorAliveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._colorAliveBtn.Location = new System.Drawing.Point(795, 275);
            this._colorAliveBtn.Name = "_colorAliveBtn";
            this._colorAliveBtn.Size = new System.Drawing.Size(51, 34);
            this._colorAliveBtn.TabIndex = 5;
            this._colorAliveBtn.UseVisualStyleBackColor = false;
            this._colorAliveBtn.Click += new System.EventHandler(this.farbeBtn_Click);
            // 
            // _colorAliveLbl
            // 
            this._colorAliveLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._colorAliveLbl.AutoSize = true;
            this._colorAliveLbl.Location = new System.Drawing.Point(652, 282);
            this._colorAliveLbl.Name = "_colorAliveLbl";
            this._colorAliveLbl.Size = new System.Drawing.Size(103, 20);
            this._colorAliveLbl.TabIndex = 6;
            this._colorAliveLbl.Text = "Farbe lebend";
            // 
            // _colorDeadLbl
            // 
            this._colorDeadLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._colorDeadLbl.AutoSize = true;
            this._colorDeadLbl.Location = new System.Drawing.Point(649, 315);
            this._colorDeadLbl.Name = "_colorDeadLbl";
            this._colorDeadLbl.Size = new System.Drawing.Size(74, 20);
            this._colorDeadLbl.TabIndex = 9;
            this._colorDeadLbl.Text = "Farbe tot";
            // 
            // _colorDeadBtn
            // 
            this._colorDeadBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._colorDeadBtn.BackColor = System.Drawing.Color.White;
            this._colorDeadBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this._colorDeadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._colorDeadBtn.Location = new System.Drawing.Point(795, 315);
            this._colorDeadBtn.Name = "_colorDeadBtn";
            this._colorDeadBtn.Size = new System.Drawing.Size(51, 34);
            this._colorDeadBtn.TabIndex = 8;
            this._colorDeadBtn.UseVisualStyleBackColor = false;
            this._colorDeadBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // _amountAliveLbl
            // 
            this._amountAliveLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._amountAliveLbl.AutoSize = true;
            this._amountAliveLbl.Location = new System.Drawing.Point(648, 511);
            this._amountAliveLbl.Name = "_amountAliveLbl";
            this._amountAliveLbl.Size = new System.Drawing.Size(170, 20);
            this._amountAliveLbl.TabIndex = 10;
            this._amountAliveLbl.Text = "Anzahl lebende Zellen:";
            // 
            // _amountGenLbl
            // 
            this._amountGenLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._amountGenLbl.AutoSize = true;
            this._amountGenLbl.Location = new System.Drawing.Point(648, 540);
            this._amountGenLbl.Name = "_amountGenLbl";
            this._amountGenLbl.Size = new System.Drawing.Size(164, 20);
            this._amountGenLbl.TabIndex = 11;
            this._amountGenLbl.Text = "Anzahl Generationen:";
            // 
            // _backgroundWorker
            // 
            this._backgroundWorker.WorkerReportsProgress = true;
            this._backgroundWorker.WorkerSupportsCancellation = true;
            // 
            // _comboBox
            // 
            this._comboBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._comboBox.FormattingEnabled = true;
            this._comboBox.Location = new System.Drawing.Point(652, 360);
            this._comboBox.Name = "_comboBox";
            this._comboBox.Size = new System.Drawing.Size(192, 28);
            this._comboBox.TabIndex = 14;
            // 
            // GridPanel
            // 
            this.GridPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this._textBoxDimension.Location = new System.Drawing.Point(653, 100);
            this._textBoxDimension.Name = "_textBoxDimension";
            this._textBoxDimension.Size = new System.Drawing.Size(51, 26);
            this._textBoxDimension.TabIndex = 16;
            this._textBoxDimension.Text = "15";
            // 
            // _saveBtn
            // 
            this._saveBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._saveBtn.BackColor = System.Drawing.Color.White;
            this._saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this._saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._saveBtn.Location = new System.Drawing.Point(652, 452);
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
            this._deleteBtn.Location = new System.Drawing.Point(752, 452);
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
            this._loadBtn.Location = new System.Drawing.Point(652, 403);
            this._loadBtn.Name = "_loadBtn";
            this._loadBtn.Size = new System.Drawing.Size(193, 43);
            this._loadBtn.TabIndex = 19;
            this._loadBtn.Text = "laden";
            this._loadBtn.UseVisualStyleBackColor = false;
            this._loadBtn.Click += new System.EventHandler(this._loadBtn_Click);
            // 
            // _previousBtn
            // 
            this._previousBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._previousBtn.BackColor = System.Drawing.Color.White;
            this._previousBtn.Enabled = false;
            this._previousBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this._previousBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._previousBtn.Location = new System.Drawing.Point(753, 151);
            this._previousBtn.Name = "_previousBtn";
            this._previousBtn.Size = new System.Drawing.Size(92, 43);
            this._previousBtn.TabIndex = 20;
            this._previousBtn.Text = "zurück";
            this._previousBtn.UseVisualStyleBackColor = false;
            // 
            // _speedTrackbar
            // 
            this._speedTrackbar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._speedTrackbar.Location = new System.Drawing.Point(710, 200);
            this._speedTrackbar.Maximum = 250;
            this._speedTrackbar.Minimum = 1;
            this._speedTrackbar.Name = "_speedTrackbar";
            this._speedTrackbar.Size = new System.Drawing.Size(136, 69);
            this._speedTrackbar.TabIndex = 250;
            this._speedTrackbar.TickFrequency = 10;
            this._speedTrackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this._speedTrackbar.Value = 250;
            this._speedTrackbar.Scroll += new System.EventHandler(this._speedTrackbar_Scroll);
            // 
            // _speedLbl
            // 
            this._speedLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._speedLbl.AutoSize = true;
            this._speedLbl.Location = new System.Drawing.Point(652, 212);
            this._speedLbl.Name = "_speedLbl";
            this._speedLbl.Size = new System.Drawing.Size(58, 20);
            this._speedLbl.TabIndex = 22;
            this._speedLbl.Text = "Tempo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(868, 664);
            this.Controls.Add(this._speedLbl);
            this.Controls.Add(this._speedTrackbar);
            this.Controls.Add(this._previousBtn);
            this.Controls.Add(this._loadBtn);
            this.Controls.Add(this._deleteBtn);
            this.Controls.Add(this._saveBtn);
            this.Controls.Add(this._textBoxDimension);
            this.Controls.Add(this.GridPanel);
            this.Controls.Add(this._comboBox);
            this.Controls.Add(this._amountGenLbl);
            this.Controls.Add(this._amountAliveLbl);
            this.Controls.Add(this._colorDeadLbl);
            this.Controls.Add(this._colorDeadBtn);
            this.Controls.Add(this._colorAliveLbl);
            this.Controls.Add(this._colorAliveBtn);
            this.Controls.Add(this._resetBtn);
            this.Controls.Add(this._nextBtn);
            this.Controls.Add(this._stopBtn);
            this.Controls.Add(this._startBtn);
            this.Controls.Add(this._rulesBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(890, 720);
            this.MinimumSize = new System.Drawing.Size(890, 720);
            this.Name = "Form1";
            this.Text = "Zellensimulation v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this._speedTrackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _rulesBtn;
        private System.Windows.Forms.Button _startBtn;
        private System.Windows.Forms.Button _stopBtn;
        private System.Windows.Forms.Button _nextBtn;
        private System.Windows.Forms.Button _resetBtn;
        private System.Windows.Forms.Button _colorAliveBtn;
        private System.Windows.Forms.Label _colorAliveLbl;
        private System.Windows.Forms.ColorDialog _colorDialog1;
        private System.Windows.Forms.Label _colorDeadLbl;
        private System.Windows.Forms.Button _colorDeadBtn;
        private System.Windows.Forms.Label _amountAliveLbl;
        private System.Windows.Forms.ColorDialog _colorDialog2;
        private System.Windows.Forms.Label _amountGenLbl;
        private System.ComponentModel.BackgroundWorker _backgroundWorker;
        private System.Windows.Forms.ComboBox _comboBox;
        private System.Windows.Forms.Panel GridPanel;
        private System.Windows.Forms.TextBox _textBoxDimension;
        private System.Windows.Forms.Button _saveBtn;
        private System.Windows.Forms.Button _deleteBtn;
        private System.Windows.Forms.Button _loadBtn;
        private System.Windows.Forms.Button _previousBtn;
        private System.Windows.Forms.TrackBar _speedTrackbar;
        private System.Windows.Forms.Label _speedLbl;
    }
}

