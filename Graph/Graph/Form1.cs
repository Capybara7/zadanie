// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Graph
{
    public partial class Form1 : Form
    {
        DrawGraph G;
        List<Vertex> V;
        List<Edge> E;
        int[,] AMatrix; //матрица смежности
        int[,] IMatrix; //матрица инцидентности

        int selected1 = -1; //выбранные вершины, для соединения линиями
        int selected2 = -1;

        public Form1()
        {
            InitializeComponent();
            V = new List<Vertex>();
            G = new DrawGraph(sheet.Width, sheet.Height);
            E = new List<Edge>();
            sheet.Image = G.GetBitmap();
        }

        private void sheet_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                for (int i = 0; i < V.Count; i++)
                {
                    if (Math.Pow((V[i].x - e.X), 2) + Math.Pow((V[i].y - e.Y), 2) <= G.R * G.R)
                    {
                        if (selected1 == -1)
                        {
                            G.drawSelectedVertex(V[i].x, V[i].y);
                            selected1 = i;
                            sheet.Image = G.GetBitmap();
                            break;
                        }
                        if (selected2 == -1)
                        {
                            G.drawSelectedVertex(V[i].x, V[i].y);
                            selected2 = i;
                            E.Add(new Edge(selected1, selected2));
                            G.drawEdge(V[selected1], V[selected2], E[E.Count - 1], E.Count - 1);
                            selected1 = -1;
                            selected2 = -1;
                            sheet.Image = G.GetBitmap();
                            break;
                        }
                    }
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                if ((selected1 != -1) &&
                    (Math.Pow((V[selected1].x - e.X), 2) + Math.Pow((V[selected1].y - e.Y), 2) <= G.R * G.R))
                {
                    G.drawVertex(V[selected1].x, V[selected1].y, (selected1 + 1).ToString());
                    selected1 = -1;
                    sheet.Image = G.GetBitmap();
                }
            }
            {//for (int i = 0; i < V.Count; i++)
            //{
            //    if (Math.Pow((V[i].x - e.X), 2) + Math.Pow((V[i].y - e.Y), 2) <= G.R * G.R)
            //    {
            //        if (selected1 == i)
            //        {
            //            G.drawSelectedVertex(V[i].x, V[i].y, 0);
            //            selected1 = -1;
            //            sheet.Image = G.GetBitmap();
            //            break;
            //        }
            //        if (selected1 != -1)
            //        {
            //            selected1 = -1;
            //            G.clearSheet();
            //            G.drawALLGraph(V, E);
            //            sheet.Image = G.GetBitmap();
            //        }
            //        if (selected1 == -1)
            //        {
            //            G.drawSelectedVertex(V[i].x, V[i].y, 1);
            //            selected1 = i;
            //            sheet.Image = G.GetBitmap();
            //            //createAdjAndOut();
            //            //listBoxMatrix.Items.Clear();
            //            //int degree = 0;
            //            //for (int j = 0; j < V.Count; j++)
            //            //    degree += AMatrix[selected1, j];
            //            //listBoxMatrix.Items.Add("Степень вершины №" + (selected1 + 1) + " равна " + degree);
            //            break;
            //        }
            //    }
            /*}*/}//Просто выделение
        }

        private void sheet_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Удаление
            if (e.Button == MouseButtons.Right)
            {
                bool flag = false; //удалили ли что-нибудь по ЭТОМУ клику
                //ищем, возможно была нажата вершина
                for (int i = 0; i < V.Count; i++)
                {
                    if (Math.Pow((V[i].x - e.X), 2) + Math.Pow((V[i].y - e.Y), 2) <= G.R * G.R)
                    {
                        for (int j = 0; j < E.Count; j++)
                        {
                            if ((E[j].v1 == i) || (E[j].v2 == i))
                            {
                                E.RemoveAt(j);
                                j--;
                            }
                            else
                            {
                                if (E[j].v1 > i) E[j].v1--;
                                if (E[j].v2 > i) E[j].v2--;
                            }
                        }
                        V.RemoveAt(i);
                        flag = true;
                        break;
                    }
                }
                //ищем, возможно было нажато ребро
                if (!flag)
                {
                    for (int i = 0; i < E.Count; i++)
                    {
                        if (E[i].v1 == E[i].v2) //если это петля
                        {
                            if ((Math.Pow((V[E[i].v1].x - G.R - e.X), 2) + Math.Pow((V[E[i].v1].y - G.R - e.Y), 2) <= ((G.R + 2) * (G.R + 2))) &&
                                (Math.Pow((V[E[i].v1].x - G.R - e.X), 2) + Math.Pow((V[E[i].v1].y - G.R - e.Y), 2) >= ((G.R - 2) * (G.R - 2))))
                            {
                                E.RemoveAt(i);
                                flag = true;
                                break;
                            }
                        }
                        else //не петля
                        {
                            if (((e.X - V[E[i].v1].x) * (V[E[i].v2].y - V[E[i].v1].y) / (V[E[i].v2].x - V[E[i].v1].x) + V[E[i].v1].y) <= (e.Y + 4) &&
                                ((e.X - V[E[i].v1].x) * (V[E[i].v2].y - V[E[i].v1].y) / (V[E[i].v2].x - V[E[i].v1].x) + V[E[i].v1].y) >= (e.Y - 4))
                            {
                                if ((V[E[i].v1].x <= V[E[i].v2].x && V[E[i].v1].x <= e.X && e.X <= V[E[i].v2].x) ||
                                    (V[E[i].v1].x >= V[E[i].v2].x && V[E[i].v1].x >= e.X && e.X >= V[E[i].v2].x))
                                {
                                    E.RemoveAt(i);
                                    flag = true;
                                    break;
                                }
                            }
                        }
                    }
                }
                //если что-то было удалено, то обновляем граф на экране
                if (flag)
                {
                    G.clearSheet();
                    G.drawALLGraph(V, E);
                    sheet.Image = G.GetBitmap();
                }
            }
            //Создание
            if (e.Button == MouseButtons.Left)
            {
                V.Add(new Vertex(e.X, e.Y));
                G.drawVertex(e.X, e.Y, V.Count.ToString());
                sheet.Image = G.GetBitmap();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createAdjAndOut();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            createIncAndOut();
        }

        //создание матрицы смежности и вывод
        private void createAdjAndOut()
        {
            AMatrix = new int[V.Count, V.Count];
            G.fillAdjacencyMatrix(V.Count, E, AMatrix);
            dataGridView1.Rows.Clear();
            dataGridView1.RowCount = V.Count + 1;
            dataGridView1.ColumnCount = V.Count + 1;
            for (int i = 1; i < V.Count + 1; i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = i;
                dataGridView1.Rows[i].Cells[0].Value = i;
            }
            for (int i = 0; i < V.Count + 1; i++)
            {
                dataGridView1.Columns[i].Width = 22;
            }
            for (int i = 0; i < V.Count; i++)
            {
                for (int j = 0; j < V.Count; j++)
                {
                    dataGridView1.Rows[i + 1].Cells[j + 1].Value = AMatrix[i, j];
                }
            }
        }

        //создание матрицы инцидентности и вывод
        private void createIncAndOut()
        {
            if (E.Count > 0)
            {
                IMatrix = new int[V.Count, E.Count];
                G.fillIncidenceMatrix(V.Count, E, IMatrix);
                dataGridView1.Rows.Clear();
                dataGridView1.RowCount = V.Count + 1;
                dataGridView1.ColumnCount = E.Count + 1;
                for (int i = 0; i < E.Count + 1; i++)
                {
                    dataGridView1.Columns[i].Width = 22;
                }
                for (int i = 0; i < V.Count; i++)
                {
                    dataGridView1.Rows[i + 1].Cells[0].Value = i + 1;
                }
                for (int i = 0; i < E.Count; i++)
                {
                    dataGridView1.Rows[0].Cells[i + 1].Value = (char)('a' + i);
                }
                for (int i = 0; i < V.Count; i++)
                {
                    for (int j = 0; j < E.Count; j++)
                    {
                        dataGridView1.Rows[i + 1].Cells[j + 1].Value = IMatrix[i, j];
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //1-white 2-black
            int[] color = new int[V.Count];
            for (int i = 0; i < V.Count; i++)
            {
                for (int k = 0; k < V.Count; k++)
                    color[k] = 1;
                List<int> cycle = new List<int>();
                cycle.Add(i + 1);
                DFScycle(i, i, E, color, -1, cycle);
            }
        }
        private void DFScycle(int u, int endV, List<Edge> E, int[] color, int unavailableEdge, List<int> cycle)
        {
            //если u == endV, то эту вершину перекрашивать не нужно, иначе мы в нее не вернемся, а вернуться необходимо
            if (u != endV)
                color[u] = 2;
            else
            {
                if (cycle.Count >= 2)
                {
                    cycle.Reverse();
                    string s = cycle[0].ToString();
                    for (int i = 1; i < cycle.Count; i++)
                        s += "-" + cycle[i].ToString();
                    bool flag = false; //есть ли палиндром для этого цикла графа в листбоксе?
                    for (int i = 0; i < listBox1.Items.Count; i++)
                        if (listBox1.Items[i].ToString() == s)
                        {
                            flag = true;
                            break;
                        }
                    if (!flag)
                    {
                        cycle.Reverse();
                        s = cycle[0].ToString();
                        for (int i = 1; i < cycle.Count; i++)
                            s += "-" + cycle[i].ToString();
                        listBox1.Items.Add(s);
                    }
                    return;
                }
            }
            for (int w = 0; w < E.Count; w++)
            {
                if (w == unavailableEdge)
                    continue;
                if (color[E[w].v2] == 1 && E[w].v1 == u)
                {
                    List<int> cycleNEW = new List<int>(cycle);
                    cycleNEW.Add(E[w].v2 + 1);
                    DFScycle(E[w].v2, endV, E, color, w, cycleNEW);
                    color[E[w].v2] = 1;
                }
                else if (color[E[w].v1] == 1 && E[w].v2 == u)
                {
                    List<int> cycleNEW = new List<int>(cycle);
                    cycleNEW.Add(E[w].v1 + 1);
                    DFScycle(E[w].v1, endV, E, color, w, cycleNEW);
                    color[E[w].v1] = 1;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            const string message = "Вы действительно хотите полностью удалить граф?";
            const string caption = "Удаление";
            var MBSave = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (MBSave == DialogResult.Yes)
            {
                V.Clear();
                E.Clear();
                G.clearSheet();
                sheet.Image = G.GetBitmap();
            }
        }
    }
}
