using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Data.SQLite;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace YUUPEI
{
    public partial class Form1 : Form
    {
        const string connectionString = "Data Source=DataBase.sqlite";

        public Form1()
        {
            InitializeComponent();
        }

        private void userAdd_Click(object sender, EventArgs e)
        {
            pageUserAdd();
        }

        private void excel_Click(object sender, EventArgs e)
        {
            // �V�K���[�N�u�b�N�̍쐬
            //using var wb = new XLWorkbook();
            // �����̃��[�N�u�b�N���J��
            using var wb = new XLWorkbook(@"C:\Users\yudu-\Downloads\hogehoge.xlsx");
            // �V�K�V�[�g�̍쐬
            // var ws = wb.Worksheets.Add("aaa");
            var ws = wb.Worksheet("aaa");
            // �Z���ɒl�����
            var cell = ws.Cell(4, 4);
            cell.Value = "�Ă���";
            // Excel�̕ۑ�
            wb.SaveAs(@"C:\Users\yudu-\Downloads\hogehoge.xlsx");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string fileName = @"./start.txt";
            if (System.IO.File.Exists(fileName))
            {
                // MessageBox.Show("'" + fileName + "' �Z�b�g�A�b�v�E�B�U�[�h�͑��݂��܂��B");

                userDataView.RowCount = 50;

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    var cnt = 0;

                    var sql = "SELECT * FROM userlist";
                    using (var command = new SQLiteCommand(sql, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                userDataView.Rows[cnt].Cells[0].Value = (string) reader["name_kan_sei"] + " " + (string) reader["name_kan_mei"];
                                // userDataView.Rows[cnt].Cells[].Value = (string) reader["name_furi_sei"] + " " + (string) reader["name_furi_mei"];
                                userDataView.Rows[cnt].Cells[1].Value = (string) reader["address"];
                                userDataView.Rows[cnt].Cells[2].Value = (string) reader["tell"] + "�i" + (string) reader["tell_type"] + "�j";
                                // userDataView.Rows[cnt].Cells[3].Value = "a";
                                cnt++;
                            }
                            reader.Close();
                        }
                    }

                    connection.Close();
                }
            }
            else
            {
                // �e�[�u���������݂��Ȃ���΍쐬����
                StringBuilder query = new StringBuilder();
                query.Clear();
                query.Append("CREATE TABLE IF NOT EXISTS userlist (");
                query.Append(" number INTEGER PRIMARY KEY AUTOINCREMENT");
                query.Append(" ,name_kan_sei TEXT NOT NULL");
                query.Append(" ,name_kan_mei TEXT NOT NULL");
                query.Append(" ,name_furi_sei TEXT NOT NULL");
                query.Append(" ,name_furi_mei TEXT NOT NULL");
                query.Append(" ,sex INTEGER NOT NULL");
                query.Append(" ,date_birthday DATE NOT NULL");
                query.Append(" ,disease TEXT");
                query.Append(" ,tell TEXT NOT NULL");
                query.Append(" ,tell_type TEXT NOT NULL");
                query.Append(" ,zipcode TEXT NOT NULL");
                query.Append(" ,address TEXT NOT NULL");
                query.Append(" ,mansion TEXT");
                query.Append(" ,date_servicestart DATE NOT NULL");
                //query.Append(" ,primary key (NO)");
                query.Append(")");

                // �N�G���[���s
                ExecuteNonQuery(query.ToString());

                using (FileStream fs = File.Create(fileName)) ;
            }
        }

        private void ExecuteNonQuery(string query)
        {
            try
            {
                // �ڑ�����w��
                using (var conn = new SQLiteConnection(connectionString))
                using (var command = conn.CreateCommand())
                {
                    // �ڑ�
                    conn.Open();

                    // �R�}���h�̎��s����
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                    //var value = command.ExecuteNonQuery();
                    //MessageBox.Show($"�X�V���ꂽ���R�[�h���� {value} �ł��B");
                }
            }
            catch (Exception ex)
            {
                //��O�������������̓��b�Z�[�W�{�b�N�X��\��
                MessageBox.Show(ex.Message);
            }
        }

        private void ���[�U�ǉ�AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageUserAdd();
        }

        private void pageUserAdd()
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
