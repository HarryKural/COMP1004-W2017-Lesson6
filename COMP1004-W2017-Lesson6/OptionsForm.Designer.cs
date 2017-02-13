namespace COMP1004_W2017_Lesson6
{
    partial class OptionsForm
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
            this.AcceptButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.FunctionGroupBox = new System.Windows.Forms.GroupBox();
            this.ExponentCheckBox = new System.Windows.Forms.CheckBox();
            this.SquareRootCheckBox = new System.Windows.Forms.CheckBox();
            this.LayoutGroupBox = new System.Windows.Forms.GroupBox();
            this.ScientificRadioButton = new System.Windows.Forms.RadioButton();
            this.StandardRadioButton = new System.Windows.Forms.RadioButton();
            this.FontButton = new System.Windows.Forms.Button();
            this.CalculatorFontDialog = new System.Windows.Forms.FontDialog();
            this.FunctionGroupBox.SuspendLayout();
            this.LayoutGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AcceptButton
            // 
            this.AcceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AcceptButton.Location = new System.Drawing.Point(13, 207);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(114, 42);
            this.AcceptButton.TabIndex = 0;
            this.AcceptButton.Text = "Accept";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this._acceptButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(263, 207);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(114, 42);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this._cancelButton_Click);
            // 
            // FunctionGroupBox
            // 
            this.FunctionGroupBox.Controls.Add(this.ExponentCheckBox);
            this.FunctionGroupBox.Controls.Add(this.SquareRootCheckBox);
            this.FunctionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FunctionGroupBox.Location = new System.Drawing.Point(13, 12);
            this.FunctionGroupBox.Name = "FunctionGroupBox";
            this.FunctionGroupBox.Size = new System.Drawing.Size(145, 111);
            this.FunctionGroupBox.TabIndex = 2;
            this.FunctionGroupBox.TabStop = false;
            this.FunctionGroupBox.Text = "Function";
            // 
            // ExponentCheckBox
            // 
            this.ExponentCheckBox.AutoSize = true;
            this.ExponentCheckBox.Location = new System.Drawing.Point(6, 72);
            this.ExponentCheckBox.Name = "ExponentCheckBox";
            this.ExponentCheckBox.Size = new System.Drawing.Size(111, 28);
            this.ExponentCheckBox.TabIndex = 1;
            this.ExponentCheckBox.Text = "Exponent";
            this.ExponentCheckBox.UseVisualStyleBackColor = true;
            // 
            // SquareRootCheckBox
            // 
            this.SquareRootCheckBox.AutoSize = true;
            this.SquareRootCheckBox.Location = new System.Drawing.Point(6, 38);
            this.SquareRootCheckBox.Name = "SquareRootCheckBox";
            this.SquareRootCheckBox.Size = new System.Drawing.Size(134, 28);
            this.SquareRootCheckBox.TabIndex = 0;
            this.SquareRootCheckBox.Text = "Square Root";
            this.SquareRootCheckBox.UseVisualStyleBackColor = true;
            // 
            // LayoutGroupBox
            // 
            this.LayoutGroupBox.Controls.Add(this.ScientificRadioButton);
            this.LayoutGroupBox.Controls.Add(this.StandardRadioButton);
            this.LayoutGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LayoutGroupBox.Location = new System.Drawing.Point(236, 12);
            this.LayoutGroupBox.Name = "LayoutGroupBox";
            this.LayoutGroupBox.Size = new System.Drawing.Size(141, 111);
            this.LayoutGroupBox.TabIndex = 3;
            this.LayoutGroupBox.TabStop = false;
            this.LayoutGroupBox.Text = "Layout";
            // 
            // ScientificRadioButton
            // 
            this.ScientificRadioButton.AutoSize = true;
            this.ScientificRadioButton.Location = new System.Drawing.Point(6, 59);
            this.ScientificRadioButton.Name = "ScientificRadioButton";
            this.ScientificRadioButton.Size = new System.Drawing.Size(102, 28);
            this.ScientificRadioButton.TabIndex = 1;
            this.ScientificRadioButton.Text = "Scientific";
            this.ScientificRadioButton.UseVisualStyleBackColor = true;
            this.ScientificRadioButton.CheckedChanged += new System.EventHandler(this._calculatorLayoutRadioButton_CheckedChanged);
            // 
            // StandardRadioButton
            // 
            this.StandardRadioButton.AutoSize = true;
            this.StandardRadioButton.Checked = true;
            this.StandardRadioButton.Location = new System.Drawing.Point(7, 29);
            this.StandardRadioButton.Name = "StandardRadioButton";
            this.StandardRadioButton.Size = new System.Drawing.Size(103, 28);
            this.StandardRadioButton.TabIndex = 0;
            this.StandardRadioButton.TabStop = true;
            this.StandardRadioButton.Text = "Standard";
            this.StandardRadioButton.UseVisualStyleBackColor = true;
            this.StandardRadioButton.CheckedChanged += new System.EventHandler(this._calculatorLayoutRadioButton_CheckedChanged);
            // 
            // FontButton
            // 
            this.FontButton.Location = new System.Drawing.Point(13, 147);
            this.FontButton.Name = "FontButton";
            this.FontButton.Size = new System.Drawing.Size(114, 42);
            this.FontButton.TabIndex = 4;
            this.FontButton.Text = "Font";
            this.FontButton.UseVisualStyleBackColor = true;
            this.FontButton.Click += new System.EventHandler(this._fontButton_Click);
            // 
            // CalculatorFontDialog
            // 
            this.CalculatorFontDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculatorFontDialog.MaxSize = 24;
            this.CalculatorFontDialog.MinSize = 10;
            // 
            // OptionsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(389, 261);
            this.ControlBox = false;
            this.Controls.Add(this.FontButton);
            this.Controls.Add(this.LayoutGroupBox);
            this.Controls.Add(this.FunctionGroupBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AcceptButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OptionsForm";
            this.FunctionGroupBox.ResumeLayout(false);
            this.FunctionGroupBox.PerformLayout();
            this.LayoutGroupBox.ResumeLayout(false);
            this.LayoutGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.GroupBox FunctionGroupBox;
        private System.Windows.Forms.CheckBox SquareRootCheckBox;
        private System.Windows.Forms.CheckBox ExponentCheckBox;
        private System.Windows.Forms.GroupBox LayoutGroupBox;
        private System.Windows.Forms.RadioButton ScientificRadioButton;
        private System.Windows.Forms.RadioButton StandardRadioButton;
        private System.Windows.Forms.Button FontButton;
        private System.Windows.Forms.FontDialog CalculatorFontDialog;
    }
}