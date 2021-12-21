
namespace MusicalChairs
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxMaxDuration = new System.Windows.Forms.TextBox();
            this.labelMaxDuration = new System.Windows.Forms.Label();
            this.labelMinDuration = new System.Windows.Forms.Label();
            this.textBoxMinDuration = new System.Windows.Forms.TextBox();
            this.labelMinSeconds = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelMaxSeconds = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            resources.ApplyResources(this.tableLayoutPanel, "tableLayoutPanel");
            this.tableLayoutPanel.Controls.Add(this.textBoxMaxDuration, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.labelMaxDuration, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.labelMinDuration, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.textBoxMinDuration, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.labelMinSeconds, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.buttonStart, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.labelMaxSeconds, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.labelInfo, 0, 2);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            // 
            // textBoxMaxDuration
            // 
            resources.ApplyResources(this.textBoxMaxDuration, "textBoxMaxDuration");
            this.textBoxMaxDuration.Name = "textBoxMaxDuration";
            // 
            // labelMaxDuration
            // 
            resources.ApplyResources(this.labelMaxDuration, "labelMaxDuration");
            this.labelMaxDuration.Name = "labelMaxDuration";
            // 
            // labelMinDuration
            // 
            resources.ApplyResources(this.labelMinDuration, "labelMinDuration");
            this.labelMinDuration.Name = "labelMinDuration";
            // 
            // textBoxMinDuration
            // 
            resources.ApplyResources(this.textBoxMinDuration, "textBoxMinDuration");
            this.textBoxMinDuration.Name = "textBoxMinDuration";
            // 
            // labelMinSeconds
            // 
            resources.ApplyResources(this.labelMinSeconds, "labelMinSeconds");
            this.labelMinSeconds.Name = "labelMinSeconds";
            // 
            // buttonStart
            // 
            this.tableLayoutPanel.SetColumnSpan(this.buttonStart, 3);
            resources.ApplyResources(this.buttonStart, "buttonStart");
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelMaxSeconds
            // 
            resources.ApplyResources(this.labelMaxSeconds, "labelMaxSeconds");
            this.labelMaxSeconds.Name = "labelMaxSeconds";
            // 
            // labelInfo
            // 
            resources.ApplyResources(this.labelInfo, "labelInfo");
            this.tableLayoutPanel.SetColumnSpan(this.labelInfo, 3);
            this.labelInfo.Name = "labelInfo";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelMinDuration;
        private System.Windows.Forms.TextBox textBoxMinDuration;
        private System.Windows.Forms.Label labelMaxSeconds;
        private System.Windows.Forms.TextBox textBoxMaxDuration;
        private System.Windows.Forms.Label labelMaxDuration;
        private System.Windows.Forms.Label labelMinSeconds;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelInfo;
    }
}