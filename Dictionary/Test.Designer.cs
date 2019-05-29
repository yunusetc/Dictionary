namespace Dictionary
{
    partial class Test
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.questionLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trengRadioButton = new System.Windows.Forms.RadioButton();
            this.checkButton = new System.Windows.Forms.Button();
            this.engtrRadioButton = new System.Windows.Forms.RadioButton();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.correctLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.actionButton = new System.Windows.Forms.Button();
            this.correctCountLabel = new System.Windows.Forms.Label();
            this.labelp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.incorrectCountLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.stopButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.questionLabel.Location = new System.Drawing.Point(53, 69);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(98, 25);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "Question";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(495, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trengRadioButton);
            this.groupBox1.Controls.Add(this.checkButton);
            this.groupBox1.Controls.Add(this.engtrRadioButton);
            this.groupBox1.Controls.Add(this.answerTextBox);
            this.groupBox1.Controls.Add(this.questionLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(139, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 229);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Question";
            // 
            // trengRadioButton
            // 
            this.trengRadioButton.AutoSize = true;
            this.trengRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.trengRadioButton.Location = new System.Drawing.Point(16, 177);
            this.trengRadioButton.Name = "trengRadioButton";
            this.trengRadioButton.Size = new System.Drawing.Size(135, 24);
            this.trengRadioButton.TabIndex = 8;
            this.trengRadioButton.TabStop = true;
            this.trengRadioButton.Text = "Turkish-English";
            this.trengRadioButton.UseVisualStyleBackColor = true;
            // 
            // checkButton
            // 
            this.checkButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.checkButton.ForeColor = System.Drawing.Color.White;
            this.checkButton.Location = new System.Drawing.Point(229, 140);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(104, 62);
            this.checkButton.TabIndex = 2;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = false;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // engtrRadioButton
            // 
            this.engtrRadioButton.AutoSize = true;
            this.engtrRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.engtrRadioButton.Location = new System.Drawing.Point(16, 154);
            this.engtrRadioButton.Name = "engtrRadioButton";
            this.engtrRadioButton.Size = new System.Drawing.Size(135, 24);
            this.engtrRadioButton.TabIndex = 7;
            this.engtrRadioButton.TabStop = true;
            this.engtrRadioButton.Text = "English-Turkish";
            this.engtrRadioButton.UseVisualStyleBackColor = true;
            // 
            // answerTextBox
            // 
            this.answerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.answerTextBox.Location = new System.Drawing.Point(147, 63);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(133, 31);
            this.answerTextBox.TabIndex = 1;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(573, 205);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(27, 20);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "15";
            // 
            // correctLabel
            // 
            this.correctLabel.AutoSize = true;
            this.correctLabel.Location = new System.Drawing.Point(12, 488);
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(35, 13);
            this.correctLabel.TabIndex = 3;
            this.correctLabel.Text = "label4";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(601, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(104, 62);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // actionButton
            // 
            this.actionButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.actionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.actionButton.ForeColor = System.Drawing.Color.White;
            this.actionButton.Location = new System.Drawing.Point(359, 439);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(104, 62);
            this.actionButton.TabIndex = 4;
            this.actionButton.Text = "Start";
            this.actionButton.UseVisualStyleBackColor = false;
            this.actionButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // correctCountLabel
            // 
            this.correctCountLabel.AutoSize = true;
            this.correctCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.correctCountLabel.ForeColor = System.Drawing.Color.White;
            this.correctCountLabel.Location = new System.Drawing.Point(573, 245);
            this.correctCountLabel.Name = "correctCountLabel";
            this.correctCountLabel.Size = new System.Drawing.Size(18, 20);
            this.correctCountLabel.TabIndex = 5;
            this.correctCountLabel.Text = "0";
            // 
            // labelp
            // 
            this.labelp.AutoSize = true;
            this.labelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelp.ForeColor = System.Drawing.Color.White;
            this.labelp.Location = new System.Drawing.Point(495, 245);
            this.labelp.Name = "labelp";
            this.labelp.Size = new System.Drawing.Size(61, 20);
            this.labelp.TabIndex = 6;
            this.labelp.Text = "Correct";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(495, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Incorrect";
            // 
            // incorrectCountLabel
            // 
            this.incorrectCountLabel.AutoSize = true;
            this.incorrectCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.incorrectCountLabel.ForeColor = System.Drawing.Color.White;
            this.incorrectCountLabel.Location = new System.Drawing.Point(573, 284);
            this.incorrectCountLabel.Name = "incorrectCountLabel";
            this.incorrectCountLabel.Size = new System.Drawing.Size(18, 20);
            this.incorrectCountLabel.TabIndex = 8;
            this.incorrectCountLabel.Text = "0";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stopButton.ForeColor = System.Drawing.Color.White;
            this.stopButton.Location = new System.Drawing.Point(175, 436);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(104, 62);
            this.stopButton.TabIndex = 9;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(175, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(281, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 39);
            this.label3.TabIndex = 11;
            this.label3.Text = "TEST";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(717, 510);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.incorrectCountLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelp);
            this.Controls.Add(this.correctCountLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.actionButton);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.correctLabel);
            this.Controls.Add(this.groupBox1);
            this.Name = "Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dictionary";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label correctLabel;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button actionButton;
        private System.Windows.Forms.Label correctCountLabel;
        private System.Windows.Forms.Label labelp;
        private System.Windows.Forms.RadioButton trengRadioButton;
        private System.Windows.Forms.RadioButton engtrRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label incorrectCountLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}