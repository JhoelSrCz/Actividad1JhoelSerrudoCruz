namespace Computadora.VISTA.ComputadoraVistas
{
    partial class ComputadoraInsertarVista
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            txtPrecio = new TextBox();
            button1 = new Button();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtIdPers = new TextBox();
            label5 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 92);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "NOMBRE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 138);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 1;
            label2.Text = "DESCRIPCION";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(172, 184);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 2;
            label3.Text = "PRECIO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 230);
            label4.Name = "label4";
            label4.Size = new Size(173, 20);
            label4.TabIndex = 3;
            label4.Text = "FECHA DE FABRICACION";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(236, 89);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(282, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(236, 135);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(282, 27);
            txtDescripcion.TabIndex = 5;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(236, 181);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(282, 27);
            txtPrecio.TabIndex = 6;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(218, 359);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(410, 359);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(236, 227);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(282, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // txtIdPers
            // 
            txtIdPers.Location = new Point(236, 43);
            txtIdPers.Name = "txtIdPers";
            txtIdPers.Size = new Size(282, 27);
            txtIdPers.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(97, 46);
            label5.Name = "label5";
            label5.Size = new Size(133, 20);
            label5.TabIndex = 11;
            label5.Text = "IDCOMPUTADORA";
            // 
            // button3
            // 
            button3.Location = new Point(572, 42);
            button3.Name = "button3";
            button3.Size = new Size(142, 29);
            button3.TabIndex = 13;
            button3.Text = "SELECCIONAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ComputadoraInsertarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(txtIdPers);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ComputadoraInsertarVista";
            Text = "ComputadoraInsertarVista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private TextBox txtPrecio;
        private Button button1;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private TextBox txtIdPers;
        private Label label5;
        private Button button3;
    }
}