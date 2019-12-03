using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MusicLibrary
{
    public partial class frmSearch : Form
    {
        public DataTable dt;
        List<AddMusic> ObjAddMusic;
        public string UserRole;

        public frmSearch()
        {
            InitializeComponent();
        }

        private DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

        }

        public DataTable GetMusicLibraryInfo()
        {
            ObjAddMusic = new List<AddMusic>()
            {
             new AddMusic { Title = "Melodies" , Album ="Apple",Composer ="Rahman" ,Release ="1990-05-01",Artist ="Rahul" },
             new AddMusic { Title = "Romance" , Album ="Blueberry",Composer ="Rahman" ,Release ="1994-07-01",Artist ="Rohan" },
             new AddMusic { Title = "Sad" , Album ="Cherry",Composer ="IllayaRaja" ,Release ="1996-02-01",Artist ="Yash" },
             new AddMusic { Title = "Mix" , Album ="Strawberry",Composer ="Harris" ,Release ="2000-10-10",Artist ="Rohit" }
            };

            dt = ConvertToDataTable(ObjAddMusic);
            return dt;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbSearch.Text.Equals("Title"))
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;            
                bs.Filter = string.Format("Title like '%{0}%'", txtSearch.Text.Trim());
                dgvMusicLib.DataSource = bs;
            }
            else if (cmbSearch.Text.Equals("Album"))
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;               
                bs.Filter = string.Format("Album like '%{0}%'", txtSearch.Text.Trim());
                dgvMusicLib.DataSource = bs;
            }
            else
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;               
                bs.Filter = string.Format("Composer like '%{0}%'", txtSearch.Text.Trim());
                dgvMusicLib.DataSource = bs;
            }
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            if (dt!=null)
            {
                dgvMusicLib.AutoGenerateColumns = false;
                dgvMusicLib.DataSource = dt;
                dgvMusicLib.AllowUserToAddRows = false;
            }
            else
            {
                dgvMusicLib.AutoGenerateColumns = false;
                dgvMusicLib.DataSource = GetMusicLibraryInfo();
                dgvMusicLib.AllowUserToAddRows = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
