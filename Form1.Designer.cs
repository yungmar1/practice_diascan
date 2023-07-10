
namespace practice_diascan
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
            this.accountNumber = new System.Windows.Forms.TextBox();
            this.create = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.currentIndications = new System.Windows.Forms.TextBox();
            this.previousIndications = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.adress = new System.Windows.Forms.TextBox();
            this.dt = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.underpay = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер лицевого счета";
            // 
            // accountNumber
            // 
            this.accountNumber.ForeColor = System.Drawing.SystemColors.InfoText;
            this.accountNumber.Location = new System.Drawing.Point(309, 51);
            this.accountNumber.Name = "accountNumber";
            this.accountNumber.Size = new System.Drawing.Size(338, 22);
            this.accountNumber.TabIndex = 1;
            this.accountNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.accountNumber_KeyPress);
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(255, 347);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(267, 50);
            this.create.TabIndex = 2;
            this.create.Text = "Cоздать ";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "ФИО";
            // 
            // fio
            // 
            this.fio.ForeColor = System.Drawing.SystemColors.MenuText;
            this.fio.Location = new System.Drawing.Point(309, 86);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(338, 22);
            this.fio.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Текущие показания, кВт*ч";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Предыдущие показания, кВт*ч";
            // 
            // currentIndications
            // 
            this.currentIndications.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.currentIndications.Location = new System.Drawing.Point(374, 203);
            this.currentIndications.Name = "currentIndications";
            this.currentIndications.Size = new System.Drawing.Size(196, 22);
            this.currentIndications.TabIndex = 9;
            this.currentIndications.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.currentIndications_KeyPress);
            // 
            // previousIndications
            // 
            this.previousIndications.ForeColor = System.Drawing.SystemColors.MenuText;
            this.previousIndications.Location = new System.Drawing.Point(374, 237);
            this.previousIndications.Name = "previousIndications";
            this.previousIndications.Size = new System.Drawing.Size(196, 22);
            this.previousIndications.TabIndex = 10;
            this.previousIndications.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.previousIndications_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(136, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Адрес";
            // 
            // adress
            // 
            this.adress.ForeColor = System.Drawing.SystemColors.MenuText;
            this.adress.Location = new System.Drawing.Point(309, 121);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(338, 22);
            this.adress.TabIndex = 13;
            // 
            // dt
            // 
            this.dt.Location = new System.Drawing.Point(309, 156);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(200, 22);
            this.dt.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Задолжность / переплата*, руб";
            // 
            // underpay
            // 
            this.underpay.ForeColor = System.Drawing.SystemColors.MenuText;
            this.underpay.Location = new System.Drawing.Point(374, 270);
            this.underpay.Name = "underpay";
            this.underpay.Size = new System.Drawing.Size(196, 22);
            this.underpay.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(186, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "(при наличии)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(337, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(349, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "(*при наличии переплаты указать в начале знак - )";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.underpay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.previousIndications);
            this.Controls.Add(this.currentIndications);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.create);
            this.Controls.Add(this.accountNumber);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ЖКХ электроэнергия";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox accountNumber;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox currentIndications;
        private System.Windows.Forms.TextBox previousIndications;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox adress;
        private System.Windows.Forms.DateTimePicker dt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox underpay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

