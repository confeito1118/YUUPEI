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
    }
}
