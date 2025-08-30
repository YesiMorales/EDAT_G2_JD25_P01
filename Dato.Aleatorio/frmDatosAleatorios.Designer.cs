namespace Dato.Aleatorio
{
    partial class frmDatosAleatorios
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
            label1 = new Label();
            Número = new Label();
            nombre = new Label();
            fechadenacimiento = new Label();
            mas = new RadioButton();
            fem = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            sgrm = new CheckBox();
            fechn = new DateTimePicker();
            numero = new TextBox();
            nmb = new TextBox();
            grp = new ComboBox();
            sld = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 0;
            label1.Text = "Datos del empleado";
            label1.Click += label1_Click;
            // 
            // Número
            // 
            Número.AutoSize = true;
            Número.Location = new Point(12, 53);
            Número.Name = "Número";
            Número.Size = new Size(63, 20);
            Número.TabIndex = 1;
            Número.Text = "Número";
            // 
            // nombre
            // 
            nombre.AutoSize = true;
            nombre.Location = new Point(12, 98);
            nombre.Name = "nombre";
            nombre.Size = new Size(64, 20);
            nombre.TabIndex = 2;
            nombre.Text = "Nombre";
            // 
            // fechadenacimiento
            // 
            fechadenacimiento.AutoSize = true;
            fechadenacimiento.Location = new Point(12, 136);
            fechadenacimiento.Name = "fechadenacimiento";
            fechadenacimiento.Size = new Size(146, 20);
            fechadenacimiento.TabIndex = 3;
            fechadenacimiento.Text = "Fecha de nacimiento";
            // 
            // mas
            // 
            mas.AutoSize = true;
            mas.Location = new Point(16, 178);
            mas.Name = "mas";
            mas.Size = new Size(97, 24);
            mas.TabIndex = 4;
            mas.TabStop = true;
            mas.Text = "Masculino";
            mas.UseVisualStyleBackColor = true;
            mas.CheckedChanged += mas_CheckedChanged;
            // 
            // fem
            // 
            fem.AutoSize = true;
            fem.Location = new Point(16, 214);
            fem.Name = "fem";
            fem.Size = new Size(95, 24);
            fem.TabIndex = 5;
            fem.TabStop = true;
            fem.Text = "Femenino";
            fem.UseVisualStyleBackColor = true;
            fem.CheckedChanged += fem_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 254);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 6;
            label2.Text = "Grupo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 290);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 7;
            label3.Text = "Sueldo";
            // 
            // sgrm
            // 
            sgrm.AutoSize = true;
            sgrm.Location = new Point(12, 326);
            sgrm.Name = "sgrm";
            sgrm.Size = new Size(132, 24);
            sgrm.TabIndex = 8;
            sgrm.Text = "Seguro Medico";
            sgrm.UseVisualStyleBackColor = true;
            sgrm.CheckedChanged += sgrm_CheckedChanged;
            // 
            // fechn
            // 
            fechn.Location = new Point(187, 135);
            fechn.Name = "fechn";
            fechn.Size = new Size(250, 27);
            fechn.TabIndex = 9;
            fechn.ValueChanged += fechn_ValueChanged;
            // 
            // numero
            // 
            numero.Location = new Point(96, 50);
            numero.Name = "numero";
            numero.Size = new Size(125, 27);
            numero.TabIndex = 10;
            numero.TextChanged += numero_TextChanged;
            // 
            // nmb
            // 
            nmb.Location = new Point(96, 95);
            nmb.Name = "nmb";
            nmb.Size = new Size(125, 27);
            nmb.TabIndex = 11;
            nmb.TextChanged += nmb_TextChanged;
            // 
            // grp
            // 
            grp.FormattingEnabled = true;
            grp.Location = new Point(68, 251);
            grp.Name = "grp";
            grp.Size = new Size(106, 28);
            grp.TabIndex = 12;
            grp.SelectedIndexChanged += grp_SelectedIndexChanged;
            // 
            // sld
            // 
            sld.Location = new Point(73, 287);
            sld.Name = "sld";
            sld.Size = new Size(177, 27);
            sld.TabIndex = 13;
            sld.TextChanged += sld_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(167, 384);
            button1.Name = "button1";
            button1.Size = new Size(244, 29);
            button1.TabIndex = 14;
            button1.Text = "Genera datos aleatorios";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmDatosAleatorios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 450);
            Controls.Add(button1);
            Controls.Add(sld);
            Controls.Add(grp);
            Controls.Add(nmb);
            Controls.Add(numero);
            Controls.Add(fechn);
            Controls.Add(sgrm);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(fem);
            Controls.Add(mas);
            Controls.Add(fechadenacimiento);
            Controls.Add(nombre);
            Controls.Add(Número);
            Controls.Add(label1);
            Name = "frmDatosAleatorios";
            Text = "frmDatosAleatorios";
            Load += frmDatosAleatorios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Número;
        private Label nombre;
        private Label fechadenacimiento;
        private RadioButton mas;
        private RadioButton fem;
        private Label label2;
        private Label label3;
        private CheckBox sgrm;
        private DateTimePicker fechn;
        private TextBox numero;
        private TextBox nmb;
        private ComboBox grp;
        private TextBox sld;
        private Button button1;
    }
}