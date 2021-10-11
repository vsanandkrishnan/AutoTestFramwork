using System;
using System.Collections.Generic;
using System.Text;
using CsvHelper;
using System.IO;
using System.Globalization;
using System.Linq;

namespace Tests.TestData
{
    public static class  CsvReaderData
    {
        /// <summary>
        /// Getting data from csv files
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static List<T> CsvReaderMethod<T>()
        {
            var streamReader = new StreamReader(@"C:\Users\AnandKrishnan\source\repos\AutoTestFramework\Tests\TestData\TestAPIData.csv");
            var csvHelper = new CsvReader(streamReader, CultureInfo.InvariantCulture);

            var output = csvHelper.GetRecords<T>().ToList();

            return output;
        }
    }
}
