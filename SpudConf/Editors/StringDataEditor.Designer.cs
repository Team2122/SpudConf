namespace Tator.SpudConf
{
    partial class StringDataEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label valueLabel;
            System.Windows.Forms.Label keyLabel;
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.stringDataEditorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.keyTextBox = new System.Windows.Forms.TextBox();
            valueLabel = new System.Windows.Forms.Label();
            keyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stringDataEditorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // valueLabel
            // 
            valueLabel.AutoSize = true;
            valueLabel.Location = new System.Drawing.Point(3, 32);
            valueLabel.Name = "valueLabel";
            valueLabel.Size = new System.Drawing.Size(37, 13);
            valueLabel.TabIndex = 2;
            valueLabel.Text = "Value:";
            // 
            // valueTextBox
            // 
            this.valueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.valueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stringDataEditorBindingSource, "Value", true));
            this.valueTextBox.Location = new System.Drawing.Point(46, 29);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(263, 20);
            this.valueTextBox.TabIndex = 3;
            this.valueTextBox.TextChanged += new System.EventHandler(this.valueTextBox_TextChanged);
            // 
            // stringDataEditorBindingSource
            // 
            this.stringDataEditorBindingSource.DataSource = typeof(Tator.SpudConf.StringDataEditor);
            // 
            // keyLabel
            // 
            keyLabel.AutoSize = true;
            keyLabel.Location = new System.Drawing.Point(12, 6);
            keyLabel.Name = "keyLabel";
            keyLabel.Size = new System.Drawing.Size(28, 13);
            keyLabel.TabIndex = 4;
            keyLabel.Text = "Key:";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.keyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stringDataEditorBindingSource, "Key", true));
            this.keyTextBox.Enabled = false;
            this.keyTextBox.Location = new System.Drawing.Point(46, 3);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(263, 20);
            this.keyTextBox.TabIndex = 5;
            // 
            // StringDataEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(keyLabel);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(valueLabel);
            this.Name = "StringDataEditor";
            this.Size = new System.Drawing.Size(312, 150);
            ((System.ComponentModel.ISupportInitialize)(this.stringDataEditorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource stringDataEditorBindingSource;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.TextBox keyTextBox;

    }
}
