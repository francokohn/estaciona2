
namespace ProyectoEstacionamiento
{
    partial class RegistrarEntrada
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.entrada = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.salida = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checktapi = new System.Windows.Forms.CheckBox();
            this.checkpuli = new System.Windows.Forms.CheckBox();
            this.checkaspi = new System.Windows.Forms.CheckBox();
            this.checklava = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtNro = new System.Windows.Forms.TextBox();
            this.lNumero = new System.Windows.Forms.Label();
            this.comboTecho = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.entrada);
            this.groupBox1.Location = new System.Drawing.Point(31, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 57);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Entrada:";
            // 
            // entrada
            // 
            this.entrada.CustomFormat = "dd/MM/yyyy       -       hh:mm tt";
            this.entrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.entrada.Location = new System.Drawing.Point(113, 19);
            this.entrada.Name = "entrada";
            this.entrada.Size = new System.Drawing.Size(197, 20);
            this.entrada.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.salida);
            this.groupBox2.Location = new System.Drawing.Point(31, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 65);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Salida:";
            // 
            // salida
            // 
            this.salida.CustomFormat = "dd/MM/yyyy       -       hh:mm tt";
            this.salida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.salida.Location = new System.Drawing.Point(115, 22);
            this.salida.Name = "salida";
            this.salida.Size = new System.Drawing.Size(195, 20);
            this.salida.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checktapi);
            this.groupBox3.Controls.Add(this.checkpuli);
            this.groupBox3.Controls.Add(this.checkaspi);
            this.groupBox3.Controls.Add(this.checklava);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 170);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(429, 64);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de Servicios:";
            // 
            // checktapi
            // 
            this.checktapi.AutoSize = true;
            this.checktapi.Location = new System.Drawing.Point(376, 28);
            this.checktapi.Name = "checktapi";
            this.checktapi.Size = new System.Drawing.Size(15, 14);
            this.checktapi.TabIndex = 6;
            this.checktapi.UseVisualStyleBackColor = true;
            // 
            // checkpuli
            // 
            this.checkpuli.AutoSize = true;
            this.checkpuli.Location = new System.Drawing.Point(259, 28);
            this.checkpuli.Name = "checkpuli";
            this.checkpuli.Size = new System.Drawing.Size(15, 14);
            this.checkpuli.TabIndex = 5;
            this.checkpuli.UseVisualStyleBackColor = true;
            // 
            // checkaspi
            // 
            this.checkaspi.AutoSize = true;
            this.checkaspi.Location = new System.Drawing.Point(153, 28);
            this.checkaspi.Name = "checkaspi";
            this.checkaspi.Size = new System.Drawing.Size(15, 14);
            this.checkaspi.TabIndex = 4;
            this.checkaspi.UseVisualStyleBackColor = true;
            // 
            // checklava
            // 
            this.checklava.AutoSize = true;
            this.checklava.Location = new System.Drawing.Point(59, 28);
            this.checklava.Name = "checklava";
            this.checklava.Size = new System.Drawing.Size(15, 14);
            this.checklava.TabIndex = 3;
            this.checklava.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tapizado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pulido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Aspirado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Lavado:";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(165, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Nuevo Cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(314, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Mostrar Datos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtNro);
            this.groupBox4.Controls.Add(this.lNumero);
            this.groupBox4.Controls.Add(this.comboTecho);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(12, 254);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(429, 76);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos de Parqueado:";
            // 
            // txtNro
            // 
            this.txtNro.Location = new System.Drawing.Point(357, 32);
            this.txtNro.Name = "txtNro";
            this.txtNro.Size = new System.Drawing.Size(34, 20);
            this.txtNro.TabIndex = 8;
            // 
            // lNumero
            // 
            this.lNumero.AutoSize = true;
            this.lNumero.Location = new System.Drawing.Point(287, 36);
            this.lNumero.Name = "lNumero";
            this.lNumero.Size = new System.Drawing.Size(64, 13);
            this.lNumero.TabIndex = 9;
            this.lNumero.Text = "Casillero N°:";
            // 
            // comboTecho
            // 
            this.comboTecho.FormattingEnabled = true;
            this.comboTecho.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.comboTecho.Location = new System.Drawing.Point(105, 32);
            this.comboTecho.Name = "comboTecho";
            this.comboTecho.Size = new System.Drawing.Size(89, 21);
            this.comboTecho.TabIndex = 7;
            this.comboTecho.Text = "Seleccionar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cobertura (techo):";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 336);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Cargar Datos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RegistrarEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 371);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistrarEntrada";
            this.Text = "RegistrarEntrada";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker entrada;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker salida;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboTecho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNro;
        private System.Windows.Forms.Label lNumero;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox checkaspi;
        private System.Windows.Forms.CheckBox checklava;
        private System.Windows.Forms.CheckBox checktapi;
        private System.Windows.Forms.CheckBox checkpuli;
    }
}