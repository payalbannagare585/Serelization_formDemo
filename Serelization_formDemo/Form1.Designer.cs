namespace Serelization_formDemo
{
    partial class Form1
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.btnBinaryWrite = new System.Windows.Forms.Button();
            this.btnBinaryRead = new System.Windows.Forms.Button();
            this.btnXMLWrite = new System.Windows.Forms.Button();
            this.btnXMLRead = new System.Windows.Forms.Button();
            this.btnSOAPWrite = new System.Windows.Forms.Button();
            this.btnSOAPRead = new System.Windows.Forms.Button();
            this.btnJSONWrite = new System.Windows.Forms.Button();
            this.btnJSONRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(57, 47);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(140, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Enter Employee Id";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(57, 109);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(168, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Enter Employee Name";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(57, 175);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(139, 20);
            this.lblSalary.TabIndex = 2;
            this.lblSalary.Text = "Enter Basic Salary";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(245, 41);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(135, 26);
            this.txtId.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(245, 103);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(135, 26);
            this.txtName.TabIndex = 4;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(245, 169);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(135, 26);
            this.txtSalary.TabIndex = 5;
            // 
            // btnBinaryWrite
            // 
            this.btnBinaryWrite.Location = new System.Drawing.Point(94, 244);
            this.btnBinaryWrite.Name = "btnBinaryWrite";
            this.btnBinaryWrite.Size = new System.Drawing.Size(156, 57);
            this.btnBinaryWrite.TabIndex = 6;
            this.btnBinaryWrite.Text = "Binary Write";
            this.btnBinaryWrite.UseVisualStyleBackColor = true;
            this.btnBinaryWrite.Click += new System.EventHandler(this.btnBinaryWrite_Click);
            // 
            // btnBinaryRead
            // 
            this.btnBinaryRead.Location = new System.Drawing.Point(297, 244);
            this.btnBinaryRead.Name = "btnBinaryRead";
            this.btnBinaryRead.Size = new System.Drawing.Size(156, 57);
            this.btnBinaryRead.TabIndex = 7;
            this.btnBinaryRead.Text = "Binary Read";
            this.btnBinaryRead.UseVisualStyleBackColor = true;
            this.btnBinaryRead.Click += new System.EventHandler(this.btnBinaryRead_Click);
            // 
            // btnXMLWrite
            // 
            this.btnXMLWrite.Location = new System.Drawing.Point(94, 338);
            this.btnXMLWrite.Name = "btnXMLWrite";
            this.btnXMLWrite.Size = new System.Drawing.Size(156, 57);
            this.btnXMLWrite.TabIndex = 8;
            this.btnXMLWrite.Text = "XML Write";
            this.btnXMLWrite.UseVisualStyleBackColor = true;
            // 
            // btnXMLRead
            // 
            this.btnXMLRead.Location = new System.Drawing.Point(297, 338);
            this.btnXMLRead.Name = "btnXMLRead";
            this.btnXMLRead.Size = new System.Drawing.Size(156, 57);
            this.btnXMLRead.TabIndex = 9;
            this.btnXMLRead.Text = "XML Read";
            this.btnXMLRead.UseVisualStyleBackColor = true;
            // 
            // btnSOAPWrite
            // 
            this.btnSOAPWrite.Location = new System.Drawing.Point(447, 47);
            this.btnSOAPWrite.Name = "btnSOAPWrite";
            this.btnSOAPWrite.Size = new System.Drawing.Size(156, 57);
            this.btnSOAPWrite.TabIndex = 10;
            this.btnSOAPWrite.Text = "SOAP Write";
            this.btnSOAPWrite.UseVisualStyleBackColor = true;
            this.btnSOAPWrite.Click += new System.EventHandler(this.btnSOAPWrite_Click);
            // 
            // btnSOAPRead
            // 
            this.btnSOAPRead.Location = new System.Drawing.Point(632, 47);
            this.btnSOAPRead.Name = "btnSOAPRead";
            this.btnSOAPRead.Size = new System.Drawing.Size(156, 57);
            this.btnSOAPRead.TabIndex = 11;
            this.btnSOAPRead.Text = "SOAP Read";
            this.btnSOAPRead.UseVisualStyleBackColor = true;
            this.btnSOAPRead.Click += new System.EventHandler(this.btnSOAPRead_Click);
            // 
            // btnJSONWrite
            // 
            this.btnJSONWrite.Location = new System.Drawing.Point(447, 138);
            this.btnJSONWrite.Name = "btnJSONWrite";
            this.btnJSONWrite.Size = new System.Drawing.Size(156, 57);
            this.btnJSONWrite.TabIndex = 12;
            this.btnJSONWrite.Text = "JSON Write";
            this.btnJSONWrite.UseVisualStyleBackColor = true;
            // 
            // btnJSONRead
            // 
            this.btnJSONRead.Location = new System.Drawing.Point(632, 138);
            this.btnJSONRead.Name = "btnJSONRead";
            this.btnJSONRead.Size = new System.Drawing.Size(156, 57);
            this.btnJSONRead.TabIndex = 13;
            this.btnJSONRead.Text = "JSON Read";
            this.btnJSONRead.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJSONRead);
            this.Controls.Add(this.btnJSONWrite);
            this.Controls.Add(this.btnSOAPRead);
            this.Controls.Add(this.btnSOAPWrite);
            this.Controls.Add(this.btnXMLRead);
            this.Controls.Add(this.btnXMLWrite);
            this.Controls.Add(this.btnBinaryRead);
            this.Controls.Add(this.btnBinaryWrite);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button btnBinaryWrite;
        private System.Windows.Forms.Button btnBinaryRead;
        private System.Windows.Forms.Button btnXMLWrite;
        private System.Windows.Forms.Button btnXMLRead;
        private System.Windows.Forms.Button btnSOAPWrite;
        private System.Windows.Forms.Button btnSOAPRead;
        private System.Windows.Forms.Button btnJSONWrite;
        private System.Windows.Forms.Button btnJSONRead;
    }
}

