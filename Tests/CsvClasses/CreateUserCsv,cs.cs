using System;
using System.Collections.Generic;
using System.Text;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace Tests.CsvClasses
{
    class CreateUserCsv_cs
    {
        [Name("name")]
        public string name { get; set; }

        [Name("Job")]
        public string job { get; set; }
    }
}
