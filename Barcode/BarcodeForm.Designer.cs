namespace Barcode
{
    partial class Barcode
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
            this.cmbCamera = new System.Windows.Forms.ComboBox();
            this.picboxBarcode = new System.Windows.Forms.PictureBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCamera
            // 
            this.cmbCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCamera.FormattingEnabled = true;
            this.cmbCamera.Location = new System.Drawing.Point(177, 17);
            this.cmbCamera.Name = "cmbCamera";
            this.cmbCamera.Size = new System.Drawing.Size(477, 21);
            this.cmbCamera.TabIndex = 0;
            // 
            // picboxBarcode
            // 
            this.picboxBarcode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboxBarcode.Location = new System.Drawing.Point(15, 55);
            this.picboxBarcode.Name = "picboxBarcode";
            this.picboxBarcode.Size = new System.Drawing.Size(639, 305);
            this.picboxBarcode.TabIndex = 1;
            this.picboxBarcode.TabStop = false;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(199, 372);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(455, 20);
            this.txtBarcode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите камеру:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Результат сканирования:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(473, 403);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(181, 40);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Начать сканирование";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Barcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.picboxBarcode);
            this.Controls.Add(this.cmbCamera);
            this.Name = "Barcode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сканер штрих-кодов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Barcode_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxBarcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCamera;
        private System.Windows.Forms.PictureBox picboxBarcode;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
    }
}

