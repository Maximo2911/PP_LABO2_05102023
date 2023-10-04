using Entidades;
namespace Integrador
{
    partial class FrmCalculadora
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
            btnOperar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            txtPrimerOperador = new TextBox();
            txtSegundoOperador = new TextBox();
            lblResultado = new Label();
            lblPrimerOperando = new Label();
            lblOperacion = new Label();
            lblSegundoOperador = new Label();
            rdbDecimal = new RadioButton();
            rdbBinario = new RadioButton();
            cmbOperacion = new ComboBox();
            grpSistema = new GroupBox();
            grpSistema.SuspendLayout();
            SuspendLayout();
            // 
            // btnOperar
            // 
            btnOperar.Location = new Point(73, 376);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(100, 30);
            btnOperar.TabIndex = 0;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            btnOperar.Click += btnOperar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(360, 376);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 30);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(639, 376);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(100, 30);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // txtPrimerOperador
            // 
            txtPrimerOperador.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrimerOperador.Location = new Point(63, 309);
            txtPrimerOperador.Name = "txtPrimerOperador";
            txtPrimerOperador.Size = new Size(125, 34);
            txtPrimerOperador.TabIndex = 3;
            // 
            // txtSegundoOperador
            // 
            txtSegundoOperador.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtSegundoOperador.Location = new Point(630, 309);
            txtSegundoOperador.Name = "txtSegundoOperador";
            txtSegundoOperador.Size = new Size(125, 34);
            txtSegundoOperador.TabIndex = 4;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(47, 45);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(183, 46);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "Resultado: ";
            // 
            // lblPrimerOperando
            // 
            lblPrimerOperando.AutoSize = true;
            lblPrimerOperando.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrimerOperando.Location = new Point(47, 275);
            lblPrimerOperando.Name = "lblPrimerOperando";
            lblPrimerOperando.Size = new Size(173, 28);
            lblPrimerOperando.TabIndex = 6;
            lblPrimerOperando.Text = "Primer operador:";
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOperacion.Location = new Point(360, 296);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(85, 21);
            lblOperacion.TabIndex = 7;
            lblOperacion.Text = "Operacion:";
            // 
            // lblSegundoOperador
            // 
            lblSegundoOperador.AutoSize = true;
            lblSegundoOperador.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblSegundoOperador.Location = new Point(596, 275);
            lblSegundoOperador.Name = "lblSegundoOperador";
            lblSegundoOperador.Size = new Size(192, 28);
            lblSegundoOperador.TabIndex = 8;
            lblSegundoOperador.Text = "Segundo operador:";
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Location = new Point(33, 42);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(68, 19);
            rdbDecimal.TabIndex = 9;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Location = new Point(154, 42);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(62, 19);
            rdbBinario.TabIndex = 10;
            rdbBinario.TabStop = true;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            // 
            // cmbOperacion
            // 
            cmbOperacion.AutoCompleteCustomSource.AddRange(new string[] { "", "+", "-", "/", "*" });
            cmbOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Items.AddRange(new object[] { "", "+", "-", "/", "*" });
            cmbOperacion.Location = new Point(342, 320);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(130, 23);
            cmbOperacion.TabIndex = 11;
            // 
            // grpSistema
            // 
            grpSistema.Controls.Add(rdbDecimal);
            grpSistema.Controls.Add(rdbBinario);
            grpSistema.Location = new Point(282, 139);
            grpSistema.Name = "grpSistema";
            grpSistema.Size = new Size(248, 100);
            grpSistema.TabIndex = 12;
            grpSistema.TabStop = false;
            grpSistema.Text = "Representar resultado en:";
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpSistema);
            Controls.Add(cmbOperacion);
            Controls.Add(lblSegundoOperador);
            Controls.Add(lblOperacion);
            Controls.Add(lblPrimerOperando);
            Controls.Add(lblResultado);
            Controls.Add(txtSegundoOperador);
            Controls.Add(txtPrimerOperador);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora Alumno:  Maximo Unrrein";
            Load += FrmCalculadora_Load;
            grpSistema.ResumeLayout(false);
            grpSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Operacion calculadora;
        private Numeracion primerOperando;
        private Numeracion segundoOperando;
        private Numeracion resultado;
        private Numeracion.ESistema sistema;


        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private TextBox txtPrimerOperador;
        private TextBox txtSegundoOperador;
        private Label lblResultado;
        private Label lblPrimerOperando;
        private Label lblOperacion;
        private Label lblSegundoOperador;
        private RadioButton rdbDecimal;
        private RadioButton rdbBinario;
        private ComboBox cmbOperacion;
        private GroupBox grpSistema;
    }
}