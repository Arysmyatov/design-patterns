using System;

namespace DP_State.Passport
{
    public class Passport : IPassport
    {
        private string PersonName {get; set; }

        public Passport(string name)
        {
            PersonName = name;
        }

        public string GetName()
        {
            return PersonName;
        }
    }
}