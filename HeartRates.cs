using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target_Heart_Rate_Calculator
{
   internal class HeartRates
   {
      private string _firstName;
      private string _lastName;
      private int _birthYear;
      private int _currentYear;

      public HeartRates(string firstName, string lastName, int birthYear, int currentYear)
      {
         _firstName = firstName;
         _lastName = lastName;
         _birthYear = birthYear;
         _currentYear = currentYear;
      }

      public string _FirstName
      {
         get { return _firstName; }
         set { _firstName = value; }
      }
      public string _LastName
      {
         get { return _lastName; }
         set { _lastName = value; }
      }
      public int _BirthYear
      {
         get { return _birthYear; }
         set { _birthYear = value; }
      }
      public int _CurrentYear
      {
         get { return _currentYear; }
         set { _currentYear = value;  }
      }
      // Property to calculate and display person's age in years
      public int Age
      {
         get { return _currentYear - _birthYear; }
      }

      // Property to calculate and display person's maximum heart rate
      public int MaxHeartRate
      {
         get { return 220 - Age; }
      }

      // Propertys to calculate and display minimum and maximum target heart rates
      public int MinTargetHeartRate
      {
         get { return (int) (.50 * MaxHeartRate); }
      }

      public int MaxTargetHeartRate
      {
         get { return (int)(.85 * MaxHeartRate);  }
      }

   }
}
