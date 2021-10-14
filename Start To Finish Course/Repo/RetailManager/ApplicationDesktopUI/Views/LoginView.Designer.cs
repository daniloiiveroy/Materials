
namespace ApplicationDesktopUI.Views
{
    partial class LoginView
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.password = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.password, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.passwordLabel, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.loginLabel, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.usernameLabel, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.userName, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.loginButton, 1, 3);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // password
            // 
            this.password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(342, 204);
            this.password.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(297, 44);
            this.password.TabIndex = 4;
            this.password.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(160, 204);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.passwordLabel.Size = new System.Drawing.Size(176, 47);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password: ";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.loginLabel, 2);
            this.loginLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(160, 20);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(479, 97);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Login Form";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(160, 137);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.usernameLabel.Size = new System.Drawing.Size(182, 47);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username: ";
            // 
            // userName
            // 
            this.userName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(342, 137);
            this.userName.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(297, 44);
            this.userName.TabIndex = 3;
            // 
            // loginButton
            // 
            this.tableLayoutPanel.SetColumnSpan(this.loginButton, 2);
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(160, 271);
            this.loginButton.Margin = new System.Windows.Forms.Padding(0, 20, 0, 5);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(479, 67);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "LoginView";
            this.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        public System.Windows.Forms.Label loginLabel;
        public System.Windows.Forms.Label usernameLabel;
        public System.Windows.Forms.Label passwordLabel;
        public System.Windows.Forms.TextBox userName;
        public System.Windows.Forms.TextBox password;
        public System.Windows.Forms.Button loginButton;
    }
}
