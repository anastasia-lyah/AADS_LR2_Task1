using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AADS_LR2_Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int[] array = txtArray.Text.Split(',').Select(int.Parse).ToArray();
                int target = int.Parse(txtTarget.Text);

                if (!IsSorted(array))
                {
                    DialogResult dialogResult = MessageBox.Show("Масив не відсортований. Ви хочете його відсортувати?",
                        "Масив не відсортований", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Array.Sort(array);
                        txtArray.Text = string.Join(",", array);
                    }
                    else
                    {
                        return; 
                    }
                }

                Stopwatch swBase = new Stopwatch();
                swBase.Start();
                int baseIndex = BinarySearch(array, target);
                swBase.Stop();

                Stopwatch swOptimized = new Stopwatch();
                swOptimized.Start();
                int optimizedIndex = OptimizedBinarySearch(array, target);
                swOptimized.Stop();

                lblBaseResult.Text = baseIndex >= 0 ? $"Знайдено на індексі {baseIndex}" : "Не знайдено";
                lblOptimizedResult.Text = optimizedIndex >= 0 ? $"Знайдено на індексі {optimizedIndex}" : "Не знайдено";
                lblBaseTime.Text = $"Час базового: {swBase.ElapsedTicks} тік";
                lblOptimizedTime.Text = $"Час оптимізованого: {swOptimized.ElapsedTicks} тік";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }
        private bool IsSorted(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                    return false;
            }
            return true;
        }
        private int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int middle = left + (right - left) / 2;

                if (array[middle] == target)
                    return middle;
                else if (array[middle] < target)
                    left = middle + 1;
                else
                    right = middle - 1;
            }

            return -1;
        }
        private int OptimizedBinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int middle = left + ((target - array[left]) * (right - left)) / (array[right] - array[left]);

                if (middle < left || middle > right)
                    return -1;

                if (array[middle] == target)
                    return middle;
                else if (array[middle] < target)
                    left = middle + 1;
                else
                    right = middle - 1;
            }
            return -1;
        }
        private void lblOptimizedResult_Click(object sender, EventArgs e)
        {

        }
    }
}
