using System.Linq.Expressions;

namespace Gpax
{
    public partial class Form1 : Form
    {
        private List<double> grades;
        public Form1()
        {
            InitializeComponent();
            grades = new List<double>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] gradeStrings = tbGrades.Text.Split(',');
            foreach (string gradeString in gradeStrings)
            {
                if (double.TryParse(gradeString, out double grade))
                {
                    grades.Add(grade);
                }
            }
            if (grades.Count == 0)
            {
                MessageBox.Show("กรุณาป้อนข้อมูลเกรด");
                return;
            }

            double gpax = CalculateGPAX(grades);
            double maxGrade = grades.Max();
            double minGrade = grades.Min();
            int studentCount = grades.Count;

            tbGPAX.Text = gpax.ToString("0.00");
            tbMaxGrade.Text = maxGrade.ToString("0.00");
            tbMinGrade.Text = minGrade.ToString("0.00");
            tbStudentCount.Text = studentCount.ToString();
        }
        private double CalculateGPAX(List<double> grades)
        {
            double sum = 0;
            foreach (double grade in grades)
            {
                sum += grade;
            }
            return sum / grades.Count;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}     
