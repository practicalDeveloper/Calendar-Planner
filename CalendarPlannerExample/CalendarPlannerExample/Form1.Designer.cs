namespace CalendarPlannerExample
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
            WeekPlanner.DataColumns dataColumns1 = new WeekPlanner.DataColumns();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_MinusDay = new System.Windows.Forms.Button();
            this.btn_PlusDay = new System.Windows.Forms.Button();
            this.btn_EditMode = new System.Windows.Forms.Button();
            this.btn_DeleteRows = new System.Windows.Forms.Button();
            this.btn_SetRowColor = new System.Windows.Forms.Button();
            this.btn_RemoveRow = new System.Windows.Forms.Button();
            this.btn_SetItemDate = new System.Windows.Forms.Button();
            this.btn_AddColumnData = new System.Windows.Forms.Button();
            this.btn_ClearColumn = new System.Windows.Forms.Button();
            this.btn_DeleteItem = new System.Windows.Forms.Button();
            this.btn_DeleteItems = new System.Windows.Forms.Button();
            this.btn_NewItem = new System.Windows.Forms.Button();
            this.btn_AddRow2 = new System.Windows.Forms.Button();
            this.btn_AddRow = new System.Windows.Forms.Button();
            this.weekPlanner1 = new WeekPlanner.CalendarPlanner();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_MinusDay);
            this.panel1.Controls.Add(this.btn_PlusDay);
            this.panel1.Controls.Add(this.btn_EditMode);
            this.panel1.Controls.Add(this.btn_DeleteRows);
            this.panel1.Controls.Add(this.btn_SetRowColor);
            this.panel1.Controls.Add(this.btn_RemoveRow);
            this.panel1.Controls.Add(this.btn_SetItemDate);
            this.panel1.Controls.Add(this.btn_AddColumnData);
            this.panel1.Controls.Add(this.btn_ClearColumn);
            this.panel1.Controls.Add(this.btn_DeleteItem);
            this.panel1.Controls.Add(this.btn_DeleteItems);
            this.panel1.Controls.Add(this.btn_NewItem);
            this.panel1.Controls.Add(this.btn_AddRow2);
            this.panel1.Controls.Add(this.btn_AddRow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 100);
            this.panel1.TabIndex = 0;
            // 
            // btn_MinusDay
            // 
            this.btn_MinusDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MinusDay.Location = new System.Drawing.Point(589, 4);
            this.btn_MinusDay.Name = "btn_MinusDay";
            this.btn_MinusDay.Size = new System.Drawing.Size(41, 23);
            this.btn_MinusDay.TabIndex = 29;
            this.btn_MinusDay.Text = "Day -";
            this.btn_MinusDay.UseVisualStyleBackColor = true;
            this.btn_MinusDay.Click += new System.EventHandler(this.btn_MinusDay_Click);
            // 
            // btn_PlusDay
            // 
            this.btn_PlusDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_PlusDay.Location = new System.Drawing.Point(636, 4);
            this.btn_PlusDay.Name = "btn_PlusDay";
            this.btn_PlusDay.Size = new System.Drawing.Size(43, 23);
            this.btn_PlusDay.TabIndex = 28;
            this.btn_PlusDay.Text = "Day +";
            this.btn_PlusDay.UseVisualStyleBackColor = true;
            this.btn_PlusDay.Click += new System.EventHandler(this.btn_PlusDay_Click);
            // 
            // btn_EditMode
            // 
            this.btn_EditMode.Location = new System.Drawing.Point(352, 33);
            this.btn_EditMode.Name = "btn_EditMode";
            this.btn_EditMode.Size = new System.Drawing.Size(110, 23);
            this.btn_EditMode.TabIndex = 27;
            this.btn_EditMode.Text = "Activate Edit Mode";
            this.btn_EditMode.UseVisualStyleBackColor = true;
            this.btn_EditMode.Click += new System.EventHandler(this.btn_EditMode_Click);
            // 
            // btn_DeleteRows
            // 
            this.btn_DeleteRows.Location = new System.Drawing.Point(379, 5);
            this.btn_DeleteRows.Name = "btn_DeleteRows";
            this.btn_DeleteRows.Size = new System.Drawing.Size(110, 23);
            this.btn_DeleteRows.TabIndex = 26;
            this.btn_DeleteRows.Text = "Delete rows";
            this.btn_DeleteRows.UseVisualStyleBackColor = true;
            this.btn_DeleteRows.Click += new System.EventHandler(this.btn_DeleteRows_Click);
            // 
            // btn_SetRowColor
            // 
            this.btn_SetRowColor.Location = new System.Drawing.Point(278, 5);
            this.btn_SetRowColor.Name = "btn_SetRowColor";
            this.btn_SetRowColor.Size = new System.Drawing.Size(95, 23);
            this.btn_SetRowColor.TabIndex = 25;
            this.btn_SetRowColor.Text = "Set row color";
            this.btn_SetRowColor.UseVisualStyleBackColor = true;
            this.btn_SetRowColor.Click += new System.EventHandler(this.btn_SetRowColor_Click);
            // 
            // btn_RemoveRow
            // 
            this.btn_RemoveRow.Location = new System.Drawing.Point(196, 4);
            this.btn_RemoveRow.Name = "btn_RemoveRow";
            this.btn_RemoveRow.Size = new System.Drawing.Size(75, 23);
            this.btn_RemoveRow.TabIndex = 24;
            this.btn_RemoveRow.Text = "Delete Row";
            this.btn_RemoveRow.UseVisualStyleBackColor = true;
            this.btn_RemoveRow.Click += new System.EventHandler(this.btn_RemoveRow_Click);
            // 
            // btn_SetItemDate
            // 
            this.btn_SetItemDate.Location = new System.Drawing.Point(249, 33);
            this.btn_SetItemDate.Name = "btn_SetItemDate";
            this.btn_SetItemDate.Size = new System.Drawing.Size(97, 23);
            this.btn_SetItemDate.TabIndex = 23;
            this.btn_SetItemDate.Text = "Set Item Date";
            this.btn_SetItemDate.UseVisualStyleBackColor = true;
            this.btn_SetItemDate.Click += new System.EventHandler(this.btn_SetItemDate_Click);
            // 
            // btn_AddColumnData
            // 
            this.btn_AddColumnData.Location = new System.Drawing.Point(106, 61);
            this.btn_AddColumnData.Name = "btn_AddColumnData";
            this.btn_AddColumnData.Size = new System.Drawing.Size(108, 23);
            this.btn_AddColumnData.TabIndex = 22;
            this.btn_AddColumnData.Text = "Add column data";
            this.btn_AddColumnData.UseVisualStyleBackColor = true;
            this.btn_AddColumnData.Click += new System.EventHandler(this.btn_AddColumnData_Click);
            // 
            // btn_ClearColumn
            // 
            this.btn_ClearColumn.Location = new System.Drawing.Point(6, 61);
            this.btn_ClearColumn.Name = "btn_ClearColumn";
            this.btn_ClearColumn.Size = new System.Drawing.Size(94, 23);
            this.btn_ClearColumn.TabIndex = 21;
            this.btn_ClearColumn.Text = "Clear Column";
            this.btn_ClearColumn.UseVisualStyleBackColor = true;
            this.btn_ClearColumn.Click += new System.EventHandler(this.btn_ClearColumn_Click);
            // 
            // btn_DeleteItem
            // 
            this.btn_DeleteItem.Location = new System.Drawing.Point(168, 33);
            this.btn_DeleteItem.Name = "btn_DeleteItem";
            this.btn_DeleteItem.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteItem.TabIndex = 20;
            this.btn_DeleteItem.Text = "Delete Item";
            this.btn_DeleteItem.UseVisualStyleBackColor = true;
            this.btn_DeleteItem.Click += new System.EventHandler(this.btn_DeleteItem_Click);
            // 
            // btn_DeleteItems
            // 
            this.btn_DeleteItems.Location = new System.Drawing.Point(87, 32);
            this.btn_DeleteItems.Name = "btn_DeleteItems";
            this.btn_DeleteItems.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteItems.TabIndex = 19;
            this.btn_DeleteItems.Text = "Delete Items";
            this.btn_DeleteItems.UseVisualStyleBackColor = true;
            this.btn_DeleteItems.Click += new System.EventHandler(this.btn_DeleteItems_Click);
            // 
            // btn_NewItem
            // 
            this.btn_NewItem.Location = new System.Drawing.Point(6, 32);
            this.btn_NewItem.Name = "btn_NewItem";
            this.btn_NewItem.Size = new System.Drawing.Size(75, 23);
            this.btn_NewItem.TabIndex = 18;
            this.btn_NewItem.Text = "New Item";
            this.btn_NewItem.UseVisualStyleBackColor = true;
            this.btn_NewItem.Click += new System.EventHandler(this.btn_NewItem_Click);
            // 
            // btn_AddRow2
            // 
            this.btn_AddRow2.Location = new System.Drawing.Point(87, 3);
            this.btn_AddRow2.Name = "btn_AddRow2";
            this.btn_AddRow2.Size = new System.Drawing.Size(103, 23);
            this.btn_AddRow2.TabIndex = 17;
            this.btn_AddRow2.Text = "Add nested rows";
            this.btn_AddRow2.UseVisualStyleBackColor = true;
            this.btn_AddRow2.Click += new System.EventHandler(this.btn_AddRow2_Click);
            // 
            // btn_AddRow
            // 
            this.btn_AddRow.Location = new System.Drawing.Point(6, 3);
            this.btn_AddRow.Name = "btn_AddRow";
            this.btn_AddRow.Size = new System.Drawing.Size(75, 23);
            this.btn_AddRow.TabIndex = 16;
            this.btn_AddRow.Text = "Add row";
            this.btn_AddRow.UseVisualStyleBackColor = true;
            this.btn_AddRow.Click += new System.EventHandler(this.btn_AddRow_Click);
            // 
            // weekPlanner1
            // 
            this.weekPlanner1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(98)))), ((int)(((byte)(128)))));
            this.weekPlanner1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weekPlanner1.Columns = dataColumns1;
            this.weekPlanner1.CurrentDate = new System.DateTime(2011, 9, 9, 14, 3, 35, 690);
            this.weekPlanner1.DatesIntervalMode = WeekPlanner.WeekPlannerMode.Daily;
            this.weekPlanner1.DayCount = 7;
            this.weekPlanner1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekPlanner1.GridBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(221)))), ((int)(((byte)(242)))));
            this.weekPlanner1.GridCellHeight = 50;
            this.weekPlanner1.GridTextFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.weekPlanner1.HeaderBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.weekPlanner1.HeaderColumnsFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.weekPlanner1.HeaderDatesFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.weekPlanner1.HeaderFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(192)))), ((int)(((byte)(234)))));
            this.weekPlanner1.HeaderFillLeftMarginColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.weekPlanner1.HeaderStyleMode = WeekPlanner.HeaderStyle.Aqua;
            this.weekPlanner1.IsAllowedDraggingBetweenRows = true;
            this.weekPlanner1.IsAllowedTreeViewDrawing = true;
            this.weekPlanner1.ItemHeight = 20;
            this.weekPlanner1.ItemTextFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.weekPlanner1.LeftMargin = 350;
            this.weekPlanner1.LeftMarginColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.weekPlanner1.Location = new System.Drawing.Point(5, 105);
            this.weekPlanner1.Name = "weekPlanner1";
            this.weekPlanner1.Size = new System.Drawing.Size(684, 331);
            this.weekPlanner1.TabIndex = 1;
            this.weekPlanner1.RowDoubleClick += new WeekPlanner.CalendarPlanner.CalendarRowEventHandler(this.weekPlanner1_RowDoubleClick);
            this.weekPlanner1.ItemMouseLeave += new WeekPlanner.CalendarPlanner.CalendarItemEventHandler(this.weekPlanner1_ItemMouseLeave);
            this.weekPlanner1.RowLeftColumnClick += new WeekPlanner.CalendarPlanner.CalendarRowLeftColumnEventHandler(this.weekPlanner1_RowLeftColumnClick);
            this.weekPlanner1.ItemDoubleClick += new WeekPlanner.CalendarPlanner.CalendarItemEventHandler(this.weekPlanner1_ItemDoubleClick);
            this.weekPlanner1.ItemMouseHover += new WeekPlanner.CalendarPlanner.CalendarItemEventHandler(this.weekPlanner1_ItemMouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 441);
            this.Controls.Add(this.weekPlanner1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private WeekPlanner.CalendarPlanner weekPlanner1;
        private System.Windows.Forms.Button btn_MinusDay;
        private System.Windows.Forms.Button btn_PlusDay;
        private System.Windows.Forms.Button btn_EditMode;
        private System.Windows.Forms.Button btn_DeleteRows;
        private System.Windows.Forms.Button btn_SetRowColor;
        private System.Windows.Forms.Button btn_RemoveRow;
        private System.Windows.Forms.Button btn_SetItemDate;
        private System.Windows.Forms.Button btn_AddColumnData;
        private System.Windows.Forms.Button btn_ClearColumn;
        private System.Windows.Forms.Button btn_DeleteItem;
        private System.Windows.Forms.Button btn_DeleteItems;
        private System.Windows.Forms.Button btn_NewItem;
        private System.Windows.Forms.Button btn_AddRow2;
        private System.Windows.Forms.Button btn_AddRow;
    }
}

