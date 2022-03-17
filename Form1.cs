using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Instruments3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            var box = (NumericUpDown)sender;
            var count = Convert.ToInt32(box.Value);

            TableZ.ColumnCount = count + 1;

            SetQuadroMatrix(NormalTable, count);
            SetQuadroMatrix(BadTable, count);

            FillHeadersAndWeights(TableZ);
            FillHeaders(NormalTable, NormalTable.Columns.Count);
            FillHeaders(BadTable, BadTable.Columns.Count);
        }

        private void SetQuadroMatrix(DataGridView table, int count)
        {
            table.RowCount = count;
            table.ColumnCount = count;
        }

        private void FillHeadersAndWeights(DataGridView tableZ)
        {
            FillHeaders(tableZ, tableZ.Columns.Count - 1);
            int lastIndex = tableZ.Columns.Count - 1;
            tableZ.Columns[lastIndex].HeaderCell.Value = "Веса";
        }

        private void FillHeaders(DataGridView table, int count)
        {
            for (int i = 0; i < count; i++)
            {
                table.Columns[i].HeaderCell.Value = (i + 1).ToString();
                try
                {
                    table.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }
                catch 
                {
                    continue;
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            var box = (NumericUpDown)sender;
            var count = Convert.ToInt32(box.Value);
            TableZ.RowCount = count;
            L.ColumnCount = count;
            L.RowCount = 1;
        }

        private void solver_Click(object sender, EventArgs e)
        {
            int totalWeight = GetWeight();
            FillNormalTable(totalWeight);
            FillFuckTable();
        }

        private void FillFuckTable()
        {
            for (int i = 0; i < NormalTable.Columns.Count; i++)
            {
                for (int j = 0; j < NormalTable.Columns.Count; j++)
                {
                    if (i == j)
                    {
                        BadTable[i, j].Value = "*";
                        continue;
                    }

                    double maximum = -100;
                    for (int k = 0; k < TableZ.Rows.Count; k++)
                    {
                        int first = Convert.ToInt32(TableZ[i, k].Value);
                        int second = Convert.ToInt32(TableZ[j, k].Value);

                        if (first <= second)
                        {
                            if (Math.Abs(first - second) / Convert.ToDouble(L[k, 0].Value) > maximum)
                            {
                                maximum = Math.Abs(first - second) / Convert.ToDouble(L[k, 0].Value);
                            }
                        }
                    }

                    BadTable[i, j].Value = maximum;
                }
            }
        }

        private int GetWeight()
        {
            int result = 0;

            for (int i = 0; i < TableZ.Rows.Count; i++)
            {
                result += Convert.ToInt32(TableZ[TableZ.Columns.Count - 1, i].Value);
            }

            return result;
        }

        private void FillNormalTable(int weight)
        {
            for (int i = 0; i < NormalTable.Columns.Count; i++)
            {
                for (int j = 0; j < NormalTable.Columns.Count; j++)
                {
                    if (i == j)
                    {
                        NormalTable[i, j].Value = "*";
                        continue;
                    }

                    int result = 0;
                    for (int k = 0; k < TableZ.Rows.Count; k++)
                    {
                        if (Convert.ToInt32(TableZ[i, k].Value) >= Convert.ToInt32(TableZ[j, k].Value))
                        {
                            result += Convert.ToInt32(TableZ[TableZ.Columns.Count - 1, k].Value);
                        }
                    }

                    NormalTable[i, j].Value = result / Convert.ToDouble(weight);
                }
            }
        }

        private int GetValue(int columnIndex, int rowIndex)
        {
            int result = Convert.ToInt32(TableZ[TableZ.Columns.Count - 1, rowIndex].Value);
            for (int i = 0; i < NormalTable.Columns.Count; i++)
            {
                
            }

            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var min = FindMin();
            var max = FindMax(); 

            List<int> possible = Enumerable.Range(1, NormalTable.Columns.Count).ToList();
            List<int> answer = new List<int>();

            int index = 0;
            while (possible.Count != 1)
            {
                for (int i = 0; i < NormalTable.Rows.Count; i++)
                {
                    for (int j = 0; j < NormalTable.Columns.Count; j++)
                    {
                        if (i != j && possible.Contains(i))
                        {
                            double normal = Convert.ToDouble(NormalTable[j, i].Value);
                            double bad = Convert.ToDouble(BadTable[j, i].Value);

                            if (normal >= max[index] && bad <= min[index])
                            {
                                answer.Add(i);
                                possible.Remove(i);
                            }
                        }
                    }
                }

                index++;
            }

            answer.Add(possible[0]);
            answer.Reverse();

            answerBox.Text = string.Join(" ", answer);
        }

        private List<double> FindMin()
        {
            List<double> result = new List<double>();
            for (int i = 0; i < BadTable.Rows.Count; i++)
            {
                for (int j = 0; j < BadTable.Columns.Count; j++)
                {
                    if (i != j)
                    {
                        result.Add((double) BadTable[j, i].Value);
                    }
                }
            }

            return result.Distinct().OrderBy(x => x).ToList();
        }

        private List<double> FindMax()
        {
            List<double> result = new List<double>();
            for (int i = 0; i < NormalTable.Rows.Count; i++)
            {
                for (int j = 0; j < NormalTable.Columns.Count; j++)
                {
                    if (i != j)
                    {
                        result.Add((double)NormalTable[j, i].Value);
                    }
                }
            }

            return result.Distinct().OrderByDescending(x => x).ToList();
        }
    }
}
