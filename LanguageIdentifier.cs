using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using PluginContracts;
using OutputHelperLib;
using IvanAkcheurov.NTextCat.Lib;
using System.IO;
using System.Linq;

namespace LanguageIdentifier
{
    public class LanguageIdentifier : Plugin
    {


        public Dictionary<int, string> OutputHeaderData { get; set; } = new Dictionary<int, string>() { { 0, "Language_NaiveBayes" },
                                                                                                        { 1, "Language_RankedChoice"}
                                                                                                      };

        public bool InheritHeader { get; } = false;


        private string _identifierFile { get; set; } = @"..\..\..\LanguageModels\Core14.profile.xml";

        public static string ModelFolder = Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory),
                                        "Plugins" + Path.DirectorySeparatorChar +
                                        "Dependencies" + Path.DirectorySeparatorChar + "NCatLibModels");

        private string SelectedModel { get; set; } = "Wiki82.profile.xml";

        private NaiveBayesLanguageIdentifierFactory NBFactory;
        private RankedLanguageIdentifierFactory RLFactory;
        private NaiveBayesLanguageIdentifier NBIdentifier;
        private RankedLanguageIdentifier RLIdentifier;








        #region Plugin Details and Info

        public string PluginName { get; } = "Identify Text Language";
        public string PluginType { get; } = "Language Analysis";
        public string PluginVersion { get; } = "1.0.2";
        public string PluginAuthor { get; } = "Ryan L. Boyd (ryan@ryanboyd.io)";
        public string PluginDescription { get; } = "This plugin tries to algorithmically determine the language of an incoming text using two different approaches. Built on top of the NTextCat library (version 0.2.1.1), you can select one of several pretrained models that are more/less conservative for more accurate classification. Works best with longer texts, recommended input texts should be a *minimum* of 5 characters long." + Environment.NewLine + Environment.NewLine +
            "https://archive.codeplex.com/?p=ntextcat" + Environment.NewLine + Environment.NewLine +
            "Output is in the form of ISO 639-2 codes. More information on these codes can be found here:" + Environment.NewLine + Environment.NewLine +
            "https://en.wikipedia.org/wiki/List_of_ISO_639-2_codes";
        public string[] InputType { get; } = { "String" };
        public string OutputType { get; } = "OutputArray";
        public string PluginTutorial { get; } = "https://youtu.be/Q6ADOD1L-9Q";
        public bool TopLevel { get; } = false;


        public Icon GetPluginIcon
        {
            get
            {
                return Properties.Resources.icon;
            }
        }

        #endregion



        public void ChangeSettings()
        {

            using (var form = new SettingsForm_LanguageIdentifier(SelectedModel))
            {

                form.Icon = Properties.Resources.icon;
                form.Text = PluginName;


                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    SelectedModel = form.LanguageModel;
                }
            }

        }





        public Payload RunPlugin(Payload Input)
        {



            Payload pData = new Payload();
            pData.FileID = Input.FileID;
            pData.SegmentID = Input.SegmentID;



            for (int i = 0; i < Input.StringList.Count; i++)
            {
                if (Input.StringList[i].Length > 0)
                {
                    var NB_Data = NBIdentifier.Identify(Input.StringList[i]);
                    var RL_Data = RLIdentifier.Identify(Input.StringList[i]);

                    pData.StringArrayList.Add(new string[2] { NB_Data.First().Item1.Iso639_2T.Replace("simple", "en"), RL_Data.First().Item1.Iso639_2T.Replace("simple", "en") });
                }
                else
                {
                    pData.StringArrayList.Add(new string[2] { "", "" });
                }

                pData.SegmentNumber.Add(Input.SegmentNumber[i]);

            }

            return (pData);



        }



        public void Initialize()
        {
            NBFactory = new NaiveBayesLanguageIdentifierFactory();
            RLFactory = new RankedLanguageIdentifierFactory();
            NBIdentifier = NBFactory.Load(Path.Combine(ModelFolder, SelectedModel));
            RLIdentifier = RLFactory.Load(Path.Combine(ModelFolder, SelectedModel));

        }


        public bool InspectSettings()
        {
            return true;
        }



        public Payload FinishUp(Payload Input)
        {
            return (Input);
        }


        #region Import/Export Settings
        public void ImportSettings(Dictionary<string, string> SettingsDict)
        {
            SelectedModel = SettingsDict["SelectedModel"];
        }

        public Dictionary<string, string> ExportSettings(bool suppressWarnings)
        {
            Dictionary<string, string> SettingsDict = new Dictionary<string, string>();
            SettingsDict.Add("SelectedModel", SelectedModel);
            return (SettingsDict);
        }
        #endregion



    }
}
