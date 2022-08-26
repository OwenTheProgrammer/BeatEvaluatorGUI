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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Hot Start");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Cold End");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Note Overlaps");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Wall Width");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Wall Duration");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Wall Minimum Duration");
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.FileInterfacePanel = new System.Windows.Forms.Panel();
            this.EvaluateFolderButton = new System.Windows.Forms.Button();
            this.EvalFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.EvaluationPanel = new System.Windows.Forms.Panel();
            this.Metrics = new System.Windows.Forms.Panel();
            this.MapTitle = new System.Windows.Forms.Label();
            this.QueueTree = new System.Windows.Forms.TreeView();
            this.MapImage = new System.Windows.Forms.PictureBox();
            this.MapMetrics = new System.Windows.Forms.TreeView();
            this.FileInterfacePanel.SuspendLayout();
            this.EvaluationPanel.SuspendLayout();
            this.Metrics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapImage)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1140, 60);
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
            this.FileInterfacePanel.Size = new System.Drawing.Size(200, 526);
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
            // EvaluationPanel
            // 
            this.EvaluationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EvaluationPanel.Controls.Add(this.Metrics);
            this.EvaluationPanel.Controls.Add(this.QueueTree);
            this.EvaluationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EvaluationPanel.Location = new System.Drawing.Point(200, 60);
            this.EvaluationPanel.Name = "EvaluationPanel";
            this.EvaluationPanel.Size = new System.Drawing.Size(940, 526);
            this.EvaluationPanel.TabIndex = 2;
            // 
            // Metrics
            // 
            this.Metrics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Metrics.Controls.Add(this.MapMetrics);
            this.Metrics.Controls.Add(this.MapImage);
            this.Metrics.Controls.Add(this.MapTitle);
            this.Metrics.Location = new System.Drawing.Point(450, 6);
            this.Metrics.Name = "Metrics";
            this.Metrics.Size = new System.Drawing.Size(487, 517);
            this.Metrics.TabIndex = 1;
            // 
            // MapTitle
            // 
            this.MapTitle.AutoSize = true;
            this.MapTitle.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MapTitle.ForeColor = System.Drawing.Color.White;
            this.MapTitle.Location = new System.Drawing.Point(97, 15);
            this.MapTitle.Margin = new System.Windows.Forms.Padding(10);
            this.MapTitle.MaximumSize = new System.Drawing.Size(366, 64);
            this.MapTitle.Name = "MapTitle";
            this.MapTitle.Size = new System.Drawing.Size(90, 19);
            this.MapTitle.TabIndex = 0;
            this.MapTitle.Text = "Map Title";
            this.MapTitle.Visible = false;
            // 
            // QueueTree
            // 
            this.QueueTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.QueueTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QueueTree.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueueTree.ForeColor = System.Drawing.Color.White;
            this.QueueTree.Location = new System.Drawing.Point(6, 6);
            this.QueueTree.Name = "QueueTree";
            this.QueueTree.Size = new System.Drawing.Size(438, 517);
            this.QueueTree.TabIndex = 0;
            this.QueueTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.OnQueueSelection);
            // 
            // MapImage
            // 
            this.MapImage.InitialImage = null;
            this.MapImage.Location = new System.Drawing.Point(20, 12);
            this.MapImage.Name = "MapImage";
            this.MapImage.Size = new System.Drawing.Size(64, 64);
            this.MapImage.TabIndex = 1;
            this.MapImage.TabStop = false;
            this.MapImage.Visible = false;
            // 
            // MapMetrics
            // 
            this.MapMetrics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MapMetrics.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MapMetrics.ForeColor = System.Drawing.Color.White;
            this.MapMetrics.Location = new System.Drawing.Point(20, 94);
            this.MapMetrics.Name = "MapMetrics";
            treeNode1.Name = "HotStart";
            treeNode1.Text = "Hot Start";
            treeNode2.Name = "ColdEnd";
            treeNode2.Text = "Cold End";
            treeNode3.Name = "NoteOverlaps";
            treeNode3.Text = "Note Overlaps";
            treeNode4.Name = "WallWidth";
            treeNode4.Text = "Wall Width";
            treeNode5.Name = "WallDuration";
            treeNode5.Text = "Wall Duration";
            treeNode6.Name = "WallMinDuration";
            treeNode6.Text = "Wall Minimum Duration";
            this.MapMetrics.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            this.MapMetrics.Size = new System.Drawing.Size(402, 378);
            this.MapMetrics.TabIndex = 4;
            this.MapMetrics.Visible = false;
            // 
            // BeatEvaluator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1140, 586);
            this.Controls.Add(this.EvaluationPanel);
            this.Controls.Add(this.FileInterfacePanel);
            this.Controls.Add(this.HeaderPanel);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "BeatEvaluator";
            this.Text = "Beat Evaluator";
            this.FileInterfacePanel.ResumeLayout(false);
            this.EvaluationPanel.ResumeLayout(false);
            this.Metrics.ResumeLayout(false);
            this.Metrics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel FileInterfacePanel;
        private System.Windows.Forms.Button EvaluateFolderButton;
        private System.Windows.Forms.FolderBrowserDialog EvalFolderDialog;
        private System.Windows.Forms.Panel EvaluationPanel;
        private System.Windows.Forms.TreeView QueueTree;
        private System.Windows.Forms.Panel Metrics;
        private System.Windows.Forms.Label MapTitle;
        private System.Windows.Forms.PictureBox MapImage;
        private System.Windows.Forms.TreeView MapMetrics;
    }
}

