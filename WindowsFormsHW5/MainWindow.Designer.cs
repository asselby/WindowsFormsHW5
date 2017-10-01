namespace WindowsFormsHW5
{
    partial class MainWindow
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.PatronimicLabel = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.extraLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.extraBox = new System.Windows.Forms.TextBox();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.sexBox = new System.Windows.Forms.TextBox();
            this.patronymicBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(42, 9);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(53, 24);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Имя";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameLabel.Location = new System.Drawing.Point(42, 49);
            this.surnameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(107, 24);
            this.surnameLabel.TabIndex = 1;
            this.surnameLabel.Text = "Фамилия";
            // 
            // PatronimicLabel
            // 
            this.PatronimicLabel.AutoSize = true;
            this.PatronimicLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatronimicLabel.Location = new System.Drawing.Point(42, 97);
            this.PatronimicLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PatronimicLabel.Name = "PatronimicLabel";
            this.PatronimicLabel.Size = new System.Drawing.Size(106, 24);
            this.PatronimicLabel.TabIndex = 2;
            this.PatronimicLabel.Text = "Отчество";
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sexLabel.Location = new System.Drawing.Point(42, 144);
            this.sexLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(50, 24);
            this.sexLabel.TabIndex = 3;
            this.sexLabel.Text = "Пол";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 305);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 24);
            this.label5.TabIndex = 4;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.Location = new System.Drawing.Point(46, 186);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(233, 24);
            this.dateLabel.TabIndex = 5;
            this.dateLabel.Text = "Год и дата рождения";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.Location = new System.Drawing.Point(46, 230);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(201, 24);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "Семейный статус";
            // 
            // extraLabel
            // 
            this.extraLabel.AutoSize = true;
            this.extraLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.extraLabel.Location = new System.Drawing.Point(46, 275);
            this.extraLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.extraLabel.Name = "extraLabel";
            this.extraLabel.Size = new System.Drawing.Size(336, 24);
            this.extraLabel.TabIndex = 7;
            this.extraLabel.Text = "Дополнительная информация";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(431, 6);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(257, 33);
            this.nameBox.TabIndex = 8;
            // 
            // extraBox
            // 
            this.extraBox.Location = new System.Drawing.Point(431, 275);
            this.extraBox.Name = "extraBox";
            this.extraBox.Size = new System.Drawing.Size(257, 33);
            this.extraBox.TabIndex = 10;
            // 
            // statusBox
            // 
            this.statusBox.Location = new System.Drawing.Point(431, 230);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(257, 33);
            this.statusBox.TabIndex = 11;
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(431, 186);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(257, 33);
            this.dateBox.TabIndex = 12;
            // 
            // sexBox
            // 
            this.sexBox.Location = new System.Drawing.Point(431, 135);
            this.sexBox.Name = "sexBox";
            this.sexBox.Size = new System.Drawing.Size(257, 33);
            this.sexBox.TabIndex = 13;
            // 
            // patronymicBox
            // 
            this.patronymicBox.Location = new System.Drawing.Point(431, 88);
            this.patronymicBox.Name = "patronymicBox";
            this.patronymicBox.Size = new System.Drawing.Size(257, 33);
            this.patronymicBox.TabIndex = 14;
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(431, 45);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(257, 33);
            this.surnameBox.TabIndex = 15;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(60, 356);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(203, 46);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Сохранить файл";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(529, 356);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(179, 46);
            this.openButton.TabIndex = 17;
            this.openButton.Text = "Открыть файл";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CheckFileExists = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.patronymicBox);
            this.Controls.Add(this.sexBox);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.extraBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.extraLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.PatronimicLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label PatronimicLabel;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label extraLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox extraBox;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.TextBox sexBox;
        private System.Windows.Forms.TextBox patronymicBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

