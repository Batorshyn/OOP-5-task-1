using SquareApp;

namespace OOP_5_task_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void PrintSquareInfo<T>(TSquare<T> square, string name) where T : struct, IComparable
        {
            rtbOutput.AppendText($"{name}: {square.ToString()}\n");
            rtbOutput.AppendText($" - Площа: {square.Area()}");
            rtbOutput.AppendText($" - Периметр: {square.Perimeter()}\n\n");
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            rtbOutput.Clear();
            try
            {
                double side1 = Convert.ToDouble(txtSide1.Text);
                double side2 = Convert.ToDouble(txtSide2.Text);
                double multiplier = Convert.ToDouble(txtMultiplier.Text);

                TSquare<double> sq1 = new TSquare<double>(side1);
                TSquare<double> sq2 = new TSquare<double>(side2);

                rtbOutput.AppendText("\t\t Початкові дані\n");
                PrintSquareInfo(sq1, "Квадрат 1");
                PrintSquareInfo(sq2, "Квадрат 2");

                rtbOutput.AppendText("\t\t Результати порівняння\n");
                int compResult = sq1.CompareTo(sq2);
                if (compResult > 0)
                    rtbOutput.AppendText("Квадрат 1 більший за Квадрат 2.\n\n");
                else if (compResult < 0)
                    rtbOutput.AppendText("Квадрат 1 менший за Квадрат 2.\n\n");
                else
                    rtbOutput.AppendText("Квадрати однакові.");

                rtbOutput.AppendText("\t\t Перевантаження операторів\n");

                TSquare<double> sqAdd = sq1 + sq2;
                rtbOutput.AppendText($"Оператор + (Додавання сторін): {sqAdd.ToString()}\n");

                TSquare<double> sqSub = sq1 - sq2;
                rtbOutput.AppendText($"Оператор - (Віднімання сторін): {sqSub.ToString()}\n");

                TSquare<double> sqMult = sq1 * multiplier;
                rtbOutput.AppendText($"Оператор * (Множення квадрата 1 на {multiplier}): {sqMult.ToString()}\n");

            }
            catch (FormatException)
            {
                MessageBox.Show("Будь ласка, введіть коректні числові значення.", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
