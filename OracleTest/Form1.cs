using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HYHISAPP.Entity;
using hyhisapp.Entity;
using HYHISAPPS.Models.Util;
using System.Net;
using System.IO;
using hyApp.Entity;
using System.Runtime.Serialization.Formatters.Binary;

namespace OracleTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = "oRrdQt6gB6cEbIZETSL9_YkaAN24";
            string time = "30";

            PhoenixDataBaseOperate.IDataBaseOperate operate = PhoenixDataBaseConnect.GenerateFactory.GenerateConnect();
            string strSql = @"select * from ywapp.jzhz_relation a where a.vglid='{0}'";
            strSql = string.Format(strSql, id);

            DataTable dt = operate.ExecDataSql(strSql);


            var sfzhs = dt.AsEnumerable().Select(a => a["VSFZH"].ToString());
            string stj = "nvl(ndel,0)=0 and NDDLX=1 and VSFZH in (" + string.Join(",", sfzhs.Select(a => "'" + a + "'")) + ")";

            DataSetPAYMENT ds = HYHISAPP.Rules.HYHISAPPStaticRules.GetPAYMENT_SelectAll(stj);


            var aa = ds.PAYMENT.Cast<RowPAYMENT>();

            var r = ds.PAYMENT.Cast<RowPAYMENT>().Select(a =>
            {
                string ztmc = "";
                short nstate = a.NSTATE;
                if (a.NSTATE == 0)
                {
                    if ((DateTime.Now - a.DDDRQ).TotalMinutes >= Convert.ToInt32(time))
                    {
                        ztmc = "超时取消";
                        nstate = 2;
                    }
                    else ztmc = "未支付";
                }
                else if (a.NSTATE == 1) ztmc = "已支付";
                return new
                {
                    VDDLSH = a.VDDLSH,
                    VCLINICNO = a.VCLINICNO,
                    VNAME = a.VNAME,
                    NCOSTS = a.NCOSTS.ToString("0.00"),
                    NSTATE = nstate,//0未支付，1已支付，2超时取消
                    ZTMC = ztmc,
                    DJZRQ = a.IsDJZRQNull() ? "" : a.DJZRQ.ToString("yyyy-MM-dd"),
                    DDDRQ = a.IsDDDRQNull() ? "" : a.DDDRQ.ToString("yyyy-MM-dd HH:mm:ss"),
                    VAPPTIME = a.VAPPTIME,
                    VDEPT = a.VDEPT,
                    VDOCTOR = a.VDOCTOR,
                    VHAOBIE = a.VHAOBIE,
                    NGHF = a.NGHF,
                    NZLF = a.NZLF
                };
            }).OrderByDescending(a => a.DDDRQ).ToList<object>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string str = HttpGet("http://58.87.122.53:8088/mzgh/GetMzDeptIndexList?nhosid=4521");

            //string str = HttpPost("http://58.87.122.53:8080//WebApi/GetProductById", "{id:\"2}");

            string str = HttpGet("http://192.168.254.87:8088/WenJuan/GetQuestionList");




        }



        public static string HttpGet(string url)
        {
            //ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
            Encoding encoding = Encoding.UTF8;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Accept = "text/html, application/xhtml+xml, */*";
            request.ContentType = "application/json";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }

        //string ss= HttpPost("http://localhost:41558/api/Demo/PostXXX", "{Code:\"test089\",Name:\"test1\"}");
        public static string HttpPost(string url, string body)
        {
            //ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
            Encoding encoding = Encoding.UTF8;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.Accept = "text/html, application/xhtml+xml, */*";
            request.ContentType = "application/json";

            byte[] buffer = encoding.GetBytes(body);
            request.ContentLength = buffer.Length;
            request.GetRequestStream().Write(buffer, 0, buffer.Length);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("id", "1");
            dic.Add("name", "aaaa");
            var result = Class1.POST("http://localhost:28771/webapi/ProductById2", dic, null);
            MessageBox.Show("wwww");
        }



        private void button4_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("id", "1");
            dic.Add("name", "aaaa");
            var result = Class1.POST("http://localhost:28771/webapi/ProductById2", "{\"id\":\"1\",\"name\":\"aaa\"}");
            MessageBox.Show(result);
        }



        private void button5_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("id", "1");
            var result = Class1.GET("http://localhost:28771/webapi/GetProductById", dic);
            MessageBox.Show("wwww");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("id", "1");
            dic.Add("name", "aaaa");
            var result = POST1("http://localhost:28771/webapi/ProductById2", "{\"id\":\"1\",\"name\":\"aaa\"}");
            MessageBox.Show(result);
        }



        public static string POST1(string url, string strJson)
        {
            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.ContentType = "text/xml";

            #region 添加Post 参数
            byte[] data = Encoding.UTF8.GetBytes(strJson);
            req.ContentLength = data.Length;
            using (Stream reqStream = req.GetRequestStream())
            {
                reqStream.Write(data, 0, data.Length);
                reqStream.Close();
            }
            #endregion

            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            //获取响应内容
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            return result;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataSetDOCTORINTRODUCTION ds = hyApp.Rules.hyAppStaticRules.GetDOCTORINTRODUCTION_SelectALl("vstaffcode=436");
            RowYWAPP_DOCTOR_INTRODUCTION row = ds.YWAPP_DOCTOR_INTRODUCTION[0];


            string str = Convert.ToBase64String(row.PHOTO);



        }
        private   byte[] ObjectToByteArray(Object obj)
        {
            if (obj == null)
                return null;

            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, obj);

            return ms.ToArray();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            string sql = "select * from ywapp.v_emr_file a where a.住院号='201900818' and a.HTML病历 is not null";
            DataTable dt = Common.SelectTable(sql);

            string str = dt.Rows[0]["HTML病历"].ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string str = AES.Decrypt("HU3jOGOIjyEq8NpOgrlCsrKxXwjGrnLSEtUEUOAFSonSIub1wzWnFt74FrhyOSUlW4f+/Ia+lf+qNfdU+jutCw0I+z3Vb9m7iLlox3MuWjs=");


            MessageBox.Show(str);



        }







    }
}
