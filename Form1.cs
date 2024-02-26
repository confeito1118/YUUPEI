using ClosedXML.Excel;

namespace YUUPEI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void userAdd_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void excel_Click(object sender, EventArgs e)
        {
            // 新規ワークブックの作成
            // using var wb = new XLWorkbook();
            // 既存のワークブックを開く
            using var wb = new XLWorkbook(@"C:\Users\sakai\test.xlsx");
            // 新規シートの作成
            var ws = wb.Worksheets.Add("aaa");
            // セルに値を入力
            var cell = ws.Cell(1, 1);
            cell.Value = "てすと";
            // Excelの保存
            wb.SaveAs(@"C:\Users\yudu-\Downloads\hogehoge.xlsx");
        }
    }
}
