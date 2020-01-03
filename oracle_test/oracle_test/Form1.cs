using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace oracle_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClientUtils.url = "tcp://10.103.16.71:8085";
            string sql = "SELECT * FROM SAJET.G_PART_MATCH";
            DataTable dt = ClientUtils.ExecuteSQL(sql).Tables[0];
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.DataSource = dt;
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {

                var strSql = "SELECT DISTINCT PRODUCT,FONTNAME,MAXWIDTH,MAXHEIGHT FROM SAJET.G_PPART_FONT ORDER BY FONTNAME,MAXHEIGHT,PRODUCT";
                Console.WriteLine("=============Msg:xxxxx");
                ClientUtils.url = "tcp://10.103.16.71:8085";
                //ClientUtils.url = "tcp://10.102.2.147:8085";

                //ClientUtils.TryConnect();
                Console.WriteLine("=============Msg:xxxxx"+ClientUtils.url);
                Console.WriteLine("=============Msg:xxxxx" );
                DataSet dsData = ClientUtils.ExecuteSQL(strSql);
                dataGridView1.DataSource=dsData.Tables[0];
                
            }
            catch (Exception ex)
            {
                var strMsg=ex.ToString();
            }
            finally
            {
                ;
            }
        }

    }
}
