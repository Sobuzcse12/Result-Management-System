using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Controller;

namespace LogIn
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDisciplineName.Text == "")
            {
                MessageBox.Show("Discipline TextBox is Empty!");
                txtDisciplineName.Focus();
            }
            else if (txtAcademicSesssion.Text == "")
            {
                MessageBox.Show("Academic Sesssion TextBox is Empty!");
                txtAcademicSesssion.Focus();
            }

            else
            {
                DisciplineController dscontrol = new DisciplineController();
                if (dscontrol.saveDiscipline(txtDisciplineName.Text, txtAcademicSesssion.Text))
                {
                    MessageBox.Show("Discipline saved successfully");
                }
            }
        }
          
        private void clear_btn_Click(object sender, EventArgs e)
        {
            txtDisciplineName.Clear();
            txtAcademicSesssion.Clear();

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            LogIn frm = new LogIn();
            frm.Show();
        }

        private void save_bt_Click(object sender, EventArgs e)
        {
            try
            {
                BatchController batch = new BatchController();
                StudentController stuentcontrol = new StudentController();


                if (batch.saveBatch(batch_txt.Text, term_com.SelectedItem.ToString()))
                {
                    stuentcontrol.saveStudent(frm_st_id_txt.Text, to_st_id_txt.Text, batch_txt.Text);
                    MessageBox.Show("saved successfully");
                }
                else MessageBox.Show("Don't save try again");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       }
   }
}