namespace RemotingClient
{
    partial class frmLogin
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
            this.btnJoin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServerAdd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(15, 35);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(395, 23);
            this.btnJoin.TabIndex = 12;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Server Address";
            // 
            // txtServerAdd
            // 
            this.txtServerAdd.Location = new System.Drawing.Point(112, 6);
            this.txtServerAdd.Name = "txtServerAdd";
            this.txtServerAdd.Size = new System.Drawing.Size(298, 20);
            this.txtServerAdd.TabIndex = 13;
            this.txtServerAdd.Text = "tcp://localhost:8080/ChatRoom";
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnJoin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 65);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServerAdd);
            this.Controls.Add(this.btnJoin);
            this.Name = "frmLogin";
            this.Text = "Join to Global Chat Room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServerAdd;
    }
}