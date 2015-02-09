namespace monitor2
{
    partial class monitoringControl
    {
        /// <summary> 
        /// Требуется переменная конструктора.
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectPathBtn = new System.Windows.Forms.Button();
            this.internalCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.currentFolderTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errorCheck = new System.Windows.Forms.CheckBox();
            this.deleteCheck = new System.Windows.Forms.CheckBox();
            this.createCheck = new System.Windows.Forms.CheckBox();
            this.renameCheck = new System.Windows.Forms.CheckBox();
            this.changeCheck = new System.Windows.Forms.CheckBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.changeLogFolder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectPathBtn
            // 
            this.selectPathBtn.Location = new System.Drawing.Point(12, 19);
            this.selectPathBtn.Name = "selectPathBtn";
            this.selectPathBtn.Size = new System.Drawing.Size(182, 30);
            this.selectPathBtn.TabIndex = 0;
            this.selectPathBtn.Text = "Выберите путь для наблюдения";
            this.selectPathBtn.UseVisualStyleBackColor = true;
            this.selectPathBtn.Click += new System.EventHandler(this.selectPathBtn_Click);
            // 
            // internalCheck
            // 
            this.internalCheck.AutoSize = true;
            this.internalCheck.Location = new System.Drawing.Point(12, 55);
            this.internalCheck.Name = "internalCheck";
            this.internalCheck.Size = new System.Drawing.Size(126, 17);
            this.internalCheck.TabIndex = 1;
            this.internalCheck.Text = "Включить подпапки";
            this.internalCheck.UseVisualStyleBackColor = true;
            this.internalCheck.CheckedChanged += new System.EventHandler(this.internalCheck_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Текущий путь:";
            // 
            // currentFolderTxt
            // 
            this.currentFolderTxt.Enabled = false;
            this.currentFolderTxt.Location = new System.Drawing.Point(215, 29);
            this.currentFolderTxt.Name = "currentFolderTxt";
            this.currentFolderTxt.Size = new System.Drawing.Size(366, 20);
            this.currentFolderTxt.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.changeLogFolder);
            this.groupBox1.Controls.Add(this.errorCheck);
            this.groupBox1.Controls.Add(this.deleteCheck);
            this.groupBox1.Controls.Add(this.createCheck);
            this.groupBox1.Controls.Add(this.renameCheck);
            this.groupBox1.Controls.Add(this.changeCheck);
            this.groupBox1.Location = new System.Drawing.Point(215, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 92);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Типы событий для логгирования";
            // 
            // errorCheck
            // 
            this.errorCheck.AutoSize = true;
            this.errorCheck.Location = new System.Drawing.Point(7, 69);
            this.errorCheck.Name = "errorCheck";
            this.errorCheck.Size = new System.Drawing.Size(66, 17);
            this.errorCheck.TabIndex = 4;
            this.errorCheck.Text = "Ошибки";
            this.errorCheck.UseVisualStyleBackColor = true;
            this.errorCheck.CheckedChanged += new System.EventHandler(this.errorCheck_CheckedChanged);
            // 
            // deleteCheck
            // 
            this.deleteCheck.AutoSize = true;
            this.deleteCheck.Location = new System.Drawing.Point(186, 43);
            this.deleteCheck.Name = "deleteCheck";
            this.deleteCheck.Size = new System.Drawing.Size(120, 17);
            this.deleteCheck.TabIndex = 3;
            this.deleteCheck.Text = "События удаления";
            this.deleteCheck.UseVisualStyleBackColor = true;
            this.deleteCheck.CheckedChanged += new System.EventHandler(this.deleteCheck_CheckedChanged);
            // 
            // createCheck
            // 
            this.createCheck.AutoSize = true;
            this.createCheck.Location = new System.Drawing.Point(186, 19);
            this.createCheck.Name = "createCheck";
            this.createCheck.Size = new System.Drawing.Size(121, 17);
            this.createCheck.TabIndex = 2;
            this.createCheck.Text = "События создания";
            this.createCheck.UseVisualStyleBackColor = true;
            this.createCheck.CheckedChanged += new System.EventHandler(this.createCheck_CheckedChanged);
            // 
            // renameCheck
            // 
            this.renameCheck.AutoSize = true;
            this.renameCheck.Location = new System.Drawing.Point(7, 43);
            this.renameCheck.Name = "renameCheck";
            this.renameCheck.Size = new System.Drawing.Size(159, 17);
            this.renameCheck.TabIndex = 1;
            this.renameCheck.Text = "События переименования";
            this.renameCheck.UseVisualStyleBackColor = true;
            this.renameCheck.CheckedChanged += new System.EventHandler(this.renameCheck_CheckedChanged);
            // 
            // changeCheck
            // 
            this.changeCheck.AutoSize = true;
            this.changeCheck.Location = new System.Drawing.Point(7, 20);
            this.changeCheck.Name = "changeCheck";
            this.changeCheck.Size = new System.Drawing.Size(129, 17);
            this.changeCheck.TabIndex = 0;
            this.changeCheck.Text = "События изменения";
            this.changeCheck.UseVisualStyleBackColor = true;
            this.changeCheck.CheckedChanged += new System.EventHandler(this.changeCheck_CheckedChanged);
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startBtn.Location = new System.Drawing.Point(9, 97);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(200, 50);
            this.startBtn.TabIndex = 5;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.selectPathBtn);
            this.groupBox2.Controls.Add(this.internalCheck);
            this.groupBox2.Location = new System.Drawing.Point(9, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 79);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // changeLogFolder
            // 
            this.changeLogFolder.Location = new System.Drawing.Point(93, 63);
            this.changeLogFolder.Name = "changeLogFolder";
            this.changeLogFolder.Size = new System.Drawing.Size(267, 23);
            this.changeLogFolder.TabIndex = 5;
            this.changeLogFolder.Text = "Сменить место хранения лога";
            this.changeLogFolder.UseVisualStyleBackColor = true;
            this.changeLogFolder.Click += new System.EventHandler(this.changeLogFolder_Click);
            // 
            // monitoringControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.currentFolderTxt);
            this.Controls.Add(this.label1);
            this.Name = "monitoringControl";
            this.Size = new System.Drawing.Size(596, 182);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectPathBtn;
        private System.Windows.Forms.CheckBox internalCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox currentFolderTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox changeCheck;
        private System.Windows.Forms.CheckBox errorCheck;
        private System.Windows.Forms.CheckBox deleteCheck;
        private System.Windows.Forms.CheckBox createCheck;
        private System.Windows.Forms.CheckBox renameCheck;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button changeLogFolder;
    }
}
