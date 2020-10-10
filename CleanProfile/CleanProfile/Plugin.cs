using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DoenaSoft.DVDProfiler.DVDProfilerHelper;
using Invelos.DVDProfilerPlugin;

namespace DoenaSoft.DVDProfiler.CleanProfile
{
    /// <summary>
    /// Summary description for HelloWorld.
    /// </summary>
    /// 
    [ComVisible(true)]
    [Guid("42F36A4A-D7B4-4D6C-9356-493F07570E12")]
    public class Plugin : IDVDProfilerPlugin, IDVDProfilerPluginInfo
    {
        internal static Settings Settings;

        private readonly String SettingsFile;

        private readonly String ErrorFile;

        private readonly String ApplicationPath;

        private IDVDProfilerAPI Api;

        private const Int32 MenuId = 1;

        private String MenuTokenISCP = "";

        public Plugin()
        {
            this.ApplicationPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Doena Soft\CleanProfileSettings\";
            this.SettingsFile = ApplicationPath + "CleanProfileSettings.xml";
            this.ErrorFile = Environment.GetEnvironmentVariable("TEMP") + @"\CleanProfileCrash.xml";
        }

        public void Load(IDVDProfilerAPI api)
        {
            this.Api = api;
            if (Directory.Exists(this.ApplicationPath) == false)
            {
                Directory.CreateDirectory(this.ApplicationPath);
            }
            if (File.Exists(this.SettingsFile))
            {
                try
                {
                    Settings = Settings.Deserialize(this.SettingsFile);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(String.Format(MessageBoxTexts.FileCantBeRead, this.SettingsFile, ex.Message)
                        , MessageBoxTexts.ErrorHeader, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            CreateSettings();
            this.Api.RegisterForEvent(PluginConstants.EVENTID_FormCreated);
            MenuTokenISCP = this.Api.RegisterMenuItem(PluginConstants.FORMID_Main, PluginConstants.MENUID_Form
                , @"DVD", "Clean Profile", MenuId);
        }

        public void Unload()
        {
            this.Api.UnregisterMenuItem(MenuTokenISCP);
            try
            {
                Settings.Serialize(this.SettingsFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format(MessageBoxTexts.FileCantBeWritten, this.SettingsFile, ex.Message)
                    , MessageBoxTexts.ErrorHeader, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Api = null;
        }

        public void HandleEvent(Int32 EventType, Object EventData)
        {
            if (EventType == PluginConstants.EVENTID_CustomMenuClick)
            {
                this.HandleMenuClick((Int32)EventData);
            }
        }

        #region IDVDProfilerPluginInfo Members
        public String GetName()
        {
            return (Texts.PluginName);
        }

        public String GetDescription()
        {
            return (Texts.PluginDescription);
        }

        public String GetAuthorName()
        {
            return ("Doena Soft.");
        }

        public String GetAuthorWebsite()
        {
            return (Texts.PluginUrl);
        }

        public Int32 GetPluginAPIVersion()
        {
            return (PluginConstants.API_VERSION);
        }

        public Int32 GetVersionMajor()
        {
            Version version;

            version = System.Reflection.Assembly.GetAssembly(this.GetType()).GetName().Version;
            return (version.Major);
        }

        public Int32 GetVersionMinor()
        {
            Version version;

            version = System.Reflection.Assembly.GetAssembly(this.GetType()).GetName().Version;
            return (version.Minor * 100 + version.Build * 10 + version.Revision);
        }
        #endregion

        private void HandleMenuClick(Int32 MenuEventID)
        {
            if (MenuEventID == MenuId)
            {
                try
                {
                    using (MainForm mainForm = new MainForm(this.Api))
                    {
                        mainForm.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    try
                    {
                        ExceptionXml exceptionXml;

                        MessageBox.Show(String.Format(MessageBoxTexts.CriticalError, ex.Message, this.ErrorFile)
                            , MessageBoxTexts.CriticalErrorHeader, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        if (File.Exists(this.ErrorFile))
                        {
                            File.Delete(ErrorFile);
                        }
                        exceptionXml = new ExceptionXml(ex);
                        DVDProfilerSerializer<ExceptionXml>.Serialize(ErrorFile, exceptionXml);
                    }
                    catch (Exception inEx)
                    {
                        MessageBox.Show(String.Format(MessageBoxTexts.FileCantBeWritten, this.ErrorFile, inEx.Message)
                            , MessageBoxTexts.ErrorHeader, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private static void CreateSettings()
        {
            if (Settings == null)
            {
                Settings = new Settings();
            }
            if (Settings.MainForm == null)
            {
                Settings.MainForm = new SizableForm();
            }
            if (Settings.DefaultValues == null)
            {
                Settings.DefaultValues = new DefaultValues();
            }
        }

        #region Plugin Registering
        [DllImport("user32.dll")]
        public extern static int SetParent(int child, int parent);

        [ComImport(), Guid("0002E005-0000-0000-C000-000000000046")]
        internal class StdComponentCategoriesMgr { }

        [ComRegisterFunction()]
        public static void RegisterServer(Type t)
        {
            CategoryRegistrar.ICatRegister cr = (CategoryRegistrar.ICatRegister)new StdComponentCategoriesMgr();
            Guid clsidThis = new Guid("42F36A4A-D7B4-4D6C-9356-493F07570E12");
            Guid catid = new Guid("833F4274-5632-41DB-8FC5-BF3041CEA3F1");

            cr.RegisterClassImplCategories(ref clsidThis, 1,
                new Guid[] { catid });
        }

        [ComUnregisterFunction()]
        public static void UnregisterServer(Type t)
        {
            CategoryRegistrar.ICatRegister cr = (CategoryRegistrar.ICatRegister)new StdComponentCategoriesMgr();
            Guid clsidThis = new Guid("42F36A4A-D7B4-4D6C-9356-493F07570E12");
            Guid catid = new Guid("833F4274-5632-41DB-8FC5-BF3041CEA3F1");

            cr.UnRegisterClassImplCategories(ref clsidThis, 1,
                new Guid[] { catid });
        }
        #endregion
    }
}