namespace library_tracking_system
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
            groupBox1 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            checkBox1 = new CheckBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            textBox3 = new TextBox();
            groupBox3 = new GroupBox();
            listBox1 = new ListBox();
            groupBox4 = new GroupBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            button5 = new Button();
            button6 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(29, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(411, 369);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Book Info";
            // 
            // button4
            // 
            button4.Location = new Point(260, 280);
            button4.Name = "button4";
            button4.Size = new Size(90, 60);
            button4.TabIndex = 13;
            button4.Text = "List";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(140, 280);
            button3.Name = "button3";
            button3.Size = new Size(90, 60);
            button3.TabIndex = 12;
            button3.Text = "Clean";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(20, 280);
            button2.Name = "button2";
            button2.Size = new Size(90, 60);
            button2.TabIndex = 11;
            button2.Text = "Add Book";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(178, 177);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(125, 27);
            numericUpDown1.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(178, 137);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 28);
            comboBox1.TabIndex = 9;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(208, 220);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(56, 24);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "No.";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(178, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(178, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(6, 220);
            label6.Name = "label6";
            label6.Size = new Size(187, 20);
            label6.TabIndex = 5;
            label6.Text = "Is it currently in the library?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(6, 180);
            label5.Name = "label5";
            label5.Size = new Size(126, 20);
            label5.TabIndex = 4;
            label5.Text = "Number of Pages:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(6, 140);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 3;
            label4.Text = "Genre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(6, 100);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 2;
            label3.Text = "Author:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(6, 60);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Book Title:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(330, 20);
            label1.TabIndex = 0;
            label1.Text = "This section is for adding book details to system.";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(527, 48);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(465, 72);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Search ";
            // 
            // button1
            // 
            button1.Location = new Point(340, 20);
            button1.Name = "button1";
            button1.Size = new Size(78, 39);
            button1.TabIndex = 1;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox3.Location = new Point(19, 26);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Type a book title or author name to search.";
            textBox3.Size = new Size(279, 27);
            textBox3.TabIndex = 0;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(listBox1);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox3.Location = new Point(527, 126);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(465, 291);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Genre List";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(19, 33);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(431, 244);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(listView1);
            groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox4.Location = new Point(29, 423);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(963, 239);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Book List";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(23, 26);
            listView1.Name = "listView1";
            listView1.Size = new Size(921, 207);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Book Name";
            columnHeader1.Width = 187;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Author";
            columnHeader2.Width = 187;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Genre";
            columnHeader3.Width = 187;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Page Number";
            columnHeader4.Width = 187;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Is Available?";
            columnHeader5.Width = 187;
            // 
            // button5
            // 
            button5.Location = new Point(379, 708);
            button5.Name = "button5";
            button5.Size = new Size(90, 60);
            button5.TabIndex = 4;
            button5.Text = "Delete Selected";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(546, 708);
            button6.Name = "button6";
            button6.Size = new Size(90, 60);
            button6.TabIndex = 5;
            button6.Text = "Show Selected";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 815);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Library Book Tracking System";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private ListBox listBox1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label6;
        private CheckBox checkBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private ListView listView1;
        private Button button5;
        private Button button6;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}