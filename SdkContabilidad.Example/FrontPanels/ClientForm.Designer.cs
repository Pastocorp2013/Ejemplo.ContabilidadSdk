
namespace SdkContabilidad.Example.FrontPanels
{
    partial class ClientForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnGetByAdminCode = new System.Windows.Forms.Button();
            this.btnGetByCode = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtIsPerson = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtIsAgent = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtIsEmployee = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtIsProv = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIsClient = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPhone3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtWebPage = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPhone1 = new System.Windows.Forms.TextBox();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dgResult = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdExtraData = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCurp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRfc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnGetAll);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.btnGetByAdminCode);
            this.panel1.Controls.Add(this.btnGetByCode);
            this.panel1.Location = new System.Drawing.Point(3, 296);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 63);
            this.panel1.TabIndex = 13;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(482, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 54);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "&Borrar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(0, 3);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(112, 51);
            this.btnGetAll.TabIndex = 3;
            this.btnGetAll.Text = "&Buscar Todos por Rfc";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(364, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(112, 54);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "&Crear";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnGetByAdminCode
            // 
            this.btnGetByAdminCode.Location = new System.Drawing.Point(118, 3);
            this.btnGetByAdminCode.Name = "btnGetByAdminCode";
            this.btnGetByAdminCode.Size = new System.Drawing.Size(117, 53);
            this.btnGetByAdminCode.TabIndex = 0;
            this.btnGetByAdminCode.Text = "Buscar por Cód &Admin";
            this.btnGetByAdminCode.UseVisualStyleBackColor = true;
            this.btnGetByAdminCode.Click += new System.EventHandler(this.btnGetByAdminCode_Click);
            // 
            // btnGetByCode
            // 
            this.btnGetByCode.Location = new System.Drawing.Point(241, 3);
            this.btnGetByCode.Name = "btnGetByCode";
            this.btnGetByCode.Size = new System.Drawing.Size(117, 53);
            this.btnGetByCode.TabIndex = 1;
            this.btnGetByCode.Text = "Buscar p&or Código";
            this.btnGetByCode.UseVisualStyleBackColor = true;
            this.btnGetByCode.Click += new System.EventHandler(this.btnGetByCode_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(293, 260);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 17);
            this.label17.TabIndex = 39;
            this.label17.Text = "Es Persona";
            // 
            // txtIsPerson
            // 
            this.txtIsPerson.Location = new System.Drawing.Point(419, 260);
            this.txtIsPerson.Name = "txtIsPerson";
            this.txtIsPerson.Size = new System.Drawing.Size(203, 22);
            this.txtIsPerson.TabIndex = 38;
            this.txtIsPerson.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 260);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 17);
            this.label18.TabIndex = 37;
            this.label18.Text = "Es Agente";
            // 
            // txtIsAgent
            // 
            this.txtIsAgent.Location = new System.Drawing.Point(118, 257);
            this.txtIsAgent.Name = "txtIsAgent";
            this.txtIsAgent.Size = new System.Drawing.Size(159, 22);
            this.txtIsAgent.TabIndex = 36;
            this.txtIsAgent.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(292, 232);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 17);
            this.label16.TabIndex = 35;
            this.label16.Text = "Es Empleado";
            // 
            // txtIsEmployee
            // 
            this.txtIsEmployee.Location = new System.Drawing.Point(418, 232);
            this.txtIsEmployee.Name = "txtIsEmployee";
            this.txtIsEmployee.Size = new System.Drawing.Size(203, 22);
            this.txtIsEmployee.TabIndex = 34;
            this.txtIsEmployee.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(292, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 17);
            this.label14.TabIndex = 33;
            this.label14.Text = "Fax";
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(418, 144);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(203, 22);
            this.txtFax.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 232);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 17);
            this.label15.TabIndex = 31;
            this.label15.Text = "Es Prov";
            // 
            // txtIsProv
            // 
            this.txtIsProv.Location = new System.Drawing.Point(96, 229);
            this.txtIsProv.Name = "txtIsProv";
            this.txtIsProv.Size = new System.Drawing.Size(180, 22);
            this.txtIsProv.TabIndex = 30;
            this.txtIsProv.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(292, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 17);
            this.label12.TabIndex = 29;
            this.label12.Text = "Es Cliente";
            // 
            // txtIsClient
            // 
            this.txtIsClient.Location = new System.Drawing.Point(418, 204);
            this.txtIsClient.Name = "txtIsClient";
            this.txtIsClient.Size = new System.Drawing.Size(203, 22);
            this.txtIsClient.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(292, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 17);
            this.label13.TabIndex = 27;
            this.label13.Text = "Teléfono 3";
            // 
            // txtPhone3
            // 
            this.txtPhone3.Location = new System.Drawing.Point(418, 113);
            this.txtPhone3.Name = "txtPhone3";
            this.txtPhone3.Size = new System.Drawing.Size(203, 22);
            this.txtPhone3.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(292, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Pagina Web";
            // 
            // txtWebPage
            // 
            this.txtWebPage.Location = new System.Drawing.Point(418, 173);
            this.txtWebPage.Name = "txtWebPage";
            this.txtWebPage.Size = new System.Drawing.Size(203, 22);
            this.txtWebPage.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(293, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Teléfono1";
            // 
            // txtPhone1
            // 
            this.txtPhone1.Location = new System.Drawing.Point(418, 85);
            this.txtPhone1.Name = "txtPhone1";
            this.txtPhone1.Size = new System.Drawing.Size(203, 22);
            this.txtPhone1.TabIndex = 22;
            // 
            // dtStartDate
            // 
            this.dtStartDate.Location = new System.Drawing.Point(90, 142);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(187, 22);
            this.dtStartDate.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Fecha Alta";
            // 
            // dgResult
            // 
            this.dgResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResult.Location = new System.Drawing.Point(3, 365);
            this.dgResult.Name = "dgResult";
            this.dgResult.RowHeadersWidth = 51;
            this.dgResult.RowTemplate.Height = 24;
            this.dgResult.Size = new System.Drawing.Size(635, 147);
            this.dgResult.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtIsPerson);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtIsAgent);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtIsEmployee);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtFax);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtIsProv);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtIsClient);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtPhone3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtWebPage);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtPhone1);
            this.groupBox1.Controls.Add(this.dtStartDate);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtIdExtraData);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPhone2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCurp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtRfc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 287);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuenta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(74, 170);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(202, 22);
            this.txtEmail.TabIndex = 18;
            this.txtEmail.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Id Dato Extra";
            // 
            // txtIdExtraData
            // 
            this.txtIdExtraData.Location = new System.Drawing.Point(146, 201);
            this.txtIdExtraData.Name = "txtIdExtraData";
            this.txtIdExtraData.Size = new System.Drawing.Size(131, 22);
            this.txtIdExtraData.TabIndex = 16;
            this.txtIdExtraData.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Teléfono 2";
            // 
            // txtPhone2
            // 
            this.txtPhone2.Location = new System.Drawing.Point(131, 114);
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Size = new System.Drawing.Size(145, 22);
            this.txtPhone2.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "CURP";
            // 
            // txtCurp
            // 
            this.txtCurp.Location = new System.Drawing.Point(73, 86);
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(203, 22);
            this.txtCurp.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "RFC";
            // 
            // txtRfc
            // 
            this.txtRfc.Location = new System.Drawing.Point(418, 54);
            this.txtRfc.Name = "txtRfc";
            this.txtRfc.Size = new System.Drawing.Size(203, 22);
            this.txtRfc.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(34, 21);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(243, 22);
            this.txtId.TabIndex = 8;
            this.txtId.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Código";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(418, 21);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(203, 22);
            this.txtCode.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(74, 54);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(203, 22);
            this.txtName.TabIndex = 4;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 538);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgResult);
            this.Controls.Add(this.groupBox1);
            this.Name = "ClientForm";
            this.ShowIcon = false;
            this.Text = "Cliente";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnGetByAdminCode;
        private System.Windows.Forms.Button btnGetByCode;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtIsPerson;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtIsAgent;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtIsEmployee;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtIsProv;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtIsClient;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPhone3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtWebPage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPhone1;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdExtraData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCurp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRfc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
    }
}