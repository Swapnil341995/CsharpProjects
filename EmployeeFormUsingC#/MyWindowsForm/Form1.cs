using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Runtime.Serialization.Formatters.Binary;

namespace MyWindowsForm
{
    public partial class Form1 : Form
    {
        private static int EID = 0;
        public static int tmpEmpId = 0;
        DictionaryClass<int, Employee> dict = new DictionaryClass<int, Employee>();
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView.Show();
            DeserializeEmployee();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void FillData()
        {
            dict.Clear();
            XmlTextWriter writer = new XmlTextWriter("SerializedDictionary.xml",null);
            for (tmpEmpId = 1; tmpEmpId <= dataGridView.Rows.Count; tmpEmpId++)
            {
                Employee employee = new Employee();
                employee.Id = tmpEmpId;
                if (employee.Id == tmpEmpId)
                {
                    --tmpEmpId;

                        employee.Id = (int)dataGridView.Rows[tmpEmpId].Cells["DgvId"].Value;
                        employee.FirstName = (string)dataGridView.Rows[tmpEmpId].Cells["DgvFirstName"].Value;
                        employee.LastName = (string)dataGridView.Rows[tmpEmpId].Cells["DgvLastName"].Value;
                        employee.NickName = (string)dataGridView.Rows[tmpEmpId].Cells["DgvNickName"].Value;
                        employee.Qualification = (string)dataGridView.Rows[tmpEmpId].Cells["DgvQualfctn"].Value;
                        employee.Country = (string)dataGridView.Rows[tmpEmpId].Cells["DgvCountry"].Value;
                        employee.State = (string)dataGridView.Rows[tmpEmpId].Cells["DgvState"].Value;
                        employee.Town = (string)dataGridView.Rows[tmpEmpId].Cells["DgvTown"].Value;
                        employee.Street = (string)dataGridView.Rows[tmpEmpId].Cells["DgvStreet"].Value;
                        employee.Address = (string)dataGridView.Rows[tmpEmpId].Cells["DgvAddress"].Value;
                    

                        ++tmpEmpId;
                        dict.Add(tmpEmpId, employee);

                }
            }

            try
            {
                MessageBox.Show("Saved Successfully!!!");

                XmlSerializer serializer = new XmlSerializer(typeof(DictionaryClass<int, Employee>));


                if (dict != null)
                    serializer.Serialize(writer, dict);

            }
            catch (Exception e)
            {
                MessageBox.Show("Message is " + e.Message);
            }
            finally
            {
                writer.Close();
            }

        }


        private void DeserializeEmployee()
        {
            
            StreamReader reader = new StreamReader(@"SerializedDictionary.xml");
            if (!reader.EndOfStream)
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(DictionaryClass<int, Employee>));
                if (reader != null) { }
                DictionaryClass<int, Employee> dc = (DictionaryClass<int, Employee>)deserializer.Deserialize(reader);
                reader.Close();


                for (int i = 0; i < dc.Count; i++)
                {
                    int j = i + 1;
                    if (dc[j] != null)
                    {
                        dataGridView.Rows.Add();
                        dataGridView.Rows[i].Cells["DgvId"].Value = dc[j].Id;
                        dataGridView.Rows[i].Cells["DgvFirstName"].Value = dc[j].FirstName;
                        dataGridView.Rows[i].Cells["DgvLastName"].Value = dc[j].LastName;
                        dataGridView.Rows[i].Cells["DgvNickName"].Value = dc[j].NickName;
                        dataGridView.Rows[i].Cells["DgvQualfctn"].Value = dc[j].Qualification;
                        dataGridView.Rows[i].Cells["DgvCountry"].Value = dc[j].Country;
                        dataGridView.Rows[i].Cells["DgvState"].Value = dc[j].State;
                        dataGridView.Rows[i].Cells["DgvTown"].Value = dc[j].Town;
                        dataGridView.Rows[i].Cells["DgvStreet"].Value = dc[j].Street;
                        dataGridView.Rows[i].Cells["DgvAddress"].Value = dc[j].Address;
                    }
                    EID = dc[j].Id;
                }

                //EID = dc.Count();

            }
            reader.Close();
        }

        private void dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_AllowUserToAddRowsChanged(object sender, EventArgs e)
        {
            
        }
        
        private void dataGridView_NewRowNeeded(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void DataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Add(++EID, "");
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            FillData();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            DeleteSelectedRow();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridView.SelectAll();
            DeleteSelectedRow();
            EID = 0;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridView.SelectAll();
            DeleteSelectedRow();
            DeserializeEmployee();
        }


        void DeleteSelectedRow()
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    dataGridView.Rows.RemoveAt(row.Index);
                }
            }
        }


    }
}