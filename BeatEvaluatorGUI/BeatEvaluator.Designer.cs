namespace BeatEvaluatorGUI
{
    partial class BeatEvaluator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BeatEvaluator));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.FileInterfacePanel = new System.Windows.Forms.Panel();
            this.EvaluateFolderButton = new System.Windows.Forms.Button();
            this.EvalFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.FileInterfacePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(934, 60);
            this.HeaderPanel.TabIndex = 0;
            // 
            // FileInterfacePanel
            // 
            this.FileInterfacePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.FileInterfacePanel.Controls.Add(this.EvaluateFolderButton);
            this.FileInterfacePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.FileInterfacePanel.Location = new System.Drawing.Point(0, 60);
            this.FileInterfacePanel.Name = "FileInterfacePanel";
            this.FileInterfacePanel.Padding = new System.Windows.Forms.Padding(5);
            this.FileInterfacePanel.Size = new System.Drawing.Size(200, 451);
            this.FileInterfacePanel.TabIndex = 1;
            // 
            // EvaluateFolderButton
            // 
            this.EvaluateFolderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.EvaluateFolderButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.EvaluateFolderButton.FlatAppearance.BorderSize = 0;
            this.EvaluateFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EvaluateFolderButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EvaluateFolderButton.Image = ((System.Drawing.Image)(resources.GetObject("EvaluateFolderButton.Image")));
            this.EvaluateFolderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EvaluateFolderButton.Location = new System.Drawing.Point(5, 5);
            this.EvaluateFolderButton.Name = "EvaluateFolderButton";
            this.EvaluateFolderButton.Size = new System.Drawing.Size(190, 60);
            this.EvaluateFolderButton.TabIndex = 0;
            this.EvaluateFolderButton.Text = "Evaluate Folder";
            this.EvaluateFolderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EvaluateFolderButton.UseVisualStyleBackColor = false;
            this.EvaluateFolderButton.Click += new System.EventHandler(this.EvaluateFolderButton_Click);
            // 
            // BeatEvaluator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(934, 511);
            this.Controls.Add(this.FileInterfacePanel);
            this.Controls.Add(this.HeaderPanel);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "BeatEvaluator";
            this.Text = "Beat Evaluator";
            this.FileInterfacePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel FileInterfacePanel;
        private System.Windows.Forms.Button EvaluateFolderButton;
        private System.Windows.Forms.FolderBrowserDialog EvalFolderDialog;
    }
}

