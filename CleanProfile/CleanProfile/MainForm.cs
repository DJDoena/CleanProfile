using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using DoenaSoft.DVDProfiler.DVDProfilerHelper;
using Invelos.DVDProfilerPlugin;

namespace DoenaSoft.DVDProfiler.CleanProfile
{
    internal partial class MainForm : Form
    {
        #region Fields
        private IDVDProfilerAPI Api;
        #endregion

        #region Constructor
        public MainForm(IDVDProfilerAPI api)
        {
            this.Api = api;
            InitializeComponent();
        }
        #endregion

        #region Form Events
        private void OnAboutToolStripMenuItemClick(Object sender, EventArgs e)
        {
            using (AboutBox aboutBox = new AboutBox(this.GetType().Assembly))
            {
                aboutBox.ShowDialog();
            }
        }

        private void OnCheckForUpdatesToolStripMenuItemClick(Object sender, EventArgs e)
        {
            this.CheckForNewVersion();
        }

        private void OnMainFormLoad(Object sender, EventArgs e)
        {
            this.SuspendLayout();
            this.LayoutForm();
            this.ResumeLayout();
            if (Plugin.Settings.CurrentVersion != this.GetType().Assembly.GetName().Version.ToString())
            {
                Plugin.Settings.CurrentVersion = this.GetType().Assembly.GetName().Version.ToString();
            }
        }

        private void OnMainFormClosing(Object sender, FormClosingEventArgs e)
        {
            this.WriteDefaultValues();
        }

        private void OnOkButtonClick(Object sender, EventArgs e)
        {
            IDVDInfo profile;

            profile = this.Api.GetDisplayedDVD();
            if (profile.GetProfileID() != null)
            {
                this.Api.DVDByProfileID(out profile, profile.GetProfileID(), -1, -1);
                this.DoProfileCleaning(profile);
                this.Api.SaveDVDToCollection(profile);
                this.Api.UpdateProfileInListDisplay(profile.GetProfileID());
                this.Api.RequeryDatabase();
            }
            this.Close();
        }

        private void OnAbortButtonClick(Object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnEntireDvdLockCheckBoxCheckedChanged(Object sender, EventArgs e)
        {
            this.SetLockOnGroupBox.Enabled = (this.EntireDvdLockCheckBox.Checked == false);
        }
        #endregion

        #region Helper Functions
        private void DoProfileCleaning(IDVDInfo profile)
        {
            #region Media Types
            if (this.MediaTypesCheckBox.Checked)
            {
                switch (this.MediaTypesComboBox.Text)
                {
                    case ("DVD"):
                        {
                            profile.SetMediaTypes(true, false, false, false);
                            break;
                        }
                    case ("BR"):
                        {
                            profile.SetMediaTypes(false, false, true, false);
                            break;
                        }
                    case ("DVD+BR"):
                        {
                            profile.SetMediaTypes(true, false, true, false);
                            break;
                        }
                    case ("UltraHD"):
                        {
                            profile.SetMediaTypes(false, false, false, true);
                            break;
                        }
                    case ("BR+UltraHD"):
                        {
                            profile.SetMediaTypes(false, false, true, true);
                            break;
                        }
                }
                profile.SetCustomMediaType(null);
            }
            if (this.MediaTypesLockCheckBox.Checked)
            {
                profile.SetLockByID(PluginConstants.LOCK_MediaTypes, true);
            }
            #endregion
            #region Original Title
            if (this.OriginalTitleCheckBox.Checked)
            {
                profile.SetOriginalTitle(String.Empty);
            }
            if (this.CountryOfOriginLockCheckBox.Checked)
            {
                //
            }
            #endregion
            #region Production Year
            if (this.ProductionYearCheckBox.Checked)
            {
                profile.SetProductionYear(0);
            }
            if (this.ProductionYearLockCheckBox.Checked)
            {
                profile.SetLockByID(PluginConstants.LOCK_ProductionYear, true);
            }
            #endregion
            #region Country of Origin
            if (this.CountryOfOriginCheckBox.Checked)
            {
                for (Int32 c = 1; c < 4; c++)
                {
                    profile.SetCountryOfOrigin(c, -1);
                }
            }
            if (this.CountryOfOriginLockCheckBox.Checked)
            {
                //
            }
            #endregion
            #region Rating
            if (this.RatingCheckBox.Checked)
            {
                profile.SetRating(0, -1, -1);
                profile.SetRatingDescription(String.Empty);
            }
            if (this.RatingLockCheckBox.Checked)
            {
                profile.SetLockByID(PluginConstants.LOCK_Rating, true);
            }
            #endregion
            #region Regions
            if (this.RegionsCheckBox.Checked)
            {
                for (Int32 r = 0; r < 7; r++)
                {
                    profile.SetRegionByID(r, false);
                }
            }
            if (this.RegionsLockCheckBox.Checked)
            {
                profile.SetLockByID(PluginConstants.LOCK_Regions, true);
            }
            #endregion
            #region Release Date
            if (this.ReleaseDateCheckBox.Checked)
            {
                profile.SetDVDReleaseDate(new DateTime());
            }
            if (this.ReleaseDateLockCheckBox.Checked)
            {
                profile.SetLockByID(PluginConstants.LOCK_ReleaseDate, true);
            }
            #endregion
            #region Case Type
            if (this.CaseTypeCheckBox.Checked)
            {
                profile.SetCaseID(-1);
                profile.SetCaseSlipCover(false);
            }
            if (this.CaseTypeLockCheckBox.Checked)
            {
                profile.SetLockByID(PluginConstants.LOCK_CaseType, true);
            }
            #endregion
            #region SRP
            if (this.SrpCheckBox.Checked)
            {
                profile.SetSRPValue(0);
                profile.SetSRPCurrency(-1);
            }
            if (this.SrpLockCheckBox.Checked)
            {
                profile.SetLockByID(PluginConstants.LOCK_PurchasePrice, true);
            }
            #endregion
            #region Genres
            if (this.GenresCheckBox.Checked)
            {
                for (Int32 g = 1; g < 6; g++)
                {
                    profile.SetGenre(g, -1);
                }
            }
            if (this.GenresLockCheckBox.Checked)
            {
                profile.SetLockByID(PluginConstants.LOCK_Genres, true);
            }
            #endregion
            #region Video Formats
            if (this.VideoFormatsCheckBox.Checked)
            {
                profile.SetAspectRatio(String.Empty);
                profile.SetFormatAnamorphic(false);
                profile.SetFormatFullFrame(false);
                profile.SetFormatPanScan(false);
                profile.SetFormatWidescreen(false);
                profile.SetVideoStandard(-1);
                profile.SetColorType(0);
                profile.SetDimensions(false, false, false);
            }
            if (this.VideoFormatsLockCheckBox.Checked)
            {
                profile.SetLockByID(PluginConstants.LOCK_VideoFormats, true);
            }
            #endregion
            #region Studios
            if (this.StudiosCheckBox.Checked)
            {
                for (Int32 s = 1; s < 4; s++)
                {
                    profile.SetStudio(s, String.Empty);
                }
            }
            if (this.StudiosLockCheckBox.Checked)
            {
                profile.SetLockByID(PluginConstants.LOCK_Studios, true);
            }
            #endregion
            #region Media Companies
            if (this.MediaCompaniesCheckBox.Checked)
            {
                for (Int32 mc = 1; mc < 4; mc++)
                {
                    profile.SetMediaCompany(mc, String.Empty);
                }
            }
            if (this.MediaCompaniesLockCheckBox.Checked)
            {
                //
            }
            #endregion
            #region Features
            if (this.FeaturesCheckBox.Checked)
            {
                SetFeature(profile, PluginConstants.FEATURE_SceneAccess);
                SetFeature(profile, PluginConstants.FEATURE_Trailer);
                SetFeature(profile, PluginConstants.FEATURE_BonusTrailers);

                SetFeature(profile, PluginConstants.FEATURE_Documentary); // Featurettes
                SetFeature(profile, PluginConstants.FEATURE_Commentary);
                SetFeature(profile, PluginConstants.FEATURE_DeletedScenes);
                SetFeature(profile, PluginConstants.FEATURE_Interviews);
                SetFeature(profile, PluginConstants.FEATURE_Bloopers);

                SetFeature(profile, PluginConstants.FEATURE_StoryboardComps);
                SetFeature(profile, PluginConstants.FEATURE_Gallery);
                SetFeature(profile, PluginConstants.FEATURE_ProductionNotes);

                SetFeature(profile, PluginConstants.FEATURE_DVDROMContent);
                SetFeature(profile, PluginConstants.FEATURE_InteractiveGame);
                SetFeature(profile, PluginConstants.FEATURE_MultiAngle);
                SetFeature(profile, PluginConstants.FEATURE_MusicVideos);

                SetFeature(profile, PluginConstants.FEATURE_THX);
                SetFeature(profile, PluginConstants.FEATURE_ClosedCaptioned);

                SetFeature(profile, PluginConstants.FEATURE_DigitalCopy);
                SetFeature(profile, PluginConstants.FEATURE_PIP);
                SetFeature(profile, PluginConstants.FEATURE_BDLive);

                SetFeature(profile, PluginConstants.FEATURE_CineChat);
                SetFeature(profile, PluginConstants.FEATURE_DBOX);
                SetFeature(profile, PluginConstants.FEATURE_MovieIQ);
                SetFeature(profile, PluginConstants.FEATURE_PlayAll);

                profile.SetOtherFeatures(String.Empty);
            }
            if (this.FeaturesLockCheckBox.Checked)
            {
                profile.SetLockByID(PluginConstants.LOCK_Studios, true);
            }
            #endregion
            #region Audio Tracks
            if (this.AudioTracksCheckBox.Checked)
            {
                for (Int32 a = 1; a < 17; a++)
                {
                    profile.SetAudioTrack(a, -1, -1, -1);
                }
            }
            if (this.AudioTracksLockCheckBox.Checked)
            {
                profile.SetLockByID(PluginConstants.LOCK_AudioTracks, true);
            }
            #endregion
            #region Subtitles
            if (this.SubtitlesCheckBox.Checked)
            {
                profile.ClearSubtitles();
            }
            if (this.SubtitlesLockCheckBox.Checked)
            {
                profile.SetLockByID(PluginConstants.LOCK_Subtitles, true);
            }
            #endregion
            #region Cast
            if (this.CastCheckBox.Checked)
            {
                profile.ClearCast();
            }
            if (this.CastLockCheckBox.Checked)
            {
                profile.SetLockByID(PluginConstants.LOCK_Cast, true);
            }
            #endregion
            #region Crew
            if (this.CrewCheckBox.Checked)
            {
                profile.ClearCrew();
            }
            if (this.CrewLockCheckBox.Checked)
            {
                profile.SetLockByID(PluginConstants.LOCK_Crew, true);
            }
            #endregion
            #region Overview
            if (this.OverviewCheckBox.Checked)
            {
                profile.SetOverview(String.Empty);
            }
            if (this.OverviewLockCheckBox.Checked)
            {
                profile.SetLockByID(PluginConstants.LOCK_Overview, true);
            }
            #endregion
            #region Easter Eggs
            if (this.EasterEggsCheckBox.Checked)
            {
                profile.SetEasterEggs(String.Empty);
            }
            if (this.EasterEggsLockCheckBox.Checked)
            {
                profile.SetLockByID(PluginConstants.LOCK_EasterEggs, true);
            }
            #endregion
            #region Discs
            if (this.DiscsCheckBox.Checked)
            {
                profile.ClearDiscs();
            }
            if (this.DiscsLockCheckBox.Checked)
            {
                profile.SetLockByID(PluginConstants.LOCK_DiscInformation, true);
            }
            #endregion
            #region Cover Images
            if (this.FrontCoverImagesCheckBox.Checked)
            {
                String source;

                source = profile.GetCoverImageFilename(true, false);
                DeleteCover(source);
                source = profile.GetCoverImageFilename(true, true);
                DeleteCover(source);
            }
            if (this.BackCoverImagesCheckBox.Checked)
            {
                String source;

                source = profile.GetCoverImageFilename(false, false);
                DeleteCover(source);
                source = profile.GetCoverImageFilename(false, true);
                DeleteCover(source);
            }
            if (this.CoverImagesLockCheckBox.Checked)
            {
                profile.SetLockByID(PluginConstants.LOCK_Scans, true);
            }
            #endregion
            #region Entire DVD Lock
            if (this.EntireDvdLockCheckBox.Checked)
            {
                profile.SetLockByID(PluginConstants.LOCK_Entire, true);
            }
            #endregion
        }

        private static void DeleteCover(String source)
        {
            if (File.Exists(source))
            {
                File.Delete(source);
            }
        }

        private static void SetFeature(IDVDInfo profile, Int32 feature)
        {
            profile.SetFeatureByID(feature, false);
        }

        private void CheckForNewVersion()
        {
            OnlineAccess.Init("Doena Soft.", "CleanProfile");
            OnlineAccess.CheckForNewVersion("http://doena-soft.de/dvdprofiler/3.9.0/versions.xml", this, "CleanProfile", this.GetType().Assembly);
        }

        private void LayoutForm()
        {
            if (Plugin.Settings.MainForm.WindowState == FormWindowState.Normal)
            {
                this.Left = Plugin.Settings.MainForm.Left;
                this.Top = Plugin.Settings.MainForm.Top;
                if (Plugin.Settings.MainForm.Width > this.MinimumSize.Width)
                {
                    this.Width = Plugin.Settings.MainForm.Width;
                }
                else
                {
                    this.Width = this.MinimumSize.Width;
                }
                if (Plugin.Settings.MainForm.Height > this.MinimumSize.Height)
                {
                    this.Height = Plugin.Settings.MainForm.Height;
                }
                else
                {
                    this.Height = this.MinimumSize.Height;
                }
            }
            else
            {
                this.Left = Plugin.Settings.MainForm.RestoreBounds.X;
                this.Top = Plugin.Settings.MainForm.RestoreBounds.Y;
                if (Plugin.Settings.MainForm.RestoreBounds.Width > this.MinimumSize.Width)
                {
                    this.Width = Plugin.Settings.MainForm.RestoreBounds.Width;
                }
                else
                {
                    this.Width = this.MinimumSize.Width;
                }
                if (Plugin.Settings.MainForm.RestoreBounds.Height > this.MinimumSize.Height)
                {
                    this.Height = Plugin.Settings.MainForm.RestoreBounds.Height;
                }
                else
                {
                    this.Height = this.MinimumSize.Height;
                }
            }
            if (Plugin.Settings.MainForm.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = Plugin.Settings.MainForm.WindowState;
            }
            this.ReadDefaultValues();
        }

        private void WriteDefaultValues()
        {
            Type defaultValuesType;
            FieldInfo[] defaultFields;
            Type mainFormType;

            defaultValuesType = typeof(DefaultValues);
            mainFormType = this.GetType();
            defaultFields = defaultValuesType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            foreach (FieldInfo defaultFieldInfo in defaultFields)
            {
                FieldInfo fieldInfo;
                CheckBox checkBox;

                if (defaultFieldInfo.Name != "DefaultMediaTypes")
                {
                    fieldInfo = mainFormType.GetField(defaultFieldInfo.Name + "CheckBox"
                        , BindingFlags.NonPublic | BindingFlags.Instance);
                    checkBox = (CheckBox)(fieldInfo.GetValue(this));
                    defaultFieldInfo.SetValue(Plugin.Settings.DefaultValues, checkBox.Checked);
                }
            }
            Plugin.Settings.DefaultValues.DefaultMediaTypes = this.MediaTypesComboBox.Text;
        }

        private void ReadDefaultValues()
        {
            Type defaultValuesType;
            FieldInfo[] defaultFields;
            Type mainFormType;

            defaultValuesType = typeof(DefaultValues);
            mainFormType = this.GetType();
            defaultFields = defaultValuesType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            foreach (FieldInfo defaultFieldInfo in defaultFields)
            {
                FieldInfo fieldInfo;
                CheckBox checkBox;

                if (defaultFieldInfo.Name != "DefaultMediaTypes")
                {
                    fieldInfo = mainFormType.GetField(defaultFieldInfo.Name + "CheckBox"
                        , BindingFlags.NonPublic | BindingFlags.Instance);
                    checkBox = (CheckBox)(fieldInfo.GetValue(this));
                    checkBox.Checked = (Boolean)(defaultFieldInfo.GetValue(Plugin.Settings.DefaultValues));
                }
            }
            this.MediaTypesComboBox.Text = Plugin.Settings.DefaultValues.DefaultMediaTypes;
        }
        #endregion
    }
}