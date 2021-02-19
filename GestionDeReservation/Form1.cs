using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeReservation
{
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS ;initial catalog=gestiondereservations ; integrated security = SSPI");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        BindingSource bs = new BindingSource();

        void afficherRIAD()
        {
            //try
            //{
            if (cn.State == ConnectionState.Closed) { cn.Open(); }
            cmd.Connection = cn;
            cmd.CommandText = "select * from RIAD";
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView2.DataSource = dt;
            bs.DataSource = dt;

            dr.Close();
            cn.Close();

            //}
            //catch (Exception ex) { }

        }

        void afficher() {
            //try
            //{
                if (cn.State == ConnectionState.Closed) { cn.Open(); }
                cmd.Connection = cn;
                cmd.CommandText = "select * from Client";
                dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                bs.DataSource = dt;
                
                dr.Close();
                cn.Close();
          
            //}
            //catch (Exception ex) { }
        
        }
        void afficherRegion()
        {
            //try
            //{
            if (cn.State == ConnectionState.Closed) { cn.Open(); }
            cmd.Connection = cn;
            cmd.CommandText = "select * from Region";
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView3.DataSource = dt;
            bs.DataSource = dt;

            dr.Close();
            cn.Close();

            //}
            //catch (Exception ex) { }

        }

        void afficherherb()
        {
            //try
            //{
            if (cn.State == ConnectionState.Closed) { cn.Open(); }
            cmd.Connection = cn;
            cmd.CommandText = "select * from TYPEHEBERGEMENT";
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView4.DataSource = dt;
            bs.DataSource = dt;

            dr.Close();
            cn.Close();

            //}
            //catch (Exception ex) { }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            if (cn.State == ConnectionState.Closed)
            { cn.Open(); }
            cmd.Connection = cn;
                cmd.CommandText="insert into CLIENT values('"+ textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"','"+textBox7.Text+"')";
                int x = cmd.ExecuteNonQuery();
                if (x == 0)
                {
                    label19.Text = "l'ajoute a échoué";
                    label19.ForeColor = System.Drawing.Color.Red;
                }
                else {
                    label19.Text = "l'ajoute a réussi";
                    label19.ForeColor = System.Drawing.Color.Green;
                    afficher();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();

                    
                }
          
                cn.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            afficher();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
            { cn.Open(); }
            cmd.Connection = cn;
            cmd.CommandText = "update CLIENT set  Nom='" + textBox2.Text + "',Prenom='" + textBox3.Text + "',GSM=" + textBox4.Text + ",Mail='" + textBox5.Text + "',Adresse='" + textBox6.Text + "',Pays='" + textBox7.Text + "'where CodeClient=" + textBox1.Text;
            
           int x = cmd.ExecuteNonQuery();
            if (x == 0)
            {
                label19.Text = "la modification à échoué";
                label19.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                label19.Text = "la modification a réussi";
                label19.ForeColor = System.Drawing.Color.Green;
                afficher();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
            { cn.Open(); }
            cmd.Connection = cn;
            cmd.CommandText = "delete from CLIENT   where CodeClient=" + textBox1.Text;

            int x = cmd.ExecuteNonQuery();
            if (x == 0)
            {
                label19.Text = "la Suppression à échoué";
                label19.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                label19.Text = "la Suppression a réussi";
                label19.ForeColor = System.Drawing.Color.Green;
                afficher();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            afficherRIAD();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
            { cn.Open(); }
            cmd.Connection = cn;
            cmd.CommandText = "insert into RIAD values('" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "','"+textBox15.Text+"','"+textBox16.Text+"')";
            int x = cmd.ExecuteNonQuery();
            if (x == 0)
            {
                label18.Text = "l'ajoute a échoué";
                label18.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                label18.Text = "l'ajoute a réussi";
                label18.ForeColor = System.Drawing.Color.Green;
                afficherRIAD();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox13.Clear();
                textBox14.Clear();
                textBox15.Clear();

                textBox16.Clear();



            }

            cn.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
            { cn.Open(); }
            cmd.Connection = cn;
            cmd.CommandText = "update RIAD set  nomR='" + textBox9.Text + "',adresserueR='" + textBox10.Text + "',codepostalR=" + textBox11.Text + ",villeR='" + textBox12.Text + "',telephoneR=" + textBox13.Text + ",nomcontactR='" + textBox14.Text + "',codeReg=" + textBox15.Text + ",nombredeplaces=" + textBox16.Text+ " where numeroR=" + textBox8.Text;

            int x = cmd.ExecuteNonQuery();
            if (x == 0)
            {
                label8.Text = "la modification à échoué";
                label8.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                label8.Text = "la modification a réussi";
                label8.ForeColor = System.Drawing.Color.Green;
                afficherRIAD();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox13.Clear();
                textBox14.Clear();
                textBox15.Clear();
                textBox16.Clear();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
            { cn.Open(); }
            cmd.Connection = cn;
            cmd.CommandText = "delete from RIAD where numeroR=" + textBox8.Text;

            int x = cmd.ExecuteNonQuery();
            if (x == 0)
            {
                label18.Text = "la Suppression à échoué";
                label18.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                label18.Text = "la Suppression a réussi";
                label18.ForeColor = System.Drawing.Color.Green;
                afficherRIAD();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox13.Clear();
                textBox14.Clear();
                textBox15.Clear();
                textBox16.Clear();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            afficherRegion();
        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (cn.State == ConnectionState.Closed)
            { cn.Open(); }
            cmd.Connection = cn;
            cmd.CommandText = "insert into Region values('" + textBox17.Text + "','" + textBox18.Text +"')";
            int x = cmd.ExecuteNonQuery();
            if (x == 0)
            {
                label22.Text = "l'ajoute a échoué";
                label22.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                label22.Text = "l'ajoute a réussi";
                label22.ForeColor = System.Drawing.Color.Green;
                afficherRegion();
                textBox18.Clear();
                textBox17.Clear();
               


            }

            cn.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
            { cn.Open(); }
            cmd.Connection = cn;
            cmd.CommandText = "update Region set  Libelle='" + textBox18.Text + "' where codeRegion=" + textBox17.Text;

            int x = cmd.ExecuteNonQuery();
            if (x == 0)
            {
                label22.Text = "la modification à échoué";
                label22.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                label22.Text = "la modification a réussi";
                label22.ForeColor = System.Drawing.Color.Green;
                afficherRegion();
                textBox18.Clear();
                textBox17.Clear();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
            { cn.Open(); }
            cmd.Connection = cn;
            cmd.CommandText = "delete from  Region  where codeRegion=" + textBox17.Text;

            int x = cmd.ExecuteNonQuery();
            if (x == 0)
            {
                label22.Text = "la Suppression à échoué";
                label22.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                label22.Text = "la Suppression a réussi";
                label22.ForeColor = System.Drawing.Color.Green;
                afficherRegion();
                textBox18.Clear();
                textBox17.Clear();
          
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            afficherherb();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
            { cn.Open(); }
            cmd.Connection = cn;
            cmd.CommandText = "insert into TYPEHEBERGEMENT values('" + textBox19.Text + "','" + textBox20.Text + "')";
            int x = cmd.ExecuteNonQuery();
            if (x == 0)
            {
                label25.Text = "l'ajoute a échoué";
                label25.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                label25.Text = "l'ajoute a réussi";
                label25.ForeColor = System.Drawing.Color.Green;
                afficherRegion();
                textBox18.Clear();
                textBox17.Clear();



            }

            cn.Close();
        }
    }
}
