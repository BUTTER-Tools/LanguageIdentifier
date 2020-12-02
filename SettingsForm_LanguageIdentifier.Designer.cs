namespace LanguageIdentifier
{
    partial class SettingsForm_LanguageIdentifier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm_LanguageIdentifier));
            this.OKButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Wiki280Selection = new System.Windows.Forms.RadioButton();
            this.Core14LangSelection = new System.Windows.Forms.RadioButton();
            this.Wiki82Selection = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.Location = new System.Drawing.Point(176, 165);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(118, 40);
            this.OKButton.TabIndex = 6;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 18);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(264, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Which Language Model to Use?";
            // 
            // SegmentationOptionRegex
            // 
            this.Wiki280Selection.AutoSize = true;
            this.Wiki280Selection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wiki280Selection.Location = new System.Drawing.Point(15, 116);
            this.Wiki280Selection.Name = "SegmentationOptionRegex";
            this.Wiki280Selection.Size = new System.Drawing.Size(273, 21);
            this.Wiki280Selection.TabIndex = 10;
            this.Wiki280Selection.Text = "280 Languages (Trained on Wikipedia)";
            this.Wiki280Selection.UseVisualStyleBackColor = true;
            // 
            // SegmentationOptionEqualSegments
            // 
            this.Core14LangSelection.AutoSize = true;
            this.Core14LangSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Core14LangSelection.Location = new System.Drawing.Point(15, 50);
            this.Core14LangSelection.Name = "SegmentationOptionEqualSegments";
            this.Core14LangSelection.Size = new System.Drawing.Size(151, 21);
            this.Core14LangSelection.TabIndex = 9;
            this.Core14LangSelection.Text = "Core 14 Languages";
            this.Core14LangSelection.UseVisualStyleBackColor = true;
            // 
            // SegmentationOptionWordsPerSegment
            // 
            this.Wiki82Selection.AutoSize = true;
            this.Wiki82Selection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wiki82Selection.Location = new System.Drawing.Point(15, 83);
            this.Wiki82Selection.Name = "SegmentationOptionWordsPerSegment";
            this.Wiki82Selection.Size = new System.Drawing.Size(265, 21);
            this.Wiki82Selection.TabIndex = 8;
            this.Wiki82Selection.Text = "82 Languages (Trained on Wikipedia)";
            this.Wiki82Selection.UseVisualStyleBackColor = true;
            // 
            // SettingsForm_LanguageIdentifier
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 217);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Wiki280Selection);
            this.Controls.Add(this.Core14LangSelection);
            this.Controls.Add(this.Wiki82Selection);
            this.Controls.Add(this.OKButton);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm_LanguageIdentifier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plugin Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton Wiki280Selection;
        private System.Windows.Forms.RadioButton Core14LangSelection;
        private System.Windows.Forms.RadioButton Wiki82Selection;
    }
}