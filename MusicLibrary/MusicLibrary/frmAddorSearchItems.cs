using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MusicLibrary
{
    public partial class frmAddorSearchItems : Form
    {
        public DataTable dt;
        List<AddMusic> ObjAddMusic;
        public string UserRole;
        public string Videofilename;
        public frmAddorSearchItems()
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

        private void frmAddorSearchItems_Load(object sender, EventArgs e)
        {
            dt = GetMusicLibraryInfo();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();
            dr["Title"] = txtTitle.Text.Trim();
            dr["Album"] = txtAlbum.Text.Trim();
            dr["Composer"] = txtComposer.Text.Trim();
            dr["Release"] = dtpRelease.Value.ToString("yyyy-MM-dd");
            dr["Artist"] = txtArtist.Text.Trim();
            dr["File"] = txtFile.Text.Trim();
            dt.Rows.Add(dr);
            dt.AcceptChanges();

            string fileName = Path.GetFileName(Videofilename);
            string sourcePath = @"C:\Users\v-vijayalakshmi.k\Desktop\vid";
            string targetPath = @"D:\Development\Test\MusicLibrary\MusicLibrary\Video";
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);
            System.IO.Directory.CreateDirectory(targetPath);
            System.IO.File.Copy(sourceFile, destFile, true);

            frmSearch objfrmSearch = new frmSearch();
            objfrmSearch.dt = dt;
            objfrmSearch.StartPosition = FormStartPosition.CenterParent;
            objfrmSearch.Dock = DockStyle.Fill;
            objfrmSearch.Show();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ObjOpenFileDialog = new OpenFileDialog();
            if (ObjOpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtFile.Text = Path.GetFileName(ObjOpenFileDialog.FileName);
                Videofilename = Path.GetFileName(ObjOpenFileDialog.FileName);
            }
        }

        private void btnAddClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
