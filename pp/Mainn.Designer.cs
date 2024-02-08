namespace pp
{
    partial class Mainn
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
            label1 = new Label();
            profil = new Button();
            apply1 = new Button();
            apply2 = new Button();
            logout = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.None;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(45, 46);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(209, 38);
            label1.TabIndex = 0;
            // 
            // profil
            // 
            profil.Location = new Point(36, 114);
            profil.Name = "profil";
            profil.Size = new Size(218, 34);
            profil.TabIndex = 1;
            profil.Text = "Profil";
            profil.UseVisualStyleBackColor = true;
            profil.Click += profil_Click;
            // 
            // apply1
            // 
            apply1.Location = new Point(36, 173);
            apply1.Name = "apply1";
            apply1.Size = new Size(218, 39);
            apply1.TabIndex = 2;
            apply1.Text = "Apply for Job Mutation";
            apply1.UseVisualStyleBackColor = true;
            apply1.Click += apply1_Click;
            // 
            // apply2
            // 
            apply2.Location = new Point(36, 230);
            apply2.Name = "apply2";
            apply2.Size = new Size(218, 38);
            apply2.TabIndex = 3;
            apply2.Text = "Apply for Job Promotion";
            apply2.UseVisualStyleBackColor = true;
            apply2.Click += apply2_Click;
            // 
            // logout
            // 
            logout.Location = new Point(92, 400);
            logout.Name = "logout";
            logout.Size = new Size(88, 38);
            logout.TabIndex = 4;
            logout.Text = "LogOut";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // Mainn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(302, 450);
            Controls.Add(logout);
            Controls.Add(apply2);
            Controls.Add(apply1);
            Controls.Add(profil);
            Controls.Add(label1);
            Name = "Mainn";
            Text = "Main";
            Load += Main_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button profil;
        private Button apply1;
        private Button apply2;
        private Button logout;
    }
}