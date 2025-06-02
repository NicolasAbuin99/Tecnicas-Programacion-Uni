namespace ProyectoHelados
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
            label3 = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            cmbTamaño = new ComboBox();
            btnGuardar = new Button();
            btnPedidos = new Button();
            dataGridView1 = new DataGridView();
            btnTotalRecaudado = new Button();
            btnSaborMaspedido = new Button();
            btnTamañoMasPedido = new Button();
            clbSabores = new CheckedListBox();
            btnTicket = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 17);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 0;
            label1.Text = "Compra del helado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 57);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 1;
            label2.Text = "Ingrese su Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 151);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 2;
            label3.Text = "Ingrese el sabor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 97);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 4;
            label5.Text = "Ingrese el tamaño";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(159, 49);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 5;
            // 
            // cmbTamaño
            // 
            cmbTamaño.FormattingEnabled = true;
            cmbTamaño.Location = new Point(159, 94);
            cmbTamaño.Name = "cmbTamaño";
            cmbTamaño.Size = new Size(121, 23);
            cmbTamaño.TabIndex = 8;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(21, 241);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(106, 23);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar Compra";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnPedidos
            // 
            btnPedidos.Location = new Point(921, 17);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(100, 23);
            btnPedidos.TabIndex = 10;
            btnPedidos.Text = "Lista de pedidos";
            btnPedidos.UseVisualStyleBackColor = true;
            btnPedidos.Click += btnPedidos_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(781, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 11;
            // 
            // btnTotalRecaudado
            // 
            btnTotalRecaudado.Location = new Point(336, 44);
            btnTotalRecaudado.Name = "btnTotalRecaudado";
            btnTotalRecaudado.Size = new Size(99, 23);
            btnTotalRecaudado.TabIndex = 12;
            btnTotalRecaudado.Text = "TotalRecaudado";
            btnTotalRecaudado.UseVisualStyleBackColor = true;
            btnTotalRecaudado.Click += btnTotalRecaudado_Click;
            // 
            // btnSaborMaspedido
            // 
            btnSaborMaspedido.Location = new Point(477, 44);
            btnSaborMaspedido.Name = "btnSaborMaspedido";
            btnSaborMaspedido.Size = new Size(111, 23);
            btnSaborMaspedido.TabIndex = 13;
            btnSaborMaspedido.Text = "Sabor mas pedido";
            btnSaborMaspedido.UseVisualStyleBackColor = true;
            btnSaborMaspedido.Click += btnSaborMaspedido_Click;
            // 
            // btnTamañoMasPedido
            // 
            btnTamañoMasPedido.Location = new Point(625, 44);
            btnTamañoMasPedido.Name = "btnTamañoMasPedido";
            btnTamañoMasPedido.Size = new Size(128, 23);
            btnTamañoMasPedido.TabIndex = 14;
            btnTamañoMasPedido.Text = "Tamaño mas vendido";
            btnTamañoMasPedido.UseVisualStyleBackColor = true;
            btnTamañoMasPedido.Click += btnTamañoMasPedido_Click;
            // 
            // clbSabores
            // 
            clbSabores.FormattingEnabled = true;
            clbSabores.Location = new Point(159, 140);
            clbSabores.Name = "clbSabores";
            clbSabores.Size = new Size(120, 94);
            clbSabores.TabIndex = 16;
            // 
            // btnTicket
            // 
            btnTicket.Location = new Point(477, 113);
            btnTicket.Name = "btnTicket";
            btnTicket.Size = new Size(103, 23);
            btnTicket.TabIndex = 17;
            btnTicket.Text = "Promedio Ticket";
            btnTicket.UseVisualStyleBackColor = true;
            btnTicket.Click += btnTicket_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 450);
            Controls.Add(btnTicket);
            Controls.Add(clbSabores);
            Controls.Add(btnTamañoMasPedido);
            Controls.Add(btnSaborMaspedido);
            Controls.Add(btnTotalRecaudado);
            Controls.Add(dataGridView1);
            Controls.Add(btnPedidos);
            Controls.Add(btnGuardar);
            Controls.Add(cmbTamaño);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox txtNombre;
        private ComboBox cmbTamaño;
        private Button btnGuardar;
        private Button btnPedidos;
        private DataGridView dataGridView1;
        private Button btnTotalRecaudado;
        private Button btnSaborMaspedido;
        private Button btnTamañoMasPedido;
        private CheckedListBox clbSabores;
        private Button btnTicket;
    }
}
