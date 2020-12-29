﻿
namespace Greg.Xrm.EnvironmentComparer
{
	partial class EnvironmentComparerPluginControl
	{
		/// <summary> 
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur de composants

		/// <summary> 
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnvironmentComparerPluginControl));
			this.tools = new System.Windows.Forms.ToolStrip();
			this.tClose = new System.Windows.Forms.ToolStripButton();
			this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tEnv1Name = new System.Windows.Forms.ToolStripLabel();
			this.tEnv2Name = new System.Windows.Forms.ToolStripLabel();
			this.tConnectToEnv2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tOpenMemento = new System.Windows.Forms.ToolStripButton();
			this.tExecuteComparison = new System.Windows.Forms.ToolStripButton();
			this.tDownloadExcelFile = new System.Windows.Forms.ToolStripButton();
			this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
			this.tLoadEntities = new System.Windows.Forms.ToolStripButton();
			this.tools.SuspendLayout();
			this.SuspendLayout();
			// 
			// tools
			// 
			this.tools.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tClose,
            this.tssSeparator1,
            this.tEnv1Name,
            this.tEnv2Name,
            this.tConnectToEnv2,
            this.toolStripSeparator1,
            this.tLoadEntities,
            this.tOpenMemento,
            this.tExecuteComparison,
            this.tDownloadExcelFile});
			this.tools.Location = new System.Drawing.Point(0, 0);
			this.tools.Name = "tools";
			this.tools.Size = new System.Drawing.Size(1175, 25);
			this.tools.TabIndex = 4;
			this.tools.Text = "toolStrip1";
			// 
			// tClose
			// 
			this.tClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tClose.Image = global::Greg.Xrm.EnvironmentComparer.Properties.Resources.door_out;
			this.tClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tClose.Name = "tClose";
			this.tClose.Size = new System.Drawing.Size(23, 22);
			this.tClose.Text = "Close this tool";
			this.tClose.Click += new System.EventHandler(this.OnCloseToolClicked);
			// 
			// tssSeparator1
			// 
			this.tssSeparator1.Name = "tssSeparator1";
			this.tssSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// tEnv1Name
			// 
			this.tEnv1Name.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tEnv1Name.Name = "tEnv1Name";
			this.tEnv1Name.Size = new System.Drawing.Size(155, 22);
			this.tEnv1Name.Text = "1. Connect to environment 1";
			// 
			// tEnv2Name
			// 
			this.tEnv2Name.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tEnv2Name.Name = "tEnv2Name";
			this.tEnv2Name.Size = new System.Drawing.Size(87, 22);
			this.tEnv2Name.Text = "[not initialized]";
			this.tEnv2Name.Visible = false;
			// 
			// tConnectToEnv2
			// 
			this.tConnectToEnv2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tConnectToEnv2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tConnectToEnv2.Image = ((System.Drawing.Image)(resources.GetObject("tConnectToEnv2.Image")));
			this.tConnectToEnv2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tConnectToEnv2.Name = "tConnectToEnv2";
			this.tConnectToEnv2.Size = new System.Drawing.Size(102, 22);
			this.tConnectToEnv2.Text = "Connect to ENV2";
			this.tConnectToEnv2.Visible = false;
			this.tConnectToEnv2.Click += new System.EventHandler(this.OnConnectToEnvironment2);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// tOpenMemento
			// 
			this.tOpenMemento.Enabled = false;
			this.tOpenMemento.Image = global::Greg.Xrm.EnvironmentComparer.Properties.Resources.folder;
			this.tOpenMemento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tOpenMemento.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tOpenMemento.Name = "tOpenMemento";
			this.tOpenMemento.Size = new System.Drawing.Size(140, 22);
			this.tOpenMemento.Text = "Open configuration...";
			this.tOpenMemento.Click += new System.EventHandler(this.OnOpenMemento);
			// 
			// tExecuteComparison
			// 
			this.tExecuteComparison.Enabled = false;
			this.tExecuteComparison.Image = global::Greg.Xrm.EnvironmentComparer.Properties.Resources.control_play_blue;
			this.tExecuteComparison.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tExecuteComparison.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tExecuteComparison.Name = "tExecuteComparison";
			this.tExecuteComparison.Size = new System.Drawing.Size(134, 22);
			this.tExecuteComparison.Text = "Execute comparison";
			this.tExecuteComparison.Click += new System.EventHandler(this.OnExecuteComparisonClicked);
			// 
			// tDownloadExcelFile
			// 
			this.tDownloadExcelFile.Enabled = false;
			this.tDownloadExcelFile.Image = global::Greg.Xrm.EnvironmentComparer.Properties.Resources.page_white_excel;
			this.tDownloadExcelFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tDownloadExcelFile.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tDownloadExcelFile.Name = "tDownloadExcelFile";
			this.tDownloadExcelFile.Size = new System.Drawing.Size(139, 22);
			this.tDownloadExcelFile.Text = "Download Excel file...";
			this.tDownloadExcelFile.Click += new System.EventHandler(this.OnDowloadExcelFileClicked);
			// 
			// dockPanel
			// 
			this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dockPanel.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingSdi;
			this.dockPanel.Location = new System.Drawing.Point(0, 25);
			this.dockPanel.Name = "dockPanel";
			this.dockPanel.Size = new System.Drawing.Size(1175, 602);
			this.dockPanel.TabIndex = 5;
			// 
			// tLoadEntities
			// 
			this.tLoadEntities.Enabled = false;
			this.tLoadEntities.Image = ((System.Drawing.Image)(resources.GetObject("tLoadEntities.Image")));
			this.tLoadEntities.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tLoadEntities.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tLoadEntities.Name = "tLoadEntities";
			this.tLoadEntities.Size = new System.Drawing.Size(94, 22);
			this.tLoadEntities.Text = "Load entities";
			this.tLoadEntities.Click += new System.EventHandler(this.OnLoadEntitiesClick);
			// 
			// EnvironmentComparerPluginControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dockPanel);
			this.Controls.Add(this.tools);
			this.Name = "EnvironmentComparerPluginControl";
			this.Size = new System.Drawing.Size(1175, 627);
			this.Load += new System.EventHandler(this.MyPluginControl_Load);
			this.tools.ResumeLayout(false);
			this.tools.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ToolStrip tools;
		private System.Windows.Forms.ToolStripButton tClose;
		private System.Windows.Forms.ToolStripSeparator tssSeparator1;
		private System.Windows.Forms.ToolStripLabel tEnv1Name;
		private System.Windows.Forms.ToolStripLabel tEnv2Name;
		private System.Windows.Forms.ToolStripButton tConnectToEnv2;
		private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton tOpenMemento;
		private System.Windows.Forms.ToolStripButton tExecuteComparison;
		private System.Windows.Forms.ToolStripButton tDownloadExcelFile;
		private System.Windows.Forms.ToolStripButton tLoadEntities;
	}
}
