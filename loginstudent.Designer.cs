
namespace Math_School
{
    partial class loginstudent
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginstudent));
            this.code = new System.Windows.Forms.TextBox();
            this.signup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.qrcodescannerpanel = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.scanning = new System.Windows.Forms.PictureBox();
            this.decoded = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cameras = new System.Windows.Forms.ComboBox();
            this.scannerpicturebox = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.qrcodescannerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scanning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scannerpicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // code
            // 
            this.code.BackColor = System.Drawing.Color.White;
            this.code.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.code.Font = new System.Drawing.Font("KG Broken Vessels Sketch", 20F);
            this.code.ForeColor = System.Drawing.Color.Gray;
            this.code.Location = new System.Drawing.Point(291, 245);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(374, 33);
            this.code.TabIndex = 24;
            this.code.Text = "TYPE THE ROOM CODE HERE";
            this.code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.code.TextChanged += new System.EventHandler(this.code_TextChanged);
            this.code.Enter += new System.EventHandler(this.code_Enter);
            this.code.Leave += new System.EventHandler(this.code_Leave);
            // 
            // signup
            // 
            this.signup.BackColor = System.Drawing.Color.DarkCyan;
            this.signup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.signup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup.Font = new System.Drawing.Font("KG Broken Vessels Sketch", 15.25F);
            this.signup.ForeColor = System.Drawing.Color.White;
            this.signup.Location = new System.Drawing.Point(424, 300);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(120, 41);
            this.signup.TabIndex = 33;
            this.signup.Text = "ENTER";
            this.signup.UseVisualStyleBackColor = false;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("KG Broken Vessels Sketch", 12F);
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(363, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 21);
            this.label2.TabIndex = 38;
            this.label2.Text = "\"WELCOME BACK STUDENTS!\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("KG Broken Vessels Sketch", 35F);
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(299, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 58);
            this.label1.TabIndex = 44;
            this.label1.Text = "ENTER A ROOM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("KG Broken Vessels Sketch", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(399, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 21);
            this.label3.TabIndex = 46;
            this.label3.Text = "SCAN QR CODE HERE!";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("KG Broken Vessels Sketch", 12F);
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(343, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(282, 21);
            this.label6.TabIndex = 48;
            this.label6.Text = "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("KG Broken Vessels Sketch", 20F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(336, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(301, 34);
            this.label8.TabIndex = 38;
            this.label8.Text = "I N V A L I D   C O D E";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("KG Broken Vessels Sketch", 10F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label9.Location = new System.Drawing.Point(370, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(227, 18);
            this.label9.TabIndex = 50;
            this.label9.Text = "P L E A S E  I N P U T  A  C O D E";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // qrcodescannerpanel
            // 
            this.qrcodescannerpanel.BackColor = System.Drawing.Color.Transparent;
            this.qrcodescannerpanel.Controls.Add(this.button5);
            this.qrcodescannerpanel.Controls.Add(this.scanning);
            this.qrcodescannerpanel.Controls.Add(this.decoded);
            this.qrcodescannerpanel.Controls.Add(this.button4);
            this.qrcodescannerpanel.Controls.Add(this.button3);
            this.qrcodescannerpanel.Controls.Add(this.label5);
            this.qrcodescannerpanel.Controls.Add(this.cameras);
            this.qrcodescannerpanel.Controls.Add(this.scannerpicturebox);
            this.qrcodescannerpanel.Location = new System.Drawing.Point(251, 44);
            this.qrcodescannerpanel.Name = "qrcodescannerpanel";
            this.qrcodescannerpanel.Size = new System.Drawing.Size(462, 445);
            this.qrcodescannerpanel.TabIndex = 47;
            this.qrcodescannerpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.qrcodescannerpanel_Paint);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DodgerBlue;
            this.button5.Enabled = false;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("KG Broken Vessels Sketch", 15.25F);
            this.button5.ForeColor = System.Drawing.Color.MintCream;
            this.button5.Location = new System.Drawing.Point(163, 392);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 43);
            this.button5.TabIndex = 53;
            this.button5.Text = "ENTER";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // scanning
            // 
            this.scanning.Image = global::Math_School.Properties.Resources.SimplisticThirstyAntelopegroundsquirrel_max_1mb;
            this.scanning.Location = new System.Drawing.Point(82, 108);
            this.scanning.Name = "scanning";
            this.scanning.Size = new System.Drawing.Size(296, 216);
            this.scanning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.scanning.TabIndex = 51;
            this.scanning.TabStop = false;
            // 
            // decoded
            // 
            this.decoded.AutoSize = true;
            this.decoded.Font = new System.Drawing.Font("KG Broken Vessels Sketch", 35F);
            this.decoded.ForeColor = System.Drawing.Color.White;
            this.decoded.Location = new System.Drawing.Point(160, 329);
            this.decoded.Name = "decoded";
            this.decoded.Size = new System.Drawing.Size(141, 58);
            this.decoded.TabIndex = 52;
            this.decoded.Text = "0000";
            this.decoded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Firebrick;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("KG Broken Vessels Sketch", 15.25F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(297, 392);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 43);
            this.button4.TabIndex = 50;
            this.button4.Text = "GO BACK";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSalmon;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("KG Broken Vessels Sketch", 15.25F);
            this.button3.ForeColor = System.Drawing.Color.MintCream;
            this.button3.Location = new System.Drawing.Point(27, 392);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 43);
            this.button3.TabIndex = 49;
            this.button3.Text = "SCAN QR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("KG Broken Vessels Sketch", 19F);
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(123, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 33);
            this.label5.TabIndex = 48;
            this.label5.Text = "ENTER A ROOM";
            // 
            // cameras
            // 
            this.cameras.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cameras.Font = new System.Drawing.Font("KG Broken Vessels Sketch", 9.75F);
            this.cameras.FormattingEnabled = true;
            this.cameras.Location = new System.Drawing.Point(122, 74);
            this.cameras.Name = "cameras";
            this.cameras.Size = new System.Drawing.Size(217, 25);
            this.cameras.TabIndex = 1;
            // 
            // scannerpicturebox
            // 
            this.scannerpicturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scannerpicturebox.Location = new System.Drawing.Point(82, 108);
            this.scannerpicturebox.Name = "scannerpicturebox";
            this.scannerpicturebox.Size = new System.Drawing.Size(296, 216);
            this.scannerpicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.scannerpicturebox.TabIndex = 0;
            this.scannerpicturebox.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Math_School.Properties.Resources.qr_code;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Eraser", 20F);
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(445, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 70);
            this.button2.TabIndex = 45;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.BackgroundImage = global::Math_School.Properties.Resources.arrow;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Location = new System.Drawing.Point(12, 11);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(34, 30);
            this.exit.TabIndex = 37;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 1);
            this.panel1.TabIndex = 51;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 526);
            this.panel2.TabIndex = 51;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(2, 526);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(959, 1);
            this.panel3.TabIndex = 51;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(959, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 525);
            this.panel4.TabIndex = 51;
            // 
            // loginstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.BackgroundImage = global::Math_School.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(961, 527);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.qrcodescannerpanel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.code);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(425, 438);
            this.Name = "loginstudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginstudent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.loginstudent_FormClosing);
            this.Load += new System.EventHandler(this.loginstudent_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginstudent_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginstudent_MouseMove);
            this.qrcodescannerpanel.ResumeLayout(false);
            this.qrcodescannerpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scanning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scannerpicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel qrcodescannerpanel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox scanning;
        public System.Windows.Forms.Label decoded;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cameras;
        private System.Windows.Forms.PictureBox scannerpicturebox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}