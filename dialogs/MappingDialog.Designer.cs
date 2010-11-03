namespace iMon.XBMC.Dialogs
{
    partial class MappingDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MappingDialog));
            this.lbKeys = new System.Windows.Forms.ListBox();
            this.lKeys = new System.Windows.Forms.Label();
            this.lValues = new System.Windows.Forms.Label();
            this.lbValues = new System.Windows.Forms.ListBox();
            this.tbNewValue = new System.Windows.Forms.TextBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.bRemove = new System.Windows.Forms.Button();
            this.bOk = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbKeys
            // 
            this.lbKeys.FormattingEnabled = true;
            this.lbKeys.Location = new System.Drawing.Point(15, 29);
            this.lbKeys.Name = "lbKeys";
            this.lbKeys.Size = new System.Drawing.Size(120, 199);
            this.lbKeys.TabIndex = 0;
            this.lbKeys.SelectedIndexChanged += new System.EventHandler(this.lbKeys_SelectedIndexChanged);
            // 
            // lKeys
            // 
            this.lKeys.AutoSize = true;
            this.lKeys.Location = new System.Drawing.Point(12, 13);
            this.lKeys.Name = "lKeys";
            this.lKeys.Size = new System.Drawing.Size(33, 13);
            this.lKeys.TabIndex = 1;
            this.lKeys.Text = "Keys:";
            // 
            // lValues
            // 
            this.lValues.AutoSize = true;
            this.lValues.Location = new System.Drawing.Point(153, 13);
            this.lValues.Name = "lValues";
            this.lValues.Size = new System.Drawing.Size(42, 13);
            this.lValues.TabIndex = 3;
            this.lValues.Text = "Values:";
            // 
            // lbValues
            // 
            this.lbValues.FormattingEnabled = true;
            this.lbValues.Location = new System.Drawing.Point(156, 29);
            this.lbValues.Name = "lbValues";
            this.lbValues.Size = new System.Drawing.Size(120, 147);
            this.lbValues.TabIndex = 2;
            this.lbValues.SelectedIndexChanged += new System.EventHandler(this.lbValues_SelectedIndexChanged);
            // 
            // tbNewValue
            // 
            this.tbNewValue.Location = new System.Drawing.Point(156, 183);
            this.tbNewValue.Name = "tbNewValue";
            this.tbNewValue.Size = new System.Drawing.Size(120, 20);
            this.tbNewValue.TabIndex = 5;
            this.tbNewValue.TextChanged += new System.EventHandler(this.tbNewValue_TextChanged);
            // 
            // bAdd
            // 
            this.bAdd.Enabled = false;
            this.bAdd.Location = new System.Drawing.Point(231, 209);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(45, 23);
            this.bAdd.TabIndex = 6;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bRemove
            // 
            this.bRemove.Enabled = false;
            this.bRemove.Location = new System.Drawing.Point(156, 209);
            this.bRemove.Name = "bRemove";
            this.bRemove.Size = new System.Drawing.Size(69, 23);
            this.bRemove.TabIndex = 7;
            this.bRemove.Text = "Remove";
            this.bRemove.UseVisualStyleBackColor = true;
            this.bRemove.Click += new System.EventHandler(this.bRemove_Click);
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(200, 253);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(75, 23);
            this.bOk.TabIndex = 8;
            this.bOk.Text = "OK";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(119, 253);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 9;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // MappingDialog
            // 
            this.AcceptButton = this.bOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(286, 289);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.bRemove);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.tbNewValue);
            this.Controls.Add(this.lValues);
            this.Controls.Add(this.lbValues);
            this.Controls.Add(this.lKeys);
            this.Controls.Add(this.lbKeys);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MappingDialog";
            this.ShowInTaskbar = false;
            this.Text = "Mapping Dialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbKeys;
        private System.Windows.Forms.Label lKeys;
        private System.Windows.Forms.Label lValues;
        private System.Windows.Forms.ListBox lbValues;
        private System.Windows.Forms.TextBox tbNewValue;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bRemove;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Button bCancel;
    }
}