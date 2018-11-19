using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Web;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
       //String  token=4f8b1574800c9709910ed7326d27ba90;
            //{oid=18655,mid=81360};
        public Form1()
        {
            InitializeComponent();
        }
   
        protected string GetCity(String ip)
        {
           
            ICity.IpAddressSearchWebService res = new ICity.IpAddressSearchWebService();
            //ICity为前面web服务引用的名字
            String[] s = res.getCountryCityByIp(ip);
            //char[] strity = { ' ' };
            //String[] str = s[1].Split(strity);
            int f = s[1].IndexOf("省");
            int l = s[1].IndexOf("市");
            int len=l-f;
            String snew=s[1].Substring(f+1,len-1);
            StringBuilder sb = new StringBuilder();
           
            return snew;
            

        }

        
        public static string GetHtml()
        {
            //从这个页面读取Ip地址
            var request = WebRequest.Create("http://www.3322.org/dyndns/getip");
            request.Method = "GET";
            var response = request.GetResponse();
            using (var stream = new System.IO.StreamReader(response.GetResponseStream()))
            {

                var content = stream.ReadLine();//获取远程的页面字符串
                return content.ToString();
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {

            WeatherWeb.WeatherWebService ws = new WeatherWeb.WeatherWebService();
            //WeatherWeb为前面天气引用的名字
            showwea.Clear();
            String city = this.city2.Text;
            String[] nums = ws.getWeatherbyCityName(city);
            showwea.AppendText(nums[0] + nums[1] + "\n");
            for (int i = 4; i < 20;i++ )
            {
               
                showwea.AppendText(nums[i] + "\n");

            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //获取当前城市名
            string s = GetHtml();
            string ip = s.Trim();
            this.ipcity.Text = ip;
            String city=GetCity(ip);
            this.city2.Text = city;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String s = this.selfcity.Text;//用户输入的城市名
            WeatherWeb.WeatherWebService ws = new WeatherWeb.WeatherWebService();
            showwea.Clear();
            String[] nums = ws.getWeatherbyCityName(s);
            showwea.AppendText(nums[0] + nums[1] + "\n");
            for (int i = 4; i < 20; i++)
            {
               
                    showwea.AppendText(nums[i] + "\n");

            }


        }

        private void showwea_TextChanged(object sender, EventArgs e)
        {

        }
     }
    
}
