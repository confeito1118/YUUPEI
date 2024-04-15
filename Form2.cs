using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace YUUPEI
{
    public partial class Form2 : Form
    {
        const string connectionString = "Data Source=DataBase.sqlite";

        public Form2()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            var birthday = date_birthday.Text;

            InsertRecord(
                name_kan_sei.Text.ToString(),
                name_kan_mei.Text.ToString(),
                name_furi_sei.Text.ToString(),
                name_furi_mei.Text.ToString(),
                0,
                birthday,
                disease.Text.ToString(),
                tell.Text.ToString(),
                tell_type.Text.ToString(),
                zipcode.Text.ToString(),
                address.Text.ToString(),
                mansion.Text.ToString(),
                date_servicestart.Text
            );

            this.Close();

            // Form1.selectUserList();
        }

        // ユーザ情報の登録
        private void InsertRecord(string name_kan_sei, string name_kan_mei, string name_furi_sei, string name_furi_mei, IntegerProperty sex, string date_birthday, string disease, string tell, string tell_type, string zipcode, string address, string mansion, string date_servicestart)
        {
            // レコードの登録
            var query = "INSERT INTO userlist (name_kan_sei, name_kan_mei, name_furi_sei, name_furi_mei, sex, date_birthday, disease, tell, tell_type, zipcode, address, mansion, date_servicestart) VALUES (" +
                $"'{name_kan_sei}', '{name_kan_mei}', '{name_furi_sei}', '{name_furi_mei}', '{sex}', '{date_birthday}', '{disease}', '{tell}', '{tell_type}', '{zipcode}', '{address}', '{mansion}', '{date_servicestart}')";

            // クエリー実行
            ExecuteNonQuery(query.ToString());
        }

        // SQL実行
        private void ExecuteNonQuery(string query)
        {
            try
            {
                // 接続先を指定
                using (var conn = new SQLiteConnection(connectionString))
                using (var command = conn.CreateCommand())
                {
                    // 接続
                    conn.Open();

                    // コマンドの実行処理
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                    //var value = command.ExecuteNonQuery();
                    //MessageBox.Show($"更新されたレコード数は {value} です。");
                }
            }
            catch (Exception ex)
            {
                //例外が発生した時はメッセージボックスを表示
                MessageBox.Show(ex.Message);
            }
        }
    }
}
