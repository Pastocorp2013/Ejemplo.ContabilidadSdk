
namespace SdkContabilidad.Example.FrontPanels
{
    partial class AccountForm
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
            this.dgResult = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtConsume = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtSatGroup = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDig2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSistOrigin = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDig1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCodAccountSum = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGroupDigit = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIs = new System.Windows.Forms.TextBox();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAcceptSegment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMAccount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEnglishName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnGetByNumber = new System.Windows.Forms.Button();
            this.btnGetById = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgResult
            // 
            this.dgResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResult.Location = new System.Drawing.Point(12, 374);
            this.dgResult.Name = "dgResult";
            this.dgResult.RowHeadersWidth = 51;
            this.dgResult.RowTemplate.Height = 24;
            this.dgResult.Size = new System.Drawing.Size(635, 147);
            this.dgResult.TabIndex = 12;
            this.dgResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgResult_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtConsume);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtSatGroup);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtDig2);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtSistOrigin);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtDig1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtCodAccountSum);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtGroupDigit);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtIs);
            this.groupBox1.Controls.Add(this.dtStartDate);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCurrency);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtAcceptSegment);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMAccount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtEnglishName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 287);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuenta";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(293, 260);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 17);
            this.label17.TabIndex = 39;
            this.label17.Text = "Consume";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // txtConsume
            // 
            this.txtConsume.Location = new System.Drawing.Point(419, 260);
            this.txtConsume.Name = "txtConsume";
            this.txtConsume.Size = new System.Drawing.Size(203, 22);
            this.txtConsume.TabIndex = 38;
            this.txtConsume.TextChanged += new System.EventHandler(this.txtConsume_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 260);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 17);
            this.label18.TabIndex = 37;
            this.label18.Text = "Agrupador SAT";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // txtSatGroup
            // 
            this.txtSatGroup.Location = new System.Drawing.Point(118, 257);
            this.txtSatGroup.Name = "txtSatGroup";
            this.txtSatGroup.Size = new System.Drawing.Size(159, 22);
            this.txtSatGroup.TabIndex = 36;
            this.txtSatGroup.TextChanged += new System.EventHandler(this.txtSatGroup_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(292, 232);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 17);
            this.label16.TabIndex = 35;
            this.label16.Text = "Dig Fiscal 2";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // txtDig2
            // 
            this.txtDig2.Location = new System.Drawing.Point(418, 232);
            this.txtDig2.Name = "txtDig2";
            this.txtDig2.Size = new System.Drawing.Size(203, 22);
            this.txtDig2.TabIndex = 34;
            this.txtDig2.Text = "0";
            this.txtDig2.TextChanged += new System.EventHandler(this.txtDig2_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(292, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 17);
            this.label14.TabIndex = 33;
            this.label14.Text = "Sistema Origen";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtSistOrigin
            // 
            this.txtSistOrigin.Location = new System.Drawing.Point(418, 144);
            this.txtSistOrigin.Name = "txtSistOrigin";
            this.txtSistOrigin.Size = new System.Drawing.Size(203, 22);
            this.txtSistOrigin.TabIndex = 32;
            this.txtSistOrigin.Text = "0";
            this.txtSistOrigin.TextChanged += new System.EventHandler(this.txtSistOrigin_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 232);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 17);
            this.label15.TabIndex = 31;
            this.label15.Text = "Dig Fiscal 1";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // txtDig1
            // 
            this.txtDig1.Location = new System.Drawing.Point(96, 229);
            this.txtDig1.Name = "txtDig1";
            this.txtDig1.Size = new System.Drawing.Size(180, 22);
            this.txtDig1.TabIndex = 30;
            this.txtDig1.Text = "0";
            this.txtDig1.TextChanged += new System.EventHandler(this.txtDig1_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(292, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 17);
            this.label12.TabIndex = 29;
            this.label12.Text = "Cod Cuenta Acum";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtCodAccountSum
            // 
            this.txtCodAccountSum.Location = new System.Drawing.Point(418, 204);
            this.txtCodAccountSum.Name = "txtCodAccountSum";
            this.txtCodAccountSum.Size = new System.Drawing.Size(203, 22);
            this.txtCodAccountSum.TabIndex = 28;
            this.txtCodAccountSum.TextChanged += new System.EventHandler(this.txtCodAccountSum_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(292, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 17);
            this.label13.TabIndex = 27;
            this.label13.Text = "Es Cta Efectivo";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(418, 113);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(203, 22);
            this.textBox4.TabIndex = 26;
            this.textBox4.Text = "0";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(292, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Dígito Agrupador";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtGroupDigit
            // 
            this.txtGroupDigit.Location = new System.Drawing.Point(418, 173);
            this.txtGroupDigit.Name = "txtGroupDigit";
            this.txtGroupDigit.Size = new System.Drawing.Size(203, 22);
            this.txtGroupDigit.TabIndex = 24;
            this.txtGroupDigit.Text = "0";
            this.txtGroupDigit.TextChanged += new System.EventHandler(this.txtGroupDigit_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(293, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Es Baja";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtIs
            // 
            this.txtIs.Location = new System.Drawing.Point(418, 85);
            this.txtIs.Name = "txtIs";
            this.txtIs.Size = new System.Drawing.Size(203, 22);
            this.txtIs.TabIndex = 22;
            this.txtIs.Text = "0";
            this.txtIs.TextChanged += new System.EventHandler(this.txtIs_TextChanged);
            // 
            // dtStartDate
            // 
            this.dtStartDate.Location = new System.Drawing.Point(90, 142);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(187, 22);
            this.dtStartDate.TabIndex = 21;
            this.dtStartDate.ValueChanged += new System.EventHandler(this.dtStartDate_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Fecha Alta";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Moneda";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(74, 170);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(202, 22);
            this.txtCurrency.TabIndex = 18;
            this.txtCurrency.Text = "0";
            this.txtCurrency.TextChanged += new System.EventHandler(this.txtCurrency_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Aplica Seg Negocio";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtAcceptSegment
            // 
            this.txtAcceptSegment.Location = new System.Drawing.Point(146, 201);
            this.txtAcceptSegment.Name = "txtAcceptSegment";
            this.txtAcceptSegment.Size = new System.Drawing.Size(131, 22);
            this.txtAcceptSegment.TabIndex = 16;
            this.txtAcceptSegment.Text = "0";
            this.txtAcceptSegment.TextChanged += new System.EventHandler(this.txtAcceptSegment_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cuenta de Mayor";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtMAccount
            // 
            this.txtMAccount.Location = new System.Drawing.Point(131, 114);
            this.txtMAccount.Name = "txtMAccount";
            this.txtMAccount.Size = new System.Drawing.Size(145, 22);
            this.txtMAccount.TabIndex = 14;
            this.txtMAccount.Text = "0";
            this.txtMAccount.TextChanged += new System.EventHandler(this.txtMAccount_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tipo";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(73, 86);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(203, 22);
            this.txtType.TabIndex = 12;
            this.txtType.Text = "0";
            this.txtType.TextChanged += new System.EventHandler(this.txtType_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nombre Inglés";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtEnglishName
            // 
            this.txtEnglishName.Location = new System.Drawing.Point(418, 54);
            this.txtEnglishName.Name = "txtEnglishName";
            this.txtEnglishName.Size = new System.Drawing.Size(203, 22);
            this.txtEnglishName.TabIndex = 10;
            this.txtEnglishName.TextChanged += new System.EventHandler(this.txtEnglishName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Id";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(34, 21);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(243, 22);
            this.txtId.TabIndex = 8;
            this.txtId.Text = "0";
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Código";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(418, 21);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(203, 22);
            this.txtCode.TabIndex = 6;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(74, 54);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(203, 22);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnGetAll);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.btnGetByNumber);
            this.panel1.Controls.Add(this.btnGetById);
            this.panel1.Location = new System.Drawing.Point(12, 305);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 63);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.btnGetAll.Text = "&Buscar Todos";
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
            // btnGetByNumber
            // 
            this.btnGetByNumber.Location = new System.Drawing.Point(118, 3);
            this.btnGetByNumber.Name = "btnGetByNumber";
            this.btnGetByNumber.Size = new System.Drawing.Size(117, 53);
            this.btnGetByNumber.TabIndex = 0;
            this.btnGetByNumber.Text = "Buscar por C&ódigo";
            this.btnGetByNumber.UseVisualStyleBackColor = true;
            this.btnGetByNumber.Click += new System.EventHandler(this.btnGetByNumber_Click);
            // 
            // btnGetById
            // 
            this.btnGetById.Location = new System.Drawing.Point(241, 3);
            this.btnGetById.Name = "btnGetById";
            this.btnGetById.Size = new System.Drawing.Size(117, 53);
            this.btnGetById.TabIndex = 1;
            this.btnGetById.Text = "Buscar por &Id";
            this.btnGetById.UseVisualStyleBackColor = true;
            this.btnGetById.Click += new System.EventHandler(this.btnGetById_Click);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 546);
            this.Controls.Add(this.dgResult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "AccountForm";
            this.ShowIcon = false;
            this.Text = "Cuenta Contable";
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnGetByNumber;
        private System.Windows.Forms.Button btnGetById;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAcceptSegment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEnglishName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtConsume;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtSatGroup;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDig2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSistOrigin;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDig1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCodAccountSum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGroupDigit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIs;
    }
}