using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D15_EF_D02_Task.Entities
{
    public class Reservation
    {
        public Reservation() { }
        public Reservation(string firstName, string lastName, string birthDay, string gender, string phoneNumber, string email, int numberGuest, string streetAddress, string aptSuite, string city, string state, string zipCode, string roomType, string roomFloor, string roomNumber, float totolBill, string paymentType, string cardType, string cardNumber, string cardExp, string cardCvc, DateTime arrivalTime, DateTime leavingTime, bool checkIn, int breakFast, int lunch, int dinner, bool cleaning, bool towel, bool ssurprise, bool supplyStatus, int foodBill)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
            Gender = gender;
            PhoneNumber = phoneNumber;
            Email = email;
            NumberGuest = numberGuest;
            StreetAddress = streetAddress;
            AptSuite = aptSuite;
            City = city;
            State = state;
            ZipCode = zipCode;
            RoomType = roomType;
            RoomFloor = roomFloor;
            RoomNumber = roomNumber;
            TotalBill = totolBill;
            PaymentType = paymentType;
            CardType = cardType;
            CardNumber = cardNumber;
            CardExp = cardExp;
            CardCvc = cardCvc;
            ArrivalTime = arrivalTime;
            LeavingTime = leavingTime;
            CheckIn = checkIn;
            BreakFast = breakFast;
            Lunch = lunch;
            Dinner = dinner;
            Cleaning = cleaning;
            Towel = towel;
            Ssurprise = ssurprise;
            SupplyStatus = supplyStatus;
            FoodBill = foodBill;
        }

        public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string BirthDay { get; set; }
		public string Gender { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
		public int NumberGuest { get; set; }
		public string StreetAddress { get; set; }
		public string AptSuite { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string ZipCode { get; set; }
		public string RoomType { get; set; }
		public string RoomFloor { get; set; }
		public string RoomNumber { get; set; }
		public float TotalBill { get; set; }
		public string PaymentType { get; set; }
		public string CardType { get; set; }
		public string CardNumber { get; set; }
		public string CardExp { get; set; }
		public string CardCvc { get; set; }
		public DateTime ArrivalTime { get; set; }
		public DateTime LeavingTime { get; set; }
		public bool CheckIn { get; set; }
		public int BreakFast { get; set; }
		public int Lunch { get; set; }
		public int Dinner { get; set; }
		public bool Cleaning { get; set; }
		public bool Towel { get; set; }
		public bool Ssurprise { get; set; }
		public bool SupplyStatus { get; set; }
		public int FoodBill { get; set; }




	}
}
