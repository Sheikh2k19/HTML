using System;
using System.Collections.Generic;
namespace WebApplication1
{
    public class BookStore
    {
        public string category { get; set; }

        public string name { get; set; }

        public int shelfNumber { get; set; }

        public int price { get; set; }
    }
    public class User
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public List<string> BookIssued { get; set; }

       
    }
}
