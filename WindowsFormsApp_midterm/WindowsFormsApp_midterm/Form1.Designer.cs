
namespace WindowsFormsApp_midterm
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_client = new System.Windows.Forms.Label();
            this.BTN_MENU = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BTN_ORIGINAL = new System.Windows.Forms.Button();
            this.BTN_CLASSIC = new System.Windows.Forms.Button();
            this.BTN_ORDERLIST = new System.Windows.Forms.Button();
            this.BTN_FUNCTION = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BTN_login = new System.Windows.Forms.Button();
            this.BTN_LAST_ORDER = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(150, 411);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(650, 39);
            this.panel5.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Reem Kufi", 8.999999F);
            this.label2.Location = new System.Drawing.Point(0, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(650, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "ADDRESS : XXXXX     TEL : 0000000000";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Location = new System.Drawing.Point(150, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(650, 412);
            this.panel6.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp_midterm.Properties.Resources.LOGO_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(184, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 305);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbl_client);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 100);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO FERNAN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_client
            // 
            this.lbl_client.AutoSize = true;
            this.lbl_client.Location = new System.Drawing.Point(12, 9);
            this.lbl_client.Name = "lbl_client";
            this.lbl_client.Size = new System.Drawing.Size(53, 12);
            this.lbl_client.TabIndex = 1;
            this.lbl_client.Text = "dear client";
            // 
            // BTN_MENU
            // 
            this.BTN_MENU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_MENU.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_MENU.Location = new System.Drawing.Point(0, 100);
            this.BTN_MENU.Name = "BTN_MENU";
            this.BTN_MENU.Size = new System.Drawing.Size(150, 45);
            this.BTN_MENU.TabIndex = 0;
            this.BTN_MENU.Text = "MENU";
            this.BTN_MENU.UseVisualStyleBackColor = false;
            this.BTN_MENU.Click += new System.EventHandler(this.BTN_MENU_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BTN_ORDERLIST);
            this.panel3.Controls.Add(this.BTN_CLASSIC);
            this.panel3.Controls.Add(this.BTN_ORIGINAL);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 145);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 118);
            this.panel3.TabIndex = 1;
            // 
            // BTN_ORIGINAL
            // 
            this.BTN_ORIGINAL.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_ORIGINAL.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BTN_ORIGINAL.FlatAppearance.BorderSize = 5;
            this.BTN_ORIGINAL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_ORIGINAL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BTN_ORIGINAL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ORIGINAL.Location = new System.Drawing.Point(0, 0);
            this.BTN_ORIGINAL.Name = "BTN_ORIGINAL";
            this.BTN_ORIGINAL.Size = new System.Drawing.Size(150, 39);
            this.BTN_ORIGINAL.TabIndex = 0;
            this.BTN_ORIGINAL.Text = "FREE ORDER";
            this.BTN_ORIGINAL.UseVisualStyleBackColor = true;
            this.BTN_ORIGINAL.Click += new System.EventHandler(this.BTN_ORIGINAL_Click);
            // 
            // BTN_CLASSIC
            // 
            this.BTN_CLASSIC.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_CLASSIC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BTN_CLASSIC.FlatAppearance.BorderSize = 5;
            this.BTN_CLASSIC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_CLASSIC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BTN_CLASSIC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CLASSIC.Location = new System.Drawing.Point(0, 39);
            this.BTN_CLASSIC.Name = "BTN_CLASSIC";
            this.BTN_CLASSIC.Size = new System.Drawing.Size(150, 39);
            this.BTN_CLASSIC.TabIndex = 1;
            this.BTN_CLASSIC.Text = "SET ORDER";
            this.BTN_CLASSIC.UseVisualStyleBackColor = true;
            this.BTN_CLASSIC.Click += new System.EventHandler(this.BTN_CLASSIC_Click);
            // 
            // BTN_ORDERLIST
            // 
            this.BTN_ORDERLIST.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_ORDERLIST.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BTN_ORDERLIST.FlatAppearance.BorderSize = 5;
            this.BTN_ORDERLIST.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_ORDERLIST.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BTN_ORDERLIST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ORDERLIST.Location = new System.Drawing.Point(0, 78);
            this.BTN_ORDERLIST.Name = "BTN_ORDERLIST";
            this.BTN_ORDERLIST.Size = new System.Drawing.Size(150, 39);
            this.BTN_ORDERLIST.TabIndex = 2;
            this.BTN_ORDERLIST.Text = "ORDER LIST";
            this.BTN_ORDERLIST.UseVisualStyleBackColor = true;
            this.BTN_ORDERLIST.Click += new System.EventHandler(this.BTN_RECORD_Click);
            // 
            // BTN_FUNCTION
            // 
            this.BTN_FUNCTION.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_FUNCTION.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_FUNCTION.Location = new System.Drawing.Point(0, 263);
            this.BTN_FUNCTION.Name = "BTN_FUNCTION";
            this.BTN_FUNCTION.Size = new System.Drawing.Size(150, 45);
            this.BTN_FUNCTION.TabIndex = 2;
            this.BTN_FUNCTION.Text = "FUNCTION";
            this.BTN_FUNCTION.UseVisualStyleBackColor = false;
            this.BTN_FUNCTION.Click += new System.EventHandler(this.BTN_FUNCTION_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_register);
            this.panel4.Controls.Add(this.BTN_LAST_ORDER);
            this.panel4.Controls.Add(this.BTN_login);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 308);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 118);
            this.panel4.TabIndex = 3;
            // 
            // BTN_login
            // 
            this.BTN_login.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BTN_login.FlatAppearance.BorderSize = 5;
            this.BTN_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BTN_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_login.Location = new System.Drawing.Point(0, 0);
            this.BTN_login.Name = "BTN_login";
            this.BTN_login.Size = new System.Drawing.Size(150, 39);
            this.BTN_login.TabIndex = 0;
            this.BTN_login.Text = "LOG IN";
            this.BTN_login.UseVisualStyleBackColor = true;
            this.BTN_login.Click += new System.EventHandler(this.BTN_SELLER_Click);
            // 
            // BTN_LAST_ORDER
            // 
            this.BTN_LAST_ORDER.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_LAST_ORDER.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BTN_LAST_ORDER.FlatAppearance.BorderSize = 5;
            this.BTN_LAST_ORDER.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_LAST_ORDER.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BTN_LAST_ORDER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_LAST_ORDER.Location = new System.Drawing.Point(0, 39);
            this.BTN_LAST_ORDER.Name = "BTN_LAST_ORDER";
            this.BTN_LAST_ORDER.Size = new System.Drawing.Size(150, 39);
            this.BTN_LAST_ORDER.TabIndex = 1;
            this.BTN_LAST_ORDER.Text = "LAST ORDER";
            this.BTN_LAST_ORDER.UseVisualStyleBackColor = true;
            this.BTN_LAST_ORDER.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_register
            // 
            this.btn_register.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_register.FlatAppearance.BorderSize = 5;
            this.btn_register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Location = new System.Drawing.Point(0, 78);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(150, 39);
            this.btn_register.TabIndex = 1;
            this.btn_register.Text = "REGISTER";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.BTN_FUNCTION);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.BTN_MENU);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 450);
            this.panel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_client;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_MENU;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BTN_ORDERLIST;
        private System.Windows.Forms.Button BTN_CLASSIC;
        private System.Windows.Forms.Button BTN_ORIGINAL;
        private System.Windows.Forms.Button BTN_FUNCTION;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button BTN_LAST_ORDER;
        private System.Windows.Forms.Button BTN_login;
        private System.Windows.Forms.Panel panel1;
    }
}

