using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace VisualProgramming_CourseWork
{
    /*
     * Данный класс реализует управление главной формой приложения, 
     * которая отображается при его запуске.
     */
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private string selectedTeacher; // Данные выбранного преподавателя.

        // Следующие переменные хранят местоположение на ПК
        // шаблонов, для создания Word документов и последующей
        // распечатки этих документов.

        private readonly string firstDocumentName = @"R:\Document1.docx";
        private readonly string secondDocumentName = @"R:\Document2.docx";
        private readonly string fourthDocumentName = @"R:\Document4.docx";
        private readonly string sixthDocumentName = @"R:\Document6.docx";
        private readonly string eighthDocumentName = @"R:\Document8.docx";
        private readonly string tenthDocumentName = @"R:\Document10.docx";
        private readonly string eleventhDocumentName = @"R:\Document11.docx";

        // При загрузке окна производится заполнение элемента управления 
        // dataGridView_table записями из таблицы students.
        // Элемент управления listBox_teachersList заполняется записями
        // таблицы driving_teachers.

        private void MainForm_Shown(object sender, EventArgs e)
        {
            DataBase DB = new DataBase();

            if (!DB.openConnection())
            {
                MessageBox.Show("Нарушено соединение с базой данных!");
                Application.Exit();
                return;
            } 
            
            MySqlCommand command = new MySqlCommand("SELECT driving_school_name FROM information", DB.getConnection());

            DbDataReader reader = command.ExecuteReader();
            int index = reader.GetOrdinal("driving_school_name");
            reader.Read();
            String schoolName = reader.GetString(index);

            MainForm.ActiveForm.Text = "Автошкола \"" + schoolName + "\"";
            reader.Close();

            command = new MySqlCommand("SELECT fullName, state_number, car_brand FROM driving_teachers ORDER BY fullName ASC", DB.getConnection());

            reader = command.ExecuteReader();

            listBox_teachersList.Items.Clear();

            if (reader.HasRows)
            {
                for (int i = 1; i <= 5; i++)
                {
                    reader.Read();

                    int someIndex = reader.GetOrdinal("fullName");
                    string fullName = reader.GetString(someIndex);
                    someIndex = reader.GetOrdinal("state_number");
                    string stateNumber = reader.GetString(someIndex);
                    someIndex = reader.GetOrdinal("car_brand");
                    string carBrand = reader.GetString(someIndex);

                    listBox_teachersList.Items.Add(fullName + " " + stateNumber + " " + carBrand);
                }
            }
            else
            {
                MessageBox.Show("Not found!");
            }

            if (!DB.closeConnection())
            {
                MessageBox.Show("Нарушено соединение с базой данных!");
                this.Close();
                return;
            }

            showAllStudents();
        }

        // Обработчик нажатия на кнопку "Найти курсанта"
        // открывает новую форму для поиска.

        private void findButton_Click(object sender, EventArgs e)
        {
            findStudentForm findForm = new findStudentForm();
            findForm.Show();
        }

        // Данный метод производит чтение всех записей из таблицы students, 
        // и заполнение элемента dataGridView_table этими записями.

        void showAllStudents()
        {
            DataBase DB = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            if (!DB.openConnection())
            {
                MessageBox.Show("Нарушено соединение с базой данных!");
                this.Close();
                return;
            }

            MySqlCommand command = new MySqlCommand("SELECT * FROM students", DB.getConnection());

            adapter.SelectCommand = command; // Выбрали команду для выполнения SQL-запроса.
            adapter.Fill(table); // Заполняем объект table значениями, полученными в результате выполнения SQL-запроса.

            dataGridView_table.DataSource = table; // Устанавливаем источник информации для элемента dataGridView_table.

            if (!DB.closeConnection())
            {
                MessageBox.Show("Нарушено соединение с базой данных!");
                this.Close();
                return;
            }
        }

        // Данный метод выводит информацию из таблицы information
        // при нажатии на кнопку "Об автошколе".

        private void toolStrip_AboutButton_Click(object sender, EventArgs e)
        {
            DataBase DB = new DataBase();

            if (!DB.openConnection())
            {
                MessageBox.Show("Нарушено соединение с базой данных!");
                this.Close();
                return;
            }

            MySqlCommand command = new MySqlCommand("SELECT * FROM information", DB.getConnection());

            DbDataReader reader = command.ExecuteReader();

            reader.Read();
            
            int someIndex = reader.GetOrdinal("driving_school_name");
            string schoolName = reader.GetString(someIndex);
            someIndex = reader.GetOrdinal("fullName_of_director");
            string directorName = reader.GetString(someIndex);
            someIndex = reader.GetOrdinal("requisites_PTD");
            string requisites = reader.GetString(someIndex);
            someIndex = reader.GetOrdinal("surname_chief_PTD");
            string chiefSurname = reader.GetString(someIndex);

            reader.Close();

            string separator = "\n*************************************************************************\n";

            MessageBox.Show(separator + "Название автошколы: " + schoolName + separator + "ФИО директора: " + directorName +
                separator + "Реквизиты ГИБДД:\n" + requisites + separator + "Фамилия начальника отдела ГИБДД: " + chiefSurname
                + separator);

            if (!DB.closeConnection())
            {
                MessageBox.Show("Нарушено соединение с базой данных!");
                this.Close();
                return;
            }
        }

        // Данный метод получает текущую дату из Базы Данных и возвращает
        // её как строковую переменную в место вызова.

        private string getCurrentDateDB()
        {
            DataBase DB = new DataBase();

            if (!DB.openConnection())
            {
                MessageBox.Show("Нарушено соединение с базой данных!");
                this.Close();
                return null;
            }

            MySqlCommand command = new MySqlCommand("SELECT CURRENT_DATE()", DB.getConnection());
            DbDataReader reader = command.ExecuteReader();
            reader.Read();
            string currDate = reader.GetString(0).Substring(0, 10);

            if (!DB.closeConnection())
            {
                MessageBox.Show("Нарушено соединение с базой данных!");
                this.Close();
                return null;
            }

            return currDate;
        }           

        // Данный метод обрабатывает нажатие на кнопку "Выбрать преподавателя".

        private void chooseButton_Click(object sender, EventArgs e)
        {
            if (listBox_teachersList.SelectedItems.Count > 0)
            {
                selectedTeacher = listBox_teachersList.SelectedItem.ToString();
                MessageBox.Show("Выбранный преподаватель (ФИО, марка автомобиля, гос.номер): \n" + selectedTeacher);
            }
            else
            {
                MessageBox.Show("Преподаватель не выбран!");
            }
        }

        // Данный метод обрабатывает нажатие на кнопку "Печать".
        private void button_print_Click(object sender, EventArgs e)
        {
            switch (listBox_forPrint.SelectedIndex)
            {
                case 0:
                    PrintDocumentFirst();
                    break;

                case 1:
                    PrintDocumentSecond();
                    break;

                case 2:
                    MessageBox.Show("Выберите курсанта в таблице");
                    break;

                case 3:
                    MessageBox.Show("Выберите курсанта в таблице");
                    break;

                case 4:
                    PrintDocumentEighth("ИП-815");
                    break;

                case 5:
                    MessageBox.Show("Выберите курсанта в таблице");
                    break;

                case 6:
                    MessageBox.Show("Выберите курсанта в таблице");
                    break;
            }
        }

        // Данный метод является обработчиком нажатия на кнопку "Выбрать курсанта".
        // Он содействует печати документа для определённого курсанта.

        private void button_chooseRow_Click(object sender, EventArgs e)
        {
            if (dataGridView_table.SelectedCells.Count > 0) // Проверяем, что есть выбранный элемент.
            {
                string temp = dataGridView_table.SelectedCells[7].Value.ToString(); // Запоминаем уникальное значение выбранного курсанта.

                if (listBox_forPrint.SelectedItems.Count > 0) // Проверяем, выбран ли нужный документ для печати.
                {
                    int documentIndex = listBox_forPrint.SelectedIndex;

                    // Далее в соответствии с выбранным документом, начинаем печать документа
                    // с помощью вызова соответствующего метода.

                    switch (documentIndex)
                    {
                        case 2:
                            PrintDocumentFourth(temp);
                            break;

                        case 3:
                            PrintDocumentSixth(temp);
                            break;

                        case 5:
                            PrintDocumentTenth(temp);
                            break;

                        case 6:
                            PrintDocumentEleventh(temp);
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Выберите документ для печати!");
                    return;
                }

            }
            else
            {
                MessageBox.Show("Выберите строку в таблице!");
                return;
            }
        }

        // Данный метод производит замену в Word документе "заглушек" на переданные в параметрах значения.

        private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }

        // Данный метод печатает "Заявление на принятие курсанта".

        void PrintDocumentFirst()
        {          
            string currDate = getCurrentDateDB();

            DataBase DB = new DataBase();

            if (!DB.openConnection())
            {
                MessageBox.Show("Нарушено соединение с базой данных!");
                this.Close();
                return;
            }

            MySqlCommand command = new MySqlCommand("SELECT fullName_of_directorDative, driving_school_name FROM `information`", DB.getConnection());
            DbDataReader reader = command.ExecuteReader();
            
            reader.Read();
            string directorFullNameDative = reader.GetString(0);
            string drivingSchoolName = reader.GetString(1);         

            reader.Close();

            if (!DB.closeConnection())
            {
                MessageBox.Show("Нарушено соединение с базой данных!");
                this.Close();
                return;
            }

            var wordApp = new Word.Application();
            wordApp.Visible = false;

            try
            {
                var wordDocument = wordApp.Documents.Open(firstDocumentName);
                ReplaceWordStub("{schoolName}", drivingSchoolName, wordDocument);
                ReplaceWordStub("{directorFullName}", directorFullNameDative, wordDocument);
                ReplaceWordStub("{currDate}", currDate, wordDocument);

                wordDocument.SaveAs2(@"R:\Final1.docx");

                wordDocument.Activate();
                wordDocument.PrintOut(Range: Word.WdPrintOutRange.wdPrintFromTo, From: "1", To: "1");

                wordDocument.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка печати документа!");
            }

            wordApp.Quit();
        }

        // Данный метод печатает "Заявку на регистрацию учебных групп".

        void PrintDocumentSecond()
        {
            DataBase DB = new DataBase();

            if (!DB.openConnection())
            {
                MessageBox.Show("Нарушено соединение с базой данных!");
                this.Close();
                return;
            }

            MySqlCommand command = new MySqlCommand("SELECT driving_school_name, driving_school_address, fullName_of_director," +
                " surname_chief_PTD_Dative FROM `information`", DB.getConnection());
            DbDataReader reader = command.ExecuteReader();

            reader.Read();
            string drivingSchoolName = reader.GetString(0);
            string drivingSchoolAddress = reader.GetString(1);
            string directorFullName = reader.GetString(2);
            string surnameChiefPTD = reader.GetString(3);

            reader.Close();

            if (!DB.closeConnection())
            {
                MessageBox.Show("Нарушено соединение с базой данных!");
                this.Close();
                return;
            }

            var wordApp = new Word.Application();
            wordApp.Visible = false;

            try
            {
                var wordDocument = wordApp.Documents.Open(secondDocumentName);
                ReplaceWordStub("{chief}", surnameChiefPTD, wordDocument);
                ReplaceWordStub("{school}", drivingSchoolName, wordDocument);
                ReplaceWordStub("{schoolAddress}", drivingSchoolAddress, wordDocument);
                ReplaceWordStub("{director}", directorFullName, wordDocument);

                wordDocument.SaveAs2(@"R:\Final2.docx");

                wordDocument.Activate();
                wordDocument.PrintOut(Range: Word.WdPrintOutRange.wdPrintFromTo, From: "1", To: "1");

                wordDocument.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка печати документа!");
            }

            wordApp.Quit();
        }    

        // Данный метод нужен для печати "Заявления на допуск сдачи экзамена в ГИБДД".

        void PrintDocumentFourth(string medNumber)
        {
            DataBase DB = new DataBase();

            if (!DB.openConnection())
            {
                MessageBox.Show("Нарушено соединение с базой данных!");
                this.Close();
                return;
            }

            MySqlCommand command = new MySqlCommand("SELECT driving_school_name, surname_chief_PTD_Dative FROM `information`", DB.getConnection());
            DbDataReader reader = command.ExecuteReader();

            reader.Read();
            string drivingSchoolName = reader.GetString(0);
            string surnameChiefPTD = reader.GetString(1);
            reader.Close();

            command = new MySqlCommand("SELECT * FROM `students` WHERE medical_certificate_number=@medNum", DB.getConnection());
            command.Parameters.Add("@medNum", MySqlDbType.VarChar).Value = medNumber;
            reader = command.ExecuteReader();

            reader.Read();
            string groupName = reader.GetString(0);
            string studentFullName = reader.GetString(1);
            string studentAddress = reader.GetString(3);
            string passportData = reader.GetString(4);
            string workPlace = reader.GetString(5);
            string workAddress = reader.GetString(6);
            string medDate = reader.GetString(8).Substring(0, 10);
            string medOrg = reader.GetString(9);

            if (!DB.closeConnection())
            {
                MessageBox.Show("Нарушено соединение с базой данных!");
                this.Close();
                return;
            }

            var wordApp = new Word.Application();
            wordApp.Visible = false;

            try
            {
                var wordDocument = wordApp.Documents.Open(fourthDocumentName);
                ReplaceWordStub("{chief}", surnameChiefPTD, wordDocument);
                ReplaceWordStub("{school}", drivingSchoolName, wordDocument);
                ReplaceWordStub("{group}", groupName, wordDocument);
                ReplaceWordStub("{studentName}", studentFullName, wordDocument);
                ReplaceWordStub("{studentAddress}", studentAddress, wordDocument);
                ReplaceWordStub("{passport}", passportData, wordDocument);
                ReplaceWordStub("{work}", workPlace, wordDocument);
                ReplaceWordStub("{workAddress}", workAddress, wordDocument);
                ReplaceWordStub("{medNum}", medNumber, wordDocument);
                ReplaceWordStub("{medDate}", medDate, wordDocument);
                ReplaceWordStub("{medOrg}", medOrg, wordDocument);


                wordDocument.SaveAs2(@"R:\Final4.docx");

                wordDocument.Activate();
                wordDocument.PrintOut(Range: Word.WdPrintOutRange.wdPrintFromTo, From: "1", To: "1");

                wordDocument.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка печати документа!");
            }

            wordApp.Quit();
        }

        // Данный метод печатает "Платёжное поручение за сдачу экзамена в ГИБДД".

        void PrintDocumentSixth(string medNumber)
        {
            DataBase DB = new DataBase();

            if (!DB.openConnection())
            {
                MessageBox.Show("Нарушено соединение с базой данных!");
                this.Close();
                return;
            }

            MySqlCommand command = new MySqlCommand("SELECT requisites_PTD FROM `information`", DB.getConnection());
            DbDataReader reader = command.ExecuteReader();

            reader.Read();
            string requisites = reader.GetString(0);
            reader.Close();

            command = new MySqlCommand("SELECT student_fullName, student_address FROM `students` WHERE medical_certificate_number=@medNum", DB.getConnection());
            command.Parameters.Add("@medNum", MySqlDbType.VarChar).Value = medNumber;
            reader = command.ExecuteReader();

            reader.Read();
            string studentFullName = reader.GetString(0);
            string studentAddress = reader.GetString(1);

            if (!DB.closeConnection())
            {
                MessageBox.Show("Нарушено соединение с базой данных!");
                this.Close();
                return;
            }

            string currDate = getCurrentDateDB();

            var wordApp = new Word.Application();
            wordApp.Visible = false;

            try
            {
                var wordDocument = wordApp.Documents.Open(sixthDocumentName);
                ReplaceWordStub("{requisites}", requisites, wordDocument);
                ReplaceWordStub("{studentName}", studentFullName, wordDocument);
                ReplaceWordStub("{studentAddress}", studentAddress, wordDocument);
                ReplaceWordStub("{currDate}", currDate, wordDocument);

                wordDocument.SaveAs2(@"R:\Final6.docx");

                wordDocument.Activate();
                wordDocument.PrintOut(Range: Word.WdPrintOutRange.wdPrintFromTo, From: "1", To: "1");

                wordDocument.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка печати документа!");
            }

            wordApp.Quit();
        }

        // Данный метод печатает "Экзаменационный протокол".

        void PrintDocumentEighth(string groupName)
        {
            DataBase DB = new DataBase();

            if (!DB.openConnection())
            {
                MessageBox.Show("Нарушено соединение с базой данных!");
                this.Close();
                return;
            }

            MySqlCommand command = new MySqlCommand("SELECT student_fullName, protocol_number, protocol_date FROM `students` WHERE group_name=@gName", DB.getConnection());
            command.Parameters.Add("@gName", MySqlDbType.VarChar).Value = groupName;
            DbDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                var wordApp = new Word.Application();
                wordApp.Visible = false;

                try
                {
                    var wordDocument = wordApp.Documents.Open(eighthDocumentName);
                    
                    int i = 1;

                    while (reader.Read()) // В цикле перебираются все записи о студентах группы.
                    {
                        string studentFullName = reader.GetString(0);
                        string protocolNum = reader.GetString(1);
                        string protocolDate = reader.GetString(2).Substring(0, 10);

                        ReplaceWordStub("{name" + i.ToString() + "}", studentFullName, wordDocument);
                        ReplaceWordStub("{proNum" + i.ToString() + "}", protocolNum, wordDocument);
                        ReplaceWordStub("{proDate" + i.ToString() + "}", protocolDate, wordDocument);

                        i++;
                    }

                    var tempDocument = wordDocument;
                    tempDocument.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;

                    tempDocument.SaveAs2(@"R:\Final8.docx");

                    wordDocument.Activate();
                    wordDocument.PrintOut(Range: Word.WdPrintOutRange.wdPrintFromTo, From: "1", To: "1");

                    wordDocument.Close();
                }
                catch
                {
                    MessageBox.Show("Ошибка печати документа!");
                }

                wordApp.Quit();
            }
            else
            {
                MessageBox.Show("Группа пуста или не существует!");
            }

            if (!DB.closeConnection())
            {
                MessageBox.Show("Нарушено соединение с базой данных!");
                this.Close();
                return;
            }
        }

        // Данный метод служит для печати "Экзаменационной карточки водителя".

        void PrintDocumentTenth(string medNumber)
        {
            DataBase DB = new DataBase();

            if (!DB.openConnection())
            {
                MessageBox.Show("Нарушено соединение с базой данных!");
                this.Close();
                return;
            }

            MySqlCommand command = new MySqlCommand("SELECT driving_school_name FROM `information`", DB.getConnection());
            DbDataReader reader = command.ExecuteReader();

            reader.Read();
            string schoolName = reader.GetString(0);
            reader.Close();

            command = new MySqlCommand("SELECT * FROM `students` WHERE medical_certificate_number=@medNum", DB.getConnection());
            command.Parameters.Add("@medNum", MySqlDbType.VarChar).Value = medNumber;
            reader = command.ExecuteReader();

            reader.Read();
            string studentFullName = reader.GetString(1);
            string studentAddress = reader.GetString(3);
            string passportData = reader.GetString(4);          
            string medDate = reader.GetString(8).Substring(0, 10);
            string medOrg = reader.GetString(9);
            string protocolNum = reader.GetString(10);
            string protocolDate = reader.GetString(11).Substring(0, 10);
            string certificateNum = reader.GetString(12);
            string certificateDate = reader.GetString(13).Substring(0, 10);
            string category = reader.GetString(14);

            if (!DB.closeConnection())
            {
                MessageBox.Show("Нарушено соединение с базой данных!");
                this.Close();
                return;
            }

            var wordApp = new Word.Application();
            wordApp.Visible = false;

            try
            {
                var wordDocument = wordApp.Documents.Open(tenthDocumentName);
                ReplaceWordStub("{school}", schoolName, wordDocument);
                ReplaceWordStub("{studentName}", studentFullName, wordDocument);
                ReplaceWordStub("{studentAddress}", studentAddress, wordDocument);
                ReplaceWordStub("{passport}", passportData, wordDocument);
                ReplaceWordStub("{medNum}", medNumber, wordDocument);
                ReplaceWordStub("{medDate}", medDate, wordDocument);
                ReplaceWordStub("{medOrg}", medOrg, wordDocument);
                ReplaceWordStub("{proNum}", protocolNum, wordDocument);
                ReplaceWordStub("{proDate}", protocolDate, wordDocument);
                ReplaceWordStub("{cerNum}", certificateNum, wordDocument);
                ReplaceWordStub("{cerDate}", certificateDate, wordDocument);
                ReplaceWordStub("{category}", category, wordDocument);

                wordDocument.SaveAs2(@"R:\Final10.docx");

                wordDocument.Activate();
                wordDocument.PrintOut(Range: Word.WdPrintOutRange.wdPrintFromTo, From: "1", To: "1");

                wordDocument.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка печати документа!");
            }

            wordApp.Quit();
        }

        // Данный метод печатает "Свидетельство об окончании автошколы".

        void PrintDocumentEleventh(string medNumber)
        {
            DataBase DB = new DataBase();

            if (!DB.openConnection())
            {
                MessageBox.Show("Нарушено соединение с базой данных!");
                this.Close();
                return;
            }

            MySqlCommand command = new MySqlCommand("SELECT driving_school_name, fullName_of_director, surname_chief_PTD FROM `information`", DB.getConnection());
            DbDataReader reader = command.ExecuteReader();

            reader.Read();
            string schoolName = reader.GetString(0);
            string directorFullName = reader.GetString(1);
            string chiefSurname = reader.GetString(2);
            reader.Close();

            command = new MySqlCommand("SELECT start_date, end_date FROM `groups` WHERE group_name='ИП-815'", DB.getConnection());
            reader = command.ExecuteReader();

            reader.Read();
            string startDate = reader.GetString(0).Substring(0, 10);
            string endDate = reader.GetString(1).Substring(0, 10);
            reader.Close();

            command = new MySqlCommand("SELECT student_fullName_dative,  protocol_number, protocol_date, certificate_number, certificate_date, category" +
                " FROM `students` WHERE medical_certificate_number=@medNum", DB.getConnection());
            command.Parameters.Add("@medNum", MySqlDbType.VarChar).Value = medNumber;
            reader = command.ExecuteReader();

            reader.Read();
            string studentFullNameDative = reader.GetString(0);
            string protocolNum = reader.GetString(1);
            string protocolDate = reader.GetString(2).Substring(0, 10);
            string category = reader.GetString(5);
            reader.Close();

            string currDate = getCurrentDateDB();

            if (!DB.closeConnection())
            {
                MessageBox.Show("Нарушено соединение с базой данных!");
                this.Close();
                return;
            }

            var wordApp = new Word.Application();
            wordApp.Visible = false;

            try
            {
                var wordDocument = wordApp.Documents.Open(eleventhDocumentName);   
                ReplaceWordStub("{studentName}", studentFullNameDative, wordDocument);
                ReplaceWordStub("{startDate}", startDate, wordDocument);
                ReplaceWordStub("{endDate}", endDate, wordDocument);
                ReplaceWordStub("{school}", schoolName, wordDocument);
                ReplaceWordStub("{category}", category, wordDocument);
                ReplaceWordStub("{director}", directorFullName, wordDocument);
                ReplaceWordStub("{proNum}", protocolNum, wordDocument);
                ReplaceWordStub("{proDate}", protocolDate, wordDocument);
                ReplaceWordStub("{currDate}", currDate, wordDocument);            

                wordDocument.SaveAs2(@"R:\Final11.docx");

                wordDocument.Activate();
                wordDocument.PrintOut(Range: Word.WdPrintOutRange.wdPrintFromTo, From: "1", To: "1");

                wordDocument.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка печати документа!");
            }

            wordApp.Quit();
        }
    }
}
