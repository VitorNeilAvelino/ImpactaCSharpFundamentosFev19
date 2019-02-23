namespace Oficina.WindowsForms
{
    partial class VeiculoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.marcaComboBox = new System.Windows.Forms.ComboBox();
            this.modeloComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.corComboBox = new System.Windows.Forms.ComboBox();
            this.combustivelComboBox = new System.Windows.Forms.ComboBox();
            this.cambioComboBox = new System.Windows.Forms.ComboBox();
            this.placaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.anoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.observacaoGroupBox = new System.Windows.Forms.GroupBox();
            this.observacaoTextBox = new System.Windows.Forms.TextBox();
            this.gravarButton = new System.Windows.Forms.Button();
            this.veiculoErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.observacaoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Modelo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ano:";
            // 
            // marcaComboBox
            // 
            this.marcaComboBox.FormattingEnabled = true;
            this.marcaComboBox.Location = new System.Drawing.Point(63, 63);
            this.marcaComboBox.Name = "marcaComboBox";
            this.marcaComboBox.Size = new System.Drawing.Size(121, 21);
            this.marcaComboBox.TabIndex = 3;
            this.marcaComboBox.Tag = "*";
            // 
            // modeloComboBox
            // 
            this.modeloComboBox.FormattingEnabled = true;
            this.modeloComboBox.Location = new System.Drawing.Point(63, 120);
            this.modeloComboBox.Name = "modeloComboBox";
            this.modeloComboBox.Size = new System.Drawing.Size(121, 21);
            this.modeloComboBox.TabIndex = 5;
            this.modeloComboBox.Tag = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Combustível:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(269, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Câmbio:";
            // 
            // corComboBox
            // 
            this.corComboBox.FormattingEnabled = true;
            this.corComboBox.Location = new System.Drawing.Point(320, 6);
            this.corComboBox.Name = "corComboBox";
            this.corComboBox.Size = new System.Drawing.Size(121, 21);
            this.corComboBox.TabIndex = 9;
            this.corComboBox.Tag = "*";
            // 
            // combustivelComboBox
            // 
            this.combustivelComboBox.FormattingEnabled = true;
            this.combustivelComboBox.Location = new System.Drawing.Point(320, 63);
            this.combustivelComboBox.Name = "combustivelComboBox";
            this.combustivelComboBox.Size = new System.Drawing.Size(121, 21);
            this.combustivelComboBox.TabIndex = 11;
            this.combustivelComboBox.Tag = "*";
            // 
            // cambioComboBox
            // 
            this.cambioComboBox.FormattingEnabled = true;
            this.cambioComboBox.Location = new System.Drawing.Point(320, 120);
            this.cambioComboBox.Name = "cambioComboBox";
            this.cambioComboBox.Size = new System.Drawing.Size(121, 21);
            this.cambioComboBox.TabIndex = 13;
            this.cambioComboBox.Tag = "*";
            // 
            // placaMaskedTextBox
            // 
            this.placaMaskedTextBox.Location = new System.Drawing.Point(63, 6);
            this.placaMaskedTextBox.Name = "placaMaskedTextBox";
            this.placaMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.placaMaskedTextBox.TabIndex = 1;
            this.placaMaskedTextBox.Tag = "*";
            // 
            // anoMaskedTextBox
            // 
            this.anoMaskedTextBox.Location = new System.Drawing.Point(63, 177);
            this.anoMaskedTextBox.Name = "anoMaskedTextBox";
            this.anoMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.anoMaskedTextBox.TabIndex = 7;
            this.anoMaskedTextBox.Tag = "*";
            // 
            // observacaoGroupBox
            // 
            this.observacaoGroupBox.Controls.Add(this.observacaoTextBox);
            this.observacaoGroupBox.Location = new System.Drawing.Point(15, 233);
            this.observacaoGroupBox.Name = "observacaoGroupBox";
            this.observacaoGroupBox.Size = new System.Drawing.Size(426, 125);
            this.observacaoGroupBox.TabIndex = 14;
            this.observacaoGroupBox.TabStop = false;
            this.observacaoGroupBox.Text = "Observação (300)";
            // 
            // observacaoTextBox
            // 
            this.observacaoTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.observacaoTextBox.Location = new System.Drawing.Point(3, 16);
            this.observacaoTextBox.Multiline = true;
            this.observacaoTextBox.Name = "observacaoTextBox";
            this.observacaoTextBox.Size = new System.Drawing.Size(420, 106);
            this.observacaoTextBox.TabIndex = 0;
            // 
            // gravarButton
            // 
            this.gravarButton.Location = new System.Drawing.Point(366, 382);
            this.gravarButton.Name = "gravarButton";
            this.gravarButton.Size = new System.Drawing.Size(75, 23);
            this.gravarButton.TabIndex = 15;
            this.gravarButton.Text = "&Gravar";
            this.gravarButton.UseVisualStyleBackColor = true;
            this.gravarButton.Click += new System.EventHandler(this.gravarButton_Click);
            // 
            // veiculoErrorProvider
            // 
            this.veiculoErrorProvider.ContainerControl = this;
            // 
            // VeiculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 417);
            this.Controls.Add(this.gravarButton);
            this.Controls.Add(this.observacaoGroupBox);
            this.Controls.Add(this.anoMaskedTextBox);
            this.Controls.Add(this.placaMaskedTextBox);
            this.Controls.Add(this.cambioComboBox);
            this.Controls.Add(this.modeloComboBox);
            this.Controls.Add(this.combustivelComboBox);
            this.Controls.Add(this.marcaComboBox);
            this.Controls.Add(this.corComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "VeiculoForm";
            this.Text = "Cadastro de Veículo";
            this.observacaoGroupBox.ResumeLayout(false);
            this.observacaoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox marcaComboBox;
        private System.Windows.Forms.ComboBox modeloComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox corComboBox;
        private System.Windows.Forms.ComboBox combustivelComboBox;
        private System.Windows.Forms.ComboBox cambioComboBox;
        private System.Windows.Forms.MaskedTextBox placaMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox anoMaskedTextBox;
        private System.Windows.Forms.GroupBox observacaoGroupBox;
        private System.Windows.Forms.TextBox observacaoTextBox;
        private System.Windows.Forms.Button gravarButton;
        private System.Windows.Forms.ErrorProvider veiculoErrorProvider;
    }
}

