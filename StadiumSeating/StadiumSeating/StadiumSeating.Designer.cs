namespace StadiumSeating
{
    partial class StadiumSeating
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
            this.grpTicketsSold = new System.Windows.Forms.GroupBox();
            this.txtClassCSeats = new System.Windows.Forms.TextBox();
            this.lblClassCSeats = new System.Windows.Forms.Label();
            this.txtClassBSeats = new System.Windows.Forms.TextBox();
            this.lblClassBSeats = new System.Windows.Forms.Label();
            this.txtClassASeats = new System.Windows.Forms.TextBox();
            this.lblClassASeats = new System.Windows.Forms.Label();
            this.lblIntro = new System.Windows.Forms.Label();
            this.grpRevenue = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblClassCRev = new System.Windows.Forms.Label();
            this.lblClassBRev = new System.Windows.Forms.Label();
            this.lblClassARev = new System.Windows.Forms.Label();
            this.btnCalcRev = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.revA = new System.Windows.Forms.Label();
            this.revB = new System.Windows.Forms.Label();
            this.revC = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.grpTicketsSold.SuspendLayout();
            this.grpRevenue.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTicketsSold
            // 
            this.grpTicketsSold.Controls.Add(this.txtClassCSeats);
            this.grpTicketsSold.Controls.Add(this.lblClassCSeats);
            this.grpTicketsSold.Controls.Add(this.txtClassBSeats);
            this.grpTicketsSold.Controls.Add(this.lblClassBSeats);
            this.grpTicketsSold.Controls.Add(this.txtClassASeats);
            this.grpTicketsSold.Controls.Add(this.lblClassASeats);
            this.grpTicketsSold.Controls.Add(this.lblIntro);
            this.grpTicketsSold.Location = new System.Drawing.Point(12, 12);
            this.grpTicketsSold.Name = "grpTicketsSold";
            this.grpTicketsSold.Size = new System.Drawing.Size(243, 269);
            this.grpTicketsSold.TabIndex = 0;
            this.grpTicketsSold.TabStop = false;
            this.grpTicketsSold.Text = "Tickets Sold ";
            // 
            // txtClassCSeats
            // 
            this.txtClassCSeats.Location = new System.Drawing.Point(104, 182);
            this.txtClassCSeats.Name = "txtClassCSeats";
            this.txtClassCSeats.Size = new System.Drawing.Size(100, 20);
            this.txtClassCSeats.TabIndex = 6;
            // 
            // lblClassCSeats
            // 
            this.lblClassCSeats.AutoSize = true;
            this.lblClassCSeats.Location = new System.Drawing.Point(36, 185);
            this.lblClassCSeats.Name = "lblClassCSeats";
            this.lblClassCSeats.Size = new System.Drawing.Size(51, 13);
            this.lblClassCSeats.TabIndex = 5;
            this.lblClassCSeats.Text = "Class C : ";
            // 
            // txtClassBSeats
            // 
            this.txtClassBSeats.Location = new System.Drawing.Point(104, 132);
            this.txtClassBSeats.Name = "txtClassBSeats";
            this.txtClassBSeats.Size = new System.Drawing.Size(100, 20);
            this.txtClassBSeats.TabIndex = 4;
            // 
            // lblClassBSeats
            // 
            this.lblClassBSeats.AutoSize = true;
            this.lblClassBSeats.Location = new System.Drawing.Point(36, 139);
            this.lblClassBSeats.Name = "lblClassBSeats";
            this.lblClassBSeats.Size = new System.Drawing.Size(51, 13);
            this.lblClassBSeats.TabIndex = 3;
            this.lblClassBSeats.Text = "Class B : ";
            // 
            // txtClassASeats
            // 
            this.txtClassASeats.Location = new System.Drawing.Point(104, 82);
            this.txtClassASeats.Name = "txtClassASeats";
            this.txtClassASeats.Size = new System.Drawing.Size(100, 20);
            this.txtClassASeats.TabIndex = 2;
            // 
            // lblClassASeats
            // 
            this.lblClassASeats.AutoSize = true;
            this.lblClassASeats.Location = new System.Drawing.Point(36, 85);
            this.lblClassASeats.Name = "lblClassASeats";
            this.lblClassASeats.Size = new System.Drawing.Size(51, 13);
            this.lblClassASeats.TabIndex = 1;
            this.lblClassASeats.Text = "Class A : ";
            // 
            // lblIntro
            // 
            this.lblIntro.Location = new System.Drawing.Point(36, 16);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(168, 45);
            this.lblIntro.TabIndex = 0;
            this.lblIntro.Text = "Enter the number of tickets sold for each class of seats";
            this.lblIntro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpRevenue
            // 
            this.grpRevenue.Controls.Add(this.Total);
            this.grpRevenue.Controls.Add(this.revC);
            this.grpRevenue.Controls.Add(this.revB);
            this.grpRevenue.Controls.Add(this.revA);
            this.grpRevenue.Controls.Add(this.lblTotal);
            this.grpRevenue.Controls.Add(this.lblClassCRev);
            this.grpRevenue.Controls.Add(this.lblClassBRev);
            this.grpRevenue.Controls.Add(this.lblClassARev);
            this.grpRevenue.Location = new System.Drawing.Point(278, 12);
            this.grpRevenue.Name = "grpRevenue";
            this.grpRevenue.Size = new System.Drawing.Size(238, 269);
            this.grpRevenue.TabIndex = 1;
            this.grpRevenue.TabStop = false;
            this.grpRevenue.Text = "Revenue Generated";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(21, 214);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 13);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total : ";
            // 
            // lblClassCRev
            // 
            this.lblClassCRev.AutoSize = true;
            this.lblClassCRev.Location = new System.Drawing.Point(21, 162);
            this.lblClassCRev.Name = "lblClassCRev";
            this.lblClassCRev.Size = new System.Drawing.Size(51, 13);
            this.lblClassCRev.TabIndex = 6;
            this.lblClassCRev.Text = "Class C : ";
            // 
            // lblClassBRev
            // 
            this.lblClassBRev.AutoSize = true;
            this.lblClassBRev.Location = new System.Drawing.Point(21, 106);
            this.lblClassBRev.Name = "lblClassBRev";
            this.lblClassBRev.Size = new System.Drawing.Size(51, 13);
            this.lblClassBRev.TabIndex = 4;
            this.lblClassBRev.Text = "Class B : ";
            // 
            // lblClassARev
            // 
            this.lblClassARev.AutoSize = true;
            this.lblClassARev.Location = new System.Drawing.Point(21, 48);
            this.lblClassARev.Name = "lblClassARev";
            this.lblClassARev.Size = new System.Drawing.Size(51, 13);
            this.lblClassARev.TabIndex = 2;
            this.lblClassARev.Text = "Class A : ";
            // 
            // btnCalcRev
            // 
            this.btnCalcRev.Location = new System.Drawing.Point(51, 298);
            this.btnCalcRev.Name = "btnCalcRev";
            this.btnCalcRev.Size = new System.Drawing.Size(94, 56);
            this.btnCalcRev.TabIndex = 2;
            this.btnCalcRev.Text = "&Calcuate Revenue";
            this.btnCalcRev.UseVisualStyleBackColor = true;
            this.btnCalcRev.Click += new System.EventHandler(this.btnCalcRev_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(204, 298);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 56);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(358, 298);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 56);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit ";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // revA
            // 
            this.revA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.revA.Location = new System.Drawing.Point(74, 38);
            this.revA.Name = "revA";
            this.revA.Size = new System.Drawing.Size(100, 23);
            this.revA.TabIndex = 8;
            this.revA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // revB
            // 
            this.revB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.revB.Location = new System.Drawing.Point(74, 96);
            this.revB.Name = "revB";
            this.revB.Size = new System.Drawing.Size(100, 23);
            this.revB.TabIndex = 9;
            this.revB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // revC
            // 
            this.revC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.revC.Location = new System.Drawing.Point(74, 152);
            this.revC.Name = "revC";
            this.revC.Size = new System.Drawing.Size(100, 23);
            this.revC.TabIndex = 10;
            this.revC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Total
            // 
            this.Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Total.Location = new System.Drawing.Point(74, 209);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(100, 23);
            this.Total.TabIndex = 11;
            this.Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StadiumSeating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(528, 375);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalcRev);
            this.Controls.Add(this.grpRevenue);
            this.Controls.Add(this.grpTicketsSold);
            this.Name = "StadiumSeating";
            this.Text = "Stadium Seating";
            this.grpTicketsSold.ResumeLayout(false);
            this.grpTicketsSold.PerformLayout();
            this.grpRevenue.ResumeLayout(false);
            this.grpRevenue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTicketsSold;
        private System.Windows.Forms.TextBox txtClassCSeats;
        private System.Windows.Forms.Label lblClassCSeats;
        private System.Windows.Forms.TextBox txtClassBSeats;
        private System.Windows.Forms.Label lblClassBSeats;
        private System.Windows.Forms.TextBox txtClassASeats;
        private System.Windows.Forms.Label lblClassASeats;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.GroupBox grpRevenue;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblClassCRev;
        private System.Windows.Forms.Label lblClassBRev;
        private System.Windows.Forms.Label lblClassARev;
        private System.Windows.Forms.Button btnCalcRev;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label revC;
        private System.Windows.Forms.Label revB;
        private System.Windows.Forms.Label revA;
    }
}

