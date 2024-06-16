namespace Lab31
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
            processListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // processListView
            // 
            processListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            processListView.Location = new Point(13, 43);
            processListView.Margin = new Padding(4, 3, 4, 3);
            processListView.Name = "processListView";
            processListView.Size = new Size(376, 355);
            processListView.TabIndex = 0;
            processListView.UseCompatibleStateImageBehavior = false;
            processListView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Process Name";
            columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "ID";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 8F);
            button1.Location = new Point(109, 10);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(88, 27);
            button1.TabIndex = 1;
            button1.Text = "ЗУПИНИТИ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += stopProcessButton_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 8F);
            button2.Location = new Point(13, 10);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(88, 27);
            button2.TabIndex = 2;
            button2.Text = "ОНОВИТИ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += refreshButton_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 8F);
            button3.Location = new Point(205, 10);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(88, 27);
            button3.TabIndex = 3;
            button3.Text = "ЕКСПОРТ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += exportButton_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 8F);
            button4.Location = new Point(301, 10);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(88, 27);
            button4.TabIndex = 4;
            button4.Text = "ПРО ПРОЦЕС";
            button4.UseVisualStyleBackColor = true;
            button4.Click += processDetailsButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 410);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(processListView);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Lab31";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListView processListView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

