using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public int valeur;
        public Form1()
        {
            InitializeComponent();
        }


       



        static string chaine = @"Data Source=localhost;Initial Catalog=form;Integrated Security=True";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSelect_Click.Enabled = true;
            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            validate.Enabled = false;
            cancel.Enabled = false;
            id_txt.Enabled = false;
            name_txt.Enabled = false;
            price_txt.Enabled = false;
            comboBox1.Enabled = false;
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {   
            
            cnx.Open();
            cmd.Connection = cnx;
            valeur = 1;
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            validate.Enabled = true;
            cancel.Enabled = true;
            btnSelect_Click.Enabled = false;
            name_txt.Enabled = true;
            price_txt.Enabled = true;
            id_txt.Enabled = true;
            comboBox1.Enabled = false;
            name_txt.Clear();
            id_txt.Clear();
            price_txt.Clear();
             cnx.Close(); 

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            valeur = 2;
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            validate.Enabled = true;
            cancel.Enabled = true;
            btnSelect_Click.Enabled = false;
            name_txt.Enabled = true;
            id_txt.Enabled = true;
            price_txt.Enabled = true;
            comboBox1.Enabled = false;
            cnx.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            valeur = 3;
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            validate.Enabled = true;
            cancel.Enabled = true;
            btnSelect_Click.Enabled = false;
            name_txt.Enabled = true;
            id_txt.Enabled = true;
            price_txt.Enabled = true;
            comboBox1.Enabled = false;
            cnx.Close();
        }

        
        private void validate_Click(object sender, EventArgs e)
        {
            if (valeur == 1)
            {
                cnx.Open();
                cmd.Connection = cnx;
                if (id_txt.Text == "" || name_txt.Text == "" || price_txt.Text == "")
                { MessageBox.Show("enter the inputs"); }
                else
                {
                    cmd.CommandText = "insert into product(id, name,price) values('" + id_txt.Text + "','" + name_txt.Text + "','" + price_txt.Text + "') ";
                    cmd.ExecuteNonQuery();
                    btnSelect_Click.Enabled = true;
                    btnInsert.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    validate.Enabled = false;
                    cancel.Enabled = false;
                    id_txt.Enabled = false;
                    name_txt.Enabled = false;
                    price_txt.Enabled = false;
                    comboBox1.Enabled = false;

                    name_txt.Clear();
                    id_txt.Clear();
                    price_txt.Clear();

                }
                cnx.Close();

            }

            if (valeur == 2)
            {
                cnx.Open();
                cmd.Connection = cnx;
                if (id_txt.Text == "" || name_txt.Text == "" || price_txt.Text == "")
                { MessageBox.Show("enter the inputs"); }
                else
                {
                    cmd.CommandText = "update product set name ='" + name_txt.Text + "', price ='" + price_txt.Text + "' where id='" + id_txt.Text + "' ";
                    cmd.ExecuteNonQuery();
                    btnSelect_Click.Enabled = true;
                    btnInsert.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    validate.Enabled = false;
                    cancel.Enabled = false;
                    id_txt.Enabled = false;
                    name_txt.Enabled = false;
                    price_txt.Enabled = false;
                    comboBox1.Enabled = false;

                    name_txt.Clear();
                    id_txt.Clear();
                    price_txt.Clear();
                }
                cnx.Close();

            }
            if (valeur == 3)
            {
                cnx.Open();
                cmd.Connection = cnx;
                if (id_txt.Text == "" )
                { MessageBox.Show("enter the inputs"); }
                else
                {
                    cmd.CommandText = "delete from product where id='" + id_txt.Text + "' ";
                    cmd.ExecuteNonQuery();
                    btnSelect_Click.Enabled = true;
                    btnInsert.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    validate.Enabled = false;
                    cancel.Enabled = false;
                    id_txt.Enabled = false;
                    name_txt.Enabled = false;
                    price_txt.Enabled = false;
                    comboBox1.Enabled = false;

                    name_txt.Clear();
                    id_txt.Clear();
                    price_txt.Clear();

                }
                cnx.Close();

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtId_dossier_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNom_dossier_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void prise_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {

            btnSelect_Click.Enabled = true;
            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            validate.Enabled = false;
            cancel.Enabled = false;
            id_txt.Enabled = false;
            name_txt.Enabled = false;
            price_txt.Enabled = false;
            comboBox1.Enabled = false;
            name_txt.Clear();
            id_txt.Clear();
            price_txt.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.CommandText = "select * from product";
            cmd.Connection = cnx;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            comboBox1.DataSource = dt;
            btnSelect_Click.Enabled = false;
            validate.Enabled = false;
            cancel.Enabled = true;
            id_txt.Enabled = false;
            name_txt.Enabled = false;
            price_txt.Enabled = false;
            comboBox1.Enabled = true;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";
            name_txt.DataBindings.Clear();
            id_txt.DataBindings.Clear();
            price_txt.DataBindings.Clear();
            name_txt.DataBindings.Add("text", comboBox1.DataSource, "name");
            id_txt.DataBindings.Add("text", comboBox1.DataSource, "id"); ;
            price_txt.DataBindings.Add("text", comboBox1.DataSource, "price");
            cnx.Close();
        }
    }
}
