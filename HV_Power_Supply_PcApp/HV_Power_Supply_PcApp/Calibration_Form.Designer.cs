
namespace HV_Power_Supply_GUI_ver._1
{
    partial class Calibration_Form
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
            this.button_StartCalib = new System.Windows.Forms.Button();
            this.dataGridView_CalibData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CalibData)).BeginInit();
            this.SuspendLayout();
            // 
            // button_StartCalib
            // 
            this.button_StartCalib.Location = new System.Drawing.Point(29, 32);
            this.button_StartCalib.Name = "button_StartCalib";
            this.button_StartCalib.Size = new System.Drawing.Size(75, 23);
            this.button_StartCalib.TabIndex = 0;
            this.button_StartCalib.Text = "Start";
            this.button_StartCalib.UseVisualStyleBackColor = true;
            this.button_StartCalib.Click += new System.EventHandler(this.button_StartCalib_Click);
            // 
            // dataGridView_CalibData
            // 
            this.dataGridView_CalibData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CalibData.Location = new System.Drawing.Point(503, 32);
            this.dataGridView_CalibData.Name = "dataGridView_CalibData";
            this.dataGridView_CalibData.Size = new System.Drawing.Size(269, 394);
            this.dataGridView_CalibData.TabIndex = 4;
            // 
            // Calibration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_CalibData);
            this.Controls.Add(this.button_StartCalib);
            this.Name = "Calibration_Form";
            this.Text = "Calibration_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CalibData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_StartCalib;
        private System.Windows.Forms.DataGridView dataGridView_CalibData;
    }
}