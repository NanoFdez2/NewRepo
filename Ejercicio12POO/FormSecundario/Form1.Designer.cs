namespace FormSecundario
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
            lbPatente = new Label();
            lbMarca = new Label();
            lbModelo = new Label();
            rbAzul = new RadioButton();
            lbColor = new Label();
            rbRojo = new RadioButton();
            rbAmarillo = new RadioButton();
            cbCombustible = new ComboBox();
            txtPatente = new TextBox();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            lbAñoFabricacion = new Label();
            txtAñoFabricacion = new TextBox();
            SuspendLayout();
            // 
            // lbPatente
            // 
            lbPatente.AutoSize = true;
            lbPatente.Location = new Point(39, 18);
            lbPatente.Name = "lbPatente";
            lbPatente.Size = new Size(100, 15);
            lbPatente.TabIndex = 0;
            lbPatente.Text = "Ingrese la patente";
            // 
            // lbMarca
            // 
            lbMarca.AutoSize = true;
            lbMarca.Location = new Point(39, 76);
            lbMarca.Name = "lbMarca";
            lbMarca.Size = new Size(93, 15);
            lbMarca.TabIndex = 1;
            lbMarca.Text = "Ingrese la marca";
            lbMarca.Click += label2_Click;
            // 
            // lbModelo
            // 
            lbModelo.AutoSize = true;
            lbModelo.Location = new Point(39, 128);
            lbModelo.Name = "lbModelo";
            lbModelo.Size = new Size(101, 15);
            lbModelo.TabIndex = 2;
            lbModelo.Text = "Ingrese el modelo";
            // 
            // rbAzul
            // 
            rbAzul.AutoSize = true;
            rbAzul.Location = new Point(39, 233);
            rbAzul.Name = "rbAzul";
            rbAzul.Size = new Size(48, 19);
            rbAzul.TabIndex = 3;
            rbAzul.TabStop = true;
            rbAzul.Text = "Azul";
            rbAzul.UseVisualStyleBackColor = true;
            // 
            // lbColor
            // 
            lbColor.AutoSize = true;
            lbColor.Location = new Point(39, 215);
            lbColor.Name = "lbColor";
            lbColor.Size = new Size(36, 15);
            lbColor.TabIndex = 4;
            lbColor.Text = "Color";
            // 
            // rbRojo
            // 
            rbRojo.AutoSize = true;
            rbRojo.Location = new Point(39, 258);
            rbRojo.Name = "rbRojo";
            rbRojo.Size = new Size(49, 19);
            rbRojo.TabIndex = 5;
            rbRojo.TabStop = true;
            rbRojo.Text = "Rojo";
            rbRojo.UseVisualStyleBackColor = true;
            // 
            // rbAmarillo
            // 
            rbAmarillo.AutoSize = true;
            rbAmarillo.Location = new Point(39, 283);
            rbAmarillo.Name = "rbAmarillo";
            rbAmarillo.Size = new Size(70, 19);
            rbAmarillo.TabIndex = 6;
            rbAmarillo.TabStop = true;
            rbAmarillo.Text = "Amarillo";
            rbAmarillo.UseVisualStyleBackColor = true;
            // 
            // cbCombustible
            // 
            cbCombustible.FormattingEnabled = true;
            cbCombustible.Location = new Point(39, 308);
            cbCombustible.Name = "cbCombustible";
            cbCombustible.Size = new Size(121, 23);
            cbCombustible.TabIndex = 7;
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(145, 15);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(136, 23);
            txtPatente.TabIndex = 8;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(138, 73);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(143, 23);
            txtMarca.TabIndex = 9;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(138, 125);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(143, 23);
            txtModelo.TabIndex = 10;
            // 
            // lbAñoFabricacion
            // 
            lbAñoFabricacion.AutoSize = true;
            lbAñoFabricacion.Location = new Point(32, 186);
            lbAñoFabricacion.Name = "lbAñoFabricacion";
            lbAñoFabricacion.Size = new Size(107, 15);
            lbAñoFabricacion.TabIndex = 11;
            lbAñoFabricacion.Text = "Año de fabricación";
            // 
            // txtAñoFabricacion
            // 
            txtAñoFabricacion.Location = new Point(137, 183);
            txtAñoFabricacion.Name = "txtAñoFabricacion";
            txtAñoFabricacion.Size = new Size(144, 23);
            txtAñoFabricacion.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 391);
            Controls.Add(txtAñoFabricacion);
            Controls.Add(lbAñoFabricacion);
            Controls.Add(txtModelo);
            Controls.Add(txtMarca);
            Controls.Add(txtPatente);
            Controls.Add(cbCombustible);
            Controls.Add(rbAmarillo);
            Controls.Add(rbRojo);
            Controls.Add(lbColor);
            Controls.Add(rbAzul);
            Controls.Add(lbModelo);
            Controls.Add(lbMarca);
            Controls.Add(lbPatente);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbPatente;
        private Label lbMarca;
        private Label lbModelo;
        private RadioButton rbAzul;
        private Label lbColor;
        private RadioButton rbRojo;
        private RadioButton rbAmarillo;
        private ComboBox cbCombustible;
        private TextBox txtPatente;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private Label lbAñoFabricacion;
        private TextBox txtAñoFabricacion;
    }
}