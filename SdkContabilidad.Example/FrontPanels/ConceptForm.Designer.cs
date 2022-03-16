
namespace SdkContabilidad.Example.FrontPanels
{
    partial class ConceptForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnGetByNumber = new System.Windows.Forms.Button();
            this.btnGetById = new System.Windows.Forms.Button();
            this.dgResult = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 198);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Concepto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(6, 153);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(430, 22);
            this.txtId.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Número";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(6, 97);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(430, 22);
            this.txtNumber.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(430, 22);
            this.txtName.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnGetAll);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.btnGetByNumber);
            this.panel1.Controls.Add(this.btnGetById);
            this.panel1.Location = new System.Drawing.Point(21, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 63);
            this.panel1.TabIndex = 7;
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
            this.btnGetByNumber.Text = "Buscar por &Número";
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
            // dgResult
            // 
            this.dgResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResult.Location = new System.Drawing.Point(21, 300);
            this.dgResult.Name = "dgResult";
            this.dgResult.RowHeadersWidth = 51;
            this.dgResult.RowTemplate.Height = 24;
            this.dgResult.Size = new System.Drawing.Size(635, 109);
            this.dgResult.TabIndex = 9;
            // 
            // ConceptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 482);
            this.Controls.Add(this.dgResult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "ConceptForm";
            this.ShowIcon = false;
            this.Text = "Ventana Concepto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Button btnGetByNumber;
        private System.Windows.Forms.Button btnGetById;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgResult;
    }
}