using System;
using System.Collections.Generic;

namespace indexers
{
    internal class EmailDNS
    {
        public string Name { get; set;}     // Name Property for EmailDNS class.
        private Dictionary<string, string> _dnsrecords;     // A dictionary FIELD.

        public EmailDNS(string name)        // Constructor that takes Name as the argument.
        {
            Name = name;
            _dnsrecords = new Dictionary<string, string>();     // Initialize the dictionary FIELD here. 
        }

        // This is the INDEXER. It is a type of Property. Notice, how we assign it to the FIELD. All it does is it allows elements of this 
        // dictionary to be accessed like arrays in the main program. Thus making it easy. 
        public string this [string record]          // Get or Set based on a Key Value in the argument.     
        {
            get { return _dnsrecords[record]; }     // To retrieve a VALUE given a KEy
            set { _dnsrecords[record] = value; }    // To set a KEY given a VALUE. 
        }

        public string Rating    // A derived Property for EmailDNS class that can only be READ and not SET.
        {
            get
            {
                if (_dnsrecords.Count == 0)
                {
                    return "Poor";
                } else if (_dnsrecords.ContainsKey("spf") && _dnsrecords.ContainsKey("dkim") && _dnsrecords.ContainsKey("dmarc"))
                {
                    return "Good";
                } else if (_dnsrecords.ContainsKey("dkim") && _dnsrecords.ContainsKey("spf"))
                {
                    return "Intermediate";
                } else if (_dnsrecords.ContainsKey("spf"))
                {
                    return "Poor";
                }
                else
                {
                    return "Improper Keys Entered.";
                }
            }
        }
    }
}
