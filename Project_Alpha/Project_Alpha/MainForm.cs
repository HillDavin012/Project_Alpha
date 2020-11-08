using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Data.SqlClient;
using System.Configuration;

namespace Project_Alpha
{
   public partial class MainForm : Form
   {
      SpeechRecognitionEngine speechRecognitionEngine = new SpeechRecognitionEngine();
      SpeechSynthesizer Eva = new SpeechSynthesizer();

      public MainForm()
      {
         InitializeComponent();
         speechRecognitionEngine = SetLanguage ("en-US");
         speechRecognitionEngine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(MainEvent_SpeechRecongnized);
         LoadGrammerAndCommands();
         speechRecognitionEngine.SetInputToDefaultAudioDevice();
         speechRecognitionEngine.RecognizeAsync(RecognizeMode.Multiple);
      }

      private void LoadGrammerAndCommands()
      {
         try
         {
            string connectionstring = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand sc = new SqlCommand();
            sc.Connection = con;
            sc.CommandText = "SELECT * FROM MyTable";
            SqlDataReader sdr = sc.ExecuteReader();
            while (sdr.Read())
            {
               var Loadcmd = sdr["EvaSocialCommands"].ToString();
               Grammar commandgrammer = new Grammar(new GrammarBuilder(new Choices(Loadcmd)));
               rec.LoadGrammerAsync(commandgrammer);
            }
            sdr.Close();
            con.Close();
         }
         catch(Exception ex) 
         {
            Eva.SpeakAsync("I've detected an invalid entry in your web commands, possibly a blank line. We commands will cease to work until it is fixed." + ex.Message); ;
         }
      }

      private void MainEvent_SpeechRecongnized(object sender, SpeechRecognizedEventArgs e)
      {
         string speech = e.Result.Text;
         string name = Environment.UserName;

         switch (speech) 
         {
            case "hello":
               Eva.SpeakAsync("Hello my name is " + name);
               break;
/*
            case "What time is it":
            case "What day is it":
            case "What is the date":
            case "What is todays date"
            case "Who are you"  
*/
         }
      }

      private SpeechRecognitionEngine SetLanguage(string preferreCulture)
      {
         foreach (RecognizerInfo config in SpeechRecognitionEngine.InstalledRecognizers())
         {
            if (config.Culture.ToString() == preferreCulture) 
            {
               speechRecognitionEngine = new SpeechRecognitionEngine(config);
               break;
            }
         }

         if (speechRecognitionEngine == null) 
         {
            MessageBox.Show("The desired culture is not installed on this machine, the speech-engine will continue using " +
               SpeechRecognitionEngine.InstalledRecognizers()[0].Culture.ToString() + " as the default culture. ",
               "Culture " + preferreCulture + " not found!");
            speechRecognitionEngine = new SpeechRecognitionEngine(SpeechRecognitionEngine.InstalledRecognizers()[0]);
         }

         return speechRecognitionEngine;
      }

      private void LeftSideMenuBtn_Click(object sender, EventArgs e)
      {
         if (LeftSideMenu.Width == 40)
         {
            LeftSideMenu.Width = 160;
         }
         else
         {
            LeftSideMenu.Width = 40;
         }
      }

      private void RightSideMenuBtn_Click(object sender, EventArgs e)
      {
         if (RightSideMenu.Width == 60)
         {
            RightSideMenu.Width = 260;
         }
         else
         {
            RightSideMenu.Width = 60;
         }
      }

      private void MainForm_Load(object sender, EventArgs e)
      {
         LeftSideMenu.Width = 160;
         RightSideMenu.Width = 160;
         Debug_Livetxt.SelectionIndent += 20;
      }
   }
}
