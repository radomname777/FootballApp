namespace FootballApp.UserControls
{
    partial class ControlPlayer
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
            this.imagebutton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lbl_name = new System.Windows.Forms.Label();
            this.Number_txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imagebutton
            // 
            this.imagebutton.CheckedState.Image = global::FootballApp.Resources.sekil_pmg;
            this.imagebutton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imagebutton.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.imagebutton.Image = global::FootballApp.Resources.depositphotos_57111133_stock_illustration_pixel_art_style_illustration_shows;
            this.imagebutton.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.imagebutton.ImageOffset = new System.Drawing.Point(0, 0);
            this.imagebutton.ImageRotate = 0F;
            this.imagebutton.ImageSize = new System.Drawing.Size(55, 90);
            this.imagebutton.Location = new System.Drawing.Point(18, 0);
            this.imagebutton.Name = "imagebutton";
            this.imagebutton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imagebutton.Size = new System.Drawing.Size(52, 95);
            this.imagebutton.TabIndex = 0;
            this.imagebutton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.guna2ImageButton1_MouseMove);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_name.ForeColor = System.Drawing.Color.Red;
            this.lbl_name.Location = new System.Drawing.Point(-3, 98);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(100, 13);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name or surname";
            // 
            // Number_txt
            // 
            this.Number_txt.AutoSize = true;
            this.Number_txt.BackColor = System.Drawing.Color.White;
            this.Number_txt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Number_txt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Number_txt.Location = new System.Drawing.Point(35, 42);
            this.Number_txt.Name = "Number_txt";
            this.Number_txt.Size = new System.Drawing.Size(13, 13);
            this.Number_txt.TabIndex = 2;
            this.Number_txt.Text = "0";
            this.Number_txt.Click += new System.EventHandler(this.Number_txt_Click);
            // 
            // ControlPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Number_txt);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.imagebutton);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ControlPlayer";
            this.Size = new System.Drawing.Size(90, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton imagebutton;
        private Label lbl_name;
        private Label Number_txt;
    }
}
