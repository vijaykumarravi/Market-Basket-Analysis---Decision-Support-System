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

   
   
    public partial class Form1 : Form
    {   
        public int male, female;
        public int employed, unemployed, student;
        public int age_group1, age_group2, age_group3;
        string ag="Less than 15";
        string ag1="15-30";
        string ag2 = "Above 30";
        string st="Employed";
        string st1="Student";
        string st2 = "Unemployed";
      
        string dbquery;
        variables [] var=new variables[10];
                
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
                var[i] = new variables();

            
        }

        private void suggest_products_Click(object sender, EventArgs e)
        {

          
            OleDbConnection conn = new OleDbConnection();
            OleDbCommand cmd;
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= E:\Final year Project\Application\Data Set\Database\AssoicationRules.mdb";
        
            try
            {
                
                String value = comboBox1.SelectedItem.ToString();
                conn.Open();

                if (radioButton1.Checked)
                {
                    //richTextBox1.Text = "Male";
                    male = 1;
                }

                else if (radioButton2.Checked)
                {
                    //richTextBox1.Text = "Female";
                    female = 1;
                }
                else
                {//richTextBox1.Text = "Please select Gender";
                }


                    if (value.Equals(ag))
                    {
                        //richTextBox1.Text = richTextBox1.Text + "\n" + value;
                        age_group1 = 1;
                    }
                    else if (value.Equals(ag1))
                    {
                        //richTextBox1.Text = richTextBox1.Text + "\n" + value;
                        age_group2 = 1;
                    }
                    else if (value.Equals(ag2))
                    {
                        //ichTextBox1.Text = richTextBox1.Text + "\n" + value;
                        age_group3 = 1;
                    }

                    else
                    {        //richTextBox1.Text = richTextBox1.Text + "\n" + "Select a valid age group";
                    }
                value = comboBox2.SelectedItem.ToString();
                if (value.Equals(st))
                {
                    //richTextBox1.Text = richTextBox1.Text + "\n" + value;
                    employed = 1;
                }
                else if (value.Equals(st1))
                {
                    //richTextBox1.Text = richTextBox1.Text + "\n" + value;
                    student = 1;

                }
                else if (value.Equals(st2))
                {
                    //richTextBox1.Text = richTextBox1.Text + "\n" + value;
                    unemployed = 1;
                }
                else
                { //richTextBox1.Text = richTextBox1.Text + "\n" + "Select a valid employment status";
                }

                    if (male == 1 && age_group1 == 1 && employed == 1)
                    {
                        //"Inside Male, Less Than 15, employed"
                        dbquery = "SELECT * FROM LT15BOYSSTUDENTS";
                        cmd = new OleDbCommand(dbquery,conn);
                        string rpremise,rconclusion;
                        
                        int i = 0;
                        
                        OleDbDataReader reader = cmd.ExecuteReader();
                        while (reader.Read()&&i<10)
                        {
                               
                            
                            string x ;
                            rpremise = reader.GetString(1);
                            var[i].premise = rpremise;
                            var[i].conclusion= reader.GetString(2);
                            //rconclusion = rconclusion;
                            x = reader.GetString(5);
                            var[i].counter =Int64.Parse(x);
                            x = reader.GetString(6);
                            var[i].time_stamp = TimeSpan.Parse(x);
                            x = reader.GetString(7);
                            var[i].id = Int64.Parse(x);

                            var[i].tablename = "LT15BOYSSTUDENTS";
                            i++;
                           

                            if (i == 10)
                            {
                                

                                break;
                            
                            }
                             
                          
                        }
                        reader.Close();
                        variables ob = new variables();
                        for (int k = 0; k < 10; k++)
                        {
                            for (int j = k + 1; j < 10; j++)
                            {
                                if (var[k].counter < var[j].counter)
                                {
                                    ob = var[k];
                                    var[k] = var[j];
                                    var[j] = ob;
                                }
                                else if (var[k].counter == var[j].counter)
                                {
                                    if (var[k].time_stamp < var[j].time_stamp)
                                    {
                                        variables t = new variables();
                                        t = var[k];
                                        var[k] = var[j];
                                        var[j] = t;
                                    }

                                }
                                else
                                    continue;
                            }
                        }
                    
                       }
                    else if (male == 1 && age_group1 == 1 && unemployed == 1)
                    {
                        //richTextBox1.Text = "Inside Male, Less Than 15, unemployed";
                        dbquery = "SELECT * FROM LT15BOYSSTUDENTS";
                        cmd = new OleDbCommand(dbquery, conn);
                        string rpremise, rconclusion;

                        int i = 0;

                        OleDbDataReader reader = cmd.ExecuteReader();
                        while (reader.Read() && i < 10)
                        {

                            string x;
                            rpremise = reader.GetString(1);
                            var[i].premise = rpremise;
                            var[i].conclusion = reader.GetString(2);
                            //rconclusion = rconclusion;
                            x = reader.GetString(5);
                            var[i].counter = Int64.Parse(x);
                            x = reader.GetString(6);
                            var[i].time_stamp = TimeSpan.Parse(x);
                            x = reader.GetString(7);
                            var[i].id = Int64.Parse(x);

                            var[i].tablename = "LT15BOYSSTUDENTS";
                            i++;


                            if (i == 10)

                                break;


                        }
                        reader.Close();
                        variables ob = new variables();
                        for (int k = 0; k < 10; k++)
                        {
                            for (int j = k + 1; j < 10; j++)
                            {
                                if (var[k].counter < var[j].counter)
                                {
                                    ob = var[k];
                                    var[k] = var[j];
                                    var[j] = ob;
                                }
                                else if (var[k].counter == var[j].counter)
                                {
                                    if (var[k].time_stamp < var[j].time_stamp)
                                    {
                                        variables t = new variables();
                                        t = var[k];
                                        var[k] = var[j];
                                        var[j] = t;
                                    }

                                }
                                else
                                    continue;
                            }
                        }

                    }
                    else if (male == 1 && age_group1 == 1 && student == 1)
                    {
                        //richTextBox1.Text = "Inside Male, Less Than 15, student";
                        dbquery = "SELECT * FROM LT15BOYSSTUDENTS";
                        cmd = new OleDbCommand(dbquery, conn);
                        string rpremise, rconclusion;

                        int i = 0;
                       // MessageBox.Show("Open");
                        OleDbDataReader reader = cmd.ExecuteReader();
                        while (reader.Read() && i < 10)
                        {

                            string x;
                            rpremise = reader.GetString(1);
                            var[i].premise = rpremise;
                           var[i].conclusion = reader.GetString(2);
                            //rconclusion = rconclusion;
                           
                            x = reader.GetString(5);
                           
                            var[i].counter = Int64.Parse(x);
                           
                            x = reader.GetString(6);
                           
                            var[i].time_stamp = TimeSpan.Parse(x);
                            x = reader.GetString(7);
                            var[i].id = Int64.Parse(x);

                            var[i].tablename = "LT15BOYSSTUDENTS";
                            i++;


                            if (i == 10)

                                break;


                        }
                        reader.Close();
                        variables ob = new variables();
                        for (int k = 0; k < 10; k++)
                        {
                            for (int j = k + 1; j < 10; j++)
                            {
                                if (var[k].counter < var[j].counter)
                                {
                                    ob = var[k];
                                    var[k] = var[j];
                                    var[j] = ob;
                                }
                                else if (var[k].counter == var[j].counter)
                                {
                                    if (var[k].time_stamp < var[j].time_stamp)
                                    {
                                        variables t = new variables();
                                        t = var[k];
                                        var[k] = var[j];
                                        var[j] = t;
                                    }

                                }
                                else
                                    continue;
                            }
                        }

                    }
                    else if (male == 1 && age_group2 == 1 && employed == 1)
                    {
                        //richTextBox1.Text = "Inside Male, 15-30, employed";
                        dbquery = "SELECT * FROM MALE1530EMPLOYED";
                        cmd = new OleDbCommand(dbquery, conn);
                        string rpremise, rconclusion;

                        int i = 0;

                        OleDbDataReader reader = cmd.ExecuteReader();
                        while (reader.Read() && i < 10)
                        {

                            string x;
                            rpremise = reader.GetString(1);
                            var[i].premise = rpremise;
                            var[i].conclusion = reader.GetString(2);
                            //rconclusion = rconclusion;
                            x = reader.GetString(5);
                            var[i].counter = Int64.Parse(x);
                            x = reader.GetString(6);
                            var[i].time_stamp = TimeSpan.Parse(x);
                            x = reader.GetString(7);
                            var[i].id = Int64.Parse(x);

                            var[i].tablename = "MALE1530EMPLOYED";
                            i++;


                            if (i == 10)
                            {


                                break;

                            }


                        }
                        reader.Close();
                        variables ob = new variables();
                        for (int k = 0; k < 10; k++)
                        {
                            for (int j = k + 1; j < 10; j++)
                            {
                                if (var[k].counter < var[j].counter)
                                {
                                    ob = var[k];
                                    var[k] = var[j];
                                    var[j] = ob;
                                }
                                else if (var[k].counter == var[j].counter)
                                {
                                    if (var[k].time_stamp < var[j].time_stamp)
                                    {
                                        variables t = new variables();
                                        t = var[k];
                                        var[k] = var[j];
                                        var[j] = t;
                                    }

                                }
                                else
                                    continue;
                            }
                        }
                    }
                    else if (male == 1 && age_group2 == 1 && unemployed == 1)
                    {
                        //richTextBox1.Text = "Inside Male, 15-30, unemployed";
                        dbquery = "SELECT * FROM MALE1530UNEMPLOYED";
                        cmd = new OleDbCommand(dbquery, conn);
                        string rpremise, rconclusion;
                        int i = 0;

                        OleDbDataReader reader = cmd.ExecuteReader();
                        while (reader.Read() && i < 10)
                        {

                            string x;
                            rpremise = reader.GetString(1);
                            var[i].premise = rpremise;
                            var[i].conclusion = reader.GetString(2);
                            //rconclusion = rconclusion;
                            x = reader.GetString(5);
                            var[i].counter = Int64.Parse(x);
                            x = reader.GetString(6);
                            var[i].time_stamp = TimeSpan.Parse(x);
                            x = reader.GetString(7);
                            var[i].id = Int64.Parse(x);

                            var[i].tablename = "MALE1530UNEMPLOYED";
                            i++;


                            if (i == 10)
                            {


                                break;

                            }


                        }
                        reader.Close();
                        variables ob = new variables();
                        for (int k = 0; k < 10; k++)
                        {
                            for (int j = k + 1; j < 10; j++)
                            {
                                if (var[k].counter < var[j].counter)
                                {
                                    ob = var[k];
                                    var[k] = var[j];
                                    var[j] = ob;
                                }
                                else if (var[k].counter == var[j].counter)
                                {
                                    if (var[k].time_stamp < var[j].time_stamp)
                                    {
                                        variables t = new variables();
                                        t = var[k];
                                        var[k] = var[j];
                                        var[j] = t;
                                    }

                                }
                                else
                                    continue;
                            }
                        }
                    }
                    else if (male == 1 && age_group2 == 1 && student == 1)
                    {
                        //richTextBox1.Text = "Inside Male, 15-30, student";
                        dbquery = "SELECT * FROM MALE1530UNEMPLOYED";
                        cmd = new OleDbCommand(dbquery, conn);
                        string rpremise, rconclusion;

                        int i = 0;

                        OleDbDataReader reader = cmd.ExecuteReader();
                        while (reader.Read() && i < 10)
                        {

                            //MessageBox.Show("Open");
                            string x;
                            rpremise = reader.GetString(1);
                            var[i].premise = rpremise;
                            var[i].conclusion = reader.GetString(2);
                            //rconclusion = rconclusion;
                            x = reader.GetString(5);
                            var[i].counter = Int64.Parse(x);
                            x = reader.GetString(6);
                            var[i].time_stamp = TimeSpan.Parse(x);
                            x = reader.GetString(7);
                            var[i].id = Int64.Parse(x);

                            var[i].tablename = "MALE1530UNEMPLOYED";
                            i++;


                            if (i == 10)
                            {


                                break;

                            }


                        }
                        reader.Close();
                        variables ob = new variables();
                        for (int k = 0; k < 10; k++)
                        {
                            for (int j = k + 1; j < 10; j++)
                            {
                                if (var[k].time_stamp < var[j].time_stamp)
                                {
                                    ob = var[k];
                                    var[k] = var[j];
                                    var[j] = ob;
                                }
                                else if (var[k].counter == var[j].counter)
                                {
                                    if (var[k].counter < var[j].counter)
                                    {
                                        variables t = new variables();
                                        t = var[k];
                                        var[k] = var[j];
                                        var[j] = t;
                                    }

                                }
                                else
                                    continue;
                            }
                        }

                    }
                    else if (male == 1 && age_group3 == 1 && employed == 1)
                    {
                        //richTextBox1.Text = "Inside Male, Above 30, employed";
                        dbquery = "SELECT * FROM MALEABOVE30EMPLOYED";
                        cmd = new OleDbCommand(dbquery, conn);
                        string rpremise, rconclusion;

                        int i = 0;

                        OleDbDataReader reader = cmd.ExecuteReader();
                        while (reader.Read() && i < 10)
                        {

                            //MessageBox.Show("Open");
                            string x;
                            rpremise = reader.GetString(1);
                            var[i].premise = rpremise;
                            var[i].conclusion = reader.GetString(2);
                            //rconclusion = rconclusion;
                            x = reader.GetString(5);
                            var[i].counter = Int64.Parse(x);
                            x = reader.GetString(6);
                            var[i].time_stamp = TimeSpan.Parse(x);
                            x = reader.GetString(7);
                            var[i].id = Int64.Parse(x);

                            var[i].tablename = "MALEABOVE30EMPLOYED";
                            i++;


                            if (i == 10)
                            {


                                break;

                            }


                        }
                        reader.Close();
                        variables ob = new variables();
                        for (int k = 0; k < 10; k++)
                        {
                            for (int j = k + 1; j < 10; j++)
                            {
                                if (var[k].counter < var[j].counter)
                                {
                                    ob = var[k];
                                    var[k] = var[j];
                                    var[j] = ob;
                                }
                                else if (var[k].counter == var[j].counter)
                                {
                                    if (var[k].time_stamp < var[j].time_stamp)
                                    {
                                        variables t = new variables();
                                        t = var[k];
                                        var[k] = var[j];
                                        var[j] = t;
                                    }

                                }
                                else
                                    continue;
                            }
                        }
                    }
                    else if (male == 1 && age_group3 == 1 && unemployed == 1)
                    {
                        //richTextBox1.Text = "Inside Male, Above 30, unemployed";
                        dbquery = "SELECT * FROM MALEABOVE30UNEMPLOYED";
                        cmd = new OleDbCommand(dbquery, conn);
                        string rpremise, rconclusion;

                        int i = 0;

                        OleDbDataReader reader = cmd.ExecuteReader();
                        while (reader.Read() && i < 10)
                        {

                            //MessageBox.Show("Open");
                            string x;
                            rpremise = reader.GetString(1);
                            var[i].premise = rpremise;
                            var[i].conclusion = reader.GetString(2);
                            //rconclusion = rconclusion;
                            x = reader.GetString(5);
                            var[i].counter = Int64.Parse(x);
                            x = reader.GetString(6);
                            var[i].time_stamp = TimeSpan.Parse(x);
                            x = reader.GetString(7);
                            var[i].id = Int64.Parse(x);

                            var[i].tablename = "MALEABOVE30UNEMPLOYED";
                            i++;


                            if (i == 10)
                            {


                                break;

                            }


                        }
                        reader.Close();
                        variables ob = new variables();
                        for (int k = 0; k < 10; k++)
                        {
                            for (int j = k + 1; j < 10; j++)
                            {
                                if (var[k].counter < var[j].counter)
                                {
                                    ob = var[k];
                                    var[k] = var[j];
                                    var[j] = ob;
                                }
                                else if (var[k].counter == var[j].counter)
                                {
                                    if (var[k].time_stamp < var[j].time_stamp)
                                    {
                                        variables t = new variables();
                                        t = var[k];
                                        var[k] = var[j];
                                        var[j] = t;
                                    }

                                }
                                else
                                    continue;
                            }
                        }

                    }
                    else if (male == 1 && age_group3 == 1 && student == 1)
                    {
                        //richTextBox1.Text = "Inside Male, Above 30, student";
                        dbquery = "SELECT * FROM MALEABOVE30UNEMPLOYED";
                        cmd = new OleDbCommand(dbquery, conn);
                        string rpremise, rconclusion;

                        int i = 0;

                        OleDbDataReader reader = cmd.ExecuteReader();
                        while (reader.Read() && i < 10)
                        {

                            //MessageBox.Show("Open");
                            string x;
                            rpremise = reader.GetString(1);
                            var[i].premise = rpremise;
                            var[i].conclusion = reader.GetString(2);
                            //rconclusion = rconclusion;
                            x = reader.GetString(5);
                            var[i].counter = Int64.Parse(x);
                            x = reader.GetString(6);
                            var[i].time_stamp = TimeSpan.Parse(x);
                            x = reader.GetString(7);
                            var[i].id = Int64.Parse(x);

                            var[i].tablename = "MALEABOVE30UNEMPLOYED";
                            i++;


                            if (i == 10)
                            {


                                break;

                            }


                        }
                        reader.Close();
                        variables ob = new variables();
                        for (int k = 0; k < 10; k++)
                        {
                            for (int j = k + 1; j < 10; j++)
                            {
                                if (var[k].time_stamp < var[j].time_stamp)
                                {
                                    ob = var[k];
                                    var[k] = var[j];
                                    var[j] = ob;
                                }
                                else if (var[k].counter == var[j].counter)
                                {
                                    if (var[k].counter < var[j].counter)
                                    {
                                        variables t = new variables();
                                        t = var[k];
                                        var[k] = var[j];
                                        var[j] = t;
                                    }

                                }
                                else
                                    continue;
                            }
                        }
                    }

                    else if (female == 1 && age_group1 == 1 && employed == 1)
                    {
                        //richTextBox1.Text = "Inside Female, Less Than 15, employed";
                        dbquery = "SELECT * FROM LT15GIRLSSTUDENT";
                        cmd = new OleDbCommand(dbquery, conn);
                        string rpremise, rconclusion;

                        int i = 0;

                        OleDbDataReader reader = cmd.ExecuteReader();
                        while (reader.Read() && i < 10)
                        {

                            //MessageBox.Show("Open");

                            string x;
                            rpremise = reader.GetString(1);
                            var[i].premise = rpremise;
                            var[i].conclusion = reader.GetString(2);
                            //rconclusion = rconclusion;
                            x = reader.GetString(5);
                            var[i].counter = Int64.Parse(x);
                            x = reader.GetString(6);
                            var[i].time_stamp = TimeSpan.Parse(x);
                            x = reader.GetString(7);
                            var[i].id = Int64.Parse(x);

                            var[i].tablename = "LT15GIRLSSTUDENT";
                            i++;


                            if (i == 10)

                                break;


                        }
                        reader.Close();
                        variables ob = new variables();
                        for (int k = 0; k < 10; k++)
                        {
                            for (int j = k + 1; j < 10; j++)
                            {
                                if (var[k].counter < var[j].counter)
                                {
                                    ob = var[k];
                                    var[k] = var[j];
                                    var[j] = ob;
                                }
                                else if (var[k].counter == var[j].counter)
                                {
                                    if (var[k].time_stamp < var[j].time_stamp)
                                    {
                                        variables t = new variables();
                                        t = var[k];
                                        var[k] = var[j];
                                        var[j] = t;
                                    }

                                }
                                else
                                    continue;
                            }
                        }

                    }
                    else if (female == 1 && age_group1 == 1 && unemployed == 1)
                    {
                        //"Inside Female, Less Than 15, unemployed"
                        dbquery = "SELECT * FROM LT15GIRLSSTUDENT";
                        cmd = new OleDbCommand(dbquery, conn);
                        string rpremise, rconclusion;

                        int i = 0;

                        OleDbDataReader reader = cmd.ExecuteReader();
                        while (reader.Read() && i < 10)
                        {

                            //MessageBox.Show("Open");
                            
                            string x;
                            rpremise = reader.GetString(1);
                            var[i].premise = rpremise;
                            var[i].conclusion = reader.GetString(2);
                            //rconclusion = rconclusion;
                            x = reader.GetString(5);
                            var[i].counter = Int64.Parse(x);
                            x = reader.GetString(6);
                            var[i].time_stamp = TimeSpan.Parse(x);
                            x = reader.GetString(7);
                            var[i].id = Int64.Parse(x);
                            
                            var[i].tablename = "LT15GIRLSSTUDENT";
                            i++;


                            if (i == 10)
                    
                                break;


                        }
                        reader.Close();
                        variables ob = new variables();
                        for (int k = 0; k < 10; k++)
                        {
                            for (int j = k + 1; j < 10; j++)
                            {
                                if (var[k].counter < var[j].counter)
                                {
                                    ob = var[k];
                                    var[k] = var[j];
                                    var[j] = ob;
                                }
                                else if (var[k].counter == var[j].counter)
                                {
                                    if (var[k].time_stamp < var[j].time_stamp)
                                    {
                                        variables t = new variables();
                                        t = var[k];
                                        var[k] = var[j];
                                        var[j] = t;
                                    }

                                }
                                else
                                    continue;
                            }
                        }
                    


                    }
                    else if (female == 1 && age_group1 == 1 && student == 1)
                    {
                        //richTextBox1.Text = "Inside Female, Less Than 15, student";
                        dbquery = "SELECT * FROM LT15GIRLSSTUDENT";
                        cmd = new OleDbCommand(dbquery, conn);
                        string rpremise, rconclusion;

                        int i = 0;

                        OleDbDataReader reader = cmd.ExecuteReader();
                        while (reader.Read() && i < 10)
                        {

                            //MessageBox.Show("Open");

                            string x;
                            rpremise = reader.GetString(1);
                            var[i].premise = rpremise;
                            var[i].conclusion = reader.GetString(2);
                            //rconclusion = rconclusion;
                            x = reader.GetString(5);
                            var[i].counter = Int64.Parse(x);
                            x = reader.GetString(6);
                            var[i].time_stamp = TimeSpan.Parse(x);
                            x = reader.GetString(7);
                            var[i].id = Int64.Parse(x);

                            var[i].tablename = "LT15GIRLSSTUDENT";
                            i++;


                            if (i == 10)

                                break;


                        }
                        reader.Close();
                        variables ob = new variables();
                        for (int k = 0; k < 10; k++)
                        {
                            for (int j = k + 1; j < 10; j++)
                            {
                                if (var[k].counter < var[j].counter)
                                {
                                    ob = var[k];
                                    var[k] = var[j];
                                    var[j] = ob;
                                }
                                else if (var[k].counter == var[j].counter)
                                {
                                    if (var[k].time_stamp < var[j].time_stamp)
                                    {
                                        variables t = new variables();
                                        t = var[k];
                                        var[k] = var[j];
                                        var[j] = t;
                                    }

                                }
                                else
                                    continue;
                            }
                        }

                    }
                    else if (female == 1 && age_group2 == 1 && employed == 1)
                    {
                        //richTextBox1.Text = "Inside Female, 15-30, employed";
                        dbquery = "SELECT * FROM FEMALE1530EMPLOYED";
                        cmd = new OleDbCommand(dbquery, conn);
                        string rpremise, rconclusion;

                        int i = 0;

                        OleDbDataReader reader = cmd.ExecuteReader();
                        while (reader.Read() && i < 10)
                        {

                            //MessageBox.Show("Open");

                            string x;
                            rpremise = reader.GetString(1);
                            var[i].premise = rpremise;
                            var[i].conclusion = reader.GetString(2);
                            //rconclusion = rconclusion;
                            x = reader.GetString(5);
                            var[i].counter = Int64.Parse(x);
                            x = reader.GetString(6);
                            var[i].time_stamp = TimeSpan.Parse(x);
                            x = reader.GetString(7);
                            var[i].id = Int64.Parse(x);

                            var[i].tablename = "FEMALE1530EMPLOYED";
                            i++;


                            if (i == 10)

                                break;


                        }
                        reader.Close();
                        variables ob = new variables();
                        for (int k = 0; k < 10; k++)
                        {
                            for (int j = k + 1; j < 10; j++)
                            {
                                if (var[k].counter < var[j].counter)
                                {
                                    ob = var[k];
                                    var[k] = var[j];
                                    var[j] = ob;
                                }
                                else if (var[k].counter == var[j].counter)
                                {
                                    if (var[k].time_stamp < var[j].time_stamp)
                                    {
                                        variables t = new variables();
                                        t = var[k];
                                        var[k] = var[j];
                                        var[j] = t;
                                    }

                                }
                                else
                                    continue;
                            }
                        }
                    }
                    else if (female == 1 && age_group2 == 1 && unemployed == 1)
                    {
                        //richTextBox1.Text = "Inside Female, 15-30, unemployed";
                        dbquery = "SELECT * FROM FEMALE1530UNEMPLOYED";
                        cmd = new OleDbCommand(dbquery, conn);
                        string rpremise, rconclusion;

                        int i = 0;

                        OleDbDataReader reader = cmd.ExecuteReader();
                        while (reader.Read() && i < 10)
                        {

                            //MessageBox.Show("Open");

                            string x;
                            rpremise = reader.GetString(1);
                            var[i].premise = rpremise;
                            var[i].conclusion = reader.GetString(2);
                            //rconclusion = rconclusion;
                            x = reader.GetString(5);
                            var[i].counter = Int64.Parse(x);
                            x = reader.GetString(6);
                            var[i].time_stamp = TimeSpan.Parse(x);
                            x = reader.GetString(7);
                            var[i].id = Int64.Parse(x);

                            var[i].tablename = "FEMALE1530UNEMPLOYED";
                            i++;


                            if (i == 10)

                                break;


                        }
                        reader.Close();
                        variables ob = new variables();
                        for (int k = 0; k < 10; k++)
                        {
                            for (int j = k + 1; j < 10; j++)
                            {
                                if (var[k].counter < var[j].counter)
                                {
                                    ob = var[k];
                                    var[k] = var[j];
                                    var[j] = ob;
                                }
                                else if (var[k].counter == var[j].counter)
                                {
                                    if (var[k].time_stamp < var[j].time_stamp)
                                    {
                                        variables t = new variables();
                                        t = var[k];
                                        var[k] = var[j];
                                        var[j] = t;
                                    }

                                }
                                else
                                    continue;
                            }
                        }
                    }
                    else if (female == 1 && age_group2 == 1 && student == 1)
                    {
                        //richTextBox1.Text = "Inside Female, 15-30, student";
                        dbquery = "SELECT * FROM FEMALE1530STUDENT";
                        cmd = new OleDbCommand(dbquery, conn);
                        string rpremise, rconclusion;

                        int i = 0;

                        OleDbDataReader reader = cmd.ExecuteReader();
                        while (reader.Read() && i < 10)
                        {

                            //MessageBox.Show("Open");

                            string x;
                            rpremise = reader.GetString(1);
                            var[i].premise = rpremise;
                            var[i].conclusion = reader.GetString(2);
                            //rconclusion = rconclusion;
                            x = reader.GetString(5);
                            var[i].counter = Int64.Parse(x);
                            x = reader.GetString(6);
                            var[i].time_stamp = TimeSpan.Parse(x);
                            x = reader.GetString(7);
                            var[i].id = Int64.Parse(x);

                            var[i].tablename = "FEMALE1530STUDENT";
                            i++;


                            if (i == 10)

                                break;


                        }
                        reader.Close();
                        variables ob = new variables();
                        for (int k = 0; k < 10; k++)
                        {
                            for (int j = k + 1; j < 10; j++)
                            {
                                if (var[k].counter < var[j].counter)
                                {
                                    ob = var[k];
                                    var[k] = var[j];
                                    var[j] = ob;
                                }
                                else if (var[k].counter == var[j].counter)
                                {
                                    if (var[k].time_stamp < var[j].time_stamp)
                                    {
                                        variables t = new variables();
                                        t = var[k];
                                        var[k] = var[j];
                                        var[j] = t;
                                    }

                                }
                                else
                                    continue;
                            }
                        }
                    }
                    else if (female == 1 && age_group3 == 1 && employed == 1)
                    {
                        //richTextBox1.Text = "Inside Female, Above 30, employed";
                        dbquery = "SELECT * FROM FEMALEABOVE30EMPLOYED";
                        cmd = new OleDbCommand(dbquery, conn);
                        string rpremise, rconclusion;

                        int i = 0;

                        OleDbDataReader reader = cmd.ExecuteReader();
                        while (reader.Read() && i < 10)
                        {

                            //MessageBox.Show("Open");

                            string x;
                            rpremise = reader.GetString(1);
                            var[i].premise = rpremise;
                            var[i].conclusion = reader.GetString(2);
                            //rconclusion = rconclusion;
                            x = reader.GetString(5);
                            var[i].counter = Int64.Parse(x);
                            x = reader.GetString(6);
                            var[i].time_stamp = TimeSpan.Parse(x);
                            x = reader.GetString(7);
                            var[i].id = Int64.Parse(x);

                            var[i].tablename = "FEMALEABOVE30EMPLOYED";
                            i++;


                            if (i == 10)

                                break;


                        }
                        reader.Close();
                        variables ob = new variables();
                        for (int k = 0; k < 10; k++)
                        {
                            for (int j = k + 1; j < 10; j++)
                            {
                                if (var[k].counter < var[j].counter)
                                {
                                    ob = var[k];
                                    var[k] = var[j];
                                    var[j] = ob;
                                }
                                else if (var[k].counter == var[j].counter)
                                {
                                    if (var[k].time_stamp < var[j].time_stamp)
                                    {
                                        variables t = new variables();
                                        t = var[k];
                                        var[k] = var[j];
                                        var[j] = t;
                                    }

                                }
                                else
                                    continue;
                            }
                        }

                    }
                    else if (female == 1 && age_group3 == 1 && unemployed == 1)
                    {
                        //richTextBox1.Text = "Inside Female, Above 30, unemployed";
                        dbquery = "SELECT * FROM FEMALEABOVE30UNEMPLOYED";
                        cmd = new OleDbCommand(dbquery, conn);
                        string rpremise, rconclusion;

                        int i = 0;

                        OleDbDataReader reader = cmd.ExecuteReader();
                        while (reader.Read() && i < 10)
                        {

                            //MessageBox.Show("Open");

                            string x;
                            rpremise = reader.GetString(1);
                            var[i].premise = rpremise;
                            var[i].conclusion = reader.GetString(2);
                            //rconclusion = rconclusion;
                            x = reader.GetString(5);
                            var[i].counter = Int64.Parse(x);
                            x = reader.GetString(6);
                            var[i].time_stamp = TimeSpan.Parse(x);
                            x = reader.GetString(7);
                            var[i].id = Int64.Parse(x);

                            var[i].tablename = "FEMALEABOVE30UNEMPLOYED";
                            i++;


                            if (i == 10)

                                break;


                        }
                        reader.Close();
                        variables ob = new variables();
                        for (int k = 0; k < 10; k++)
                        {
                            for (int j = k + 1; j < 10; j++)
                            {
                                if (var[k].counter < var[j].counter)
                                {
                                    ob = var[k];
                                    var[k] = var[j];
                                    var[j] = ob;
                                }
                                else if (var[k].counter == var[j].counter)
                                {
                                    if (var[k].time_stamp < var[j].time_stamp)
                                    {
                                        variables t = new variables();
                                        t = var[k];
                                        var[k] = var[j];
                                        var[j] = t;
                                    }

                                }
                                else
                                    continue;
                            }
                        }
                    }
                    else if (female == 1 && age_group3 == 1 && student == 1)
                    {
                        //richTextBox1.Text = "Inside Female, Above 30, student";
                        dbquery = "SELECT * FROM FEMALEABOVE30STUDENT";
                        cmd = new OleDbCommand(dbquery, conn);
                        string rpremise, rconclusion;

                        int i = 0;

                        OleDbDataReader reader = cmd.ExecuteReader();
                        while (reader.Read() && i < 10)
                        {

                            //MessageBox.Show("Open");

                            string x;
                            rpremise = reader.GetString(1);
                            var[i].premise = rpremise;
                            var[i].conclusion = reader.GetString(2);
                            //rconclusion = rconclusion;
                            x = reader.GetString(5);
                            var[i].counter = Int64.Parse(x);
                            x = reader.GetString(6);
                            var[i].time_stamp = TimeSpan.Parse(x);
                            x = reader.GetString(7);
                            var[i].id = Int64.Parse(x);

                            var[i].tablename = "FEMALEABOVE30STUDENT";
                            i++;


                            if (i == 10)

                                break;


                        }
                        reader.Close();
                        variables ob = new variables();
                        for (int k = 0; k < 10; k++)
                        {
                            for (int j = k + 1; j < 10; j++)
                            {
                                if (var[k].counter < var[j].counter)
                                {
                                    ob = var[k];
                                    var[k] = var[j];
                                    var[j] = ob;
                                }
                                else if (var[k].counter == var[j].counter)
                                {
                                    if (var[k].time_stamp < var[j].time_stamp)
                                    {
                                        variables t = new variables();
                                        t = var[k];
                                        var[k] = var[j];
                                        var[j] = t;
                                    }

                                }
                                else
                                    continue;
                            }
                        }
                    }
                    else
                    {   //richTextBox1.Text = "Invalid";
                    }
                  
                Form2 myf = new Form2(var);
                myf.Show();
                for (int o = 0; o < 10; o++)
                {
                    Console.WriteLine(var[o].id);
                    Console.WriteLine(var[o].counter);
                    Console.WriteLine(var[o].time_stamp);
                }
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message.ToString());
            }
            finally
            {
                conn.Close();
            }
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
