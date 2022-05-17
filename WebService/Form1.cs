using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Net;
using System.IO;
using MaterialSkin.Animations;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Text.Json;

namespace WebService
{   
    public partial class Form1 : MaterialForm
    {
        List<string> NIP_List = new List<string>();
        List<string> REGON_List = new List<string>();
        BindingSource bs = new BindingSource();
        BindingSource REGON_bs = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            change_UI_Colors();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HideAll();
            bs.DataSource = NIP_List;
            REGON_bs.DataSource = REGON_List;
        }
        private void HideAll()
        {
            multi_run_Button.Hide(); REGON_multi_run_Button.Hide();
            REGON_input_ListBox.Hide(); input_ListBox.Hide();
            multiple_REGON_textBox.Hide(); multiple_NIP_textBox.Hide();
            add_REGON_list_Button.Hide(); add_NIP_list_Button.Hide();
            multiple_results_TextBox.Hide(); REGON_multiple_results_TextBox.Hide();
        }

        private void change_UI_Colors()
        {
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Grey800, Primary.Grey700,
                Primary.Grey800, Accent.Indigo700,
                TextShade.WHITE
            );
            Text = "Wykaz Ministerstwa Finansów";
            
        }

        private void run_Button_Click(object sender, EventArgs e)
        {
            long NIP;
            string NIP_string = nip_textBox.Text;

            if (long.TryParse(NIP_string, out NIP))
            {
                if (GetIntegerDigitCount(NIP) == 10)
                {
                    ServicePointManager.Expect100Continue = true;
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;

                    string address = $@"https://wl-api.mf.gov.pl/api/search/nip/{NIP_string}?date={DateTime.Now.ToString("yyyy-MM-dd")}";                 
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"{address}");
                    //MessageBox.Show(address);
                    request.ContentType = "application/json";
                    request.Method = "GET";
                    request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                    request.UserAgent = "Mozilla / 5.0(Windows NT 10.0; Win64; x64; rv: 71.0) Gecko / 20100101 Firefox / 71.0";
                    request.Timeout = 600000;
                    

                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    Console.WriteLine(response.StatusDescription);
                    Stream dataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream);
                    string responseFromServer = reader.ReadToEnd();

                    reader.Close();
                    dataStream.Close();
                    response.Close();

                    ResultsDataSingleNIP swynik = JsonConvert.DeserializeObject<ResultsDataSingleNIP>(responseFromServer);
                    s_update_results_label(swynik);
                }
                else
                {
                    MessageBox.Show("NIP must have 10 numbers in total");
                }
            }
            else
            {
                MaterialMessageBox.Show("Invalid Input");
            }
        }

        private void multi_run_Button_Click(object sender, EventArgs e)
        {
            int i = 1;
            string address = $@"https://wl-api.mf.gov.pl/api/search/nips/";
            foreach(string single_nip in NIP_List)
            {
                if (i > 1)
                {
                    address += ($"%{i}C" + single_nip);
                }
                else
                {
                    address += single_nip;
                }
                i=2;
            }
            address += $@"?date={DateTime.Now.ToString("yyyy-MM-dd")}";


            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;         
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"{address}");
            //MessageBox.Show(address);
            request.ContentType = "application/json";
            request.Method = "GET";
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            request.UserAgent = "Mozilla / 5.0(Windows NT 10.0; Win64; x64; rv: 71.0) Gecko / 20100101 Firefox / 71.0";
            request.Timeout = 600000;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Console.WriteLine(response.StatusDescription);
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();

            reader.Close();
            dataStream.Close();
            response.Close();

            ResultsData2 wynik = JsonConvert.DeserializeObject<ResultsData2>(responseFromServer);
            update_results_label(wynik);
        }

        static int GetIntegerDigitCount(long valueInt)
        {
            // Version 2: use if-statements.
            long value = valueInt;
            int sign = 0;
            if (value < 0)
            {
                value = -value;
                sign = 1;
            }
            if (value <= 9)
            {
                return sign + 1;
            }
            if (value <= 99)
            {
                return sign + 2;
            }
            if (value <= 999)
            {
                return sign + 3;
            }
            if (value <= 9999)
            {
                return sign + 4;
            }
            if (value <= 99999)
            {
                return sign + 5;
            }
            if (value <= 999999)
            {
                return sign + 6;
            }
            if (value <= 9999999)
            {
                return sign + 7;
            }
            if (value <= 99999999)
            {
                return sign + 8;
            }
            if (value <= 999999999)
            {
                return sign + 9;
            }
            if (value <= 9999999999)
            {
                return sign + 10;
            }
            return sign + 11;
        }
        
        private void run_Button2_Click(object sender, EventArgs e)
        {
            long REGON;
            string regon_string = REGON_TextBox.Text;
            char first = 'a';
            if (!(string.IsNullOrWhiteSpace(REGON_TextBox.Text)))
            {
                first = regon_string[0];
            }
            if (long.TryParse(regon_string, out REGON))
            {
                if (GetIntegerDigitCount(REGON) == 9 || (GetIntegerDigitCount(REGON) == 8 && first == '0'))
                {
                    ServicePointManager.Expect100Continue = true;
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;

                    string address = $@"https://wl-api.mf.gov.pl/api/search/regon/{regon_string}?date={DateTime.Now.ToString("yyyy-MM-dd")}";
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"{address}");

                    request.ContentType = "application/json";
                    request.Method = "GET";
                    request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                    request.UserAgent = "Mozilla / 5.0(Windows NT 10.0; Win64; x64; rv: 71.0) Gecko / 20100101 Firefox / 71.0";
                    request.Timeout = 600000;
                    //HttpWebRequest request = CreateRequest($@"https://wl-api.mf.gov.pl/api/search/nip/{NIP_string}?date={DateTime.Now.ToString("yyyy-mm-dd")}");
                    //MessageBox.Show(address);

                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    Console.WriteLine(response.StatusDescription);
                    Stream dataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream);
                    string responseFromServer = reader.ReadToEnd();

                    reader.Close();
                    dataStream.Close();
                    response.Close();

                    ResultsDataSingleNIP REGON_wynik = JsonConvert.DeserializeObject<ResultsDataSingleNIP>(responseFromServer);
                    s_update_regon_results_label(REGON_wynik);
                }
                else
                {
                    MessageBox.Show("Regon must have 9 numbers in total");
                }
            }
            else
            {
                MaterialMessageBox.Show("Invalid Input");
            }
        }

        private void REGON_multi_run_Button_Click(object sender, EventArgs e)
        {
            int i = 1;
            string address = $@"https://wl-api.mf.gov.pl/api/search/regons/";
            foreach (string single_regon in REGON_List)
            {
                if (i > 1)
                {
                    address += ($"%{i}C" + single_regon);
                }
                else
                {
                    address += single_regon;
                }
                i = 2;
            }
            address += $@"?date={DateTime.Now.ToString("yyyy-MM-dd")}";


            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"{address}");
            //MessageBox.Show(address);
            request.ContentType = "application/json";
            request.Method = "GET";
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            request.UserAgent = "Mozilla / 5.0(Windows NT 10.0; Win64; x64; rv: 71.0) Gecko / 20100101 Firefox / 71.0";
            request.Timeout = 600000;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Console.WriteLine(response.StatusDescription);
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();

            reader.Close();
            dataStream.Close();
            response.Close();

            ResultsData2 wynik3 = JsonConvert.DeserializeObject<ResultsData2>(responseFromServer);
            update_regon_results_label(wynik3);
        }
    

        void s_update_results_label(ResultsDataSingleNIP obj)
        {
            results_Label.Text = "Request Id: " + obj.sResult.sRequestId;
            results_Label.Text +=
              "\n\nName: " + obj.sResult.sSubject.sName
            + "\nNip: " + obj.sResult.sSubject.sNip
            + "\nStatusVat: " + obj.sResult.sSubject.sStatusVat
            + "\nRegon: " + obj.sResult.sSubject.sRegon
            + "\nPesel: " + obj.sResult.sSubject.sPesel
            + "\nKrs: " + obj.sResult.sSubject.sKrs
            + "\nResidenceAddress:  " + obj.sResult.sSubject.sResidenceAddress
            + "\nWorkingAddress:  " + obj.sResult.sSubject.sWorkingAddress
            + "\nRegistrationLegalDate:  " + obj.sResult.sSubject.sRegistrationLegalDate;
        }

        void s_update_regon_results_label(ResultsDataSingleNIP obj)
        { 
            regon_results_Label.Text = "Request Id: " + obj.sResult.sRequestId;
            regon_results_Label.Text +=
              "\n\nName: " + obj.sResult.sSubject.sName
            + "\nNip: " + obj.sResult.sSubject.sNip
            + "\nStatusVat: " + obj.sResult.sSubject.sStatusVat
            + "\nRegon: " + obj.sResult.sSubject.sRegon
            + "\nPesel: " + obj.sResult.sSubject.sPesel
            + "\nKrs: " + obj.sResult.sSubject.sKrs
            + "\nResidenceAddress:  " + obj.sResult.sSubject.sResidenceAddress
            + "\nWorkingAddress:  " + obj.sResult.sSubject.sWorkingAddress
            + "\nRegistrationLegalDate:  " + obj.sResult.sSubject.sRegistrationLegalDate;
        }
        void update_results_label(ResultsData2 obj)
        {
            multiple_results_TextBox.Text = "Request Id: " + obj.Result.RequestId;
            for (int i = 0; i < obj.Result.Entries.Length; i++)
            {
                multiple_results_TextBox.Text +=
                  "\n\nName: " + obj.Result.Entries[i].Subjects[0].Name
                + "\nNip: " + obj.Result.Entries[i].Subjects[0].Nip
                + "\nStatusVat: " + obj.Result.Entries[i].Subjects[0].StatusVat
                + "\nRegon: " + obj.Result.Entries[i].Subjects[0].Regon
                + "\nPesel: " + obj.Result.Entries[i].Subjects[0].Pesel
                + "\nKrs: " + obj.Result.Entries[i].Subjects[0].Krs
                + "\nResidenceAddress:  " + obj.Result.Entries[i].Subjects[0].ResidenceAddress
                + "\nWorkingAddress:  " + obj.Result.Entries[i].Subjects[0].WorkingAddress
                + "\nRegistrationLegalDate:  " + obj.Result.Entries[i].Subjects[0].RegistrationLegalDate;
            }
        }
        void update_regon_results_label(ResultsData2 obj)
        {
            REGON_multiple_results_TextBox.Text = "Request Id: " + obj.Result.RequestId;
            for (int i = 0; i < obj.Result.Entries.Length; i++)
            {
                REGON_multiple_results_TextBox.Text +=
                  "\n\nName: " + obj.Result.Entries[i].Subjects[0].Name
                + "\nNip: " + obj.Result.Entries[i].Subjects[0].Nip
                + "\nStatusVat: " + obj.Result.Entries[i].Subjects[0].StatusVat
                + "\nRegon: " + obj.Result.Entries[i].Subjects[0].Regon
                + "\nPesel: " + obj.Result.Entries[i].Subjects[0].Pesel
                + "\nKrs: " + obj.Result.Entries[i].Subjects[0].Krs
                + "\nResidenceAddress:  " + obj.Result.Entries[i].Subjects[0].ResidenceAddress
                + "\nWorkingAddress:  " + obj.Result.Entries[i].Subjects[0].WorkingAddress
                + "\nRegistrationLegalDate:  " + obj.Result.Entries[i].Subjects[0].RegistrationLegalDate;
            }
        }


        private void multiple_nips_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (multiple_nips_Checkbox.Checked)
            {
                nip_Label.Hide(); REGON_Label.Hide();
                nip_textBox.Hide(); REGON_TextBox.Hide();
                run_Button.Hide(); REGON_run_Button.Hide();
                multi_run_Button.Show(); REGON_multi_run_Button.Show();
                input_ListBox.Show(); multiple_NIP_textBox.Show(); add_NIP_list_Button.Show();
                multiple_results_TextBox.Show(); REGON_multiple_results_TextBox.Show();
                REGON_input_ListBox.Show();multiple_REGON_textBox.Show();add_REGON_list_Button.Show();
            }
            else
            {
                nip_Label.Show(); REGON_Label.Show();
                nip_textBox.Show();REGON_TextBox.Show();
                run_Button.Show(); REGON_run_Button.Show();
                multi_run_Button.Hide(); REGON_multi_run_Button.Hide();
                input_ListBox.Hide(); multiple_NIP_textBox.Hide(); add_NIP_list_Button.Hide();
                multiple_results_TextBox.Hide(); REGON_multiple_results_TextBox.Hide();
                REGON_input_ListBox.Hide(); multiple_REGON_textBox.Hide(); add_REGON_list_Button.Hide();
            }
        }

        private void add_NIP_list_Button_Click(object sender, EventArgs e)
        {
            long NIP;
            string NIP_string = multiple_NIP_textBox.Text;

            if (long.TryParse(NIP_string, out NIP))
            {
                if (GetIntegerDigitCount(NIP) == 10)
                {
                    if (NIP_List.Contains(multiple_NIP_textBox.Text) == false)
                    {
                        NIP_List.Add(multiple_NIP_textBox.Text);
                        input_ListBox.DataSource = bs;
                        multiple_NIP_textBox.Clear();
                        bs.ResetBindings(false);
                    }
                    else
                    {
                        MaterialMessageBox.Show("NIP already added");
                    }
                }
                else 
                {
                    MaterialMessageBox.Show("NIP must have 10 numbers in total");
                }
            }
            else
            {
                MaterialMessageBox.Show("Invalid Input");
            }
        }
        private void input_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            multiple_NIP_textBox.Text = input_ListBox.SelectedItem.ToString();  
        }

        private void add_REGON_list_Button_Click(object sender, EventArgs e)
        {
            long REGON;
            string REGON_string = multiple_REGON_textBox.Text;
            char first = 'a';
            if (!(string.IsNullOrWhiteSpace(multiple_REGON_textBox.Text)))
            {
                first = REGON_string[0];
            }
            if (long.TryParse(REGON_string, out REGON))
            {
                if (GetIntegerDigitCount(REGON) == 9 || (GetIntegerDigitCount(REGON)==8 && first == '0'))
                {
                    if (REGON_List.Contains(multiple_REGON_textBox.Text) == false)
                    {
                        REGON_List.Add(multiple_REGON_textBox.Text);
                        REGON_input_ListBox.DataSource = REGON_bs;
                        multiple_REGON_textBox.Clear();
                        REGON_bs.ResetBindings(false);
                    }
                    else
                    {
                        MaterialMessageBox.Show("REGON already added");
                    }
                }
                else
                {
                    MaterialMessageBox.Show("REGON must have 9 numbers in total");
                }
            }
            else
            {
                MaterialMessageBox.Show("Invalid Input");
            }
        }
    }
}
