
namespace NguyenHoangLong_5951071052_Weather
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
            this.lbl_textCity = new System.Windows.Forms.Label();
            this.lbl_Country = new System.Windows.Forms.Label();
            this.lbl_DoCe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Day = new System.Windows.Forms.Label();
            this.lbl_Condition = new System.Windows.Forms.Label();
            this.lblDes = new System.Windows.Forms.Label();
            this.lbl_Speed = new System.Windows.Forms.Label();
            this.lbl_Des2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_textCity
            // 
            this.lbl_textCity.AutoSize = true;
            this.lbl_textCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_textCity.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_textCity.Location = new System.Drawing.Point(48, 38);
            this.lbl_textCity.Name = "lbl_textCity";
            this.lbl_textCity.Size = new System.Drawing.Size(251, 54);
            this.lbl_textCity.TabIndex = 0;
            this.lbl_textCity.Text = "Thanh Pho";
            // 
            // lbl_Country
            // 
            this.lbl_Country.AutoSize = true;
            this.lbl_Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Country.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Country.Location = new System.Drawing.Point(48, 139);
            this.lbl_Country.Name = "lbl_Country";
            this.lbl_Country.Size = new System.Drawing.Size(221, 54);
            this.lbl_Country.TabIndex = 1;
            this.lbl_Country.Text = "Quoc Gia";
            // 
            // lbl_DoCe
            // 
            this.lbl_DoCe.AutoSize = true;
            this.lbl_DoCe.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DoCe.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_DoCe.Location = new System.Drawing.Point(48, 242);
            this.lbl_DoCe.Name = "lbl_DoCe";
            this.lbl_DoCe.Size = new System.Drawing.Size(57, 54);
            this.lbl_DoCe.TabIndex = 2;
            this.lbl_DoCe.Text = "C";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(457, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "Forecast";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Day
            // 
            this.lbl_Day.AutoSize = true;
            this.lbl_Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Day.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Day.Location = new System.Drawing.Point(460, 114);
            this.lbl_Day.Name = "lbl_Day";
            this.lbl_Day.Size = new System.Drawing.Size(77, 31);
            this.lbl_Day.TabIndex = 4;
            this.lbl_Day.Text = "Days";
            // 
            // lbl_Condition
            // 
            this.lbl_Condition.AutoSize = true;
            this.lbl_Condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Condition.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Condition.Location = new System.Drawing.Point(460, 157);
            this.lbl_Condition.Name = "lbl_Condition";
            this.lbl_Condition.Size = new System.Drawing.Size(143, 31);
            this.lbl_Condition.TabIndex = 5;
            this.lbl_Condition.Text = "Conditions";
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDes.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblDes.Location = new System.Drawing.Point(460, 197);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(151, 31);
            this.lblDes.TabIndex = 6;
            this.lblDes.Text = "Description";
            // 
            // lbl_Speed
            // 
            this.lbl_Speed.AutoSize = true;
            this.lbl_Speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Speed.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Speed.Location = new System.Drawing.Point(676, 114);
            this.lbl_Speed.Name = "lbl_Speed";
            this.lbl_Speed.Size = new System.Drawing.Size(110, 31);
            this.lbl_Speed.TabIndex = 7;
            this.lbl_Speed.Text = "12 km/h";
            // 
            // lbl_Des2
            // 
            this.lbl_Des2.AutoSize = true;
            this.lbl_Des2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Des2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Des2.Location = new System.Drawing.Point(676, 197);
            this.lbl_Des2.Name = "lbl_Des2";
            this.lbl_Des2.Size = new System.Drawing.Size(44, 31);
            this.lbl_Des2.TabIndex = 8;
            this.lbl_Des2.Text = "14";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Des2);
            this.Controls.Add(this.lbl_Speed);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.lbl_Condition);
            this.Controls.Add(this.lbl_Day);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_DoCe);
            this.Controls.Add(this.lbl_Country);
            this.Controls.Add(this.lbl_textCity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_textCity;
        private System.Windows.Forms.Label lbl_Country;
        private System.Windows.Forms.Label lbl_DoCe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Day;
        private System.Windows.Forms.Label lbl_Condition;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Label lbl_Speed;
        private System.Windows.Forms.Label lbl_Des2;
    }
}

