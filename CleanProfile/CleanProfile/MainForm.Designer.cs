namespace DoenaSoft.DVDProfiler.CleanProfile
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
            if(disposing && (components != null))
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
            this.OkButton = new System.Windows.Forms.Button();
            this.AbortButton = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.PublicTabPage = new System.Windows.Forms.TabPage();
            this.SetLockOnEntireGroupBox = new System.Windows.Forms.GroupBox();
            this.EntireDvdLockCheckBox = new System.Windows.Forms.CheckBox();
            this.SetLockOnGroupBox = new System.Windows.Forms.GroupBox();
            this.OriginalTitleLockCheckBox = new System.Windows.Forms.CheckBox();
            this.DiscsLockCheckBox = new System.Windows.Forms.CheckBox();
            this.MediaTypesLockCheckBox = new System.Windows.Forms.CheckBox();
            this.EasterEggsLockCheckBox = new System.Windows.Forms.CheckBox();
            this.CaseTypeLockCheckBox = new System.Windows.Forms.CheckBox();
            this.OverviewLockCheckBox = new System.Windows.Forms.CheckBox();
            this.FeaturesLockCheckBox = new System.Windows.Forms.CheckBox();
            this.RatingLockCheckBox = new System.Windows.Forms.CheckBox();
            this.CrewLockCheckBox = new System.Windows.Forms.CheckBox();
            this.CastLockCheckBox = new System.Windows.Forms.CheckBox();
            this.AudioTracksLockCheckBox = new System.Windows.Forms.CheckBox();
            this.CoverImagesLockCheckBox = new System.Windows.Forms.CheckBox();
            this.ProductionYearLockCheckBox = new System.Windows.Forms.CheckBox();
            this.CountryOfOriginLockCheckBox = new System.Windows.Forms.CheckBox();
            this.GenresLockCheckBox = new System.Windows.Forms.CheckBox();
            this.SubtitlesLockCheckBox = new System.Windows.Forms.CheckBox();
            this.ReleaseDateLockCheckBox = new System.Windows.Forms.CheckBox();
            this.SrpLockCheckBox = new System.Windows.Forms.CheckBox();
            this.MediaCompaniesLockCheckBox = new System.Windows.Forms.CheckBox();
            this.StudiosLockCheckBox = new System.Windows.Forms.CheckBox();
            this.VideoFormatsLockCheckBox = new System.Windows.Forms.CheckBox();
            this.RegionsLockCheckBox = new System.Windows.Forms.CheckBox();
            this.OverwriteGroupBox = new System.Windows.Forms.GroupBox();
            this.MediaTypesComboBox = new System.Windows.Forms.ComboBox();
            this.MediaTypesCheckBox = new System.Windows.Forms.CheckBox();
            this.OriginalTitleCheckBox = new System.Windows.Forms.CheckBox();
            this.BackCoverImagesCheckBox = new System.Windows.Forms.CheckBox();
            this.DiscsCheckBox = new System.Windows.Forms.CheckBox();
            this.EasterEggsCheckBox = new System.Windows.Forms.CheckBox();
            this.OverviewCheckBox = new System.Windows.Forms.CheckBox();
            this.FeaturesCheckBox = new System.Windows.Forms.CheckBox();
            this.CaseTypeCheckBox = new System.Windows.Forms.CheckBox();
            this.RatingCheckBox = new System.Windows.Forms.CheckBox();
            this.CrewCheckBox = new System.Windows.Forms.CheckBox();
            this.CastCheckBox = new System.Windows.Forms.CheckBox();
            this.AudioTracksCheckBox = new System.Windows.Forms.CheckBox();
            this.FrontCoverImagesCheckBox = new System.Windows.Forms.CheckBox();
            this.ProductionYearCheckBox = new System.Windows.Forms.CheckBox();
            this.CountryOfOriginCheckBox = new System.Windows.Forms.CheckBox();
            this.GenresCheckBox = new System.Windows.Forms.CheckBox();
            this.SubtitlesCheckBox = new System.Windows.Forms.CheckBox();
            this.ReleaseDateCheckBox = new System.Windows.Forms.CheckBox();
            this.SrpCheckBox = new System.Windows.Forms.CheckBox();
            this.MediaCompaniesCheckBox = new System.Windows.Forms.CheckBox();
            this.StudiosCheckBox = new System.Windows.Forms.CheckBox();
            this.VideoFormatsCheckBox = new System.Windows.Forms.CheckBox();
            this.RegionsCheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl.SuspendLayout();
            this.PublicTabPage.SuspendLayout();
            this.SetLockOnEntireGroupBox.SuspendLayout();
            this.SetLockOnGroupBox.SuspendLayout();
            this.OverwriteGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            resources.ApplyResources(this.OkButton, "OkButton");
            this.OkButton.Name = "OkButton";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OnOkButtonClick);
            // 
            // AbortButton
            // 
            this.AbortButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.AbortButton, "AbortButton");
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.UseVisualStyleBackColor = true;
            this.AbortButton.Click += new System.EventHandler(this.OnAbortButtonClick);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.PublicTabPage);
            resources.ApplyResources(this.TabControl, "TabControl");
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            // 
            // PublicTabPage
            // 
            this.PublicTabPage.Controls.Add(this.SetLockOnEntireGroupBox);
            this.PublicTabPage.Controls.Add(this.SetLockOnGroupBox);
            this.PublicTabPage.Controls.Add(this.OverwriteGroupBox);
            resources.ApplyResources(this.PublicTabPage, "PublicTabPage");
            this.PublicTabPage.Name = "PublicTabPage";
            this.PublicTabPage.UseVisualStyleBackColor = true;
            // 
            // SetLockOnEntireGroupBox
            // 
            this.SetLockOnEntireGroupBox.Controls.Add(this.EntireDvdLockCheckBox);
            resources.ApplyResources(this.SetLockOnEntireGroupBox, "SetLockOnEntireGroupBox");
            this.SetLockOnEntireGroupBox.Name = "SetLockOnEntireGroupBox";
            this.SetLockOnEntireGroupBox.TabStop = false;
            // 
            // EntireDvdLockCheckBox
            // 
            resources.ApplyResources(this.EntireDvdLockCheckBox, "EntireDvdLockCheckBox");
            this.EntireDvdLockCheckBox.Name = "EntireDvdLockCheckBox";
            this.EntireDvdLockCheckBox.UseVisualStyleBackColor = true;
            this.EntireDvdLockCheckBox.CheckedChanged += new System.EventHandler(this.OnEntireDvdLockCheckBoxCheckedChanged);
            // 
            // SetLockOnGroupBox
            // 
            this.SetLockOnGroupBox.Controls.Add(this.OriginalTitleLockCheckBox);
            this.SetLockOnGroupBox.Controls.Add(this.DiscsLockCheckBox);
            this.SetLockOnGroupBox.Controls.Add(this.MediaTypesLockCheckBox);
            this.SetLockOnGroupBox.Controls.Add(this.EasterEggsLockCheckBox);
            this.SetLockOnGroupBox.Controls.Add(this.CaseTypeLockCheckBox);
            this.SetLockOnGroupBox.Controls.Add(this.OverviewLockCheckBox);
            this.SetLockOnGroupBox.Controls.Add(this.FeaturesLockCheckBox);
            this.SetLockOnGroupBox.Controls.Add(this.RatingLockCheckBox);
            this.SetLockOnGroupBox.Controls.Add(this.CrewLockCheckBox);
            this.SetLockOnGroupBox.Controls.Add(this.CastLockCheckBox);
            this.SetLockOnGroupBox.Controls.Add(this.AudioTracksLockCheckBox);
            this.SetLockOnGroupBox.Controls.Add(this.CoverImagesLockCheckBox);
            this.SetLockOnGroupBox.Controls.Add(this.ProductionYearLockCheckBox);
            this.SetLockOnGroupBox.Controls.Add(this.CountryOfOriginLockCheckBox);
            this.SetLockOnGroupBox.Controls.Add(this.GenresLockCheckBox);
            this.SetLockOnGroupBox.Controls.Add(this.SubtitlesLockCheckBox);
            this.SetLockOnGroupBox.Controls.Add(this.ReleaseDateLockCheckBox);
            this.SetLockOnGroupBox.Controls.Add(this.SrpLockCheckBox);
            this.SetLockOnGroupBox.Controls.Add(this.MediaCompaniesLockCheckBox);
            this.SetLockOnGroupBox.Controls.Add(this.StudiosLockCheckBox);
            this.SetLockOnGroupBox.Controls.Add(this.VideoFormatsLockCheckBox);
            this.SetLockOnGroupBox.Controls.Add(this.RegionsLockCheckBox);
            resources.ApplyResources(this.SetLockOnGroupBox, "SetLockOnGroupBox");
            this.SetLockOnGroupBox.Name = "SetLockOnGroupBox";
            this.SetLockOnGroupBox.TabStop = false;
            // 
            // OriginalTitleLockCheckBox
            // 
            resources.ApplyResources(this.OriginalTitleLockCheckBox, "OriginalTitleLockCheckBox");
            this.OriginalTitleLockCheckBox.Name = "OriginalTitleLockCheckBox";
            this.OriginalTitleLockCheckBox.UseVisualStyleBackColor = true;
            // 
            // DiscsLockCheckBox
            // 
            resources.ApplyResources(this.DiscsLockCheckBox, "DiscsLockCheckBox");
            this.DiscsLockCheckBox.Name = "DiscsLockCheckBox";
            this.DiscsLockCheckBox.UseVisualStyleBackColor = true;
            // 
            // MediaTypesLockCheckBox
            // 
            resources.ApplyResources(this.MediaTypesLockCheckBox, "MediaTypesLockCheckBox");
            this.MediaTypesLockCheckBox.Name = "MediaTypesLockCheckBox";
            this.MediaTypesLockCheckBox.UseVisualStyleBackColor = true;
            // 
            // EasterEggsLockCheckBox
            // 
            resources.ApplyResources(this.EasterEggsLockCheckBox, "EasterEggsLockCheckBox");
            this.EasterEggsLockCheckBox.Name = "EasterEggsLockCheckBox";
            this.EasterEggsLockCheckBox.UseVisualStyleBackColor = true;
            // 
            // CaseTypeLockCheckBox
            // 
            resources.ApplyResources(this.CaseTypeLockCheckBox, "CaseTypeLockCheckBox");
            this.CaseTypeLockCheckBox.Name = "CaseTypeLockCheckBox";
            this.CaseTypeLockCheckBox.UseVisualStyleBackColor = true;
            // 
            // OverviewLockCheckBox
            // 
            resources.ApplyResources(this.OverviewLockCheckBox, "OverviewLockCheckBox");
            this.OverviewLockCheckBox.Name = "OverviewLockCheckBox";
            this.OverviewLockCheckBox.UseVisualStyleBackColor = true;
            // 
            // FeaturesLockCheckBox
            // 
            resources.ApplyResources(this.FeaturesLockCheckBox, "FeaturesLockCheckBox");
            this.FeaturesLockCheckBox.Name = "FeaturesLockCheckBox";
            this.FeaturesLockCheckBox.UseVisualStyleBackColor = true;
            // 
            // RatingLockCheckBox
            // 
            resources.ApplyResources(this.RatingLockCheckBox, "RatingLockCheckBox");
            this.RatingLockCheckBox.Name = "RatingLockCheckBox";
            this.RatingLockCheckBox.UseVisualStyleBackColor = true;
            // 
            // CrewLockCheckBox
            // 
            resources.ApplyResources(this.CrewLockCheckBox, "CrewLockCheckBox");
            this.CrewLockCheckBox.Name = "CrewLockCheckBox";
            this.CrewLockCheckBox.UseVisualStyleBackColor = true;
            // 
            // CastLockCheckBox
            // 
            resources.ApplyResources(this.CastLockCheckBox, "CastLockCheckBox");
            this.CastLockCheckBox.Name = "CastLockCheckBox";
            this.CastLockCheckBox.UseVisualStyleBackColor = true;
            // 
            // AudioTracksLockCheckBox
            // 
            resources.ApplyResources(this.AudioTracksLockCheckBox, "AudioTracksLockCheckBox");
            this.AudioTracksLockCheckBox.Name = "AudioTracksLockCheckBox";
            this.AudioTracksLockCheckBox.UseVisualStyleBackColor = true;
            // 
            // CoverImagesLockCheckBox
            // 
            resources.ApplyResources(this.CoverImagesLockCheckBox, "CoverImagesLockCheckBox");
            this.CoverImagesLockCheckBox.Name = "CoverImagesLockCheckBox";
            this.CoverImagesLockCheckBox.UseVisualStyleBackColor = true;
            // 
            // ProductionYearLockCheckBox
            // 
            resources.ApplyResources(this.ProductionYearLockCheckBox, "ProductionYearLockCheckBox");
            this.ProductionYearLockCheckBox.Name = "ProductionYearLockCheckBox";
            this.ProductionYearLockCheckBox.UseVisualStyleBackColor = true;
            // 
            // CountryOfOriginLockCheckBox
            // 
            resources.ApplyResources(this.CountryOfOriginLockCheckBox, "CountryOfOriginLockCheckBox");
            this.CountryOfOriginLockCheckBox.Name = "CountryOfOriginLockCheckBox";
            this.CountryOfOriginLockCheckBox.UseVisualStyleBackColor = true;
            // 
            // GenresLockCheckBox
            // 
            resources.ApplyResources(this.GenresLockCheckBox, "GenresLockCheckBox");
            this.GenresLockCheckBox.Name = "GenresLockCheckBox";
            this.GenresLockCheckBox.UseVisualStyleBackColor = true;
            // 
            // SubtitlesLockCheckBox
            // 
            resources.ApplyResources(this.SubtitlesLockCheckBox, "SubtitlesLockCheckBox");
            this.SubtitlesLockCheckBox.Name = "SubtitlesLockCheckBox";
            this.SubtitlesLockCheckBox.UseVisualStyleBackColor = true;
            // 
            // ReleaseDateLockCheckBox
            // 
            resources.ApplyResources(this.ReleaseDateLockCheckBox, "ReleaseDateLockCheckBox");
            this.ReleaseDateLockCheckBox.Name = "ReleaseDateLockCheckBox";
            this.ReleaseDateLockCheckBox.UseVisualStyleBackColor = true;
            // 
            // SrpLockCheckBox
            // 
            resources.ApplyResources(this.SrpLockCheckBox, "SrpLockCheckBox");
            this.SrpLockCheckBox.Name = "SrpLockCheckBox";
            this.SrpLockCheckBox.UseVisualStyleBackColor = true;
            // 
            // MediaCompaniesLockCheckBox
            // 
            resources.ApplyResources(this.MediaCompaniesLockCheckBox, "MediaCompaniesLockCheckBox");
            this.MediaCompaniesLockCheckBox.Name = "MediaCompaniesLockCheckBox";
            this.MediaCompaniesLockCheckBox.UseVisualStyleBackColor = true;
            // 
            // StudiosLockCheckBox
            // 
            resources.ApplyResources(this.StudiosLockCheckBox, "StudiosLockCheckBox");
            this.StudiosLockCheckBox.Name = "StudiosLockCheckBox";
            this.StudiosLockCheckBox.UseVisualStyleBackColor = true;
            // 
            // VideoFormatsLockCheckBox
            // 
            resources.ApplyResources(this.VideoFormatsLockCheckBox, "VideoFormatsLockCheckBox");
            this.VideoFormatsLockCheckBox.Name = "VideoFormatsLockCheckBox";
            this.VideoFormatsLockCheckBox.UseVisualStyleBackColor = true;
            // 
            // RegionsLockCheckBox
            // 
            resources.ApplyResources(this.RegionsLockCheckBox, "RegionsLockCheckBox");
            this.RegionsLockCheckBox.Name = "RegionsLockCheckBox";
            this.RegionsLockCheckBox.UseVisualStyleBackColor = true;
            // 
            // OverwriteGroupBox
            // 
            this.OverwriteGroupBox.Controls.Add(this.MediaTypesComboBox);
            this.OverwriteGroupBox.Controls.Add(this.MediaTypesCheckBox);
            this.OverwriteGroupBox.Controls.Add(this.OriginalTitleCheckBox);
            this.OverwriteGroupBox.Controls.Add(this.BackCoverImagesCheckBox);
            this.OverwriteGroupBox.Controls.Add(this.DiscsCheckBox);
            this.OverwriteGroupBox.Controls.Add(this.EasterEggsCheckBox);
            this.OverwriteGroupBox.Controls.Add(this.OverviewCheckBox);
            this.OverwriteGroupBox.Controls.Add(this.FeaturesCheckBox);
            this.OverwriteGroupBox.Controls.Add(this.CaseTypeCheckBox);
            this.OverwriteGroupBox.Controls.Add(this.RatingCheckBox);
            this.OverwriteGroupBox.Controls.Add(this.CrewCheckBox);
            this.OverwriteGroupBox.Controls.Add(this.CastCheckBox);
            this.OverwriteGroupBox.Controls.Add(this.AudioTracksCheckBox);
            this.OverwriteGroupBox.Controls.Add(this.FrontCoverImagesCheckBox);
            this.OverwriteGroupBox.Controls.Add(this.ProductionYearCheckBox);
            this.OverwriteGroupBox.Controls.Add(this.CountryOfOriginCheckBox);
            this.OverwriteGroupBox.Controls.Add(this.GenresCheckBox);
            this.OverwriteGroupBox.Controls.Add(this.SubtitlesCheckBox);
            this.OverwriteGroupBox.Controls.Add(this.ReleaseDateCheckBox);
            this.OverwriteGroupBox.Controls.Add(this.SrpCheckBox);
            this.OverwriteGroupBox.Controls.Add(this.MediaCompaniesCheckBox);
            this.OverwriteGroupBox.Controls.Add(this.StudiosCheckBox);
            this.OverwriteGroupBox.Controls.Add(this.VideoFormatsCheckBox);
            this.OverwriteGroupBox.Controls.Add(this.RegionsCheckBox);
            resources.ApplyResources(this.OverwriteGroupBox, "OverwriteGroupBox");
            this.OverwriteGroupBox.Name = "OverwriteGroupBox";
            this.OverwriteGroupBox.TabStop = false;
            // 
            // MediaTypesComboBox
            // 
            this.MediaTypesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MediaTypesComboBox.FormattingEnabled = true;
            this.MediaTypesComboBox.Items.AddRange(new object[] {
            resources.GetString("MediaTypesComboBox.Items"),
            resources.GetString("MediaTypesComboBox.Items1"),
            resources.GetString("MediaTypesComboBox.Items2")});
            resources.ApplyResources(this.MediaTypesComboBox, "MediaTypesComboBox");
            this.MediaTypesComboBox.Name = "MediaTypesComboBox";
            // 
            // MediaTypesCheckBox
            // 
            resources.ApplyResources(this.MediaTypesCheckBox, "MediaTypesCheckBox");
            this.MediaTypesCheckBox.Name = "MediaTypesCheckBox";
            this.MediaTypesCheckBox.UseVisualStyleBackColor = true;
            // 
            // OriginalTitleCheckBox
            // 
            resources.ApplyResources(this.OriginalTitleCheckBox, "OriginalTitleCheckBox");
            this.OriginalTitleCheckBox.Name = "OriginalTitleCheckBox";
            this.OriginalTitleCheckBox.UseVisualStyleBackColor = true;
            // 
            // BackCoverImagesCheckBox
            // 
            resources.ApplyResources(this.BackCoverImagesCheckBox, "BackCoverImagesCheckBox");
            this.BackCoverImagesCheckBox.Name = "BackCoverImagesCheckBox";
            this.BackCoverImagesCheckBox.UseVisualStyleBackColor = true;
            // 
            // DiscsCheckBox
            // 
            resources.ApplyResources(this.DiscsCheckBox, "DiscsCheckBox");
            this.DiscsCheckBox.Name = "DiscsCheckBox";
            this.DiscsCheckBox.UseVisualStyleBackColor = true;
            // 
            // EasterEggsCheckBox
            // 
            resources.ApplyResources(this.EasterEggsCheckBox, "EasterEggsCheckBox");
            this.EasterEggsCheckBox.Name = "EasterEggsCheckBox";
            this.EasterEggsCheckBox.UseVisualStyleBackColor = true;
            // 
            // OverviewCheckBox
            // 
            resources.ApplyResources(this.OverviewCheckBox, "OverviewCheckBox");
            this.OverviewCheckBox.Name = "OverviewCheckBox";
            this.OverviewCheckBox.UseVisualStyleBackColor = true;
            // 
            // FeaturesCheckBox
            // 
            resources.ApplyResources(this.FeaturesCheckBox, "FeaturesCheckBox");
            this.FeaturesCheckBox.Name = "FeaturesCheckBox";
            this.FeaturesCheckBox.UseVisualStyleBackColor = true;
            // 
            // CaseTypeCheckBox
            // 
            resources.ApplyResources(this.CaseTypeCheckBox, "CaseTypeCheckBox");
            this.CaseTypeCheckBox.Name = "CaseTypeCheckBox";
            this.CaseTypeCheckBox.UseVisualStyleBackColor = true;
            // 
            // RatingCheckBox
            // 
            resources.ApplyResources(this.RatingCheckBox, "RatingCheckBox");
            this.RatingCheckBox.Name = "RatingCheckBox";
            this.RatingCheckBox.UseVisualStyleBackColor = true;
            // 
            // CrewCheckBox
            // 
            resources.ApplyResources(this.CrewCheckBox, "CrewCheckBox");
            this.CrewCheckBox.Name = "CrewCheckBox";
            this.CrewCheckBox.UseVisualStyleBackColor = true;
            // 
            // CastCheckBox
            // 
            resources.ApplyResources(this.CastCheckBox, "CastCheckBox");
            this.CastCheckBox.Name = "CastCheckBox";
            this.CastCheckBox.UseVisualStyleBackColor = true;
            // 
            // AudioTracksCheckBox
            // 
            resources.ApplyResources(this.AudioTracksCheckBox, "AudioTracksCheckBox");
            this.AudioTracksCheckBox.Name = "AudioTracksCheckBox";
            this.AudioTracksCheckBox.UseVisualStyleBackColor = true;
            // 
            // FrontCoverImagesCheckBox
            // 
            resources.ApplyResources(this.FrontCoverImagesCheckBox, "FrontCoverImagesCheckBox");
            this.FrontCoverImagesCheckBox.Name = "FrontCoverImagesCheckBox";
            this.FrontCoverImagesCheckBox.UseVisualStyleBackColor = true;
            // 
            // ProductionYearCheckBox
            // 
            resources.ApplyResources(this.ProductionYearCheckBox, "ProductionYearCheckBox");
            this.ProductionYearCheckBox.Name = "ProductionYearCheckBox";
            this.ProductionYearCheckBox.UseVisualStyleBackColor = true;
            // 
            // CountryOfOriginCheckBox
            // 
            resources.ApplyResources(this.CountryOfOriginCheckBox, "CountryOfOriginCheckBox");
            this.CountryOfOriginCheckBox.Name = "CountryOfOriginCheckBox";
            this.CountryOfOriginCheckBox.UseVisualStyleBackColor = true;
            // 
            // GenresCheckBox
            // 
            resources.ApplyResources(this.GenresCheckBox, "GenresCheckBox");
            this.GenresCheckBox.Name = "GenresCheckBox";
            this.GenresCheckBox.UseVisualStyleBackColor = true;
            // 
            // SubtitlesCheckBox
            // 
            resources.ApplyResources(this.SubtitlesCheckBox, "SubtitlesCheckBox");
            this.SubtitlesCheckBox.Name = "SubtitlesCheckBox";
            this.SubtitlesCheckBox.UseVisualStyleBackColor = true;
            // 
            // ReleaseDateCheckBox
            // 
            resources.ApplyResources(this.ReleaseDateCheckBox, "ReleaseDateCheckBox");
            this.ReleaseDateCheckBox.Name = "ReleaseDateCheckBox";
            this.ReleaseDateCheckBox.UseVisualStyleBackColor = true;
            // 
            // SrpCheckBox
            // 
            resources.ApplyResources(this.SrpCheckBox, "SrpCheckBox");
            this.SrpCheckBox.Name = "SrpCheckBox";
            this.SrpCheckBox.UseVisualStyleBackColor = true;
            // 
            // MediaCompaniesCheckBox
            // 
            resources.ApplyResources(this.MediaCompaniesCheckBox, "MediaCompaniesCheckBox");
            this.MediaCompaniesCheckBox.Name = "MediaCompaniesCheckBox";
            this.MediaCompaniesCheckBox.UseVisualStyleBackColor = true;
            // 
            // StudiosCheckBox
            // 
            resources.ApplyResources(this.StudiosCheckBox, "StudiosCheckBox");
            this.StudiosCheckBox.Name = "StudiosCheckBox";
            this.StudiosCheckBox.UseVisualStyleBackColor = true;
            // 
            // VideoFormatsCheckBox
            // 
            resources.ApplyResources(this.VideoFormatsCheckBox, "VideoFormatsCheckBox");
            this.VideoFormatsCheckBox.Name = "VideoFormatsCheckBox";
            this.VideoFormatsCheckBox.UseVisualStyleBackColor = true;
            // 
            // RegionsCheckBox
            // 
            resources.ApplyResources(this.RegionsCheckBox, "RegionsCheckBox");
            this.RegionsCheckBox.Name = "RegionsCheckBox";
            this.RegionsCheckBox.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForUpdatesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            resources.ApplyResources(this.checkForUpdatesToolStripMenuItem, "checkForUpdatesToolStripMenuItem");
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.OnCheckForUpdatesToolStripMenuItemClick);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnAboutToolStripMenuItemClick);
            // 
            // MainForm
            // 
            this.AcceptButton = this.OkButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.AbortButton;
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.AbortButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnMainFormClosing);
            this.Load += new System.EventHandler(this.OnMainFormLoad);
            this.TabControl.ResumeLayout(false);
            this.PublicTabPage.ResumeLayout(false);
            this.SetLockOnEntireGroupBox.ResumeLayout(false);
            this.SetLockOnEntireGroupBox.PerformLayout();
            this.SetLockOnGroupBox.ResumeLayout(false);
            this.SetLockOnGroupBox.PerformLayout();
            this.OverwriteGroupBox.ResumeLayout(false);
            this.OverwriteGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button AbortButton;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage PublicTabPage;
        private System.Windows.Forms.GroupBox SetLockOnEntireGroupBox;
        private System.Windows.Forms.CheckBox EntireDvdLockCheckBox;
        private System.Windows.Forms.GroupBox SetLockOnGroupBox;
        private System.Windows.Forms.CheckBox DiscsLockCheckBox;
        private System.Windows.Forms.CheckBox MediaTypesLockCheckBox;
        private System.Windows.Forms.CheckBox EasterEggsLockCheckBox;
        private System.Windows.Forms.CheckBox CaseTypeLockCheckBox;
        private System.Windows.Forms.CheckBox OverviewLockCheckBox;
        private System.Windows.Forms.CheckBox FeaturesLockCheckBox;
        private System.Windows.Forms.CheckBox RatingLockCheckBox;
        private System.Windows.Forms.CheckBox CrewLockCheckBox;
        private System.Windows.Forms.CheckBox CastLockCheckBox;
        private System.Windows.Forms.CheckBox AudioTracksLockCheckBox;
        private System.Windows.Forms.CheckBox CoverImagesLockCheckBox;
        private System.Windows.Forms.CheckBox ProductionYearLockCheckBox;
        private System.Windows.Forms.CheckBox CountryOfOriginLockCheckBox;
        private System.Windows.Forms.CheckBox GenresLockCheckBox;
        private System.Windows.Forms.CheckBox SubtitlesLockCheckBox;
        private System.Windows.Forms.CheckBox ReleaseDateLockCheckBox;
        private System.Windows.Forms.CheckBox SrpLockCheckBox;
        private System.Windows.Forms.CheckBox MediaCompaniesLockCheckBox;
        private System.Windows.Forms.CheckBox StudiosLockCheckBox;
        private System.Windows.Forms.CheckBox VideoFormatsLockCheckBox;
        private System.Windows.Forms.CheckBox RegionsLockCheckBox;
        private System.Windows.Forms.GroupBox OverwriteGroupBox;
        private System.Windows.Forms.CheckBox DiscsCheckBox;
        private System.Windows.Forms.CheckBox EasterEggsCheckBox;
        private System.Windows.Forms.CheckBox OverviewCheckBox;
        private System.Windows.Forms.CheckBox FeaturesCheckBox;
        private System.Windows.Forms.CheckBox CaseTypeCheckBox;
        private System.Windows.Forms.CheckBox RatingCheckBox;
        private System.Windows.Forms.CheckBox CrewCheckBox;
        private System.Windows.Forms.CheckBox CastCheckBox;
        private System.Windows.Forms.CheckBox AudioTracksCheckBox;
        private System.Windows.Forms.CheckBox FrontCoverImagesCheckBox;
        private System.Windows.Forms.CheckBox ProductionYearCheckBox;
        private System.Windows.Forms.CheckBox CountryOfOriginCheckBox;
        private System.Windows.Forms.CheckBox GenresCheckBox;
        private System.Windows.Forms.CheckBox SubtitlesCheckBox;
        private System.Windows.Forms.CheckBox ReleaseDateCheckBox;
        private System.Windows.Forms.CheckBox SrpCheckBox;
        private System.Windows.Forms.CheckBox MediaCompaniesCheckBox;
        private System.Windows.Forms.CheckBox StudiosCheckBox;
        private System.Windows.Forms.CheckBox VideoFormatsCheckBox;
        private System.Windows.Forms.CheckBox RegionsCheckBox;
        private System.Windows.Forms.CheckBox OriginalTitleCheckBox;
        private System.Windows.Forms.CheckBox BackCoverImagesCheckBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.CheckBox OriginalTitleLockCheckBox;
        private System.Windows.Forms.CheckBox MediaTypesCheckBox;
        private System.Windows.Forms.ComboBox MediaTypesComboBox;


    }
}