using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using Ambro_WPF2.Models;
using System.Windows;

/**
 * With help from MsDocs
 */

namespace Ambro_WPF2
{
    public class XmlFileIO
    {
        public static void SaveData(object obj, string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(obj.GetType());
            TextWriter writer = new StreamWriter(fileName);
            serializer.Serialize(writer, obj);
            writer.Close();
        }

        public static T OpenFile<T>(string fileName) where T : new()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            // A FileStream is needed to read the XML document.
            FileStream fs = new FileStream(fileName, FileMode.Open);
            // Declare an object variable of the type to be deserialized.
            T obj;
            /* Use the Deserialize method to restore the object's state with
               data from the XML document. */
            obj = (T)serializer.Deserialize(fs);

            // return
            return obj;
        }
    }
}
