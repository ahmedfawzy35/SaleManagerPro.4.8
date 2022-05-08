using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagerPro.Forms.EmployeeForms
{
    public partial class DocumentItem : UserControl
    {
        public event EventHandler<ActionTaskEventArgs> ActionTaskClicked;

        public int idDocument = 1;
        public string nameDocument = "لا يوجد مستندات"; 

        [Category("RJ Code Advance")]

        public int IdDocument
        {
            get
            {
                return idDocument;
            }
            set
            {
                idDocument = value;

              
                Invalidate();
            }
        }
                [Category("RJ Code Advance")]

        public string NameDocument
        {
            get
            {
                return nameDocument;
            }
            set
            {
                nameDocument = value;

                button1.Text = nameDocument;
                Invalidate();
            }
        }


        public DocumentItem()
        {
            InitializeComponent();

            
        }

        private string[] button1_Click(object sender, EventArgs e)
        {
            string[] values = new string[2];
            values[0] =idDocument.ToString();
            values[1] =nameDocument;
            return values;
        }

        private void btnActionTasks_Click(object sender, EventArgs e)
        {
            string buttonName = (sender as Control).Name;
            // Or use the Text, the Tag or whatever other value
            // string buttonTag = (sender as Control).Tag;

             var args = new ActionTaskEventArgs(nameDocument, idDocument);
            ActionTaskClicked?.Invoke(this, args);

        }

        public class ActionTaskEventArgs : EventArgs
        {
            public ActionTaskEventArgs(string decoumentName, int decoumentId)
            {
                DecoumentName = decoumentName;
                DecoumentId = decoumentId;
            }

            public string DecoumentName { get; }
            public int DecoumentId { get; }
        }
    }
   
}
