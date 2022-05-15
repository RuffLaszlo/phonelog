using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneLog
{
    public class CallDestination
    {
        public string Country { get; private set; }
        public string Region { get; private set; }
        public string CountryCode { get; private set; }
        public string RegionCode { get; private set; }

        public CallDestination(string country, string region, string countryCode, string regionCode)
        {
            this.Country = country;
            this.Region = region;
            this.CountryCode = countryCode;
            this.RegionCode = regionCode;
        }

        /*It is not checked whether country and countryCode match each other*/
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            return Equals(obj as CallDestination);
        }

        public bool Equals(CallDestination pc)
        {
            return (CountryCode == pc.CountryCode && RegionCode == pc.RegionCode);
        }

        public override int GetHashCode()
        {
            return Int32.Parse(CountryCode + RegionCode);
        }
    }
}
