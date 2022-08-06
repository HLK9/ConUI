
namespace ConUI
{
    partial class ConUI
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
            this.btnRunCus = new MaterialSkin.Controls.MaterialButton();
            this.richOutput = new System.Windows.Forms.RichTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCmdCus = new MaterialSkin.Controls.MaterialTextBox();
            this.btnCmdList = new MaterialSkin.Controls.MaterialButton();
            this.btnExit = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // btnRunCus
            // 
            this.btnRunCus.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRunCus.Depth = 0;
            this.btnRunCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunCus.HighEmphasis = true;
            this.btnRunCus.Icon = null;
            this.btnRunCus.Location = new System.Drawing.Point(7, 83);
            this.btnRunCus.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRunCus.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRunCus.Name = "btnRunCus";
            this.btnRunCus.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRunCus.Size = new System.Drawing.Size(193, 50);
            this.btnRunCus.TabIndex = 0;
            this.btnRunCus.Text = "Run custom command";
            this.btnRunCus.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRunCus.UseAccentColor = false;
            this.btnRunCus.UseVisualStyleBackColor = true;
            this.btnRunCus.Click += new System.EventHandler(this.btnRunCus_Click);
            // 
            // richOutput
            // 
            this.richOutput.Location = new System.Drawing.Point(7, 142);
            this.richOutput.Name = "richOutput";
            this.richOutput.Size = new System.Drawing.Size(1050, 501);
            this.richOutput.TabIndex = 1;
            this.richOutput.Text = "";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(500, 33);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(76, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Console UI";
            // 
            // txtCmdCus
            // 
            this.txtCmdCus.AnimateReadOnly = false;
            this.txtCmdCus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCmdCus.Depth = 0;
            this.txtCmdCus.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCmdCus.LeadingIcon = null;
            this.txtCmdCus.Location = new System.Drawing.Point(207, 83);
            this.txtCmdCus.MaxLength = 50;
            this.txtCmdCus.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCmdCus.Multiline = false;
            this.txtCmdCus.Name = "txtCmdCus";
            this.txtCmdCus.Size = new System.Drawing.Size(509, 50);
            this.txtCmdCus.TabIndex = 3;
            this.txtCmdCus.Text = "";
            this.txtCmdCus.TrailingIcon = null;
            // 
            // btnCmdList
            // 
            this.btnCmdList.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCmdList.Depth = 0;
            this.btnCmdList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCmdList.HighEmphasis = true;
            this.btnCmdList.Icon = null;
            this.btnCmdList.Location = new System.Drawing.Point(723, 83);
            this.btnCmdList.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCmdList.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCmdList.Name = "btnCmdList";
            this.btnCmdList.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCmdList.Size = new System.Drawing.Size(188, 50);
            this.btnCmdList.TabIndex = 4;
            this.btnCmdList.Text = "Command List";
            this.btnCmdList.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCmdList.UseAccentColor = false;
            this.btnCmdList.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExit.Depth = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.HighEmphasis = true;
            this.btnExit.Icon = null;
            this.btnExit.Location = new System.Drawing.Point(919, 83);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExit.Size = new System.Drawing.Size(137, 50);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExit.UseAccentColor = false;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // ConUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 649);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCmdList);
            this.Controls.Add(this.txtCmdCus);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.richOutput);
            this.Controls.Add(this.btnRunCus);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "ConUI";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnRunCus;
        private System.Windows.Forms.RichTextBox richOutput;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtCmdCus;
        private MaterialSkin.Controls.MaterialButton btnCmdList;
        private MaterialSkin.Controls.MaterialButton btnExit;
    }
}

