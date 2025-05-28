namespace ConcecionarioCoches
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
            label1 = new Label();
            label2 = new Label();
            btnLista = new Button();
            txtModelo = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtPrecio = new TextBox();
            Seleccionador = new TextBox();
            label6 = new Label();
            txtColor = new TextBox();
            btnGuardar = new Button();
            btnCompra = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 53);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 0;
            label1.Text = "Agregar Coche :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(572, 53);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 1;
            label2.Text = "Comprar Coches :";
            // 
            // btnLista
            // 
            btnLista.Location = new Point(335, 49);
            btnLista.Name = "btnLista";
            btnLista.Size = new Size(102, 23);
            btnLista.TabIndex = 2;
            btnLista.Text = "Lista de coches:";
            btnLista.UseVisualStyleBackColor = true;
            btnLista.Click += btnLista_Click;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(172, 97);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(100, 23);
            txtModelo.TabIndex = 3;
            txtModelo.TextChanged += txtAgregar_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 100);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 5;
            label3.Text = "Modelo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 151);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 6;
            label4.Text = "Color";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 203);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 7;
            label5.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(172, 203);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 8;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            // 
            // Seleccionador
            // 
            Seleccionador.Location = new Point(651, 105);
            Seleccionador.Name = "Seleccionador";
            Seleccionador.Size = new Size(100, 23);
            Seleccionador.TabIndex = 9;
            Seleccionador.TextChanged += Seleccionador_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(469, 108);
            label6.Name = "label6";
            label6.Size = new Size(143, 15);
            label6.TabIndex = 10;
            label6.Text = "Seleccione Nro de coche :";
            // 
            // txtColor
            // 
            txtColor.Location = new Point(172, 151);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(100, 23);
            txtColor.TabIndex = 11;
            txtColor.TextChanged += txtColor_TextChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(71, 263);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar datos";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCompra
            // 
            btnCompra.Location = new Point(690, 169);
            btnCompra.Name = "btnCompra";
            btnCompra.Size = new Size(75, 23);
            btnCompra.TabIndex = 13;
            btnCompra.Text = "Compra";
            btnCompra.UseVisualStyleBackColor = true;
            btnCompra.Click += btnCompra_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCompra);
            Controls.Add(btnGuardar);
            Controls.Add(txtColor);
            Controls.Add(label6);
            Controls.Add(Seleccionador);
            Controls.Add(txtPrecio);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtModelo);
            Controls.Add(btnLista);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnLista;
        private TextBox txtModelo;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtPrecio;
        private TextBox Seleccionador;
        private Label label6;
        private TextBox txtColor;
        private Button btnGuardar;
        private Button btnCompra;
    }
}
