using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serelization_formDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                //step 1
                FileStream fs = new FileStream(@"C:\SkillMineDoc\Employee.dat", FileMode.Create, FileAccess.Write);

                //step 2
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(txtId.Text);
                emp.Name = txtName.Text;
                emp.Salary = Convert.ToInt32(txtSalary.Text);

                //step3
                BinaryFormatter
                    binaryFormatter = new BinaryFormatter();

                binaryFormatter.Serialize(fs, emp);

                fs.Close();
                MessageBox.Show("Employee record added to file");

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                // step1 1
                FileStream fs = new FileStream(@"C:\SkillMineDoc\Employee.dat", FileMode.Open, FileAccess.Read);
                // step 2
                Employee emp = new Employee();
                // step 3
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                emp = (Employee)binaryFormatter.Deserialize(fs);
                fs.Close();

                txtId.Text = emp.Id.ToString();
                txtName.Text = emp.Name;
                txtSalary.Text = emp.Salary.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSOAPWrite_Click(object sender, EventArgs e)
        {
            try
            {
                //step 1
                FileStream fs = new FileStream(@"C:\SkillMineDoc\EmployeeSOAP.soap", FileMode.Create, FileAccess.Write);

                //step 2
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(txtId.Text);
                emp.Name = txtName.Text;
                emp.Salary = Convert.ToInt32(txtSalary.Text);

                //step3
                SoapFormatter
                    soapFormatter = new SoapFormatter();

                soapFormatter.Serialize(fs, emp);

                fs.Close();
                MessageBox.Show("Employee record added to file");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSOAPRead_Click(object sender, EventArgs e)
        {
            try
            {
                // step1 1
                FileStream fs = new FileStream(@"C:\SkillMineDoc\EmployeeSOAP.soap", FileMode.Open, FileAccess.Read);
                // step 2
                Employee emp = new Employee();
                // step 3
                SoapFormatter soapFormatter = new SoapFormatter();
                emp = (Employee)soapFormatter.Deserialize(fs);
                fs.Close();

                txtId.Text = emp.Id.ToString();
                txtName.Text = emp.Name;
                txtSalary.Text = emp.Salary.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
    
}

