using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PRN211_Console
{
    class Validation
    {

        public static bool checkLogin(string userID, string password)
        {
            if (userID == null || password == null) { return false; }
            return true;
        }

        public static bool checkLength(int minLen, int maxLen, string value)
        {
            if (value.Length > maxLen || value.Length <= minLen)
            {
                return true;
            }
            return false;
        }

        public static bool checkAge(int age)
        {
            if (age > 25 || age < 18)
            {
                return true;
            }
            return false;
        }

        public static bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@gmail.com+$";
            return Regex.IsMatch(email, pattern);
        }

        public static bool checkID(string id)
        {
            bool check = true;
            int ID;
            if (int.TryParse(id, out ID))
            {
            }
            else
            {
                MessageBox.Show("Please enter your ID correctly", "Warning", MessageBoxButtons.OK);
                check = false;
            }
            return check;
        }

        public static bool checkValidation(string id, string name, string age,
            string phoneNumber, string mail, string des)
        {
            bool check = true;
            //============ Check ID ============
            int ID;
            if (int.TryParse(id, out ID))
            {
            }
            else
            {
                MessageBox.Show("Please enter your ID correctly", "Warning", MessageBoxButtons.OK);
                check = false;
            }

            //============ Check Tên ============
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please retype your name correctly", "Warning", MessageBoxButtons.OK);
                check = false;
            }

            bool nameLen = checkLength(3, 20, name);
            if (nameLen)
            {
                MessageBox.Show("Please retype your name correctly", "Warning", MessageBoxButtons.OK);
                check = false;
            }

            //============ Check Tuổi ============
            int Age;
            if (int.TryParse(age, out Age))
            {
            }
            else
            {
                MessageBox.Show("Please enter your age correctly", "Warning", MessageBoxButtons.OK);
                check = false;
            }
            bool ageLen = checkLength(1, 2, age);
            if (ageLen)
            {
                MessageBox.Show("Please retype your age", "Warning", MessageBoxButtons.OK);
                check = false;
            }

            bool ageNumber = checkAge(Convert.ToInt32(age));
            if (ageNumber)
            {
                MessageBox.Show("Please retype your age", "Warning", MessageBoxButtons.OK);
                check = false;
            }

            //============ Check SDT ============
            int PhoneNumber;
            if (int.TryParse(phoneNumber, out PhoneNumber))
            {
            }
            else
            {
                MessageBox.Show("Please enter your phone number correctly", "Warning", MessageBoxButtons.OK);
                check = false;
            }
            bool phonenumberLen = checkLength(9, 11, phoneNumber);
            if (phonenumberLen)
            {
                MessageBox.Show("Please enter your phone number correctly", "Warning", MessageBoxButtons.OK);
                check = false;
            }

            //============ Check Mail ============
            if (string.IsNullOrEmpty(mail))
            {
                MessageBox.Show("Email is required", "Warning", MessageBoxButtons.OK);
                check = false;
            }
            bool mailCheck = IsValidEmail(mail);
            if (mailCheck == false)
            {
                MessageBox.Show("Email is wrong format", "Warning", MessageBoxButtons.OK);
                check = false;
            }

            //============ Check Description ============
            if (string.IsNullOrEmpty(des))
            {
                MessageBox.Show("Please enter your description correctly", "Warning", MessageBoxButtons.OK);
                check = false;
            }
            bool desLen = checkLength(9, 30, des);
            if (desLen)
            {
                MessageBox.Show("Description must be from 10 to 30 chars! Try Again", "Warning", MessageBoxButtons.OK);
                check = false;
            }

            return check;
        }

        public static bool checkEmpty(string id, string name, string branchName, string typeID)
        {
            bool check = false;
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("ID not empty", "Warning");
                check = true;
            }
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name not empty", "Warning");
                check = true;
            }
            if (string.IsNullOrEmpty(branchName))
            {
                MessageBox.Show("Branch not empty", "Warning");
                check = true;
            }
            if (string.IsNullOrEmpty(typeID))
            {
                MessageBox.Show("TypeID not empty", "Warning");
                check = true;
            }
            return check;
        }
    }
}
