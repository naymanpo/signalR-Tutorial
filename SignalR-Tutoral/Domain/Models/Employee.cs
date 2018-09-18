using System;

namespace SignalR_Tutoral.Domain.Models
{
    public class Employee
    {
        public int Id { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string PlaceOfBirth { set; get; }
        public DateTime BirthOfDate {set;get;}
        public DateTime TimeStamp { set; get; }
    }
}