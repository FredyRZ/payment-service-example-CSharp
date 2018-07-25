namespace NexioPaySample
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
            this.Iframe_GetJWT = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ps_runtrans_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ps_catpuretrans_btn = new System.Windows.Forms.Button();
            this.ps_refundtrans_btn = new System.Windows.Forms.Button();
            this.ps_voidtrans_btn = new System.Windows.Forms.Button();
            this.Resultbox = new System.Windows.Forms.RichTextBox();
            this.clear_btn = new System.Windows.Forms.Button();
            this.TransId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Iframe_GetJWT
            // 
            this.Iframe_GetJWT.Location = new System.Drawing.Point(20, 29);
            this.Iframe_GetJWT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Iframe_GetJWT.Name = "Iframe_GetJWT";
            this.Iframe_GetJWT.Size = new System.Drawing.Size(121, 28);
            this.Iframe_GetJWT.TabIndex = 0;
            this.Iframe_GetJWT.Text = "GetJWT";
            this.Iframe_GetJWT.UseVisualStyleBackColor = true;
            this.Iframe_GetJWT.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "RefreshJWT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ps_runtrans_btn
            // 
            this.ps_runtrans_btn.Location = new System.Drawing.Point(5, 34);
            this.ps_runtrans_btn.Name = "ps_runtrans_btn";
            this.ps_runtrans_btn.Size = new System.Drawing.Size(121, 28);
            this.ps_runtrans_btn.TabIndex = 5;
            this.ps_runtrans_btn.Text = "Run Transaction";
            this.ps_runtrans_btn.UseVisualStyleBackColor = true;
            this.ps_runtrans_btn.Click += new System.EventHandler(this.ps_runtrans_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ps_catpuretrans_btn);
            this.groupBox2.Controls.Add(this.ps_refundtrans_btn);
            this.groupBox2.Controls.Add(this.ps_voidtrans_btn);
            this.groupBox2.Controls.Add(this.ps_runtrans_btn);
            this.groupBox2.Location = new System.Drawing.Point(20, 112);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(132, 177);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment Service";
            // 
            // ps_catpuretrans_btn
            // 
            this.ps_catpuretrans_btn.Location = new System.Drawing.Point(5, 136);
            this.ps_catpuretrans_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ps_catpuretrans_btn.Name = "ps_catpuretrans_btn";
            this.ps_catpuretrans_btn.Size = new System.Drawing.Size(121, 29);
            this.ps_catpuretrans_btn.TabIndex = 8;
            this.ps_catpuretrans_btn.Text = "Capture Trans";
            this.ps_catpuretrans_btn.UseVisualStyleBackColor = true;
            this.ps_catpuretrans_btn.Click += new System.EventHandler(this.ps_catpuretrans_btn_Click);
            // 
            // ps_refundtrans_btn
            // 
            this.ps_refundtrans_btn.Location = new System.Drawing.Point(5, 103);
            this.ps_refundtrans_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ps_refundtrans_btn.Name = "ps_refundtrans_btn";
            this.ps_refundtrans_btn.Size = new System.Drawing.Size(121, 29);
            this.ps_refundtrans_btn.TabIndex = 7;
            this.ps_refundtrans_btn.Text = "Refund Transaction";
            this.ps_refundtrans_btn.UseVisualStyleBackColor = true;
            this.ps_refundtrans_btn.Click += new System.EventHandler(this.ps_refundtrans_btn_Click);
            // 
            // ps_voidtrans_btn
            // 
            this.ps_voidtrans_btn.Location = new System.Drawing.Point(5, 70);
            this.ps_voidtrans_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ps_voidtrans_btn.Name = "ps_voidtrans_btn";
            this.ps_voidtrans_btn.Size = new System.Drawing.Size(121, 28);
            this.ps_voidtrans_btn.TabIndex = 6;
            this.ps_voidtrans_btn.Text = "Void Transaction";
            this.ps_voidtrans_btn.UseVisualStyleBackColor = true;
            this.ps_voidtrans_btn.Click += new System.EventHandler(this.ps_voidtrans_btn_Click);
            // 
            // Resultbox
            // 
            this.Resultbox.Location = new System.Drawing.Point(164, 29);
            this.Resultbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Resultbox.Name = "Resultbox";
            this.Resultbox.Size = new System.Drawing.Size(458, 587);
            this.Resultbox.TabIndex = 10;
            this.Resultbox.Text = "";
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(26, 587);
            this.clear_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(121, 28);
            this.clear_btn.TabIndex = 11;
            this.clear_btn.Text = "Clear";
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // TransId
            // 
            this.TransId.Location = new System.Drawing.Point(12, 367);
            this.TransId.Name = "TransId";
            this.TransId.Size = new System.Drawing.Size(139, 21);
            this.TransId.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "Transaction ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 636);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TransId);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.Resultbox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Iframe_GetJWT);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Nexio Pay Sample";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Iframe_GetJWT;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ps_runtrans_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ps_voidtrans_btn;
        private System.Windows.Forms.Button ps_refundtrans_btn;
        private System.Windows.Forms.Button ps_catpuretrans_btn;
        private System.Windows.Forms.RichTextBox Resultbox;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.TextBox TransId;
        private System.Windows.Forms.Label label1;
    }
}

