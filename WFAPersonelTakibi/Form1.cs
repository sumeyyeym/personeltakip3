using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using WFAPersonelTakibi.Personel;

namespace WFAPersonelTakibi
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        EmployeeService employeeService = new EmployeeService();
        private void BtnSave_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.FirstName = txtFirstName.Text;
            emp.LastName = txtLastName.Text;
            emp.Adress = txtAddress.Text;
            emp.Email = txtMail.Text;
            emp.Phone = txtPhone.Text;
            emp.Department = (Department)Enum.Parse(typeof(Department), cmbDepartment.Text);
            emp.BirthDate = dtBirthDate.Value;
            #region Uzun
            //if (rdFemale.Checked)
            //{
            //    emp.Gender = Gender.Female;
            //}
            //else if (rdMale.Checked)
            //{
            //    emp.Gender = Gender.Male;
            //}
            //else if (rdRandom.Checked)
            //{
            //    emp.Gender = Gender.Random;
            //} 
            #endregion
            foreach (Control item in metroPanel1.Controls)
            {
                if (item is MetroRadioButton)
                {
                    MetroRadioButton rd = (MetroRadioButton)item;
                    if (rd.Checked)
                    {
                        emp.Gender = (Gender)Enum.Parse(typeof(Gender), rd.Text);
                    }
                }
            }

            bool result = employeeService.Add(emp);
            MessageBox.Show(this, result ? "Kayıt başarıyla eklendi" : "Kayıt ekleme hatası", "Kayıt Ekleme Bildirimi", MessageBoxButtons.OK, result ? MessageBoxIcon.Hand : MessageBoxIcon.Error);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDepartment.Items.AddRange(Enum.GetNames(typeof(Department)));
        }
    }
}
