using M3Assignment03NorthwindDatabase.DbModels;
using M3Assignment03NorthwindDatabase.DtoModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;
using System.Linq;

namespace M3Assignment03NorthwindDatabase
{
    
    class Program
    {
        private static readonly northwindContext _context = new northwindContext();

        
        static void Main(string[] args)
        {
            var customers = _context.Customers.ToList();


            var city = customers
                .Select(c => c.City)
                .Distinct();
            Console.WriteLine(string.Join(", ", city));
            Console.Write($"\nEnter the name of the city:");
            string input = Console.ReadLine().ToLower();

            var filteredCompany = customers
                .Where(c => c.City.ToLower() == input);
            var count = filteredCompany.Count();

            Console.WriteLine($"There are {count} customers in {input}");


            foreach (var com in filteredCompany)
            {

                Console.WriteLine($"{com.Company} ");
            }


        }
        public static bool TakeByCity(Customer c)
        {
            return c.City == "New York";
        }



        //foreach (var cus in customers)
        //{
        //    if (cus.City == city)
        //    {
        //        filteredCustomers.Add(cus);
        //    }

        //}
        //foreach (var cus in filteredCustomers)
        //{
        //    Console.WriteLine($"Enter the name of the city:");
        //    Console.ReadLine();
        //    Console.WriteLine($"{cus.Company} {cus.LastName} {cus.FirstName}  {cus.City}");

        //}

        //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //long[] numbers2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //var res2 = numbers2.Where(c => c % 2 == 0);
        //Console.WriteLine(string.Join(", ", res2));
        //IEnumerable<int> res3 = from n in numbers
        //                        where n % 2 != 0
        //                        select n;
        //Console.WriteLine(string.Join(", ", res3));

        // var filteredCustomers2 = customers.Where(TakeByCity);

        //var filteredCustomers2 =
        //customers.Where(delegate (Customer c) { return c.City == "New York"; });

        //    var products = _context.Products.ToList();
        //    var productsDto = new List<ProductDto>();

        //    foreach (var p in products)
        //    {
        //        ProductDto prod = new ProductDto
        //        {
        //            SupplierIds = p.SupplierIds,
        //            Id = p.Id,
        //            ProductCode = p.ProductCode,
        //            ProductName = p.ProductName,
        //            Description = p.Description,
        //            StandardCost = p.StandardCost,
        //            ListPrice = p.ListPrice,
        //            ReorderLevel = p.ReorderLevel,
        //            TargetLevel = p.TargetLevel,
        //            QuantityPerUnit = p.QuantityPerUnit,
        //            Discontinued = p.Discontinued,
        //            MinimumReorderQuantity = p.MinimumReorderQuantity,
        //            Category = p.Category,
        //            Attachments = p.Attachments
        //        };
        //        productsDto.Add(prod);
        //    }

        //    string xmlProductsDto = "productsDto.xml";
        //    ToXmlFile(xmlProductsDto, productsDto);

        //    string jsonProductsDto = "productsDto.json";
        //    ToJsonFile(jsonProductsDto, productsDto);

        //    string binaryProductsDto = "productsDto.dat";
        //    ToJsonFile(binaryProductsDto, productsDto);

        //    string xmlProducts = "products.xml";
        //    ToXmlFile(xmlProducts, products);

        //    string jsonProducts = "products.json";
        //    ToJsonFile(jsonProducts, products);

        //    List<SerializedFile> fileList = new List<SerializedFile>
        //    {
        //        new SerializedFile{
        //            Name = xmlProductsDto,
        //            Size = new FileInfo(xmlProductsDto).Length},
        //        new SerializedFile{
        //            Name = jsonProductsDto,
        //            Size = new FileInfo(jsonProductsDto).Length},
        //        new SerializedFile{
        //            Name = binaryProductsDto,
        //            Size = new FileInfo(binaryProductsDto).Length},

        //    };
        //    fileList.Sort();
        //    int place = 1;

        //    foreach(var file in fileList)
        //    {
        //        Console.WriteLine($"{place++}. {file.Name} : {file.Size} bytes");
        //    }
        //}

        //public static void ToJsonFile<T>(string file, T obj)
        //{
        //    string json = JsonSerializer.Serialize(obj);
        //    File.WriteAllText(file, json);
        //}

        //public static void ToBinary<T>(string file, TextReader obj)
        //{
        //    using (Stream st = File.Open(file, FileMode.Create))
        //    {
        //        BinaryFormatter bf = new BinaryFormatter();
        //        bf.Serialize(st, obj);
        //    }
        //}
        //public static T FromXmlSerializer<T>(string file)
        //{
        //    XmlSerializer xmls = new XmlSerializer(typeof(T));
        //    var xmlContent = File.ReadAllText(file);

        //    using (StringReader sr = new StringReader(xmlContent))
        //    {
        //        return (T)xmls.Deserialize(sr);
        //    }

        //}
        //public static void ToXmlFile<T>(string file, T obj)
        //{
        //    using (StringWriter sw = new StringWriter(new StringBuilder()))
        //    {
        //        XmlSerializer xmls = new XmlSerializer(typeof(T));
        //        xmls.Serialize(sw, obj);
        //        File.WriteAllText(file, sw.ToString());
        //    }

    }
}
