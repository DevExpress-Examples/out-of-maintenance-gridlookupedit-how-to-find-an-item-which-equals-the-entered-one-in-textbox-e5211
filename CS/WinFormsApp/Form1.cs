using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public List<MyClass> CreateDataSource()
        {
            List<MyClass> list = new List<MyClass>();
            list.Add(new MyClass() { ID = 0, Value = "AA1A" });
            list.Add(new MyClass() { ID = 1, Value = "AA" });
            list.Add(new MyClass() { ID = 2, Value = "AAA" });
            list.Add(new MyClass() { ID = 3, Value = "D" });
            list.Add(new MyClass() { ID = 4, Value = "E" });

            return list;
        }

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RepositoryItemCustomridLookUpEdit rep = customGridLookUpEdit1.Properties;

            rep.DataSource = CreateDataSource();
            rep.DisplayMember = "Value";
            rep.ValueMember = "Value";            
        }

    }

    public class MyClass
    {
        public int ID { get; set; }
        public string Value { get; set; }
       
    }
}
