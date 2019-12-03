using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;

namespace MusicLibrary
{
    public class global
    {
        List<AddMusic> ObjAddMusic;
        public DataTable dt;

        public static frmAddorSearchItems frmAddorSearchItems;
       
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
    }
}
