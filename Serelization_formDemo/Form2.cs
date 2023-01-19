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
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Serelization_formDemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                //step 1
                FileStream fs = new FileStream(@"C:\SkillMineDoc\Student.dat", FileMode.Create, FileAccess.Write);

                //step 2
                Student std = new Student();
                std.Id = Convert.ToInt32(txtId.Text);
                std.Name = txtName.Text;
                std.Percentage = Convert.ToInt32(txtPercentage.Text);

                //step3
                BinaryFormatter
                    binaryFormatter = new BinaryFormatter();

                binaryFormatter.Serialize(fs, std);

                fs.Close();
                MessageBox.Show("Employee record added to file");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                // step1 1
                FileStream fs = new FileStream(@"C:\SkillMineDoc\Student.dat", FileMode.Open, FileAccess.Read);
                // step 2
                Student std
                    = new Student();
                // step 3
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                std = (Student)binaryFormatter.Deserialize(fs);
                fs.Close();

                txtId.Text = std.Id.ToString();
                txtName.Text = std.Name;
                txtPercentage.Text = std.Percentage.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXmlWrite_Click(object sender, EventArgs e)
        {
            try
            {
                //step 1
                FileStream fs = new FileStream(@"C:\SkillMineDoc\StudentXML.xml", FileMode.Create, FileAccess.Write);

                //step 2
                Student std= new Student();
                std.Id = Convert.ToInt32(txtId.Text);
                std.Name = txtName.Text;
                std.Percentage = Convert.ToInt32(txtPercentage.Text);

                //step3
                XmlSerializer
                    xml = new XmlSerializer(typeof(Employee));

                xml.Serialize(fs, std);

                fs.Close();
                MessageBox.Show("Employee record added to file");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnXMLRead_Click(object sender, EventArgs e)
        {
            try
            {
                // step1 1
                FileStream fs = new FileStream(@"C:\SkillMineDoc\StudentXML.xml", FileMode.Open, FileAccess.Read);
                // step 2
                Student std = new Student();
                // step 3
                XmlSerializer
                   xml = new XmlSerializer(typeof(Student));

                std = (Student)xml.Deserialize(fs);
                fs.Close();

                txtId.Text = std.Id.ToString();
                txtName.Text = std.Name;
                txtPercentage.Text = std.Percentage.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSoapWrite_Click(object sender, EventArgs e)
        {
            try
            {
                //step 1
                FileStream fs = new FileStream(@"C:\SkillMineDoc\StudentSOAP.soap", FileMode.Create, FileAccess.Write);

                //step 2
                Student std = new Student();
                std.Id = Convert.ToInt32(txtPercentage.Text);
                std.Name = txtName.Text;
                std.Percentage = Convert.ToInt32(txtPercentage.Text);

                //step3
                SoapFormatter
                    soapFormatter = new SoapFormatter();

                soapFormatter.Serialize(fs, std);

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
                FileStream fs = new FileStream(@"C:\SkillMineDoc\StudentSOAP.soap", FileMode.Open, FileAccess.Read);
                // step 2
                Student std = new Student();
                // step 3
                SoapFormatter soapFormatter = new SoapFormatter();
                std = (Student)soapFormatter.Deserialize(fs);
                fs.Close();

                txtId.Text = std.Id.ToString();
                txtName.Text = std.Name;
                txtPercentage.Text = std.Percentage.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnJSONWrite_Click(object sender, EventArgs e)
        {
            try
            {
                //step 1
                FileStream fs = new FileStream(@"C:\SkillMineDoc\StudentJSON.json", FileMode.Create, FileAccess.Write);

                //step 2
                 Student std = new Student();
                std.Id = Convert.ToInt32(txtId.Text);
                std.Name = txtName.Text;
                std.Percentage = Convert.ToInt32(txtPercentage.Text);

                //step3
                JsonSerializer.Serialize<Student>(fs, std);


                fs.Close();
                MessageBox.Show("Employee record added to file");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnJSONRead_Click(object sender, EventArgs e)
        {
            try
            {
                // step1 1
                FileStream fs = new FileStream(@"C:\SkillMineDoc\StudentJSON.json", FileMode.Open, FileAccess.Read);
                // step 2
                Student std = new Student();
                // step 3
                std = JsonSerializer.Deserialize<Student>(fs);


                fs.Close();

                txtId.Text = std.Id.ToString();
                txtName.Text = std.Name;
                txtPercentage.Text = std.Percentage.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
