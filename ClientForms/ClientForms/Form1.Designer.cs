namespace ClientForms
{
    partial class Form1
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
            this.msg = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // msg
            // 
            this.msg.Location = new System.Drawing.Point(133, 53);
            this.msg.Multiline = true;
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(210, 140);
            this.msg.TabIndex = 0;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(204, 199);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 1;
            this.btn_send.Text = "SEND";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 374);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.msg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox msg;
        private System.Windows.Forms.Button btn_send;
    }
}

