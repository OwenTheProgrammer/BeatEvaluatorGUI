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
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Hot Start");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Cold End");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("Note Overlaps");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Wall Width");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("Wall Duration");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("Wall Minimum Duration");
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.FileInterfacePanel = new System.Windows.Forms.Panel();
            this.ClearQueue = new System.Windows.Forms.Button();
            this.CustomFolderButton = new System.Windows.Forms.Button();
            this.BSRLinkButton = new System.Windows.Forms.Button();
            this.BPLISTButton = new System.Windows.Forms.Button();
            this.EvaluateZipButton = new System.Windows.Forms.Button();
            this.EvaluateFolderButton = new System.Windows.Forms.Button();
            this.EvalFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.EvaluationPanel = new System.Windows.Forms.Panel();
            this.Metrics = new System.Windows.Forms.Panel();
            this.MapMetrics = new System.Windows.Forms.TreeView();
            this.MapImage = new System.Windows.Forms.PictureBox();
            this.MapTitle = new System.Windows.Forms.Label();
            this.QueueTree = new System.Windows.Forms.TreeView();
            this.EvalFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.LoadingBar = new System.Windows.Forms.ProgressBar();
            this.ProgressText = new System.Windows.Forms.Label();
            this.HeaderPanel.SuspendLayout();
            this.FileInterfacePanel.SuspendLayout();
            this.EvaluationPanel.SuspendLayout();
            this.Metrics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapImage)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.HeaderPanel.Controls.Add(this.ProgressText);
            this.HeaderPanel.Controls.Add(this.LoadingBar);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1140, 60);
            this.HeaderPanel.TabIndex = 0;
            // 
            // FileInterfacePanel
            // 
            this.FileInterfacePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.FileInterfacePanel.Controls.Add(this.ClearQueue);
            this.FileInterfacePanel.Controls.Add(this.CustomFolderButton);
            this.FileInterfacePanel.Controls.Add(this.BSRLinkButton);
            this.FileInterfacePanel.Controls.Add(this.BPLISTButton);
            this.FileInterfacePanel.Controls.Add(this.EvaluateZipButton);
            this.FileInterfacePanel.Controls.Add(this.EvaluateFolderButton);
            this.FileInterfacePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.FileInterfacePanel.Location = new System.Drawing.Point(0, 60);
            this.FileInterfacePanel.Name = "FileInterfacePanel";
            this.FileInterfacePanel.Padding = new System.Windows.Forms.Padding(5);
            this.FileInterfacePanel.Size = new System.Drawing.Size(200, 526);
            this.FileInterfacePanel.TabIndex = 1;
            // 
            // ClearQueue
            // 
            this.ClearQueue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.ClearQueue.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClearQueue.FlatAppearance.BorderSize = 0;
            this.ClearQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearQueue.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearQueue.Image = ((System.Drawing.Image)(resources.GetObject("ClearQueue.Image")));
            this.ClearQueue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClearQueue.Location = new System.Drawing.Point(5, 305);
            this.ClearQueue.Name = "ClearQueue";
            this.ClearQueue.Size = new System.Drawing.Size(190, 60);
            this.ClearQueue.TabIndex = 5;
            this.ClearQueue.Text = "Clear Map Queue";
            this.ClearQueue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ClearQueue.UseVisualStyleBackColor = false;
            this.ClearQueue.Click += new System.EventHandler(this.QueueClear_Click);
            // 
            // CustomFolderButton
            // 
            this.CustomFolderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.CustomFolderButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomFolderButton.FlatAppearance.BorderSize = 0;
            this.CustomFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomFolderButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomFolderButton.Image = ((System.Drawing.Image)(resources.GetObject("CustomFolderButton.Image")));
            this.CustomFolderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustomFolderButton.Location = new System.Drawing.Point(5, 245);
            this.CustomFolderButton.Name = "CustomFolderButton";
            this.CustomFolderButton.Size = new System.Drawing.Size(190, 60);
            this.CustomFolderButton.TabIndex = 4;
            this.CustomFolderButton.Text = "Evaluate Custom folder";
            this.CustomFolderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CustomFolderButton.UseVisualStyleBackColor = false;
            this.CustomFolderButton.Click += new System.EventHandler(this.CustomFolderButton_Click);
            // 
            // BSRLinkButton
            // 
            this.BSRLinkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.BSRLinkButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.BSRLinkButton.FlatAppearance.BorderSize = 0;
            this.BSRLinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSRLinkButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSRLinkButton.Image = ((System.Drawing.Image)(resources.GetObject("BSRLinkButton.Image")));
            this.BSRLinkButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BSRLinkButton.Location = new System.Drawing.Point(5, 185);
            this.BSRLinkButton.Name = "BSRLinkButton";
            this.BSRLinkButton.Size = new System.Drawing.Size(190, 60);
            this.BSRLinkButton.TabIndex = 3;
            this.BSRLinkButton.Text = "Evaluate !BSR";
            this.BSRLinkButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BSRLinkButton.UseVisualStyleBackColor = false;
            // 
            // BPLISTButton
            // 
            this.BPLISTButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.BPLISTButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.BPLISTButton.FlatAppearance.BorderSize = 0;
            this.BPLISTButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BPLISTButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BPLISTButton.Image = ((System.Drawing.Image)(resources.GetObject("BPLISTButton.Image")));
            this.BPLISTButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BPLISTButton.Location = new System.Drawing.Point(5, 125);
            this.BPLISTButton.Name = "BPLISTButton";
            this.BPLISTButton.Size = new System.Drawing.Size(190, 60);
            this.BPLISTButton.TabIndex = 2;
            this.BPLISTButton.Text = "Evaluate .bplist";
            this.BPLISTButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BPLISTButton.UseVisualStyleBackColor = false;
            // 
            // EvaluateZipButton
            // 
            this.EvaluateZipButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.EvaluateZipButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.EvaluateZipButton.FlatAppearance.BorderSize = 0;
            this.EvaluateZipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EvaluateZipButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EvaluateZipButton.Image = ((System.Drawing.Image)(resources.GetObject("EvaluateZipButton.Image")));
            this.EvaluateZipButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EvaluateZipButton.Location = new System.Drawing.Point(5, 65);
            this.EvaluateZipButton.Name = "EvaluateZipButton";
            this.EvaluateZipButton.Size = new System.Drawing.Size(190, 60);
            this.EvaluateZipButton.TabIndex = 1;
            this.EvaluateZipButton.Text = "Evaluate ZIP file";
            this.EvaluateZipButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EvaluateZipButton.UseVisualStyleBackColor = false;
            this.EvaluateZipButton.Click += new System.EventHandler(this.EvaluateZipFile_Click);
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
            // MapMetrics
            // 
            this.MapMetrics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MapMetrics.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MapMetrics.ForeColor = System.Drawing.Color.White;
            this.MapMetrics.Location = new System.Drawing.Point(20, 94);
            this.MapMetrics.Name = "MapMetrics";
            treeNode49.Name = "HotStart";
            treeNode49.Text = "Hot Start";
            treeNode50.Name = "ColdEnd";
            treeNode50.Text = "Cold End";
            treeNode51.Name = "NoteOverlaps";
            treeNode51.Text = "Note Overlaps";
            treeNode52.Name = "WallWidth";
            treeNode52.Text = "Wall Width";
            treeNode53.Name = "WallDuration";
            treeNode53.Text = "Wall Duration";
            treeNode54.Name = "WallMinDuration";
            treeNode54.Text = "Wall Minimum Duration";
            this.MapMetrics.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode49,
            treeNode50,
            treeNode51,
            treeNode52,
            treeNode53,
            treeNode54});
            this.MapMetrics.Size = new System.Drawing.Size(402, 378);
            this.MapMetrics.TabIndex = 4;
            this.MapMetrics.Visible = false;
            // 
            // MapImage
            // 
            this.MapImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("MapImage.InitialImage")));
            this.MapImage.Location = new System.Drawing.Point(20, 12);
            this.MapImage.MaximumSize = new System.Drawing.Size(64, 64);
            this.MapImage.Name = "MapImage";
            this.MapImage.Size = new System.Drawing.Size(64, 64);
            this.MapImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MapImage.TabIndex = 1;
            this.MapImage.TabStop = false;
            this.MapImage.Visible = false;
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
            // EvalFileDialog
            // 
            this.EvalFileDialog.FileName = "BeatMap";
            this.EvalFileDialog.Filter = "Zip files|*.zip";
            // 
            // LoadingBar
            // 
            this.LoadingBar.Location = new System.Drawing.Point(106, 21);
            this.LoadingBar.MarqueeAnimationSpeed = 50;
            this.LoadingBar.Name = "LoadingBar";
            this.LoadingBar.Size = new System.Drawing.Size(241, 23);
            this.LoadingBar.TabIndex = 0;
            this.LoadingBar.Value = 1;
            // 
            // ProgressText
            // 
            this.ProgressText.AutoSize = true;
            this.ProgressText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressText.ForeColor = System.Drawing.Color.White;
            this.ProgressText.Location = new System.Drawing.Point(353, 21);
            this.ProgressText.Name = "ProgressText";
            this.ProgressText.Size = new System.Drawing.Size(0, 19);
            this.ProgressText.TabIndex = 1;
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BeatEvaluator_FormClosing);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
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
        private System.Windows.Forms.Button EvaluateZipButton;
        private System.Windows.Forms.Button BSRLinkButton;
        private System.Windows.Forms.Button BPLISTButton;
        private System.Windows.Forms.Button CustomFolderButton;
        private System.Windows.Forms.Button ClearQueue;
        private System.Windows.Forms.OpenFileDialog EvalFileDialog;
        private System.Windows.Forms.ProgressBar LoadingBar;
        private System.Windows.Forms.Label ProgressText;
    }
}

