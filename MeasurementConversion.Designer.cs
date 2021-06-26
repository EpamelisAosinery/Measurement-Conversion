namespace Conversion
{
    partial class MeasurementConversion
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
            this.cboMeasurement = new System.Windows.Forms.ComboBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.cboUnit1 = new System.Windows.Forms.ComboBox();
            this.cboUnit2 = new System.Windows.Forms.ComboBox();
            this.lblFormula = new System.Windows.Forms.Label();
            this.lblFormulaDescription = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboMeasurement
            // 
            this.cboMeasurement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMeasurement.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMeasurement.FormattingEnabled = true;
            this.cboMeasurement.ItemHeight = 27;
            this.cboMeasurement.Location = new System.Drawing.Point(12, 28);
            this.cboMeasurement.Name = "cboMeasurement";
            this.cboMeasurement.Size = new System.Drawing.Size(400, 35);
            this.cboMeasurement.TabIndex = 0;
            this.cboMeasurement.SelectedIndexChanged += new System.EventHandler(this.cmbMeasurement_SelectedIndexChanged);
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(12, 92);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(168, 34);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInput.TextChanged += new System.EventHandler(this.btnCalculate_Click);
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(244, 92);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(168, 34);
            this.txtOutput.TabIndex = 4;
            this.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboUnit1
            // 
            this.cboUnit1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnit1.FormattingEnabled = true;
            this.cboUnit1.Location = new System.Drawing.Point(12, 123);
            this.cboUnit1.Name = "cboUnit1";
            this.cboUnit1.Size = new System.Drawing.Size(168, 34);
            this.cboUnit1.TabIndex = 2;
            this.cboUnit1.SelectedIndexChanged += new System.EventHandler(this.btnCalculate_Click);
            // 
            // cboUnit2
            // 
            this.cboUnit2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnit2.FormattingEnabled = true;
            this.cboUnit2.Location = new System.Drawing.Point(244, 123);
            this.cboUnit2.Name = "cboUnit2";
            this.cboUnit2.Size = new System.Drawing.Size(168, 34);
            this.cboUnit2.TabIndex = 5;
            this.cboUnit2.SelectedIndexChanged += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblFormula
            // 
            this.lblFormula.AutoSize = true;
            this.lblFormula.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormula.Location = new System.Drawing.Point(13, 193);
            this.lblFormula.Name = "lblFormula";
            this.lblFormula.Size = new System.Drawing.Size(89, 26);
            this.lblFormula.TabIndex = 6;
            this.lblFormula.Text = "Formula:";
            // 
            // lblFormulaDescription
            // 
            this.lblFormulaDescription.AutoSize = true;
            this.lblFormulaDescription.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormulaDescription.Location = new System.Drawing.Point(108, 193);
            this.lblFormulaDescription.Name = "lblFormulaDescription";
            this.lblFormulaDescription.Size = new System.Drawing.Size(0, 26);
            this.lblFormulaDescription.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Enabled = false;
            this.btnCalculate.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(186, 105);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(52, 41);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "=";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // MeasurementConversion
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 314);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblFormulaDescription);
            this.Controls.Add(this.lblFormula);
            this.Controls.Add(this.cboUnit2);
            this.Controls.Add(this.cboUnit1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.cboMeasurement);
            this.Name = "MeasurementConversion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Measurement Conversion v0 ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMeasurement;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.ComboBox cboUnit1;
        private System.Windows.Forms.ComboBox cboUnit2;
        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.Label lblFormulaDescription;
        private System.Windows.Forms.Button btnCalculate;
    }
}

