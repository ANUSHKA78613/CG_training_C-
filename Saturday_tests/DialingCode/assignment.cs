using System;
using System.Collections.Generic;
namespace DialingCodesApp
{
    public static class DialingCodes
    {
        public static Dictionary<int,string> GetEmptyDictionary()
        {
            Dictionary<int,string> d1 = new Dictionary<int, string>();
            return d1;
        }
        public static Dictionary<int, string> GetExistingDictionary()
        {
        Dictionary<int, string> d2 = new Dictionary<int, string>();

            d2.Add(1,"United States of America");
            d2.Add(55,"Brazil");
            d2.Add(91,"India");
            return d2;
        }
        public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
        {
            Dictionary<int,string> d3 =  GetEmptyDictionary();
          
            d3.Add(countryCode,countryName);
            return d3;
        }
        public static Dictionary<int, string> AddCountryToExistingDictionary(Dictionary<int, string> d4, int countryCode, string countryName)
        {
            
            d4.Add(countryCode,countryName);
            return d4;
        }
        public static string GetCountryNameFromDictionary(Dictionary<int, string> d2, int countryCode)
        {
            
            return d2[countryCode];
        }

        public static bool CheckCodeExists(Dictionary<int, string> d2, int countryCode)
        {
         
            return d2.ContainsKey(countryCode);
        }

        public static Dictionary<int, string> UpdateDictionary(Dictionary<int, string> d2, int countryCode, string countryName)
        {
            if (d2.ContainsKey(countryCode))
            {
                d2[countryCode] = countryName;
            }
            return d2;
        }
        public static Dictionary<int, string> RemoveCountryFromDictionary(Dictionary<int, string> d2, int countryCode)
        {
            if (d2.ContainsKey(countryCode))
            {
                d2.Remove(countryCode);
            }
            return d2;
        }

        public static string FindLongestCountryName(Dictionary<int, string> d2)
        {
           string l = "";
            foreach(var d in d2)
            {
                if(d.Value.Length > l.Length)
                {
                    l = d.Value;
                }    
            }
           return l;
        }
    }
}