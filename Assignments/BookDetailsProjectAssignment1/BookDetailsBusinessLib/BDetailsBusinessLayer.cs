using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookDetailsEntitiesLib;
using BookDetailsDataAccessLib;


namespace BookDetailsBusinessLib
{
    public class BDetailsBusinessLayer
    {
        public int AddBookDetails(BookDetailsEntities bdt)
        {
            BDetailsDataAccessLib dal = new BDetailsDataAccessLib();
            var count = dal.AddBookDetails(bdt);
            return count;
        }
        public List<BookDetailsEntities> GetAllBooks()
        {
            BDetailsDataAccessLib dal = new BDetailsDataAccessLib();
            var bdes = dal.GetAllBooks();
            return bdes;
        }
        public BookDetailsEntities GetBookDetailsByBName(string bookname)
        {
            var dal = new BDetailsDataAccessLib();
            var bdetails = dal.GetBookDetailsByBName(bookname);
            return bdetails;
        }
    }
    
}
