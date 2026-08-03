namespace ClickMacroApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnSetPos;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblKeys;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnSetPos = new System.Windows.Forms.Button();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.lblInterval = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblKeys = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSetPos
            // 
            this.btnSetPos.Location = new System.Drawing.Point(12, 41);
            this.btnSetPos.Name = "btnSetPos";
            this.btnSetPos.Size = new System.Drawing.Size(150, 23);
            this.btnSetPos.TabIndex = 0;
            this.btnSetPos.Text = "클릭 위치 설정";
            this.btnSetPos.UseVisualStyleBackColor = true;
            this.btnSetPos.Click += new System.EventHandler(this.btnSetPos_Click);
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(12, 70);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(100, 21);
            this.txtInterval.TabIndex = 1;
            this.txtInterval.Text = "1000";
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(118, 73);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(86, 12);
            this.lblInterval.TabIndex = 2;
            this.lblInterval.Text = "클릭 간격 (ms)";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(89, 12);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "상태: 대기 중";
            // 
            // lblKeys
            // 
            this.lblKeys.AutoSize = true;
            this.lblKeys.Location = new System.Drawing.Point(12, 105);
            this.lblKeys.Name = "lblKeys";
            this.lblKeys.Size = new System.Drawing.Size(139, 12);
            this.lblKeys.TabIndex = 4;
            this.lblKeys.Text = "F6: 시작 / F7: 중지 단축키";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 131);
            this.Controls.Add(this.lblKeys);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.btnSetPos);
            this.Name = "Form1";
            this.Text = "Click Macro App";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
