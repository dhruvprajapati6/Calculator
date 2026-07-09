namespace Ex_3_WidForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnadd = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnsub = new Button();
            btnmul = new Button();
            btndiv = new Button();
            label3 = new Label();
            labresult = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnclear = new Button();
            btnexit = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnadd
            // 
            btnadd.BackColor = SystemColors.ActiveBorder;
            btnadd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnadd.ForeColor = SystemColors.ActiveCaptionText;
            btnadd.Location = new Point(117, 275);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(48, 41);
            btnadd.TabIndex = 0;
            btnadd.Text = "+";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 45);
            label1.Name = "label1";
            label1.Size = new Size(127, 23);
            label1.TabIndex = 1;
            label1.Text = "Enter No One :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AllowDrop = true;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(5, 100);
            label2.Name = "label2";
            label2.Size = new Size(128, 23);
            label2.TabIndex = 2;
            label2.Text = "Enter No Two :";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.AllowDrop = true;
            textBox1.Location = new Point(169, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.AllowDrop = true;
            textBox2.Location = new Point(169, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(140, 27);
            textBox2.TabIndex = 4;
            // 
            // btnsub
            // 
            btnsub.BackColor = SystemColors.ActiveCaption;
            btnsub.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsub.Location = new Point(197, 275);
            btnsub.Name = "btnsub";
            btnsub.Size = new Size(48, 41);
            btnsub.TabIndex = 5;
            btnsub.Text = "-";
            btnsub.UseVisualStyleBackColor = false;
            btnsub.Click += btnsub_Click;
            // 
            // btnmul
            // 
            btnmul.BackColor = Color.DarkOrange;
            btnmul.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnmul.Location = new Point(283, 275);
            btnmul.Name = "btnmul";
            btnmul.Size = new Size(48, 41);
            btnmul.TabIndex = 6;
            btnmul.Text = "*";
            btnmul.UseVisualStyleBackColor = false;
            btnmul.Click += btnmul_Click;
            // 
            // btndiv
            // 
            btndiv.BackColor = Color.LightCoral;
            btndiv.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndiv.Location = new Point(366, 275);
            btndiv.Name = "btndiv";
            btndiv.Size = new Size(48, 41);
            btndiv.TabIndex = 7;
            btndiv.Text = "/";
            btndiv.UseVisualStyleBackColor = false;
            btndiv.Click += btndiv_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightPink;
            label3.Location = new Point(218, 35);
            label3.Name = "label3";
            label3.Size = new Size(132, 20);
            label3.TabIndex = 8;
            label3.Text = "Simple-Calculator";
            label3.Click += label3_Click;
            // 
            // labresult
            // 
            labresult.AutoSize = true;
            labresult.BorderStyle = BorderStyle.FixedSingle;
            labresult.Location = new Point(6, 38);
            labresult.Name = "labresult";
            labresult.Size = new Size(74, 22);
            labresult.TabIndex = 9;
            labresult.Text = "Result  =";
            labresult.Click += labresult_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(92, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(412, 166);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "📱";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(labresult);
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(98, 334);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(362, 71);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "📲";
            // 
            // btnclear
            // 
            btnclear.BackColor = Color.Chartreuse;
            btnclear.Location = new Point(151, 435);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(94, 29);
            btnclear.TabIndex = 13;
            btnclear.Text = "🔄️ Clear";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // btnexit
            // 
            btnexit.BackColor = Color.Brown;
            btnexit.Location = new Point(319, 435);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(94, 29);
            btnexit.TabIndex = 14;
            btnexit.Text = "❌ Exit";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(608, 487);
            Controls.Add(btnexit);
            Controls.Add(btnclear);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(btndiv);
            Controls.Add(btnmul);
            Controls.Add(btnsub);
            Controls.Add(btnadd);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnadd;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnsub;
        private Button btnmul;
        private Button btndiv;
        private Label label3;
        private Label labresult;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnclear;
        private Button btnexit;
    }
}
