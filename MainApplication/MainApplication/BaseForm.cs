using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainApplication
{
    public partial class BaseForm : Form
    {
        private List<string> _StringItems = new List<string>();

        //we do have a property named "StringItems" with a type of List<string>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]

        //we will just need to change the editor that the property uses
        [Editor("System.Windows.Forms.Design.StringCollectionEditor, System.Design, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
            typeof(System.Drawing.Design.UITypeEditor))]
        public List<string> StringItems
        {
            get { return _StringItems; }
            set { _StringItems = value; }
        }

        public BaseForm()
        {
            InitializeComponent();
        }
        //It works!
    }
}
