using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lb2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Class.University> Universities = new();
        DataTable Table = new();

        private void Form1_Load(object sender, EventArgs e)
        {
            Table.Columns.Add("Название университета");
            Table.Columns.Add("Адрес");
            Table.Columns.Add("Количество комнат");
            Table.Columns.Add("Количество персонала");
            Table.Columns.Add("Количество студентов");
            Table.Columns.Add("Оплата за проживание");
            dataGridView1.DataSource = Table;
        }
        private void EnterButton_Click(object sender, EventArgs e)
        {
            string UniversityName;
            string Address;
            int NumberOfRooms;
            int NumberOfStaff;
            int NumberOfStudents;
            decimal PaymentForAccommodation;
            bool flag = false;

            if (String.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Название университета не может быть пустым!", "Повторите ввод!", MessageBoxButtons.OK);
                textBoxName.Clear();
            }
            if (String.IsNullOrEmpty(textBoxAddress.Text))
            {
                MessageBox.Show("Адрес не может быть пустым!", "Повторите ввод!", MessageBoxButtons.OK);
                textBoxAddress.Clear();
            }
            if (!flag)
            {
                UniversityName = textBoxName.Text;
                Address = textBoxAddress.Text;
                NumberOfRooms = decimal.ToInt32(numericUpDownRooms.Value);
                NumberOfStaff = decimal.ToInt32(numericUpDownStaff.Value);
                NumberOfStudents = decimal.ToInt32(numericUpDownStudents.Value);
                PaymentForAccommodation = numericUpDownPayment.Value;

                Class.University university = new(UniversityName, Address, NumberOfRooms, NumberOfStaff, NumberOfStudents, PaymentForAccommodation);
                Universities.Add(university);

                textBoxName.Clear();
                textBoxAddress.Clear();
                numericUpDownRooms.Value = numericUpDownRooms.Minimum;
                numericUpDownStaff.Value = numericUpDownStaff.Minimum;
                numericUpDownStudents.Value = numericUpDownStudents.Minimum;
                numericUpDownPayment.Value = numericUpDownPayment.Minimum;
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonMonhtlyIncome_Click(object sender, EventArgs e)
        {
            if (Universities.Count > 0)
            {
                textBoxIncome.Text = Universities[^1].MonthlyIncome().ToString();
            }
        }

        private void buttonHalfYearIncome_Click(object sender, EventArgs e)
        {
            if (Universities.Count > 0)
            {
                textBoxIncome.Text = Universities[^1].HalfYearIncome().ToString();
            }
        }

        private void buttonAnnualIncome_Click(object sender, EventArgs e)
        {
            if (Universities.Count > 0)
            {
                textBoxIncome.Text = Universities[^1].AnnualIncome().ToString();
            }
        }

        private void buttonIncreasing_Click(object sender, EventArgs e)
        {
            if (Universities.Count > 0)
            {
                Universities[^1].IncreasingTheNumberOfRooms(decimal.ToInt32(numericUpDownIncreasing.Value));
            }
            numericUpDownIncreasing.Value = numericUpDownIncreasing.Minimum;
        }

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            if (Universities.Count > 0)
            {
                Universities[^1].Check_in(decimal.ToInt32(numericUpDownCheckIn.Value));
            }
            numericUpDownCheckIn.Value = numericUpDownCheckIn.Minimum;
        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            if (Universities.Count > 0)
            {
                Universities[^1].Check_out(decimal.ToInt32(numericUpDownCheckOut.Value));
            }
            numericUpDownCheckOut.Value = numericUpDownCheckOut.Minimum;
        }

        private void buttonCanteen_Click(object sender, EventArgs e)
        {
            if (Universities.Count > 0)
            {
                Universities[^1].CanteenIncome();
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (Universities.Count > 0)
            {
                Class.University university = (Class.University)Universities[^1].Clone();
                Universities.Add(university);
            }
            else MessageBox.Show("Ошибка!", "Нельзя сделать копию!", MessageBoxButtons.OK);
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            Table.Clear();

            for (int i = 0; i < Universities.Count; i++)
            {
                Table.Rows.Add(Universities[i].University_Name, Universities[i]._Address, Universities[i].Number_Of_Rooms,
                    Universities[i].Number_Of_Staff, Universities[i].Number_Of_Students, Universities[i].Payment_For_Accommodation);
            }

            //foreach (var item in Universities)
            //{
            //    Table.Rows.Add(item.University_Name, item._Address, item.Number_Of_Rooms, item.Number_Of_Rooms, item.Number_Of_Staff, item.Number_Of_Students, item.Payment_For_Accommodation);
            //}
            dataGridView1.DataSource = Table;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownStudents_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
