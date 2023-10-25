using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscreteMath_2c._1h._8w
{
    public partial class Form1 : Form
    {
           private int CurrentMarker = 1;
        public static Dictionary<int, int> Weights1 = new Dictionary<int, int>
        {
            { 1, 18},
            { 2, 21},
            { 3, 17},
            { 4, 23},
            { 5, 30},
            { 6, 7},
            { 7, 25},
            { 8, 12},
            { 9, 14},
            { 10, 28},
            { 11, 35},
            { 12, 37}
        };
        readonly static Dictionary<int, int> Weights = new Dictionary<int, int>
        {
            { 1, 23},
            { 2, 35},
            { 3, 22},
            { 4, 46},
            { 5, 33},
            { 6, 45},
            { 7, 16},
            { 8, 41},
            { 9, 21},
            { 10, 9},
            { 11, 14},
            { 12, 28}
        };
        readonly static List<Arc> Arcs = new List<Arc>()
        {
            new Arc(1, 9),
            new Arc(1, 12),
            new Arc(2, 4),
            new Arc(2, 5),
            new Arc(3, 5),
            new Arc(3, 7),
            new Arc(4, 1),
            new Arc(5, 1),
            new Arc(7, 12),
            new Arc(8, 1),
            new Arc(8, 10),
            new Arc(9, 6),
            new Arc(9, 11),
            new Arc(10, 9),
            new Arc(10, 11),
            new Arc(12, 6),
            new Arc(12, 9)
        };
        Graph Graph;
        readonly static List<Arc> Arcs1 = new List<Arc>()
        {
            new Arc(1, 2),
            new Arc(2, 5),
            new Arc(2, 6),
            new Arc(3, 9),
            new Arc(4, 6),
            new Arc(4, 8),
            new Arc(4, 11),
            new Arc(7, 11),
            new Arc(8, 5),
            new Arc(9, 4),
            new Arc(9, 7),
            new Arc(9, 8),
            new Arc(9, 12),
            new Arc(10, 9),
            new Arc(10, 11),
            new Arc(11, 6),
            new Arc(12, 8)
        };
        public Form1()
        {
            InitializeComponent();
            Graph = new Graph(12, Weights, Arcs);
            GridSetup();
        }
        public void GridSetup()
        {
            foreach (Arc Arc in Arcs)
            {
                ArcsGrid.Rows.Add(Arc.From, Arc.To);
            }
            if (GraphDataGrid.RowCount != 0)
                GraphDataGrid.Rows.Clear();
/*            if (!StepButton.Enabled)
                StepButton.Enabled = true;*/
            foreach (var n in Graph.Nodes)
            {
                GraphDataGrid.Rows.Add(n.Index,
                                       n.Weight,
                                       null,
                                       null,
                                       null,
                                       null,
                                       null,
                                       null,
                                       null,
                                       null,
                                       null,
                                       null,
                                       null,
                                       null,
                                       null,
                                       0);
            }
            CurrentMarker = 1;
            ArcsGrid.ClearSelection();
            GraphDataGrid.ClearSelection();
        }
        private void GraphDataGrid_Paint(object sender, PaintEventArgs e)
        {
            //Offsets to adjust the position of the merged Header.
            int heightOffset = -2;
            int widthOffset = -5;
            int xOffset = 0;
            int yOffset = 1;

            //Index of Header column from where the merging will start.
            int columnIndex = 2;

            //Number of Header columns to be merged.
            int columnCount = 13;

            //Get the position of the Header Cell.
            Rectangle headerCellRectangle = GraphDataGrid.GetCellDisplayRectangle(columnIndex, 0, true);

            //X coordinate of the merged Header Column.
            int xCord = headerCellRectangle.Location.X + xOffset;

            //Y coordinate of the merged Header Column.
            int yCord = headerCellRectangle.Location.Y - GraphDataGrid.ColumnHeadersHeight + yOffset;

            //Calculate Width of merged Header Column by adding the widths of all Columns to be merged.
            int mergedHeaderWidth = GraphDataGrid.Columns[columnIndex].Width * columnCount + widthOffset;

            //Calculate Width of merged Header Column by adding the widths of all Columns to be merged.
            int mergedHeaderHeight = GraphDataGrid.ColumnHeadersHeight + heightOffset;

            //Generate the merged Header Column Rectangle.
            Rectangle mergedHeaderRect = new Rectangle(xCord, yCord, mergedHeaderWidth, mergedHeaderHeight);

            //Draw the merged Header Column Rectangle.
            e.Graphics.FillRectangle(new SolidBrush(Color.White), mergedHeaderRect);

            //Draw the merged Header Column Text.
            e.Graphics.DrawString(RatioOrigin.Checked ? "Количество входящих": "Количество выходящих", GraphDataGrid.ColumnHeadersDefaultCellStyle.Font, Brushes.Black, xCord + mergedHeaderWidth / 4, yCord + mergedHeaderHeight / 4);
        }
        private void StepButton_Click(object sender, EventArgs e)
        {
            RatioOrigin.Enabled = false;
            RatioStock.Enabled = false;
            btnSetupGrid.Enabled = false;
            if (CurrentMarker <= 12)
            {
                var indexDelete = RatioOrigin.Checked ? HeaviestOrigin() : LightestDrain();
                Graph.RemoveAt(indexDelete);
                Graph[indexDelete].Marker = CurrentMarker;

                GraphDataGrid.ClearSelection();
                GraphDataGrid.Rows[indexDelete - 1].Cells[15].Selected = true;

                foreach (var n in Graph.Nodes)
                {
                    DataGridViewRow FillRow = GraphDataGrid.Rows[n.Index - 1];
                    int Arcs = RatioOrigin.Checked ? n.Inners : n.Outers;
                    FillRow.Cells[2 + CurrentMarker].Value = Arcs;
                    if ((int)FillRow.Cells[1 + CurrentMarker].Value != Arcs)
                        FillRow.Cells[2 + CurrentMarker].Style.ForeColor = Color.SpringGreen;
                    FillRow.Cells[15].Value = n.Marker;
                }
                CurrentMarker++;
                if (CurrentMarker > 12)
                    StepButton.Enabled = false;
            }
        }
        private int LightestDrain()
        {
            int minWeight = 0;
            int minIndex = 0;

            foreach (Node Node in Graph.Nodes)
            {
                if ((Node.Weight < minWeight || minWeight == 0) && Node.Outers == 0 && Node.Marker == 0)
                {
                    minWeight = Node.Weight;
                    minIndex = Node.Index;
                }
            }
            return minIndex;
        }
        private int HeaviestOrigin()
        {
            int maxWeight = 0;
            int indxmaxWeight = 0;

            foreach (Node Node in Graph.Nodes)
            {
                if (Node.Weight > maxWeight && Node.Inners == 0 && Node.Marker == 0)
                {
                    maxWeight = Node.Weight;
                    indxmaxWeight = Node.Index;
                }
            }
            return indxmaxWeight;
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            RatioOrigin.Enabled = true;
            RatioOrigin.Checked = true;
            RatioStock.Enabled = true;
            btnSetupGrid.Enabled = true;
            StepButton.Enabled = false;
            Graph = new Graph(12, Weights, Arcs);
            GridSetup();
        }
        public void btnSetupGrid_Click(object sender, EventArgs e)
        {
            RatioOrigin.Enabled = true;
            RatioStock.Enabled = true;
            StepButton.Enabled = true;
            GridSetup();
            foreach (Node node in Graph.Nodes)
            {
                int Arcs = RatioOrigin.Checked ? node.Inners : node.Outers;
                GraphDataGrid.Rows[node.Index - 1].Cells[2].Value = Arcs;
            }
        }
    }
}
