using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagerPro.Forms
{
    public partial class MultyStringBox : UserControl
    {
        private List<string> values = new List<string>();
        public DataTable data = new DataTable();
        private string lableText = "";

        [Category("RJ Code Advance")]
        public List<string> Values
        {
            get
            {
                values.Clear();
                foreach (DataRow item in data.Rows)
                {
                    values.Add(item[0].ToString());
                }
                return values;
            }
            set
            {
                values = value;
                foreach (string item in value)
                {
                    DataRow r = data.NewRow();
                    r[0] = item;
                    data.Rows.Add(r);
                    Invalidate();

                }

            }
        }
        //[Category("RJ Code Advance")]


        public void ValuesClear()
        {
            values.Clear();
            data.Clear();
            Invalidate();

        }
        public MultyStringBox()
        {
            InitializeComponent();
            data.Columns.Add("value", typeof(string));
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textvalue .Text))
            {
                return;
            }
            DataRow dr = data.NewRow();
            dr[0] = textvalue .Text;
            data.Rows.Add(dr);
            textvalue .Text = "";
            //dataGridValues.DataSource = values;
            Invalidate();
        }
        [Category("RJ Code Advance")]
        public string LableText
        {
            get
            {
                return lableText;
            }
            set
            {
                lableText = value;
                lbladress.Text = lableText;
                Invalidate();
            }
        }
        private void dataGridValues_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void MultyStringBox_Load(object sender, EventArgs e)
        {
           
            dataGridValues.DataSource = data;
            Invalidate();
        }

        private void dataGridValues_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!string.IsNullOrEmpty(dataGridValues.CurrentRow.Cells[0].Value.ToString()))
            {
                textvalue .Text = dataGridValues.CurrentRow.Cells[0].Value.ToString();
                data.Rows.RemoveAt(dataGridValues.CurrentRow.Index);

                Invalidate();
            }
        }
    }
}
