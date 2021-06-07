
namespace Relacionamentoapp
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
            this.bt_add = new System.Windows.Forms.Button();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_contato = new System.Windows.Forms.TextBox();
            this.cb_pref = new System.Windows.Forms.ComboBox();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_contato = new System.Windows.Forms.Label();
            this.lb_sexo = new System.Windows.Forms.Label();
            this.cb_sexo = new System.Windows.Forms.ComboBox();
            this.lb_pref = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(253, 181);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(100, 23);
            this.bt_add.TabIndex = 0;
            this.bt_add.Text = "Adicionar";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(102, 84);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(100, 23);
            this.tb_nome.TabIndex = 1;
            this.tb_nome.TextChanged += new System.EventHandler(this.tb_nome_TextChanged);
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(253, 84);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(100, 23);
            this.tb_email.TabIndex = 2;
            // 
            // tb_contato
            // 
            this.tb_contato.Location = new System.Drawing.Point(418, 84);
            this.tb_contato.Name = "tb_contato";
            this.tb_contato.Size = new System.Drawing.Size(100, 23);
            this.tb_contato.TabIndex = 3;
            // 
            // cb_pref
            // 
            this.cb_pref.FormattingEnabled = true;
            this.cb_pref.Items.AddRange(new object[] {
            "Homens",
            "Mulheres",
            "Todos"});
            this.cb_pref.Location = new System.Drawing.Point(359, 136);
            this.cb_pref.Name = "cb_pref";
            this.cb_pref.Size = new System.Drawing.Size(121, 23);
            this.cb_pref.TabIndex = 6;
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_titulo.Location = new System.Drawing.Point(45, 24);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(521, 31);
            this.lb_titulo.TabIndex = 7;
            this.lb_titulo.Text = "Banco de informações do RelacionamentoAPP";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(58, 87);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(43, 15);
            this.lb_nome.TabIndex = 8;
            this.lb_nome.Text = "Nome:";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(208, 87);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(39, 15);
            this.lb_email.TabIndex = 9;
            this.lb_email.Text = "Email:";
            // 
            // lb_contato
            // 
            this.lb_contato.AutoSize = true;
            this.lb_contato.Location = new System.Drawing.Point(359, 87);
            this.lb_contato.Name = "lb_contato";
            this.lb_contato.Size = new System.Drawing.Size(53, 15);
            this.lb_contato.TabIndex = 10;
            this.lb_contato.Text = "Contato:";
            // 
            // lb_sexo
            // 
            this.lb_sexo.AutoSize = true;
            this.lb_sexo.Location = new System.Drawing.Point(116, 139);
            this.lb_sexo.Name = "lb_sexo";
            this.lb_sexo.Size = new System.Drawing.Size(35, 15);
            this.lb_sexo.TabIndex = 11;
            this.lb_sexo.Text = "Sexo:";
            // 
            // cb_sexo
            // 
            this.cb_sexo.FormattingEnabled = true;
            this.cb_sexo.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.cb_sexo.Location = new System.Drawing.Point(157, 136);
            this.cb_sexo.Name = "cb_sexo";
            this.cb_sexo.Size = new System.Drawing.Size(121, 23);
            this.cb_sexo.TabIndex = 12;
            // 
            // lb_pref
            // 
            this.lb_pref.AutoSize = true;
            this.lb_pref.Location = new System.Drawing.Point(284, 139);
            this.lb_pref.Name = "lb_pref";
            this.lb_pref.Size = new System.Drawing.Size(69, 15);
            this.lb_pref.TabIndex = 13;
            this.lb_pref.Text = "Preferência:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 284);
            this.Controls.Add(this.lb_pref);
            this.Controls.Add(this.cb_sexo);
            this.Controls.Add(this.lb_sexo);
            this.Controls.Add(this.lb_contato);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.cb_pref);
            this.Controls.Add(this.tb_contato);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.bt_add);
            this.Name = "Form1";
            this.Text = "RelacionamentoAPP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_contato;
        private System.Windows.Forms.ComboBox cb_pref;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_contato;
        private System.Windows.Forms.Label lb_sexo;
        private System.Windows.Forms.ComboBox cb_sexo;
        private System.Windows.Forms.Label lb_pref;
    }
}

