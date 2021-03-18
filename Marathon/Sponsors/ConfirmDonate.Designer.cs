namespace Marathon.Sponsors
{
    partial class ConfirmDonate
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
            this.buttonBMR = new System.Windows.Forms.Button();
            this.labelCountDonate = new System.Windows.Forms.Label();
            this.labelFund = new System.Windows.Forms.Label();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metrolabelNameRunner = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // buttonBMR
            // 
            this.buttonBMR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonBMR.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonBMR.FlatAppearance.BorderSize = 2;
            this.buttonBMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBMR.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBMR.Location = new System.Drawing.Point(293, 343);
            this.buttonBMR.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBMR.Name = "buttonBMR";
            this.buttonBMR.Size = new System.Drawing.Size(226, 56);
            this.buttonBMR.TabIndex = 13;
            this.buttonBMR.Text = "Назад";
            this.buttonBMR.UseVisualStyleBackColor = false;
            // 
            // labelCountDonate
            // 
            this.labelCountDonate.Font = new System.Drawing.Font("Gadugi", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountDonate.ForeColor = System.Drawing.Color.Silver;
            this.labelCountDonate.Location = new System.Drawing.Point(131, 246);
            this.labelCountDonate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCountDonate.Name = "labelCountDonate";
            this.labelCountDonate.Size = new System.Drawing.Size(542, 95);
            this.labelCountDonate.TabIndex = 12;
            this.labelCountDonate.Text = "$0.00";
            this.labelCountDonate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFund
            // 
            this.labelFund.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFund.Location = new System.Drawing.Point(131, 209);
            this.labelFund.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFund.Name = "labelFund";
            this.labelFund.Size = new System.Drawing.Size(542, 37);
            this.labelFund.TabIndex = 11;
            this.labelFund.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(103, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(604, 112);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Спасибо за вашу поддержку бегуна в Marathon Skills 2021\r\nВаше пожертвование пойде" +
    "т в его благотворительную организацию\r\n";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metrolabelNameRunner
            // 
            this.metrolabelNameRunner.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metrolabelNameRunner.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metrolabelNameRunner.ForeColor = System.Drawing.Color.Silver;
            this.metrolabelNameRunner.Location = new System.Drawing.Point(174, 172);
            this.metrolabelNameRunner.Name = "metrolabelNameRunner";
            this.metrolabelNameRunner.Size = new System.Drawing.Size(478, 27);
            this.metrolabelNameRunner.Style = MetroFramework.MetroColorStyle.Silver;
            this.metrolabelNameRunner.TabIndex = 14;
            this.metrolabelNameRunner.Text = "Иван Прудов(204) из Russia\r\n";
            this.metrolabelNameRunner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metrolabelNameRunner.UseStyleColors = true;
            // 
            // ConfirmDonate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metrolabelNameRunner);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.buttonBMR);
            this.Controls.Add(this.labelCountDonate);
            this.Controls.Add(this.labelFund);
            this.Name = "ConfirmDonate";
            this.Text = "                       Спасибо за вашу спонсорскую поддержку";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBMR;
        private System.Windows.Forms.Label labelCountDonate;
        private System.Windows.Forms.Label labelFund;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metrolabelNameRunner;
    }
}