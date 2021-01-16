using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public enum status
    {
        good,
        medium,
        bad,
    }
    [Serializable()]
    public class ABook:ISerializable
    {
        #region Định nghĩa dữ liệu
        private string _BookID;
        private status _Status;
        private Boolean _Availability;
        private Book _BookType;
        public string BookID { get => _BookID; set => _BookID = value; }
        public status Status { get => _Status; set => _Status = value; }
        public Boolean Availability { get => _Availability; set => _Availability = value; }
        public Book BookType { get => _BookType; set => _BookType = value; }
        #endregion
        public ABook() { }
        public ABook(string BookID, status Status, Boolean Availability, Book BookType)
        {
            this.BookID = BookID;
            this.Status = Status;
            this.Availability = Availability;
            this.BookType = BookFactory.getBookType(BookType.ISBN, BookType.Title, BookType.Author, BookType.Publisher,BookType.Year);
        }
        public ABook(SerializationInfo info, StreamingContext ctxt)
        {
            //định nghĩa lại phương thức Deserialization
            _BookID = (string)info.GetValue("BookID", typeof(string));
            _Status = (status)info.GetValue("Status", typeof(status));
            _Availability = (bool)info.GetValue("Availability", typeof(bool));
            _BookType = BookFactory.getBookType((Book)info.GetValue("BookType", typeof(Book)));
        }
        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("BookID", _BookID);
            info.AddValue("Status", _Status);
            info.AddValue("Availability", _Availability);
            info.AddValue("BookType", _BookType);
        }
    }
}
