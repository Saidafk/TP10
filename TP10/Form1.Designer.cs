namespace TP10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvDev = new DataGridView();
            cbDev = new ComboBox();
            bsDev = new BindingSource(components);
            bsDev1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvDev).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsDev).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsDev1).BeginInit();
            SuspendLayout();
            // 
            // dgvDev
            // 
            dgvDev.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDev.Location = new Point(188, 133);
            dgvDev.Name = "dgvDev";
            dgvDev.Size = new Size(405, 263);
            dgvDev.TabIndex = 0;
            // 
            // cbDev
            // 
            cbDev.FormattingEnabled = true;
            cbDev.Location = new Point(339, 45);
            cbDev.Name = "cbDev";
            cbDev.Size = new Size(121, 23);
            cbDev.TabIndex = 1;
            cbDev.SelectedIndexChanged += cbDev_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbDev);
            Controls.Add(dgvDev);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDev).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsDev).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsDev1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDev;
        private ComboBox cbDev;
        private BindingSource bsDev;
        private BindingSource bsDev1;
    }
}
