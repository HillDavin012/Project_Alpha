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
            try
            {
                // Set the language for speech engine
                speechRecognitionEngine = SetLanguage("en-US");
                //Event handler for recognized text 
                speechRecognitionEngine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Mainevent_SpeechRecognized);
                //This is for speak completed event
                Eva.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(speak_completed);
                //Event for load grammar for speech engine 
                LoadGrammarAndCommands();
                // Using the system's default microphone
                speechRecognitionEngine.SetInputToDefaultAudioDevice();
                // Start listening 
                speechRecognitionEngine.RecognizeAsync(RecognizeMode.Multiple);
                Eva.SelectVoiceByHints(VoiceGender.Female);//("Zira");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Eva.SelectVoice("Zira");
           // speechRecognitionEngine = VoiceGender.Female;
            //speechRecognitionEngine = VoiceGender.Female;
            //speechRecognitionEngine = VoiceGender.Female;
            //System.Speech.Synthesis
      }

        private void speak_completed(object sender, SpeakCompletedEventArgs e)
        {
            //ReadBtn.Enabled = true;
        }

        private void Mainevent_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            //System Username 
            string Name = Environment.UserName;
            //Recognized Spoken words result is e.Result.Text
            string speech = e.Result.Text;
            //Debug_Livetxt.Text += "You said : " + e.Result.Text + "\n";
            //Switch to e.Result.Text
            switch (speech)
            {
                //Greetings
                case "hello":
                    Eva.SpeakAsync("hello Dauvin" + Name);
                    System.DateTime timenow = System.DateTime.Now;
                    if (timenow.Hour >= 5 && timenow.Hour < 12)
                    { Eva.SpeakAsync("Goodmorning " + Name); }
                    if (timenow.Hour >= 12 && timenow.Hour < 18)
                    { Eva.SpeakAsync("Good afternoon " + Name); }
                    if (timenow.Hour >= 18 && timenow.Hour < 24)
                    { Eva.SpeakAsync("Good evening " + Name); }
                    if (timenow.Hour < 5)
                    { Eva.SpeakAsync("Hello " + Name + ", you are still awake you should go to sleep, it's getting late"); }
                    break;
                case "what time is it":
                    System.DateTime now = System.DateTime.Now;
                    string time = now.GetDateTimeFormats('t')[0];
                    Eva.SpeakAsync(time);
                    break;
            }
        }
        private void LoadGrammarAndCommands()
        {
            try
            {
                string connectionstring = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                SqlCommand sc = new SqlCommand();
                sc.Connection = con;
                sc.CommandText = "SELECT * FROM DefaultTable";
                SqlDataReader sdr = sc.ExecuteReader();
                while (sdr.Read())
                {
                    string Loadcmd = sdr["DefaultCommands"].ToString();
                    Grammar commandgrammer = new Grammar(new GrammarBuilder(new Choices(Loadcmd)));
                    speechRecognitionEngine.LoadGrammar(commandgrammer);
                }
            sdr.Close();
            con.Close();
         }
         catch(Exception ex) 
         {
                Console.WriteLine("Hello############# {0}", ex);
                //Eva.SpeakAsync("I've detected an invalid entry in your web commands, possibly a blank line. We commands will cease to work until it is fixed." + ex.Message); ;
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
            
            case "Identify":
               Eva.SpeakAsync("Hello my name is " + name);
               break;
            
           //case default
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
