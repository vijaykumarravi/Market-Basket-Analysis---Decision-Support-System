using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Project
{
    public partial class Form3 : Form
    {
        OleDbConnection conn1 = new OleDbConnection();
        OleDbCommand cmd;
        OleDbCommand cmd1;
        OleDbCommand cmd2;
        int button_number;
        string ppremise, cconclusion;
        public Form3(variables obj)
        {
            InitializeComponent();
            conn1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= D:\Final year Project\Application\Data Set\Database\AssoicationRules.mdb";
           
        }
        public void Init(variables obj,int bno)
        {
            int flag=0;
            button_number = bno;
            ppremise = obj.premise;
            cconclusion = obj.conclusion;
           
            bool check = ppremise.Contains(",");
            bool check1=cconclusion.Contains(",");
            int len;
            if (check)
            {
                obj.product_1 = ppremise.Substring(0, ppremise.IndexOf(","));
                
                len=(ppremise.Length-obj.product_1.Length-2);
                obj.product_2 = ppremise.Substring((ppremise.IndexOf(",") + 2),len);
                obj.product_3 = cconclusion;
                flag = 1;
                
            }
            else if (check1)
            {
                obj.product_1 = cconclusion.Substring(0,(cconclusion.IndexOf(",")));
                len = (cconclusion.Length - obj.product_1.Length - 2);
                obj.product_2 = cconclusion.Substring((cconclusion.IndexOf(",") + 2), len);
                obj.product_3 = ppremise;
                flag = 1;
                
            }
            else
            {
                obj.product_1 = ppremise;
                obj.product_2 = cconclusion;
                flag = 0;
                
            }
            if (flag == 1)
            {
                
                find_discount(obj,button_number);
            }
            else
            {
                findd_discout(obj,button_number);
            }

        }
        public void findd_discout(variables ob,int buno)
        {
            try
            {
                string s;
                cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * FROM PRODUCTLIST WHERE ProductList=? ;";
                cmd.Parameters.AddWithValue("@ProductList", ob.product_1);
                cmd.Connection = conn1;
                conn1.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                   
                while (reader.Read())
                {
                    s = reader.GetString(2);
                    ob.price_1 = float.Parse(s);
                    

                }
                reader.Close();
                conn1.Close();
              
                cmd1 = new OleDbCommand();
                cmd1.CommandText = "Select * FROM PRODUCTLIST WHERE ProductList=?";
                cmd1.Parameters.AddWithValue("@ProductList", ob.product_2);
                cmd1.Connection = conn1;
                conn1.Open();
                OleDbDataReader reader2 = cmd1.ExecuteReader();

                while (reader2.Read())
                {
                    s = reader2.GetString(2);
                    ob.price_2 = float.Parse(s);
                }
                reader.Close();
               
                if (buno < 4)
                {
                    ob.total = ob.price_1 + ob.price_2;
                    ob.discount = (ob.total) * (float)0.15;
                    ob.nett = ob.total - ob.discount;
                }
                else if (buno > 3 && buno < 6)
                {
                    ob.total = ob.price_1 + ob.price_2;
                    ob.discount = (ob.total) * (float)0.125;
                    ob.nett = ob.total - ob.discount;
                
                }
                else if (buno > 5 && buno < 8)
                {
                    ob.total = ob.price_1 + ob.price_2;
                    ob.discount = (ob.total) * (float)0.10;
                    ob.nett = ob.total - ob.discount;
                
                }
                else
                {
                    ob.total = ob.price_1 + ob.price_2;
                    ob.discount = (ob.total) * (float)0.05;
                    ob.nett = ob.total - ob.discount;
                
                }
                display(ob);
            }
            catch (Exception s)
            {
                MessageBox.Show("1Exception Caught"+s.Message.ToString());
            }
            finally
            {
                Console.WriteLine(ob.price_1);
                Console.WriteLine(ob.price_2);
                conn1.Close();

            }
        }
        public void find_discount(variables ob,int buno)
        {
            try
            {
            string s;

            cmd=new OleDbCommand();
            cmd.CommandType=CommandType.Text;
            cmd.CommandText="Select * FROM PRODUCTLIST WHERE ProductList=?";
            cmd.Parameters.AddWithValue("@ProductList",ob.product_1);
            cmd.Connection = conn1;
            conn1.Open();
            OleDbDataReader reader=cmd.ExecuteReader();
            while(reader.Read())
            {
                s=reader.GetString(2);
                ob.price_1=float.Parse(s);
                
            }
            reader.Close();
            conn1.Close();
            cmd1 = new OleDbCommand();
            cmd1.CommandText="Select * FROM PRODUCTLIST WHERE ProductList=?";
            cmd1.Parameters.AddWithValue("@ProductList",ob.product_2);
            cmd1.Connection = conn1;
            conn1.Open();
            OleDbDataReader reade=cmd1.ExecuteReader();
            while(reade.Read())
            {
                s=reade.GetString(2);
                ob.price_2=float.Parse(s); 
            }
            reader.Close();
            conn1.Close();
            cmd2 = new OleDbCommand();
            cmd2.CommandText="Select * FROM PRODUCTLIST WHERE ProductList=?";
            cmd2.Parameters.AddWithValue("@ProductList",ob.product_3);
            cmd2.Connection = conn1;
            conn1.Open();
            reader=cmd2.ExecuteReader();
            while(reader.Read())
            {
                s=reader.GetString(2);
                ob.price_3=float.Parse(s);
                
            }
            reader.Close();
            if (buno < 4)
            {
                ob.total = ob.price_1 + ob.price_2 + ob.price_3;
                ob.discount = (ob.total) * (float)0.15;
                ob.nett = ob.total - ob.discount;
            }
            else if (buno > 3 && buno < 6)
            {
                ob.total = ob.price_1 + ob.price_2 + ob.price_3;
                ob.discount = (ob.total) * (float)0.125;
                ob.nett = ob.total - ob.discount;

            }
            else if (buno > 5 && buno < 8)
            {
                ob.total = ob.price_1 + ob.price_2 + ob.price_3;
                ob.discount = (ob.total) * (float)0.10;
                ob.nett = ob.total - ob.discount;

            }
            else
            {
                ob.total = ob.price_1 + ob.price_2+ob.price_3;
                ob.discount = (ob.total) * (float)0.05;
                ob.nett = ob.total - ob.discount;

            }
            display1(ob);


            }
        catch(Exception s)
            {
            MessageBox.Show("Exception Caught"+s.Message.ToString());
            }
            finally
            {
                Console.WriteLine(ob.price_1);
                Console.WriteLine(ob.price_2);
                Console.WriteLine(ob.price_3);
                
                conn1.Close();
        
            }
        }

        public void display(variables oname)
        {
            richTextBox1.Text = "Final Discounted Price";
            richTextBox1.Select();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.Text = richTextBox1.Text + Environment.NewLine + Environment.NewLine;
            richTextBox1.Text+="Products:"+oname.product_1+","+oname.product_2 +"with a discount of"+oname.discount.ToString();
            richTextBox1.Text = richTextBox1.Text + Environment.NewLine;
            richTextBox1.Text = richTextBox1.Text + "Nett Total:" + oname.nett.ToString();
        
        }

        public void display1(variables oname)
        {
            richTextBox1.Text = "Final Discounted Price";
            richTextBox1.Select();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.Text = richTextBox1.Text + Environment.NewLine + Environment.NewLine;
            richTextBox1.Text += "Products:" + oname.product_1 + "," + oname.product_2 + oname.product_3 +"with a discount of" + oname.discount.ToString();
            richTextBox1.Text = richTextBox1.Text + Environment.NewLine;
            richTextBox1.Text = richTextBox1.Text + "Nett Total:" + oname.nett.ToString();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You For Shopping With Us !!!");
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            
        }
    }
}
