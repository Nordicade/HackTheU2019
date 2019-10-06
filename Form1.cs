using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;

namespace test2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }


        private void ChooseFileButton_Click(object sender, EventArgs e)
        {
            //do error checks





          
            MongoDB db = new MongoDB();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    class MongoDB
    {

        //This is the default constructor

        public MongoDB()

        {
            // 
            var credential = MongoCredential.CreateCredential("test", "Test_Admin", "drowssap");
            var settings = new MongoClientSettings
            {
                Credential = credential
                //Server = new MongoServerAddress(,Convert.ToInt32(ConfigurationManager.AppSettings["27017"]))
            };
           // var client = new MongoClient(settings);
            //
           var client = new MongoClient("mongodb+srv://Test_Admin:<drowssap>@hacktheu-htus5.gcp.mongodb.net/admin?retryWrites=true&w=majority");
            
            var database = client.GetDatabase("test");
            

           

            var collection = database.GetCollection<BsonDocument>("items");
            OpenFileDialog od = new OpenFileDialog();
            od.ShowDialog();

            string fileName = od.FileName;
            string json;
            string currentline;
            dynamic items;
            BsonDocument bson;
            // System.IO.StreamReader  jsonFile = new System.IO.StreamReader(fileName);
            using (StreamReader r = new StreamReader(fileName))
            {
               // bson = BsonDocument.Parse(r.ReadToEnd());
                json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject(json);
                
            }

             //collection.InsertOne(bson);
            List<string> coordinates = new List<string>();
            Console.WriteLine(items.buyers[0].Coordinates);
            for(int i = 0; i < items.buyers.Count; i++)
            {
                Console.WriteLine(items.buyers[i].Coordinates);
                if (int.Parse((string)(items.buyers[i].Age)) > 70)
                {
                    coordinates.Add((string)(items.buyers[i].Coordinates));
                }
            }
            //C:\Users\jljut\Desktop\test.txt
            System.IO.File.WriteAllLines(@"test.txt", coordinates.ToArray());
        }

    }

    class buyer
    {
          public string Coordinates { get; set; }
    public int Age { get; set; }
    public string MaritalStatus { get; set; }
    public string Gender{ get; set; }
        public string EducationLevel { get; set; }
    }


    
}

