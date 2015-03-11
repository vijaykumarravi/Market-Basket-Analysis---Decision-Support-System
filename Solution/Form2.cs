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
    public partial class Form2 : Form
    {

        
        variables [] localobj=new variables[10];

         OleDbConnection conn;
         OleDbCommand cmd;
         Form3 myfr;
        public Form2(variables [] obj)
        {
            
            
            InitializeComponent();
            
            conn=new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= D:\Final year Project\Application\Data Set\Database\AssoicationRules.mdb";
            for (int i = 0; i < 10; i++)
                localobj[i] = obj[i];



            button1.Text = obj[0].premise + " and " + obj[0].conclusion + " At 15% Offer";
            button2.Text = obj[1].premise + " and " + obj[1].conclusion + " At 15% Offer";
            button3.Text = obj[2].premise + " and " + obj[2].conclusion + " At 15% Offer";
            button4.Text = obj[3].premise + " and " + obj[3].conclusion + " At 12.5% Offer";
            button5.Text = obj[4].premise + " and " + obj[4].conclusion + " At 12.5% Offer";
            button6.Text = obj[5].premise + " and " + obj[5].conclusion + " At 10% Offer";
            button7.Text = obj[6].premise + " and " + obj[6].conclusion + " At 10% Offer";
            button8.Text = obj[7].premise + " and " + obj[7].conclusion + " At 5% Offer";
            button9.Text = obj[8].premise + " and " + obj[8].conclusion + " At 5% Offer";
            button10.Text = obj[9].premise + " and " + obj[9].conclusion + " At 5% Offer";
        }
            public void updateLT15BOYSSTUDENT(variables fob, int bno)
        {
            try
            {

                cmd = new OleDbCommand();
                
                cmd.CommandType=CommandType.Text;
                cmd.CommandText = "UPDATE LT15BOYSSTUDENTS SET Ctr = ?, Time_Stamp=?  WHERE Num_Id = ?;"; //+ localobj[0].id +"'";
               
                
                cmd.Parameters.AddWithValue("@Ctr", fob.counter.ToString());
                cmd.Parameters.AddWithValue("@Time_Stamp", fob.time_stamp.ToString());
                cmd.Parameters.AddWithValue("@Num_Id", fob.id.ToString());
                cmd.Connection = conn;
                
                conn.Open();
                  
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated In Database");
                myfr = new Form3(fob);
                myfr.Show();
                myfr.Init(fob,bno);
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

            public void updateLT15GIRLSSTUDENT(variables fob,int bno)
            {
                try
                {

                    cmd = new OleDbCommand();
         
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE LT15GIRLSSTUDENT SET Ctr = ?, Time_Stamp=?  WHERE Num_Id = ?;"; //+ localobj[0].id +"'";
                    cmd.Parameters.AddWithValue("@Ctr", fob.counter.ToString());
                    cmd.Parameters.AddWithValue("@Time_Stamp", fob.time_stamp.ToString());
                    cmd.Parameters.AddWithValue("@Num_Id", fob.id.ToString());
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated In Database");
                    myfr = new Form3(fob);
                    myfr.Show();
                    myfr.Init(fob,bno);
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
            public void updateMALE1530EMPLOYED(variables fob, int bno)
            {
                try
                {

                    cmd = new OleDbCommand();
                    
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE MALE1530EMPLOYED SET Ctr = ?, Time_Stamp=?  WHERE Num_Id = ?;"; //+ localobj[0].id +"'";
                    cmd.Parameters.AddWithValue("@Ctr", fob.counter.ToString());
                    cmd.Parameters.AddWithValue("@Time_Stamp", fob.time_stamp.ToString());
                    cmd.Parameters.AddWithValue("@Num_Id", fob.id.ToString());
                    cmd.Connection = conn;
                    conn.Open();
                      
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated In Database");
                    myfr = new Form3(fob);
                    myfr.Show();
                    myfr.Init(fob,bno);
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
            public void updateMALE1530UNEMPLOYED(variables fob, int bno)
            {
                try
                {

                    cmd = new OleDbCommand();
                    
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE MALE1530UNEMPLOYED SET Ctr = ?, Time_Stamp=?  WHERE Num_Id = ?;"; //+ localobj[0].id +"'";
                    cmd.Parameters.AddWithValue("@Ctr", fob.counter.ToString());
                    cmd.Parameters.AddWithValue("@Time_Stamp", fob.time_stamp.ToString());
                    cmd.Parameters.AddWithValue("@Num_Id", fob.id.ToString());
                    cmd.Connection = conn;
                    conn.Open();
                    //
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated In Database");
                    myfr = new Form3(fob);
                    myfr.Show();
                    myfr.Init(fob,bno);
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
            public void updateMALE1530STUDENT(variables fob, int bno)
            {
                try
                {

                    cmd = new OleDbCommand();
                    
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE MALE1530STUDENT SET Ctr = ?, Time_Stamp=?  WHERE Num_Id = ?;"; //+ localobj[0].id +"'";
                    cmd.Parameters.AddWithValue("@Ctr", fob.counter.ToString());
                    cmd.Parameters.AddWithValue("@Time_Stamp", fob.time_stamp.ToString());
                    cmd.Parameters.AddWithValue("@Num_Id", fob.id.ToString());
                    cmd.Connection = conn;
                    conn.Open();
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated In Database");
                    myfr = new Form3(fob);
                    myfr.Show();
                    myfr.Init(fob,bno);
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
            public void updateMALEABOVE30EMPLOYED(variables fob,int bno)
            {
                try
                {

                    cmd = new OleDbCommand();
                    
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE MALEABOVE30EMPLOYED SET Ctr = ?, Time_Stamp=?  WHERE Num_Id = ?;"; //+ localobj[0].id +"'";
                    cmd.Parameters.AddWithValue("@Ctr", fob.counter.ToString());
                    cmd.Parameters.AddWithValue("@Time_Stamp", fob.time_stamp.ToString());
                    cmd.Parameters.AddWithValue("@Num_Id", fob.id.ToString());
                    cmd.Connection = conn;
                    conn.Open();
                      
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated In Database");
                    myfr = new Form3(fob);
                    myfr.Show();
                    myfr.Init(fob,bno);
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
            public void updateMALEABOVE30UNEMPLOYED(variables fob,int bno)
            {
                try
                {

                    cmd = new OleDbCommand();

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE MALEABOVE30UNEMPLOYED SET Ctr = ?, Time_Stamp=?  WHERE Num_Id = ?;"; //+ localobj[0].id +"'";
                    cmd.Parameters.AddWithValue("@Ctr", fob.counter.ToString());
                    cmd.Parameters.AddWithValue("@Time_Stamp", fob.time_stamp.ToString());
                    cmd.Parameters.AddWithValue("@Num_Id", fob.id.ToString());
                    cmd.Connection = conn;
                    conn.Open();
                      
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated In Database");
                    myfr = new Form3(fob);
                    myfr.Show();
                    myfr.Init(fob,bno);
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
            public void updateFEMALE1530EMPLOYED(variables fob,int bno)
            {
                try
                {

                    cmd = new OleDbCommand();

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE FEMALE1530EMPLOYED SET Ctr = ?, Time_Stamp=?  WHERE Num_Id = ?;"; //+ localobj[0].id +"'";
                    cmd.Parameters.AddWithValue("@Ctr", fob.counter.ToString());
                    cmd.Parameters.AddWithValue("@Time_Stamp", fob.time_stamp.ToString());
                    cmd.Parameters.AddWithValue("@Num_Id", fob.id.ToString());
                    cmd.Connection = conn;
                    conn.Open();
                      
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated In Database");
                    myfr = new Form3(fob);
                    myfr.Show();
                    myfr.Init(fob,bno);
                }
                catch (Exception s)
                {
                    
                    MessageBox.Show(s.Message.ToString()+s.Message.ToString());

                }
                finally
                {
                    conn.Close();
                }

         
            }
            public void updateFEMALE1530UNEMPLOYED(variables fob,int bno)
            {
                try
                {

                    cmd = new OleDbCommand();
                    
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE FEMALE1530UNEMPLOYED SET Ctr = ?, Time_Stamp=?  WHERE Num_Id = ?;"; //+ localobj[0].id +"'";
                    cmd.Parameters.AddWithValue("@Ctr", fob.counter.ToString());
                    cmd.Parameters.AddWithValue("@Time_Stamp", fob.time_stamp.ToString());
                    cmd.Parameters.AddWithValue("@Num_Id", fob.id.ToString());
                    cmd.Connection = conn;
                    conn.Open();
                      
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated In Database");
                    myfr = new Form3(fob);
                    myfr.Show();
                    myfr.Init(fob,bno);
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
            public void updateFEMALE1530STUDENT(variables fob,int bno)
            {
                try
                {

                    cmd = new OleDbCommand();

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE FEMALE1530STUDENT SET Ctr = ?, Time_Stamp=?  WHERE Num_Id = ?;"; //+ localobj[0].id +"'";
                    cmd.Parameters.AddWithValue("@Ctr", fob.counter.ToString());
                    cmd.Parameters.AddWithValue("@Time_Stamp", fob.time_stamp.ToString());
                    cmd.Parameters.AddWithValue("@Num_Id", fob.id.ToString());
                    cmd.Connection = conn;
                    conn.Open();
                      
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated In Database");
                    myfr = new Form3(fob);
                    myfr.Show();
                    myfr.Init(fob,bno);
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
            public void updateFEMALEABOVE30EMPLOYED(variables fob,int bno)
            {
                try
                {

                    cmd = new OleDbCommand();
                    
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE FEMALEABOVE30EMPLOYED SET Ctr = ?, Time_Stamp=?  WHERE Num_Id = ?;"; //+ localobj[0].id +"'";
                    cmd.Parameters.AddWithValue("@Ctr", fob.counter.ToString());
                    cmd.Parameters.AddWithValue("@Time_Stamp", fob.time_stamp.ToString());
                    cmd.Parameters.AddWithValue("@Num_Id", fob.id.ToString());
                    cmd.Connection = conn;
                    conn.Open();
                      
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated In Database");
                    myfr = new Form3(fob);
                    myfr.Show();
                    myfr.Init(fob,bno);
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
            public void updateFEMALEABOVE30UNEMPLOYED(variables fob,int bno)
            {
                try
                {

                    cmd = new OleDbCommand();
                    
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE FEMALEABOVE30UNEMPLOYED SET Ctr = ?, Time_Stamp=?  WHERE Num_Id = ?;"; //+ localobj[0].id +"'";
                    cmd.Parameters.AddWithValue("@Ctr", fob.counter.ToString());
                    cmd.Parameters.AddWithValue("@Time_Stamp", fob.time_stamp.ToString());
                    cmd.Parameters.AddWithValue("@Num_Id", fob.id.ToString());
                    cmd.Connection = conn;
                    conn.Open();
                      
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated In Database");
                    myfr = new Form3(fob);
                    myfr.Show();
                    myfr.Init(fob,bno);
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
            public void updateFEMALEABOVE30STUDENT(variables fob,int bno)
            {
                try
                {

                    cmd = new OleDbCommand();
                    
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE FEMALEABOVE30STUDENT SET Ctr = ?, Time_Stamp=?  WHERE Num_Id = ?;"; //+ localobj[0].id +"'";
                    cmd.Parameters.AddWithValue("@Ctr", fob.counter.ToString());
                    cmd.Parameters.AddWithValue("@Time_Stamp", fob.time_stamp.ToString());
                    cmd.Parameters.AddWithValue("@Num_Id", fob.id.ToString());
                    cmd.Connection = conn;
                    conn.Open();
                      
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated In Database");
                    myfr = new Form3(fob);
                    myfr.Show();
                    myfr.Init(fob,bno);

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
        private void button1_Click(object sender, EventArgs e)
        {
            
                localobj[0].counter++;
                localobj[0].time_stamp=DateTime.Now.TimeOfDay;
                if (localobj[0].tablename.Equals("LT15BOYSSTUDENTS"))
                    updateLT15BOYSSTUDENT(localobj[0],1);
                else if (localobj[0].tablename.Equals("LT15GIRLSSTUDENT"))
                    updateLT15GIRLSSTUDENT(localobj[0],1);
                else if (localobj[0].tablename.Equals("MALE1530EMPLOYED"))
                    updateMALE1530EMPLOYED(localobj[0],1);
                else if (localobj[0].tablename.Equals("MALE1530UNEMPLOYED"))
                    updateMALE1530UNEMPLOYED(localobj[0],1);
                else if (localobj[0].tablename.Equals("MALE1530STUDENT"))
                    updateMALE1530STUDENT(localobj[0],1);
                else if (localobj[0].tablename.Equals("MALEABOVE30EMPLOYED"))
                    updateMALEABOVE30EMPLOYED(localobj[0],1);
                else if (localobj[0].tablename.Equals("MALEABOVE30UNEMPLOYED"))
                    updateMALEABOVE30UNEMPLOYED(localobj[0],1);
                else if (localobj[0].tablename.Equals("FEMALE1530EMPLOYED"))
                    updateFEMALE1530EMPLOYED(localobj[0],1);
                else if (localobj[0].tablename.Equals("FEMALE1530UNEMPLOYED"))
                    updateFEMALE1530UNEMPLOYED(localobj[0],1);
                else if (localobj[0].tablename.Equals("FEMALE1530STUDENT"))
                    updateFEMALE1530STUDENT(localobj[0],1);
                else if (localobj[0].tablename.Equals("FEMALEABOVE30EMPLOYED"))
                    updateFEMALEABOVE30EMPLOYED(localobj[0],1);
                else if (localobj[0].tablename.Equals("FEMALEABOVE30UNEMPLOYED"))
                    updateFEMALEABOVE30UNEMPLOYED(localobj[0],1);
                else if (localobj[0].tablename.Equals("FEMALEABOVE30STUDENT"))
                    updateFEMALEABOVE30STUDENT(localobj[0],1);
                else
                    MessageBox.Show("Error");
                }

        private void button2_Click(object sender, EventArgs e)
        {
            localobj[1].counter++;
            localobj[1].time_stamp = DateTime.Now.TimeOfDay;
            if (localobj[1].tablename.Equals("LT15BOYSSTUDENTS"))
                updateLT15BOYSSTUDENT(localobj[1],2);
            else if (localobj[1].tablename.Equals("LT15GIRLSSTUDENT"))
                updateLT15GIRLSSTUDENT(localobj[1],2);
            else if (localobj[1].tablename.Equals("MALE1530EMPLOYED"))
                updateMALE1530EMPLOYED(localobj[1],2);
            else if (localobj[1].tablename.Equals("MALE1530UNEMPLOYED"))
                updateMALE1530UNEMPLOYED(localobj[1],2);
            else if (localobj[1].tablename.Equals("MALE1530STUDENT"))
                updateMALE1530STUDENT(localobj[1],2);
            else if (localobj[1].tablename.Equals("MALEABOVE30EMPLOYED"))
                updateMALEABOVE30EMPLOYED(localobj[1],2);
            else if (localobj[1].tablename.Equals("MALEABOVE30UNEMPLOYED"))
                updateMALEABOVE30UNEMPLOYED(localobj[1],2);
            else if (localobj[1].tablename.Equals("FEMALE1530EMPLOYED"))
                updateFEMALE1530EMPLOYED(localobj[1],2);
            else if (localobj[1].tablename.Equals("FEMALE1530UNEMPLOYED"))
                updateFEMALE1530UNEMPLOYED(localobj[1],2);
            else if (localobj[1].tablename.Equals("FEMALE1530STUDENT"))
                updateFEMALE1530STUDENT(localobj[1],2);
            else if (localobj[1].tablename.Equals("FEMALEABOVE30EMPLOYED"))
                updateFEMALEABOVE30EMPLOYED(localobj[1],2);
            else if (localobj[1].tablename.Equals("FEMALEABOVE30UNEMPLOYED"))
                updateFEMALEABOVE30UNEMPLOYED(localobj[1],2);
            else if (localobj[1].tablename.Equals("FEMALEABOVE30STUDENT"))
                updateFEMALEABOVE30STUDENT(localobj[1],2);
            else
                MessageBox.Show("Error");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            localobj[2].counter++;
            localobj[2].time_stamp = DateTime.Now.TimeOfDay;
            if (localobj[2].tablename.Equals("LT15BOYSSTUDENTS"))
                updateLT15BOYSSTUDENT(localobj[2],3);
            else if (localobj[2].tablename.Equals("LT15GIRLSSTUDENT"))
                updateLT15GIRLSSTUDENT(localobj[2],3);
            else if (localobj[2].tablename.Equals("MALE1530EMPLOYED"))
                updateMALE1530EMPLOYED(localobj[2],3);
            else if (localobj[2].tablename.Equals("MALE1530UNEMPLOYED"))
                updateMALE1530UNEMPLOYED(localobj[2],3);
            else if (localobj[2].tablename.Equals("MALE1530STUDENT"))
                updateMALE1530STUDENT(localobj[2],3);
            else if (localobj[2].tablename.Equals("MALEABOVE30EMPLOYED"))
                updateMALEABOVE30EMPLOYED(localobj[2],3);
            else if (localobj[2].tablename.Equals("MALEABOVE30UNEMPLOYED"))
                updateMALEABOVE30UNEMPLOYED(localobj[2],3);
            else if (localobj[2].tablename.Equals("FEMALE1530EMPLOYED"))
                updateFEMALE1530EMPLOYED(localobj[2],3);
            else if (localobj[2].tablename.Equals("FEMALE1530UNEMPLOYED"))
                updateFEMALE1530UNEMPLOYED(localobj[2],3);
            else if (localobj[2].tablename.Equals("FEMALE1530STUDENT"))
                updateFEMALE1530STUDENT(localobj[2],3);
            else if (localobj[2].tablename.Equals("FEMALEABOVE30EMPLOYED"))
                updateFEMALEABOVE30EMPLOYED(localobj[2],3);
            else if (localobj[2].tablename.Equals("FEMALEABOVE30UNEMPLOYED"))
                updateFEMALEABOVE30UNEMPLOYED(localobj[2],3);
            else if (localobj[2].tablename.Equals("FEMALEABOVE30STUDENT"))
                updateFEMALEABOVE30STUDENT(localobj[2],3);
            else
                MessageBox.Show("Error");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            localobj[3].counter++;
            localobj[3].time_stamp = DateTime.Now.TimeOfDay;
            if (localobj[3].tablename.Equals("LT15BOYSSTUDENTS"))
                updateLT15BOYSSTUDENT(localobj[3],4);
            else if (localobj[3].tablename.Equals("LT15GIRLSSTUDENT"))
                updateLT15GIRLSSTUDENT(localobj[3],4);
            else if (localobj[3].tablename.Equals("MALE1530EMPLOYED"))
                updateMALE1530EMPLOYED(localobj[3],4);
            else if (localobj[3].tablename.Equals("MALE1530UNEMPLOYED"))
                updateMALE1530UNEMPLOYED(localobj[3],4);
            else if (localobj[3].tablename.Equals("MALE1530STUDENT"))
                updateMALE1530STUDENT(localobj[3],4);
            else if (localobj[3].tablename.Equals("MALEABOVE30EMPLOYED"))
                updateMALEABOVE30EMPLOYED(localobj[3],4);
            else if (localobj[3].tablename.Equals("MALEABOVE30UNEMPLOYED"))
                updateMALEABOVE30UNEMPLOYED(localobj[3],4);
            else if (localobj[3].tablename.Equals("FEMALE1530EMPLOYED"))
                updateFEMALE1530EMPLOYED(localobj[3],4);
            else if (localobj[3].tablename.Equals("FEMALE1530UNEMPLOYED"))
                updateFEMALE1530UNEMPLOYED(localobj[3],4);
            else if (localobj[3].tablename.Equals("FEMALE1530STUDENT"))
                updateFEMALE1530STUDENT(localobj[3],4);
            else if (localobj[3].tablename.Equals("FEMALEABOVE30EMPLOYED"))
                updateFEMALEABOVE30EMPLOYED(localobj[3],4);
            else if (localobj[3].tablename.Equals("FEMALEABOVE30UNEMPLOYED"))
                updateFEMALEABOVE30UNEMPLOYED(localobj[3],4);
            else if (localobj[3].tablename.Equals("FEMALEABOVE30STUDENT"))
                updateFEMALEABOVE30STUDENT(localobj[3],4);
            else
                MessageBox.Show("Error");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            localobj[4].counter++;
            localobj[4].time_stamp = DateTime.Now.TimeOfDay;
            if (localobj[4].tablename.Equals("LT15BOYSSTUDENTS"))
                updateLT15BOYSSTUDENT(localobj[4],5);
            else if (localobj[4].tablename.Equals("LT15GIRLSSTUDENT"))
                updateLT15GIRLSSTUDENT(localobj[4],5);
            else if (localobj[4].tablename.Equals("MALE1530EMPLOYED"))
                updateMALE1530EMPLOYED(localobj[4],5);
            else if (localobj[4].tablename.Equals("MALE1530UNEMPLOYED"))
                updateMALE1530UNEMPLOYED(localobj[4],5);
            else if (localobj[4].tablename.Equals("MALE1530STUDENT"))
                updateMALE1530STUDENT(localobj[4],5);
            else if (localobj[4].tablename.Equals("MALEABOVE30EMPLOYED"))
                updateMALEABOVE30EMPLOYED(localobj[4],5);
            else if (localobj[4].tablename.Equals("MALEABOVE30UNEMPLOYED"))
                updateMALEABOVE30UNEMPLOYED(localobj[4],5);
            else if (localobj[4].tablename.Equals("FEMALE1530EMPLOYED"))
                updateFEMALE1530EMPLOYED(localobj[4],5);
            else if (localobj[4].tablename.Equals("FEMALE1530UNEMPLOYED"))
                updateFEMALE1530UNEMPLOYED(localobj[4],5);
            else if (localobj[4].tablename.Equals("FEMALE1530STUDENT"))
                updateFEMALE1530STUDENT(localobj[4],5);
            else if (localobj[4].tablename.Equals("FEMALEABOVE30EMPLOYED"))
                updateFEMALEABOVE30EMPLOYED(localobj[4],5);
            else if (localobj[4].tablename.Equals("FEMALEABOVE30UNEMPLOYED"))
                updateFEMALEABOVE30UNEMPLOYED(localobj[4],5);
            else if (localobj[4].tablename.Equals("FEMALEABOVE30STUDENT"))
                updateFEMALEABOVE30STUDENT(localobj[4],5);
            else
                MessageBox.Show("Error");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            localobj[5].counter++;
            localobj[5].time_stamp = DateTime.Now.TimeOfDay;
            if (localobj[5].tablename.Equals("LT15BOYSSTUDENTS"))
                updateLT15BOYSSTUDENT(localobj[5],6);
            else if (localobj[5].tablename.Equals("LT15GIRLSSTUDENT"))
                updateLT15GIRLSSTUDENT(localobj[5],6);
            else if (localobj[5].tablename.Equals("MALE1530EMPLOYED"))
                updateMALE1530EMPLOYED(localobj[5],6);
            else if (localobj[5].tablename.Equals("MALE1530UNEMPLOYED"))
                updateMALE1530UNEMPLOYED(localobj[5],6);
            else if (localobj[5].tablename.Equals("MALE1530STUDENT"))
                updateMALE1530STUDENT(localobj[5],6);
            else if (localobj[5].tablename.Equals("MALEABOVE30EMPLOYED"))
                updateMALEABOVE30EMPLOYED(localobj[5],6);
            else if (localobj[5].tablename.Equals("MALEABOVE30UNEMPLOYED"))
                updateMALEABOVE30UNEMPLOYED(localobj[5],6);
            else if (localobj[5].tablename.Equals("FEMALE1530EMPLOYED"))
                updateFEMALE1530EMPLOYED(localobj[5],6);
            else if (localobj[5].tablename.Equals("FEMALE1530UNEMPLOYED"))
                updateFEMALE1530UNEMPLOYED(localobj[5],6);
            else if (localobj[5].tablename.Equals("FEMALE1530STUDENT"))
                updateFEMALE1530STUDENT(localobj[5],6);
            else if (localobj[5].tablename.Equals("FEMALEABOVE30EMPLOYED"))
                updateFEMALEABOVE30EMPLOYED(localobj[5],6);
            else if (localobj[5].tablename.Equals("FEMALEABOVE30UNEMPLOYED"))
                updateFEMALEABOVE30UNEMPLOYED(localobj[5],6);
            else if (localobj[5].tablename.Equals("FEMALEABOVE30STUDENT"))
                updateFEMALEABOVE30STUDENT(localobj[5],6);
            else
                MessageBox.Show("Error");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            localobj[6].counter++;
            localobj[6].time_stamp = DateTime.Now.TimeOfDay;
            if (localobj[6].tablename.Equals("LT15BOYSSTUDENTS"))
                updateLT15BOYSSTUDENT(localobj[6],7);
            else if (localobj[6].tablename.Equals("LT15GIRLSSTUDENT"))
                updateLT15GIRLSSTUDENT(localobj[6],7);
            else if (localobj[6].tablename.Equals("MALE1530EMPLOYED"))
                updateMALE1530EMPLOYED(localobj[6],7);
            else if (localobj[6].tablename.Equals("MALE1530UNEMPLOYED"))
                updateMALE1530UNEMPLOYED(localobj[6],7);
            else if (localobj[6].tablename.Equals("MALE1530STUDENT"))
                updateMALE1530STUDENT(localobj[6],7);
            else if (localobj[6].tablename.Equals("MALEABOVE30EMPLOYED"))
                updateMALEABOVE30EMPLOYED(localobj[6],7);
            else if (localobj[6].tablename.Equals("MALEABOVE30UNEMPLOYED"))
                updateMALEABOVE30UNEMPLOYED(localobj[6],7);
            else if (localobj[6].tablename.Equals("FEMALE1530EMPLOYED"))
                updateFEMALE1530EMPLOYED(localobj[6],7);
            else if (localobj[6].tablename.Equals("FEMALE1530UNEMPLOYED"))
                updateFEMALE1530UNEMPLOYED(localobj[6],7);
            else if (localobj[6].tablename.Equals("FEMALE1530STUDENT"))
                updateFEMALE1530STUDENT(localobj[6],7);
            else if (localobj[6].tablename.Equals("FEMALEABOVE30EMPLOYED"))
                updateFEMALEABOVE30EMPLOYED(localobj[6],7);
            else if (localobj[6].tablename.Equals("FEMALEABOVE30UNEMPLOYED"))
                updateFEMALEABOVE30UNEMPLOYED(localobj[6],7);
            else if (localobj[6].tablename.Equals("FEMALEABOVE30STUDENT"))
                updateFEMALEABOVE30STUDENT(localobj[6],7);
            else
                MessageBox.Show("Error");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            localobj[7].counter++;
            localobj[7].time_stamp = DateTime.Now.TimeOfDay;
            if (localobj[7].tablename.Equals("LT15BOYSSTUDENTS"))
                updateLT15BOYSSTUDENT(localobj[7],8);
            else if (localobj[7].tablename.Equals("LT15GIRLSSTUDENT"))
                updateLT15GIRLSSTUDENT(localobj[7],8);
            else if (localobj[7].tablename.Equals("MALE1530EMPLOYED"))
                updateMALE1530EMPLOYED(localobj[7],8);
            else if (localobj[7].tablename.Equals("MALE1530UNEMPLOYED"))
                updateMALE1530UNEMPLOYED(localobj[7],8);
            else if (localobj[7].tablename.Equals("MALE1530STUDENT"))
                updateMALE1530STUDENT(localobj[7],8);
            else if (localobj[7].tablename.Equals("MALEABOVE30EMPLOYED"))
                updateMALEABOVE30EMPLOYED(localobj[7],8);
            else if (localobj[7].tablename.Equals("MALEABOVE30UNEMPLOYED"))
                updateMALEABOVE30UNEMPLOYED(localobj[7],8);
            else if (localobj[7].tablename.Equals("FEMALE1530EMPLOYED"))
                updateFEMALE1530EMPLOYED(localobj[7],8);
            else if (localobj[7].tablename.Equals("FEMALE1530UNEMPLOYED"))
                updateFEMALE1530UNEMPLOYED(localobj[7],8);
            else if (localobj[7].tablename.Equals("FEMALE1530STUDENT"))
                updateFEMALE1530STUDENT(localobj[7],8);
            else if (localobj[7].tablename.Equals("FEMALEABOVE30EMPLOYED"))
                updateFEMALEABOVE30EMPLOYED(localobj[7],8);
            else if (localobj[7].tablename.Equals("FEMALEABOVE30UNEMPLOYED"))
                updateFEMALEABOVE30UNEMPLOYED(localobj[7],8);
            else if (localobj[7].tablename.Equals("FEMALEABOVE30STUDENT"))
                updateFEMALEABOVE30STUDENT(localobj[7],8);
            else
                MessageBox.Show("Error");

        }

        private void button9_Click(object sender, EventArgs e)
        {
            localobj[8].counter++;
            localobj[8].time_stamp = DateTime.Now.TimeOfDay;
            if (localobj[8].tablename.Equals("LT15BOYSSTUDENTS"))
                updateLT15BOYSSTUDENT(localobj[8],9);
            else if (localobj[8].tablename.Equals("LT15GIRLSSTUDENT"))
                updateLT15GIRLSSTUDENT(localobj[8],9);
            else if (localobj[8].tablename.Equals("MALE1530EMPLOYED"))
                updateMALE1530EMPLOYED(localobj[8],9);
            else if (localobj[8].tablename.Equals("MALE1530UNEMPLOYED"))
                updateMALE1530UNEMPLOYED(localobj[8],9);
            else if (localobj[8].tablename.Equals("MALE1530STUDENT"))
                updateMALE1530STUDENT(localobj[8],9);
            else if (localobj[8].tablename.Equals("MALEABOVE30EMPLOYED"))
                updateMALEABOVE30EMPLOYED(localobj[8],9);
            else if (localobj[8].tablename.Equals("MALEABOVE30UNEMPLOYED"))
                updateMALEABOVE30UNEMPLOYED(localobj[8],9);
            else if (localobj[8].tablename.Equals("FEMALE1530EMPLOYED"))
                updateFEMALE1530EMPLOYED(localobj[8],9);
            else if (localobj[8].tablename.Equals("FEMALE1530UNEMPLOYED"))
                updateFEMALE1530UNEMPLOYED(localobj[8],9);
            else if (localobj[8].tablename.Equals("FEMALE1530STUDENT"))
                updateFEMALE1530STUDENT(localobj[8],9);
            else if (localobj[8].tablename.Equals("FEMALEABOVE30EMPLOYED"))
                updateFEMALEABOVE30EMPLOYED(localobj[8],9);
            else if (localobj[8].tablename.Equals("FEMALEABOVE30UNEMPLOYED"))
                updateFEMALEABOVE30UNEMPLOYED(localobj[8],9);
            else if (localobj[8].tablename.Equals("FEMALEABOVE30STUDENT"))
                updateFEMALEABOVE30STUDENT(localobj[8],9);
            else
                MessageBox.Show("Error");

        }

        private void button10_Click(object sender, EventArgs e)
        {

            localobj[9].counter++;
            localobj[9].time_stamp = DateTime.Now.TimeOfDay;
            if (localobj[9].tablename.Equals("LT15BOYSSTUDENTS"))
                updateLT15BOYSSTUDENT(localobj[9],10);
            else if (localobj[9].tablename.Equals("LT15GIRLSSTUDENT"))
                updateLT15GIRLSSTUDENT(localobj[9],10);
            else if (localobj[9].tablename.Equals("MALE1530EMPLOYED"))
                updateMALE1530EMPLOYED(localobj[9],10);
            else if (localobj[9].tablename.Equals("MALE1530UNEMPLOYED"))
                updateMALE1530UNEMPLOYED(localobj[9],10);
            else if (localobj[9].tablename.Equals("MALE1530STUDENT"))
                updateMALE1530STUDENT(localobj[9],10);
            else if (localobj[9].tablename.Equals("MALEABOVE30EMPLOYED"))
                updateMALEABOVE30EMPLOYED(localobj[9],10);
            else if (localobj[9].tablename.Equals("MALEABOVE30UNEMPLOYED"))
                updateMALEABOVE30UNEMPLOYED(localobj[9],10);
            else if (localobj[9].tablename.Equals("FEMALE1530EMPLOYED"))
                updateFEMALE1530EMPLOYED(localobj[9],10);
            else if (localobj[9].tablename.Equals("FEMALE1530UNEMPLOYED"))
                updateFEMALE1530UNEMPLOYED(localobj[9],10);
            else if (localobj[9].tablename.Equals("FEMALE1530STUDENT"))
                updateFEMALE1530STUDENT(localobj[9],10);
            else if (localobj[9].tablename.Equals("FEMALEABOVE30EMPLOYED"))
                updateFEMALEABOVE30EMPLOYED(localobj[9],10);
            else if (localobj[9].tablename.Equals("FEMALEABOVE30UNEMPLOYED"))
                updateFEMALEABOVE30UNEMPLOYED(localobj[9],10);
            else if (localobj[9].tablename.Equals("FEMALEABOVE30STUDENT"))
                updateFEMALEABOVE30STUDENT(localobj[9],10);
            else
                MessageBox.Show("Error");

        }
    }
    
        


}
