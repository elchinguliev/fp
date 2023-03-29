using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WpfApp8.Models;
using Newtonsoft.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace WpfApp8.FileHelper
{
    public class FileHelper
    {
        public static void WriteSchoolBus(List<Bus> car)
        {
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter($"cars.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, car);
                }
            }
        }
        public static List<Bus>? ReadJsonSchoolBus(string fileName)
        {
            List<Bus>? car = new();
            var context = File.ReadAllText(fileName);
            car = JsonConvert.DeserializeObject<List<Bus>>(context);
            return car;
        }

        public static void WriteStudent(Student student)
        {
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter($"student.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, student);
                }
            }
        }
        public static List<Student>? ReadJsonStudent(string fileName)
        {
            List<Student>? student = new();
            var context = File.ReadAllText(fileName);
            student = JsonConvert.DeserializeObject<List<Student>>(context);
            return student;
        }

        public static void WriteDriver(List<BusDrivers> driver)
        {
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter("driver.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, driver);
                }
            }
        }
        public static List<BusDrivers>? ReadJsonDriver(string fileName)
        {
            List<BusDrivers>? driver = new();
            var context = File.ReadAllText(fileName);
            driver = JsonConvert.DeserializeObject<List<BusDrivers>>(context);
            return driver;
        }
    }
}

