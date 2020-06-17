using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgramming_CourseWork
{
    /*
     * Данный класс служит для взаимодействия с формой findStudentForm,
     * которая, в свою очередь, реализует возможность поиска курсанта 
     * автошколы в базе по ФИО, номеру протокола и номеру свидетельства.
     */
    public partial class findStudentForm : Form
    {
        public findStudentForm()
        {
            InitializeComponent();
        }

        private void button_findStudent_Click(object sender, EventArgs e)
        {
            string fullName = textBox_fullName.Text;
            string protocolNum = textBox_protocolNum.Text;
            string certificateNum = textBox_certificateNum.Text;

            if (fullName == "")
            {
                MessageBox.Show("Заполните поле \"ФИО курсанта\"!");
                return;
            }
            else if (protocolNum == "")
            {
                MessageBox.Show("Заполните поле \"Протокол №\"!");
                return;
            }
            else if (certificateNum == "")
            {
                MessageBox.Show("Заполните поле \"Свидетельство №\"!");
                return;
            }

            DataBase DB = new DataBase();

            if (!DB.openConnection())
            {
                MessageBox.Show("Нарушено соединение с базой данных!");
                this.Close();
            }
        
            // Задаём содержимое SQL-запроса и обращаемся с данным запросом к базе данных.
            
            MySqlCommand command = new MySqlCommand("SELECT * FROM students WHERE student_fullName=@fullName " +
                "AND protocol_number=@proNum AND certificate_number=@cerNum", DB.getConnection());

            command.Parameters.Add("@fullName", MySqlDbType.VarChar).Value = fullName;
            command.Parameters.Add("@proNum", MySqlDbType.VarChar).Value = protocolNum;
            command.Parameters.Add("@cerNum", MySqlDbType.VarChar).Value = certificateNum;

            // Инициализирует DbDataReader, с помощью которого будем читать из таблиц записи,
            // и помещать их содержимое в элемент управления listBox_studentData.

            DbDataReader reader = command.ExecuteReader();

            listBox_studentData.Items.Clear();

            if (reader.HasRows)
            {               
                reader.Read(); // Производим чтение записи.

                int someIndex = reader.GetOrdinal("group_name"); // Находим индекс нужного нам столбца, по его названию.
                string groupName = reader.GetString(someIndex);  // Записываем в строковую переменную содержимое данной ячейки.
                someIndex = reader.GetOrdinal("student_fullName");
                fullName = reader.GetString(someIndex);
                someIndex = reader.GetOrdinal("student_fullName_dative");
                string fullNameDative = reader.GetString(someIndex);
                someIndex = reader.GetOrdinal("passport_data");
                string passData = reader.GetString(someIndex);
                someIndex = reader.GetOrdinal("place_of_work");
                string placeWork = reader.GetString(someIndex);
                someIndex = reader.GetOrdinal("address_of_work");
                string workAddress = reader.GetString(someIndex);
                someIndex = reader.GetOrdinal("medical_certificate_number");
                string medNum = reader.GetString(someIndex);
                someIndex = reader.GetOrdinal("medical_certificate_date");
                string medDate = reader.GetString(someIndex).Substring(0, 10); ;
                someIndex = reader.GetOrdinal("medical_certificate_organizationName");
                string medOrganization = reader.GetString(someIndex);
                someIndex = reader.GetOrdinal("protocol_number");
                protocolNum = reader.GetString(someIndex);
                someIndex = reader.GetOrdinal("protocol_date");
                string protocolDate = reader.GetString(someIndex).Substring(0,10);
                someIndex = reader.GetOrdinal("certificate_number");
                certificateNum = reader.GetString(someIndex);
                someIndex = reader.GetOrdinal("certificate_date");
                string certificateDate = reader.GetString(someIndex).Substring(0, 10);
                someIndex = reader.GetOrdinal("category");
                string category = reader.GetString(someIndex);

                listBox_studentData.Items.Add("Название группы: " + groupName); // Заполняем listBox_studentData.
                listBox_studentData.Items.Add("ФИО курсанта: " + fullName);
                listBox_studentData.Items.Add("ФИО курсанта в дательном падеже: " + fullNameDative);
                listBox_studentData.Items.Add("Пасспортные данные: " + passData);
                listBox_studentData.Items.Add("Место работы: " + placeWork);
                listBox_studentData.Items.Add("Адрес места работы: " + workAddress);
                listBox_studentData.Items.Add("Номер медицинской справки: " + medNum);
                listBox_studentData.Items.Add("Дата выдачи медициской справки: " + medDate);
                listBox_studentData.Items.Add("Мед.учреждение, выдавшее справку: " + medOrganization);
                listBox_studentData.Items.Add("Номер протокола: " + protocolNum);
                listBox_studentData.Items.Add("Дата выдачи протокола: " + protocolDate);
                listBox_studentData.Items.Add("Номер свидетельства: " + certificateNum);
                listBox_studentData.Items.Add("Дата выдачи свидетельства: " + certificateDate);
                listBox_studentData.Items.Add("Категория: " + category);
            }
            else
            {
                MessageBox.Show("Данный курсант не найден!");
            }

            if (!DB.closeConnection())
            {
                MessageBox.Show("Нарушено соединение с базой данных!");
                this.Close();
            }
        }
    }
}
