namespace QuanLyLuanVan
{
    partial class UCLich
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
            this.sfCalendar1 = new Syncfusion.WinForms.Input.SfCalendar();
            this.SuspendLayout();
            // 
            // sfCalendar1
            // 
            this.sfCalendar1.Location = new System.Drawing.Point(0, 3);
            this.sfCalendar1.MinimumSize = new System.Drawing.Size(196, 196);
            this.sfCalendar1.Name = "sfCalendar1";
            this.sfCalendar1.Size = new System.Drawing.Size(672, 497);
            this.sfCalendar1.TabIndex = 0;
            this.sfCalendar1.Text = "sfCalendar1";
            this.sfCalendar1.Click += new System.EventHandler(this.sfCalendar1_Click);
            // 
            // UCLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sfCalendar1);
            this.Name = "UCLich";
            this.Size = new System.Drawing.Size(674, 500);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.WinForms.Input.SfCalendar sfCalendar1;
    }
}
