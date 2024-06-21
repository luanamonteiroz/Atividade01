namespace Atividade01.View
{
    partial class SomaNumeros
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
            lbl_Titulo = new Label();
            lbl_valor1 = new Label();
            lbl_valor2 = new Label();
            tbx_Valor1 = new TextBox();
            tbx_Valor2 = new TextBox();
            lbl_Mensagem = new Label();
            btn_Calcular = new Button();
            lbl_Mensagem1 = new Label();
            SuspendLayout();
            // 
            // lbl_Titulo
            // 
            lbl_Titulo.AutoSize = true;
            lbl_Titulo.Font = new Font("Snap ITC", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Titulo.Location = new Point(72, 101);
            lbl_Titulo.Name = "lbl_Titulo";
            lbl_Titulo.Size = new Size(430, 48);
            lbl_Titulo.TabIndex = 0;
            lbl_Titulo.Text = "Some Dois Números";
            lbl_Titulo.Click += lbl_Titulo_Click;
            // 
            // lbl_valor1
            // 
            lbl_valor1.AutoSize = true;
            lbl_valor1.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_valor1.Location = new Point(72, 224);
            lbl_valor1.Name = "lbl_valor1";
            lbl_valor1.Size = new Size(94, 24);
            lbl_valor1.TabIndex = 1;
            lbl_valor1.Text = "Valor 1:";
            // 
            // lbl_valor2
            // 
            lbl_valor2.AutoSize = true;
            lbl_valor2.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_valor2.Location = new Point(300, 225);
            lbl_valor2.Name = "lbl_valor2";
            lbl_valor2.Size = new Size(94, 24);
            lbl_valor2.TabIndex = 2;
            lbl_valor2.Text = "Valor 2:";
            // 
            // tbx_Valor1
            // 
            tbx_Valor1.Location = new Point(172, 225);
            tbx_Valor1.Name = "tbx_Valor1";
            tbx_Valor1.Size = new Size(100, 23);
            tbx_Valor1.TabIndex = 3;
            // 
            // tbx_Valor2
            // 
            tbx_Valor2.Location = new Point(400, 225);
            tbx_Valor2.Name = "tbx_Valor2";
            tbx_Valor2.Size = new Size(100, 23);
            tbx_Valor2.TabIndex = 4;
            tbx_Valor2.TextChanged += textBox2_TextChanged;
            // 
            // lbl_Mensagem
            // 
            lbl_Mensagem.AutoSize = true;
            lbl_Mensagem.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Mensagem.ForeColor = SystemColors.ControlLightLight;
            lbl_Mensagem.Location = new Point(241, 303);
            lbl_Mensagem.Name = "lbl_Mensagem";
            lbl_Mensagem.Size = new Size(0, 27);
            lbl_Mensagem.TabIndex = 5;
            // 
            // btn_Calcular
            // 
            btn_Calcular.BackColor = Color.Plum;
            btn_Calcular.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_Calcular.Location = new Point(199, 387);
            btn_Calcular.Name = "btn_Calcular";
            btn_Calcular.Size = new Size(195, 51);
            btn_Calcular.TabIndex = 6;
            btn_Calcular.Text = "Calcular";
            btn_Calcular.UseVisualStyleBackColor = false;
            btn_Calcular.Click += btn_Calcular_Click;
            // 
            // lbl_Mensagem1
            // 
            lbl_Mensagem1.BackColor = Color.DarkRed;
            lbl_Mensagem1.Font = new Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Mensagem1.ForeColor = SystemColors.ControlLightLight;
            lbl_Mensagem1.Location = new Point(139, 277);
            lbl_Mensagem1.Name = "lbl_Mensagem1";
            lbl_Mensagem1.Size = new Size(309, 73);
            lbl_Mensagem1.TabIndex = 7;
            lbl_Mensagem1.Click += lbl_Mensagem1_Click;
            // 
            // SomaNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(620, 450);
            Controls.Add(lbl_Mensagem1);
            Controls.Add(btn_Calcular);
            Controls.Add(lbl_Mensagem);
            Controls.Add(tbx_Valor2);
            Controls.Add(tbx_Valor1);
            Controls.Add(lbl_valor2);
            Controls.Add(lbl_valor1);
            Controls.Add(lbl_Titulo);
            Name = "SomaNumeros";
            Text = "Soma De Dois Números";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Titulo;
        private Label lbl_valor1;
        private Label lbl_valor2;
        private TextBox tbx_Valor1;
        private TextBox tbx_Valor2;
        private Label lbl_Mensagem;
        private Button btn_Calcular;
        private Label lbl_Mensagem1;
    }
}