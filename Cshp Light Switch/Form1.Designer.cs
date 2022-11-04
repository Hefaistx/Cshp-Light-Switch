namespace Cshp_Light_Switch
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.siticoneToggleSwitch1 = new Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // siticoneToggleSwitch1
            // 
            this.siticoneToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.siticoneToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.siticoneToggleSwitch1.Location = new System.Drawing.Point(334, 211);
            this.siticoneToggleSwitch1.Name = "siticoneToggleSwitch1";
            this.siticoneToggleSwitch1.Size = new System.Drawing.Size(98, 50);
            this.siticoneToggleSwitch1.TabIndex = 0;
            this.siticoneToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.siticoneToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.siticoneToggleSwitch1.CheckedChanged += new System.EventHandler(this.siticoneToggleSwitch1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siticoneToggleSwitch1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch siticoneToggleSwitch1;
        private Label label1;
    }
}