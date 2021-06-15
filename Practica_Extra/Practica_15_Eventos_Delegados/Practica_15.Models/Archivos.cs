using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Models {
    public class Archivos {

        public bool Guardar(Persona persona) {
            try {
                string path = $"{Environment.CurrentDirectory}\\File";
                string fileName = "File.txt";
                string message = $"Cajero cobro a {persona.ToString()} ${persona.MontoTotal}.";
                if (!Directory.Exists(path)) {
                    Directory.CreateDirectory(path);
                }
                using (StreamWriter writer = new StreamWriter($"{path}\\{fileName}")) {
                    writer.WriteLine(message);
                    return true;
                }
            } catch (Exception exe) {

                throw new Exception(exe.Message);
            }
        }
    }
}
