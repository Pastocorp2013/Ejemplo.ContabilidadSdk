
namespace SdkContabilidad.Example
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnOpenCompany = new System.Windows.Forms.Button();
            this.btnCloseCompany = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAccounts = new System.Windows.Forms.Button();
            this.btnConcepts = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(23, 10);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(117, 47);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "&Conectar SDK";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(23, 82);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(117, 53);
            this.btnDisconnect.TabIndex = 1;
            this.btnDisconnect.Text = "&Desconectar SDK";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnOpenCompany
            // 
            this.btnOpenCompany.Location = new System.Drawing.Point(23, 153);
            this.btnOpenCompany.Name = "btnOpenCompany";
            this.btnOpenCompany.Size = new System.Drawing.Size(112, 54);
            this.btnOpenCompany.TabIndex = 2;
            this.btnOpenCompany.Text = "&Abrir Empresa";
            this.btnOpenCompany.UseVisualStyleBackColor = true;
            this.btnOpenCompany.Click += new System.EventHandler(this.btnOpenCompany_Click);
            // 
            // btnCloseCompany
            // 
            this.btnCloseCompany.Location = new System.Drawing.Point(28, 230);
            this.btnCloseCompany.Name = "btnCloseCompany";
            this.btnCloseCompany.Size = new System.Drawing.Size(112, 55);
            this.btnCloseCompany.TabIndex = 3;
            this.btnCloseCompany.Text = "Ce&rrar Empresa";
            this.btnCloseCompany.UseVisualStyleBackColor = true;
            this.btnCloseCompany.Click += new System.EventHandler(this.btnCloseCompany_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(6, 46);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(430, 22);
            this.txtUser.TabIndex = 4;
            this.txtUser.Text = "SUPERVISOR";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCloseCompany);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.btnDisconnect);
            this.panel1.Controls.Add(this.btnOpenCompany);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 317);
            this.panel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Location = new System.Drawing.Point(207, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 155);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credenciales Contabilidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contraseña";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(6, 110);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(430, 22);
            this.txtPassword.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCompany);
            this.groupBox2.Location = new System.Drawing.Point(207, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 145);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Base de datos";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(6, 34);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(430, 22);
            this.txtCompany.TabIndex = 8;
            this.txtCompany.Text = "ctpruebasContabilidad";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnConcepts);
            this.groupBox3.Controls.Add(this.btnAccounts);
            this.groupBox3.Location = new System.Drawing.Point(15, 351);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(651, 170);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Formularios Esquemas";
            // 
            // btnAccounts
            // 
            this.btnAccounts.Location = new System.Drawing.Point(6, 35);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Size = new System.Drawing.Size(112, 55);
            this.btnAccounts.TabIndex = 4;
            this.btnAccounts.Text = "Cuentas";
            this.btnAccounts.UseVisualStyleBackColor = true;
            // 
            // btnConcepts
            // 
            this.btnConcepts.Location = new System.Drawing.Point(124, 35);
            this.btnConcepts.Name = "btnConcepts";
            this.btnConcepts.Size = new System.Drawing.Size(112, 55);
            this.btnConcepts.TabIndex = 5;
            this.btnConcepts.Text = "Conceptos";
            this.btnConcepts.UseVisualStyleBackColor = true;
            this.btnConcepts.Click += new System.EventHandler(this.btnConcepts_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Ejemplo CONTPAQi SDK Contabilidad";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnOpenCompany;
        private System.Windows.Forms.Button btnCloseCompany;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnConcepts;
        private System.Windows.Forms.Button btnAccounts;
    }
}

