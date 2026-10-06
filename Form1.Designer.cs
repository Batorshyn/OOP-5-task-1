namespace OOP_5_task_1
{
    partial class MainForm
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
            lblSide1 = new Label();
            txtSide1 = new TextBox();
            lblSide2 = new Label();
            txtSide2 = new TextBox();
            lblMult = new Label();
            txtMultiplier = new TextBox();
            btnTest = new Button();
            rtbOutput = new RichTextBox();
            SuspendLayout();
            // 
            // lblSide1
            // 
            lblSide1.Location = new Point(20, 20);
            lblSide1.Name = "lblSide1";
            lblSide1.Size = new Size(120, 15);
            lblSide1.TabIndex = 0;
            lblSide1.Text = "Сторона квадрата 1:";
            // 
            // txtSide1
            // 
            txtSide1.Location = new Point(150, 17);
            txtSide1.Name = "txtSide1";
            txtSide1.Size = new Size(100, 23);
            txtSide1.TabIndex = 1;
            // 
            // lblSide2
            // 
            lblSide2.Location = new Point(20, 50);
            lblSide2.Name = "lblSide2";
            lblSide2.Size = new Size(120, 15);
            lblSide2.TabIndex = 2;
            lblSide2.Text = "Сторона квадрата 2:";
            // 
            // txtSide2
            // 
            txtSide2.Location = new Point(150, 47);
            txtSide2.Name = "txtSide2";
            txtSide2.Size = new Size(100, 23);
            txtSide2.TabIndex = 3;
            // 
            // lblMult
            // 
            lblMult.Location = new Point(20, 80);
            lblMult.Name = "lblMult";
            lblMult.Size = new Size(120, 15);
            lblMult.TabIndex = 4;
            lblMult.Text = "Множник (для *):";
            // 
            // txtMultiplier
            // 
            txtMultiplier.Location = new Point(150, 77);
            txtMultiplier.Name = "txtMultiplier";
            txtMultiplier.Size = new Size(100, 23);
            txtMultiplier.TabIndex = 5;
            // 
            // btnTest
            // 
            btnTest.Location = new Point(20, 110);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(230, 30);
            btnTest.TabIndex = 6;
            btnTest.Text = "Виконати тестування";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // rtbOutput
            // 
            rtbOutput.Location = new Point(20, 150);
            rtbOutput.Name = "rtbOutput";
            rtbOutput.ReadOnly = true;
            rtbOutput.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbOutput.Size = new Size(440, 240);
            rtbOutput.TabIndex = 7;
            rtbOutput.Text = "";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 411);
            Controls.Add(rtbOutput);
            Controls.Add(btnTest);
            Controls.Add(txtMultiplier);
            Controls.Add(lblMult);
            Controls.Add(txtSide2);
            Controls.Add(lblSide2);
            Controls.Add(txtSide1);
            Controls.Add(lblSide1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Квадрат";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSide1;
        private TextBox txtSide1;
        private Label lblSide2;
        private TextBox txtSide2;
        private Label lblMult;
        private TextBox txtMultiplier;
        private Button btnTest;
        private RichTextBox rtbOutput;
    }
}
