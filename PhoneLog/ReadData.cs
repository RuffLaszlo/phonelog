using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneLog
{
    public static class ReadData
    {
        //obsolete
        public static string FindCountry(string phoneNumber, string countryPath)
        {
            StreamReader sr = new StreamReader(countryPath);
            while (sr.Peek() != -1)
            {
                string[] nextCountry = sr.ReadLine().Split('\t');
                if (phoneNumber.StartsWith(nextCountry[0]))
                {
                    return nextCountry[1];
                }
            }
            throw new Exception("The phone number does not correspond with any known countries.");
        }

        public static CallDestination FindCountryAndRegion(string phoneNumber, string countryPath, string regionPath)
        {
            // I should probably find Region first, because it automatically provides country code as well
            // assuming country+region is unique, but if it isn't the problem is unsolvable anyway.
            string country = "";
            string region = "";
            string countryCode = "";
            string regionCode = "";
            StreamReader sr = new StreamReader(countryPath, Encoding.Latin1);
            while (sr.Peek() != -1)
            {
                string[] nextCountry = sr.ReadLine().Split('\t');
                if (phoneNumber.StartsWith(nextCountry[0]))
                {
                    countryCode = nextCountry[0];
                    country = nextCountry[1];
                    break;
                }
            }
            sr.Close();

            if (country.Equals(""))
            {
                throw new InvalidDataException("phone number does not correspond to any known countries.");
            }
            else
            {
                sr = new StreamReader(regionPath, Encoding.Latin1);
                while (sr.Peek() != -1)
                {
                    string[] data = sr.ReadLine().Split('\t');
                    if (phoneNumber.StartsWith(data[0]+data[1]))
                    {
                        region = data[2];
                        regionCode = data[1];
                        break;
                    }
                }
                if (region == "")
                {
                    throw new InvalidDataException("Region could not be identified.");
                }
                return new CallDestination(country, region, countryCode, regionCode);
            }
        }

    }
}
