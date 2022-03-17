
namespace Instruments3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TableZ = new System.Windows.Forms.DataGridView();
            this.NormalTable = new System.Windows.Forms.DataGridView();
            this.criteriesCount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BadTable = new System.Windows.Forms.DataGridView();
            this.solver = new System.Windows.Forms.Button();
            this.L = new System.Windows.Forms.DataGridView();
            this.answerBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.minBox = new System.Windows.Forms.TextBox();
            this.maxBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NormalTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.criteriesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BadTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "критерии";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "варианты";
            // 
            // TableZ
            // 
            this.TableZ.AllowUserToAddRows = false;
            this.TableZ.AllowUserToDeleteRows = false;
            this.TableZ.AllowUserToResizeColumns = false;
            this.TableZ.AllowUserToResizeRows = false;
            this.TableZ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableZ.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TableZ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableZ.Location = new System.Drawing.Point(621, 34);
            this.TableZ.Name = "TableZ";
            this.TableZ.RowHeadersVisible = false;
            this.TableZ.RowHeadersWidth = 51;
            this.TableZ.RowTemplate.Height = 24;
            this.TableZ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.TableZ.ShowEditingIcon = false;
            this.TableZ.Size = new System.Drawing.Size(488, 150);
            this.TableZ.TabIndex = 5;
            // 
            // NormalTable
            // 
            this.NormalTable.AllowUserToAddRows = false;
            this.NormalTable.AllowUserToDeleteRows = false;
            this.NormalTable.AllowUserToResizeColumns = false;
            this.NormalTable.AllowUserToResizeRows = false;
            this.NormalTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NormalTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.NormalTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NormalTable.Location = new System.Drawing.Point(15, 145);
            this.NormalTable.Name = "NormalTable";
            this.NormalTable.ReadOnly = true;
            this.NormalTable.RowHeadersWidth = 51;
            this.NormalTable.RowTemplate.Height = 24;
            this.NormalTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.NormalTable.Size = new System.Drawing.Size(488, 150);
            this.NormalTable.TabIndex = 10;
            // 
            // criteriesCount
            // 
            this.criteriesCount.Location = new System.Drawing.Point(112, 32);
            this.criteriesCount.Name = "criteriesCount";
            this.criteriesCount.Size = new System.Drawing.Size(120, 22);
            this.criteriesCount.TabIndex = 11;
            this.criteriesCount.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(112, 72);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 12;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Матрица согласия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Матрица несогласия";
            // 
            // BadTable
            // 
            this.BadTable.AllowUserToAddRows = false;
            this.BadTable.AllowUserToDeleteRows = false;
            this.BadTable.AllowUserToResizeColumns = false;
            this.BadTable.AllowUserToResizeRows = false;
            this.BadTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BadTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.BadTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BadTable.Location = new System.Drawing.Point(15, 352);
            this.BadTable.Name = "BadTable";
            this.BadTable.ReadOnly = true;
            this.BadTable.RowHeadersWidth = 51;
            this.BadTable.RowTemplate.Height = 24;
            this.BadTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.BadTable.Size = new System.Drawing.Size(488, 150);
            this.BadTable.TabIndex = 16;
            // 
            // solver
            // 
            this.solver.Location = new System.Drawing.Point(238, 32);
            this.solver.Name = "solver";
            this.solver.Size = new System.Drawing.Size(159, 62);
            this.solver.TabIndex = 17;
            this.solver.Text = "Решить";
            this.solver.UseVisualStyleBackColor = true;
            this.solver.Click += new System.EventHandler(this.solver_Click);
            // 
            // L
            // 
            this.L.AllowUserToAddRows = false;
            this.L.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.L.BackgroundColor = System.Drawing.SystemColors.Control;
            this.L.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.L.GridColor = System.Drawing.SystemColors.ControlLight;
            this.L.Location = new System.Drawing.Point(621, 216);
            this.L.Name = "L";
            this.L.RowHeadersWidth = 51;
            this.L.RowTemplate.Height = 24;
            this.L.Size = new System.Drawing.Size(488, 53);
            this.L.TabIndex = 18;
            // 
            // answerBox
            // 
            this.answerBox.Location = new System.Drawing.Point(15, 575);
            this.answerBox.Multiline = true;
            this.answerBox.Name = "answerBox";
            this.answerBox.ReadOnly = true;
            this.answerBox.Size = new System.Drawing.Size(488, 88);
            this.answerBox.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 509);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 545);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "max";
            // 
            // minBox
            // 
            this.minBox.Location = new System.Drawing.Point(50, 509);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(105, 22);
            this.minBox.TabIndex = 22;
            // 
            // maxBox
            // 
            this.maxBox.Location = new System.Drawing.Point(50, 545);
            this.maxBox.Name = "maxBox";
            this.maxBox.Size = new System.Drawing.Size(105, 22);
            this.maxBox.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 58);
            this.button1.TabIndex = 24;
            this.button1.Text = "Получить ответ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 699);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maxBox);
            this.Controls.Add(this.minBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.L);
            this.Controls.Add(this.solver);
            this.Controls.Add(this.BadTable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.criteriesCount);
            this.Controls.Add(this.NormalTable);
            this.Controls.Add(this.TableZ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Задание 3";
            ((System.ComponentModel.ISupportInitialize)(this.TableZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NormalTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.criteriesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BadTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView TableZ;
        private System.Windows.Forms.DataGridView NormalTable;
        private System.Windows.Forms.NumericUpDown criteriesCount;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView BadTable;
        private System.Windows.Forms.Button solver;
        private System.Windows.Forms.DataGridView L;
        private System.Windows.Forms.TextBox answerBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox minBox;
        private System.Windows.Forms.TextBox maxBox;
        private System.Windows.Forms.Button button1;
    }
}

