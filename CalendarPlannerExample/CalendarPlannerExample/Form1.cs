using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeekPlanner;

namespace CalendarPlannerExample
{
    public partial class Form1 : Form
    {
        private int day;

        public Form1()
        {
            InitializeComponent();

            weekPlanner1.Columns.Add("Example1", "Example1", 250);
            weekPlanner1.Columns.Add("Example2", "Example2", 150);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            weekPlanner1.CurrentDate = DateTime.Now;
        }

        public IEnumerable<WeekPlannerItem> GetItemsByRow(int rowIndex)
        {
            var rows = weekPlanner1.Rows;
            var row = rows.ElementAt(rowIndex);
            return row.Items.ToList();
        }

        private void btn_AddRow_Click(object sender, EventArgs e)
        {
            var itemCollection = new WeekPlannerItemCollection();

            var item = new WeekPlannerItem();
            item.StartDate = DateTime.Now.AddDays(0);
            item.EndDate = DateTime.Now.AddDays(0);
            item.Subject = "1 date";
            item.BackColor = Color.YellowGreen;
            itemCollection.Add(item);

            item = new WeekPlannerItem();
            item.StartDate = DateTime.Now.AddDays(-1);
            item.EndDate = DateTime.Now.AddDays(8);
            item.Subject = "2 date";
            itemCollection.Add(item);

            item = new WeekPlannerItem();
            item.StartDate = DateTime.Now.AddDays(0);
            item.EndDate = DateTime.Now.AddDays(3);
            item.Subject = "3 date";
            itemCollection.Add(item);

            item = new WeekPlannerItem();
            item.StartDate = DateTime.Now.AddDays(0);
            item.EndDate = DateTime.Now.AddDays(2);
            item.Subject = "4 date";
            itemCollection.Add(item);


            item = new WeekPlannerItem();
            item.StartDate = DateTime.Now.AddDays(4);
            item.EndDate = DateTime.Now.AddDays(6);
            item.Subject = "5 date";
            itemCollection.Add(item);

            item = new WeekPlannerItem();
            item.StartDate = DateTime.Now.AddDays(2);
            item.EndDate = DateTime.Now.AddDays(6);
            item.Subject = "6 date";
            itemCollection.Add(item);


            item = new WeekPlannerItem();
            item.StartDate = DateTime.Now.AddDays(0);
            item.EndDate = DateTime.Now.AddDays(6);
            item.Subject = "7 date";
            itemCollection.Add(item);

            item = new WeekPlannerItem();
            item.StartDate = DateTime.Now.AddDays(0);
            item.EndDate = DateTime.Now.AddDays(3);
            item.Subject = "8 date";
            itemCollection.Add(item);


            var ColumnRows = new DataColumns(weekPlanner1.Calendar);

            ColumnRows["Example1"].Data.Add(Guid.NewGuid().ToString().Substring(0, 8));
            ColumnRows["Example1"].Data.Add(Guid.NewGuid().ToString().Substring(0, 8));
            ColumnRows["Example2"].Data.Add(Guid.NewGuid().ToString().Substring(0, 8));

            weekPlanner1.Rows.Add(ColumnRows, itemCollection);
        }

        private void btn_AddRow2_Click(object sender, EventArgs e)
        {
            var ColumnRows = new DataColumns(weekPlanner1.Calendar);

            var itemCollection = new WeekPlannerItemCollection();

            var item = new WeekPlannerItem();
            item.StartDate = DateTime.Now.AddDays(0);
            item.EndDate = DateTime.Now.AddDays(0);
            item.Subject = "1 date";
            item.BackColor = Color.YellowGreen;
            itemCollection.Add(item);

            var row = new WeekPlannerRow();
            row.Columns = ColumnRows;
            ColumnRows["Example1"].Data.Add(Guid.NewGuid().ToString().Substring(0, 8));

            row.Name = Guid.NewGuid().ToString().Substring(0, 5);
            row.Items = itemCollection;
            row.IsCollapsible = true;
            weekPlanner1.Rows.Add(row);
        }

        private void btn_RemoveRow_Click(object sender, EventArgs e)
        {
            if (weekPlanner1.Rows.Count > 0)
            {
                if (!weekPlanner1.Rows[weekPlanner1.SelectedRowIndex].IsCollapsible)
                {

                    weekPlanner1.Rows.Remove(weekPlanner1.SelectedRowIndex);
                }
            }
        }


        private bool isSelectedRow()
        {
            if (weekPlanner1.SelectedRowIndex == -1)
            {
                MessageBox.Show("Please select cell");
                return false;
            }

            return true;
        }

        private void btn_SetRowColor_Click(object sender, EventArgs e)
        {
            if (isSelectedRow())
            {
                var row = weekPlanner1.Rows.ElementAt(weekPlanner1.SelectedRowIndex);
                row.BackColor = Color.Lime;
            }
        }

        private void btn_DeleteRows_Click(object sender, EventArgs e)
        {
            weekPlanner1.Rows.Clear();
        }

        private void btn_NewItem_Click(object sender, EventArgs e)
        {
            if (isSelectedRow())
            {
                var rows = weekPlanner1.Rows;
                var row = rows.ElementAt(weekPlanner1.SelectedRowIndex);

                var item = new WeekPlannerItem();
                item.StartDate = DateTime.Now.AddDays(0);
                item.EndDate = DateTime.Now.AddDays(0);
                item.Subject = "Example";
                item.BackColor = Color.YellowGreen;

                row.Items.Add(item);
            }
        }

        private void btn_DeleteItems_Click(object sender, EventArgs e)
        {
            if (isSelectedRow())
            {
                var rows = weekPlanner1.Rows;
                var row = rows.ElementAt(weekPlanner1.SelectedRowIndex);
                row.Items.Clear();
            }
        }

        private void btn_DeleteItem_Click(object sender, EventArgs e)
        {
            if (isSelectedRow())
            {
                var rows = weekPlanner1.Rows;
                var row = rows.ElementAt(weekPlanner1.SelectedRowIndex);

                var item = row.Items.Where(d => d.Subject == "Example").FirstOrDefault();
                if (item == null)
                {
                    MessageBox.Show("Item is not found");
                    return;
                }
                row.Items.Remove(item);
            }
        }

        private void btn_SetItemDate_Click(object sender, EventArgs e)
        {
            if (isSelectedRow())
            {
                var rows = weekPlanner1.Rows;
                var row = rows.ElementAt(weekPlanner1.SelectedRowIndex);

                var item = row.Items.Where(d => d.Subject == "Example").FirstOrDefault();
                if (item == null)
                {
                    MessageBox.Show("Item is not found");
                    return;
                }
                item.StartDate = DateTime.Now.AddDays(1);
                item.EndDate = DateTime.Now.AddDays(5);
            }
        }

        private void btn_EditMode_Click(object sender, EventArgs e)
        {
            if (weekPlanner1.SelectedItem == null)
            {
                MessageBox.Show("Please select an item");
                return;
            }

            weekPlanner1.ActivateEditMode(weekPlanner1.SelectedItem);
        }

        private void btn_ClearColumn_Click(object sender, EventArgs e)
        {
            if (isSelectedRow())
            {
                var row = weekPlanner1.Rows.ElementAt(weekPlanner1.SelectedRowIndex);
                row.Columns["Example1"].Data.Clear();
            }
        }

        private void btn_AddColumnData_Click(object sender, EventArgs e)
        {
            if (isSelectedRow())
            {
                var row = weekPlanner1.Rows.ElementAt(weekPlanner1.SelectedRowIndex);
                row.Columns["Example1"].Data.Add(Guid.NewGuid().ToString().Substring(0, 8), Color.Red);
            }
        }

        private void weekPlanner1_ItemDoubleClick(object sender, WeekPlannerItemEventArgs e)
        {
            weekPlanner1.ActivateEditMode(e.Item);
            e.Item.BackColor = Color.Yellow;
        }

        private void weekPlanner1_RowDoubleClick(object sender, RowEventArgs e)
        {
            weekPlanner1.Rows.ElementAt(weekPlanner1.SelectedRowIndex).Items.Add(weekPlanner1.SelectedCellDate, weekPlanner1.SelectedCellDate, "Example");
        }

        private void btn_MinusDay_Click(object sender, EventArgs e)
        {
            day--;
            weekPlanner1.CurrentDate = DateTime.Now.AddDays(day);
        }

        private void btn_PlusDay_Click(object sender, EventArgs e)
        {
            day++;
            weekPlanner1.CurrentDate = DateTime.Now.AddDays(day);
        }

        private void weekPlanner1_ItemMouseHover(object sender, WeekPlannerItemEventArgs e)
        {
            Console.WriteLine("Mouse over item:" + e.Item.Subject);
        }

        private void weekPlanner1_ItemMouseLeave(object sender, WeekPlannerItemEventArgs e)
        {
            Console.WriteLine("Left item:" + e.Item.Subject);
        }

        private void weekPlanner1_RowLeftColumnClick(object sender, RowClickEventArgs e, int rowNumber)
        {
            if (e.MouseButton == MouseButtons.Right)
            {
                MessageBox.Show(e.Row.Level.ToString());
            }

            if (e.Row.IsCollapsible)
            {
                if (e.Row.IsExpanded)
                {
                    var count = IterateChilds(e.Row.Name, true, 0);
                    //if not found child nodes
                    if (count == 0)
                    {
                        for (int i = 1; i < 3; i++)
                        {
                            var row = new WeekPlannerRow();
                            var ColumnRows = new DataColumns(weekPlanner1.Calendar);
                            row.Columns = ColumnRows;

                            ColumnRows["Example1"].Data.Add(Guid.NewGuid().ToString().Substring(0, 8));
 
                            row.Name = Guid.NewGuid().ToString().Substring(0, 5);
                            row.Level = e.Row.Level + 1;
                            row.AncestorName = e.Row.Name;

                            if (i == 2 && e.Row.Level<2)
                            {
                                row.IsCollapsible = true;
                            }
                            else
                            {
                                row.LeftMarginBackColor = Color.FromArgb(240, 242, 245);
                                row.BackColor = Color.GhostWhite;
                            }
                            row = weekPlanner1.Rows.Insert(rowNumber + i, row);
                        }
 
                    }
                }
                //if found child nodes
                else
                {
                    var r = weekPlanner1.Rows.ElementAt(rowNumber);
                    IterateChilds(r.Name,false,0);
                }
            }

        }

        //iterates child nodes
        private int IterateChilds(string ancestor, bool isVisible, int childCount)
        {
            var nodes = weekPlanner1.Rows.Where(r => r.AncestorName == ancestor);

            foreach (var node in nodes)
            {
                childCount++;
                node.IsVisible = isVisible;
                node.IsExpanded = true;
                IterateChilds(node.Name, isVisible, childCount);
            }
            return childCount;
        }




    }
}
