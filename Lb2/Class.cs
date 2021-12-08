using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2
{
    public static class Canteen
    {
        public static decimal AddingACanteen(this decimal income, int numberOfStudents,
            decimal paymentForAccommodation, ref int numberOfStaff)
        {
            if (income == 0)
            {
                income = paymentForAccommodation * numberOfStudents;
            }
            income += income * 0.2m;
            numberOfStaff += 5;
            return income;
        }
    }
    class Class
    {
        public class University : ICloneable
        {
            string UniversityName;
            string Address;
            int NumberOfRooms;
            int NumberOfStaff;
            int NumberOfStudents;
            decimal PaymentForAccommodation;
            decimal income;

            public University(string universityName,  string address, int numberOfRooms, int numberOfStaff, 
                int numberOfStudents, decimal paymentOfAccommodation)
            {
                UniversityName = universityName;
                NumberOfRooms = numberOfRooms;
                Address = address;
                NumberOfStaff = numberOfStaff;
                NumberOfStudents = numberOfStudents;
                PaymentForAccommodation = paymentOfAccommodation;
            }

            public string University_Name => UniversityName;
            public string _Address => Address;
            public int Number_Of_Rooms => NumberOfRooms;
            public int Number_Of_Staff => NumberOfStaff;
            public int Number_Of_Students => NumberOfStudents;
            public decimal Payment_For_Accommodation => PaymentForAccommodation;
            public decimal Income => income;

            public object Clone()
            {
                University university = new(this.University_Name,
                    this._Address, this.Number_Of_Rooms, this.Number_Of_Staff, 
                    this.Number_Of_Students, this.Payment_For_Accommodation
                    );
                return university;    
            }

            bool flag = false;

            public void IncreasingTheNumberOfRooms(int countOfRooms)
            {
                NumberOfRooms += countOfRooms;
            }
            public void Check_in(int students)
            {
                NumberOfStudents += students;
            } 
            public void Check_out(int students)
            {
                NumberOfStudents -= students;
            }
            public decimal MonthlyIncome()
            {
                income = PaymentForAccommodation * NumberOfStudents;
                return income;
            }
            public decimal HalfYearIncome()
            {
                //var temp = flag ? 6 * income : 6 * income * PaymentForAccommodation * NumberOfStudents;
                return flag ? 6 * income : 6 * income * PaymentForAccommodation * NumberOfStudents;
            }
            public decimal AnnualIncome()
            {
                return flag ? 12 * income : 12 * income *  PaymentForAccommodation * NumberOfStudents;
            }
            public void CanteenIncome()
            {
                income = income.AddingACanteen(NumberOfStudents, PaymentForAccommodation, ref NumberOfStaff);
            }
        }
    }
}
