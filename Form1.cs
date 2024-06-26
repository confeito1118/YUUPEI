using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.VisualBasic;
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
            // 新規ワークブックの作成
            //using var wb = new XLWorkbook();
            // 既存のワークブックを開く
            using var wb = new XLWorkbook(@"C:\Users\yudu-\Downloads\hogehoge.xlsx");
            // 新規シートの作成
            // var ws = wb.Worksheets.Add("aaa");
            var ws = wb.Worksheet("aaa");
            // セルに値を入力
            var cell = ws.Cell(4, 4);
            cell.Value = "てすと";
            // Excelの保存
            wb.SaveAs(@"C:\Users\yudu-\Downloads\hogehoge.xlsx");
        }

        /// <summary>
        /// ユーザー情報の取得
        /// </summary>
        private void selectUserList()
        {
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
                            userDataView.Rows[cnt].Cells[0].Value = (string)reader["name_kan_sei"] + " " + (string)reader["name_kan_mei"];
                            userDataView.Rows[cnt].Cells[1].Value = (string)reader["address"];
                            userDataView.Rows[cnt].Cells[2].Value = (string)reader["tell"] + "（" + (string)reader["tell_type"] + "）";
                            userDataView.Rows[cnt].Cells[3].Value = "編集";
                            userDataView.Rows[cnt].Cells[3].ToolTipText = reader["number"].ToString();
                            userDataView.Rows[cnt].Cells[4].Value = "削除";
                            userDataView.Rows[cnt].Cells[4].ToolTipText = reader["number"].ToString();
                            cnt++;
                        }
                        reader.Close();
                    }
                }

                connection.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string fileName = @"./start.txt";
            if (System.IO.File.Exists(fileName))
            {
                // MessageBox.Show("'" + fileName + "' セットアップウィザードは存在します。");

                userDataView.RowCount = 50;
                selectUserList();
            }
            else
            {
                // テーブル名が存在しなければ作成する
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

                // クエリー実行
                ExecuteNonQuery(query.ToString());

                using (FileStream fs = File.Create(fileName)) ;
            }
        }

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

        private void ユーザ追加AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageUserAdd();
        }

        private void pageUserAdd()
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        /// <summary>
        /// 編集ボタンのクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // クリックした列が対象列かチェックする
            DataGridView dgv = (DataGridView)sender;
            // 詳細ボタンをクリック
            if (dgv.Columns[e.ColumnIndex].Name == "detail")
            {
                MessageBox.Show(e.RowIndex.ToString() +
                    "行のボタンがクリックされました。");
            }
            // 削除ボタンをクリック
            if (dgv.Columns[e.ColumnIndex].Name == "delete")
            {
                // 削除ボタンのツールチップを取得
                // label1.Text = userDataView.Rows[e.RowIndex].Cells[4].ToolTipText;
                // 削除処理
                try
                {
                    using (var conn = new SQLiteConnection(connectionString))
                    using (var command = conn.CreateCommand())
                    {
                        // 接続
                        conn.Open();

                        // コマンドの実行処理
                        command.CommandText = "DELETE FROM userlist WHERE number = " + userDataView.Rows[e.RowIndex].Cells[4].ToolTipText;
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("削除に失敗しました");
                }

            }
        }

        private void reloadTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectUserList();
        }
    }
}
