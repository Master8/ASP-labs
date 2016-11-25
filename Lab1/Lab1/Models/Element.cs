using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab1.Models
{
    public abstract class Element
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
    }

    public class Folder : Element
    {
        public List<Element> Subelements { get; set; }
        
        public int NumberOfSubelements
        {
            get
            {
                return Subelements.Count;
            }
        }
    }

    public class File : Element
    {
        public int Size { get; set; }
    }
}