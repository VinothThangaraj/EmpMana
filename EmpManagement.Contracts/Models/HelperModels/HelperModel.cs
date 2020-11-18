using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpManagement.Contracts.Models.HelperModels
{
    class HelperModel
    {
    }
    public class HttpPostedFile
    {
        public HttpPostedFile(string name, string filename, byte[] file)
        {
            this.Name = name;
            this.Filename = filename;
            this.File = file;
        }

        public string Name { get; private set; }
        public string Filename { get; private set; }
        public byte[] File { private set; get; }
    }

    public class HttpPostedField
    {
        public HttpPostedField(string name, string value)
        {
            this.Name = name;
            this.Value = value;
        }

        public string Name { get; private set; }
        public string Value { get; private set; }
    }

    public class HttpPostedData
    {
        public HttpPostedData(IDictionary<string, HttpPostedField> fields, IDictionary<string, HttpPostedFile> files)
        {
            Fields = fields;
            Files = files;
        }

        public IDictionary<string, HttpPostedField> Fields { get; private set; }
        public IDictionary<string, HttpPostedFile> Files { get; private set; }
    }
}
