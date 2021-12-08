
namespace Lb2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxIncome = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.ButtonMonhtlyIncome = new System.Windows.Forms.Button();
            this.buttonHalfYearIncome = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.numericUpDownRooms = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStaff = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStudents = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPayment = new System.Windows.Forms.NumericUpDown();
            this.buttonAnnualIncome = new System.Windows.Forms.Button();
            this.buttonIncreasing = new System.Windows.Forms.Button();
            this.numericUpDownIncreasing = new System.Windows.Forms.NumericUpDown();
            this.buttonCheckIn = new System.Windows.Forms.Button();
            this.buttonCheckOut = new System.Windows.Forms.Button();
            this.numericUpDownCheckIn = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCheckOut = new System.Windows.Forms.NumericUpDown();
            this.buttonCanteen = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIncreasing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCheckIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCheckOut)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(888, 199);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBoxIncome
            // 
            this.textBoxIncome.Location = new System.Drawing.Point(317, 252);
            this.textBoxIncome.Multiline = true;
            this.textBoxIncome.Name = "textBoxIncome";
            this.textBoxIncome.Size = new System.Drawing.Size(133, 53);
            this.textBoxIncome.TabIndex = 1;
            this.textBoxIncome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 252);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(133, 53);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(147, 252);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(133, 53);
            this.textBoxAddress.TabIndex = 3;
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(6, 463);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(72, 31);
            this.EnterButton.TabIndex = 4;
            this.EnterButton.Text = "Ввод";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // ButtonMonhtlyIncome
            // 
            this.ButtonMonhtlyIncome.Location = new System.Drawing.Point(86, 463);
            this.ButtonMonhtlyIncome.Name = "ButtonMonhtlyIncome";
            this.ButtonMonhtlyIncome.Size = new System.Drawing.Size(103, 31);
            this.ButtonMonhtlyIncome.TabIndex = 5;
            this.ButtonMonhtlyIncome.Text = "Доход за месяц";
            this.ButtonMonhtlyIncome.UseVisualStyleBackColor = true;
            this.ButtonMonhtlyIncome.Click += new System.EventHandler(this.buttonMonhtlyIncome_Click);
            // 
            // buttonHalfYearIncome
            // 
            this.buttonHalfYearIncome.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonHalfYearIncome.Location = new System.Drawing.Point(195, 463);
            this.buttonHalfYearIncome.Name = "buttonHalfYearIncome";
            this.buttonHalfYearIncome.Size = new System.Drawing.Size(114, 31);
            this.buttonHalfYearIncome.TabIndex = 6;
            this.buttonHalfYearIncome.Text = "Доход за полгода ";
            this.buttonHalfYearIncome.UseVisualStyleBackColor = true;
            this.buttonHalfYearIncome.Click += new System.EventHandler(this.buttonHalfYearIncome_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(944, 456);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(103, 44);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.button4_Click);
            // 
            // numericUpDownRooms
            // 
            this.numericUpDownRooms.Location = new System.Drawing.Point(31, 342);
            this.numericUpDownRooms.Name = "numericUpDownRooms";
            this.numericUpDownRooms.Size = new System.Drawing.Size(53, 23);
            this.numericUpDownRooms.TabIndex = 8;
            // 
            // numericUpDownStaff
            // 
            this.numericUpDownStaff.Location = new System.Drawing.Point(132, 342);
            this.numericUpDownStaff.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownStaff.Name = "numericUpDownStaff";
            this.numericUpDownStaff.Size = new System.Drawing.Size(53, 23);
            this.numericUpDownStaff.TabIndex = 9;
            // 
            // numericUpDownStudents
            // 
            this.numericUpDownStudents.Location = new System.Drawing.Point(243, 342);
            this.numericUpDownStudents.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownStudents.Name = "numericUpDownStudents";
            this.numericUpDownStudents.Size = new System.Drawing.Size(53, 23);
            this.numericUpDownStudents.TabIndex = 10;
            this.numericUpDownStudents.ValueChanged += new System.EventHandler(this.numericUpDownStudents_ValueChanged);
            // 
            // numericUpDownPayment
            // 
            this.numericUpDownPayment.Location = new System.Drawing.Point(333, 342);
            this.numericUpDownPayment.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownPayment.Name = "numericUpDownPayment";
            this.numericUpDownPayment.Size = new System.Drawing.Size(53, 23);
            this.numericUpDownPayment.TabIndex = 11;
            // 
            // buttonAnnualIncome
            // 
            this.buttonAnnualIncome.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAnnualIncome.Location = new System.Drawing.Point(311, 463);
            this.buttonAnnualIncome.Name = "buttonAnnualIncome";
            this.buttonAnnualIncome.Size = new System.Drawing.Size(103, 31);
            this.buttonAnnualIncome.TabIndex = 12;
            this.buttonAnnualIncome.Text = "Доход за год";
            this.buttonAnnualIncome.UseVisualStyleBackColor = true;
            this.buttonAnnualIncome.Click += new System.EventHandler(this.buttonAnnualIncome_Click);
            // 
            // buttonIncreasing
            // 
            this.buttonIncreasing.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonIncreasing.Location = new System.Drawing.Point(420, 463);
            this.buttonIncreasing.Name = "buttonIncreasing";
            this.buttonIncreasing.Size = new System.Drawing.Size(82, 31);
            this.buttonIncreasing.TabIndex = 13;
            this.buttonIncreasing.Text = "Оплата";
            this.buttonIncreasing.UseVisualStyleBackColor = true;
            this.buttonIncreasing.Click += new System.EventHandler(this.buttonIncreasing_Click);
            // 
            // numericUpDownIncreasing
            // 
            this.numericUpDownIncreasing.Location = new System.Drawing.Point(449, 342);
            this.numericUpDownIncreasing.Name = "numericUpDownIncreasing";
            this.numericUpDownIncreasing.Size = new System.Drawing.Size(53, 23);
            this.numericUpDownIncreasing.TabIndex = 14;
            // 
            // buttonCheckIn
            // 
            this.buttonCheckIn.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonCheckIn.Location = new System.Drawing.Point(508, 463);
            this.buttonCheckIn.Name = "buttonCheckIn";
            this.buttonCheckIn.Size = new System.Drawing.Size(81, 32);
            this.buttonCheckIn.TabIndex = 15;
            this.buttonCheckIn.Text = "Заселение";
            this.buttonCheckIn.UseVisualStyleBackColor = true;
            this.buttonCheckIn.Click += new System.EventHandler(this.buttonCheckIn_Click);
            // 
            // buttonCheckOut
            // 
            this.buttonCheckOut.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonCheckOut.Location = new System.Drawing.Point(595, 463);
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.Size = new System.Drawing.Size(79, 32);
            this.buttonCheckOut.TabIndex = 16;
            this.buttonCheckOut.Text = "Выселение";
            this.buttonCheckOut.UseVisualStyleBackColor = true;
            this.buttonCheckOut.Click += new System.EventHandler(this.buttonCheckOut_Click);
            // 
            // numericUpDownCheckIn
            // 
            this.numericUpDownCheckIn.Location = new System.Drawing.Point(622, 342);
            this.numericUpDownCheckIn.Name = "numericUpDownCheckIn";
            this.numericUpDownCheckIn.Size = new System.Drawing.Size(65, 23);
            this.numericUpDownCheckIn.TabIndex = 17;
            // 
            // numericUpDownCheckOut
            // 
            this.numericUpDownCheckOut.Location = new System.Drawing.Point(712, 342);
            this.numericUpDownCheckOut.Name = "numericUpDownCheckOut";
            this.numericUpDownCheckOut.Size = new System.Drawing.Size(71, 23);
            this.numericUpDownCheckOut.TabIndex = 18;
            // 
            // buttonCanteen
            // 
            this.buttonCanteen.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonCanteen.Location = new System.Drawing.Point(680, 464);
            this.buttonCanteen.Name = "buttonCanteen";
            this.buttonCanteen.Size = new System.Drawing.Size(79, 32);
            this.buttonCanteen.TabIndex = 19;
            this.buttonCanteen.Text = "Столовая";
            this.buttonCanteen.UseVisualStyleBackColor = true;
            this.buttonCanteen.Click += new System.EventHandler(this.buttonCanteen_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonCopy.Location = new System.Drawing.Point(765, 463);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(88, 32);
            this.buttonCopy.TabIndex = 20;
            this.buttonCopy.Text = "Копировать";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonDisplay.Location = new System.Drawing.Point(859, 463);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(79, 32);
            this.buttonDisplay.TabIndex = 21;
            this.buttonDisplay.Text = "Отобразить";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Название университета";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Адрес ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Доход";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Кол-во комнат";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Кол-во персонала";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "Кол-во студентов";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(333, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "Оплата";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(413, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "Увеличение кол-ва комнат";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(622, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 15);
            this.label9.TabIndex = 30;
            this.label9.Text = "Заселение";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(712, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 15);
            this.label10.TabIndex = 31;
            this.label10.Text = "Выселение ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 512);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonCanteen);
            this.Controls.Add(this.numericUpDownCheckOut);
            this.Controls.Add(this.numericUpDownCheckIn);
            this.Controls.Add(this.buttonCheckOut);
            this.Controls.Add(this.buttonCheckIn);
            this.Controls.Add(this.numericUpDownIncreasing);
            this.Controls.Add(this.buttonIncreasing);
            this.Controls.Add(this.buttonAnnualIncome);
            this.Controls.Add(this.numericUpDownPayment);
            this.Controls.Add(this.numericUpDownStudents);
            this.Controls.Add(this.numericUpDownStaff);
            this.Controls.Add(this.numericUpDownRooms);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonHalfYearIncome);
            this.Controls.Add(this.ButtonMonhtlyIncome);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxIncome);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIncreasing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCheckIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCheckOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxIncome;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button ButtonMonhtlyIncome;
        private System.Windows.Forms.Button buttonHalfYearIncome;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.NumericUpDown numericUpDownRooms;
        private System.Windows.Forms.NumericUpDown numericUpDownStaff;
        private System.Windows.Forms.NumericUpDown numericUpDownStudents;
        private System.Windows.Forms.NumericUpDown numericUpDownPayment;
        private System.Windows.Forms.Button buttonAnnualIncome;
        private System.Windows.Forms.Button buttonIncreasing;
        private System.Windows.Forms.NumericUpDown numericUpDownIncreasing;
        private System.Windows.Forms.Button buttonCheckIn;
        private System.Windows.Forms.Button buttonCheckOut;
        private System.Windows.Forms.NumericUpDown numericUpDownCheckIn;
        private System.Windows.Forms.NumericUpDown numericUpDownCheckOut;
        private System.Windows.Forms.Button buttonCanteen;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

