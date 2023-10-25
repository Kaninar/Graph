using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DiscreteMath_2c._1h._8w
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ArcsGrid = new System.Windows.Forms.DataGridView();
            this.От = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.До = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.StepButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RatioOrigin = new RadioButton();
            this.RatioStock = new RadioButton();
            this.RatioButtons = new Container();
            this.btnSetupGrid = new System.Windows.Forms.Button();
            this.GraphDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ArcsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            //
            GraphDataGrid.Location = new Point(402, 2);
            GraphDataGrid.ColumnCount = 16;
            GraphDataGrid.Size = new Size(575, 354);
            GraphDataGrid.ColumnHeadersHeight = 40;
            GraphDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GraphDataGrid.ColumnCount = 16;
            GraphDataGrid.Font = new Font(Font.FontFamily, 13F, FontStyle.Bold);
            GraphDataGrid.Columns[0].Name = "№";
            GraphDataGrid.Columns[1].Name = "Вес";
            GraphDataGrid.Columns[15].Name = "Метка";
            GraphDataGrid.RowHeadersVisible = false;
            GraphDataGrid.ScrollBars = ScrollBars.None;
            GraphDataGrid.RowTemplate.Height = 30;
            GraphDataGrid.ReadOnly = true;
            GraphDataGrid.AllowUserToAddRows = false;
            GraphDataGrid.AllowUserToDeleteRows = false;
            GraphDataGrid.AllowUserToOrderColumns = false;
            GraphDataGrid.AllowUserToResizeRows = false;
            GraphDataGrid.AllowUserToResizeColumns = false;
            GraphDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            GraphDataGrid.Columns["№"].Width = 48;
            GraphDataGrid.ColumnHeadersDefaultCellStyle.Font = new Font(this.Font.FontFamily, 13F, FontStyle.Bold);
            GraphDataGrid.Columns["Вес"].Width = 61;
            GraphDataGrid.Columns["Вес"].ReadOnly = false;
            GraphDataGrid.Columns["Метка"].Width = 72;
            GraphDataGrid.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            GraphDataGrid.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            GraphDataGrid.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            GraphDataGrid.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            GraphDataGrid.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
            GraphDataGrid.Columns[7].SortMode = DataGridViewColumnSortMode.NotSortable;
            GraphDataGrid.Columns[8].SortMode = DataGridViewColumnSortMode.NotSortable;
            GraphDataGrid.Columns[9].SortMode = DataGridViewColumnSortMode.NotSortable;
            GraphDataGrid.Columns[10].SortMode = DataGridViewColumnSortMode.NotSortable;
            GraphDataGrid.Columns[11].SortMode = DataGridViewColumnSortMode.NotSortable;
            GraphDataGrid.Columns[12].SortMode = DataGridViewColumnSortMode.NotSortable;
            GraphDataGrid.Columns[13].SortMode = DataGridViewColumnSortMode.NotSortable;
            GraphDataGrid.Columns[14].SortMode = DataGridViewColumnSortMode.NotSortable;
            //GraphDataGrid.Columns[15].SortMode = DataGridViewColumnSortMode.NotSortable;
            GraphDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            GraphDataGrid.Paint += GraphDataGrid_Paint;
            // 
            // ArcsGrid
            // 
            this.ArcsGrid.AllowUserToAddRows = false;
            this.ArcsGrid.AllowUserToDeleteRows = false;
            this.ArcsGrid.AllowUserToResizeColumns = false;
            this.ArcsGrid.AllowUserToResizeRows = false;
            this.ArcsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ArcsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ArcsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArcsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.От,
            this.До});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ArcsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.ArcsGrid.Location = new System.Drawing.Point(990, 2);
            this.ArcsGrid.Name = "ArcsGrid";
            this.ArcsGrid.ReadOnly = true;
            this.ArcsGrid.RowHeadersVisible = false;
            this.ArcsGrid.RowTemplate.Height = 25;
            this.ArcsGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ArcsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ArcsGrid.Size = new System.Drawing.Size(120, 450);
            this.ArcsGrid.TabIndex = 0;
            this.ArcsGrid.MultiSelect = false;
            // 
            // От
            // 
            this.От.Name = "От";
            this.От.ReadOnly = true;
            // 
            // До
            // 
            this.До.Name = "До";
            this.До.ReadOnly = true;
            // 
            // Picture
            // 
            this.Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Picture.Image = global::DiscreteMath_2c._1h._8w.Properties.Resources.GraphPicture;
            this.Picture.Location = new System.Drawing.Point(2, 2);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(380, 500);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture.TabIndex = 1;
            this.Picture.TabStop = false;
            // 
            // StepButton
            // 
            this.StepButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StepButton.Location = new System.Drawing.Point(404, 450);
            this.StepButton.Name = "StepButton";
            this.StepButton.Size = new System.Drawing.Size(100, 30);
            this.StepButton.TabIndex = 0;
            this.StepButton.Text = "Шаг";
            this.StepButton.Enabled = false;
            this.StepButton.UseVisualStyleBackColor = true;
            this.StepButton.Click += new System.EventHandler(this.StepButton_Click);
            //
            this.ClearButton.Location = new Point(1035, 477);
            this.ClearButton.Size = new Size(75,25);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(ClearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Font = new Font(this.Font.FontFamily, 12F);
            this.label1.Text = "Нажмите на кнопку для удалеие слудеющего источника.";
            //
            this.RatioButtons.Add(RatioOrigin);
            this.RatioButtons.Add(RatioStock);
            //
            this.RatioOrigin.Location = new Point(402,366);
            this.RatioOrigin.Text = "От истока";
            this.RatioOrigin.Checked = true;
            this.RatioStock.Location = new Point(512, 366);
            this.RatioStock.Text = "От стока";
            //
            this.btnSetupGrid.Location = new Point(622, 366);
            this.btnSetupGrid.Text = "Установить";
            this.btnSetupGrid.Size = new Size(120, 30);
            this.btnSetupGrid.Font = new Font(Font.FontFamily, 10F, FontStyle.Regular);
            this.btnSetupGrid.Enabled = true;
            this.btnSetupGrid.Click += btnSetupGrid_Click;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 504);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.ArcsGrid);
            this.Controls.Add(this.StepButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.GraphDataGrid);
            this.Controls.Add(this.RatioOrigin);
            this.Controls.Add(this.RatioStock);
            this.Controls.Add(this.btnSetupGrid);
            this.Icon = global::DiscreteMath_2c._1h._8w.Properties.Resources.FastIcon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Граф";
            ((System.ComponentModel.ISupportInitialize)(this.ArcsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.DataGridView ArcsGrid;
        private PictureBox Picture;
        private Button StepButton;
        private Button ClearButton;
        private DataGridViewTextBoxColumn От;
        private DataGridViewTextBoxColumn До;
        private Label label1;
        private DataGridView GraphDataGrid;
        public RadioButton RatioOrigin;
        public RadioButton RatioStock;
        private Container RatioButtons;
        private Button btnSetupGrid;
    }
}

