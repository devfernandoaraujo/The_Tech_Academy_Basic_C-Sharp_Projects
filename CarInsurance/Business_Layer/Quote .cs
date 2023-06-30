using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsurance.Business_Layer
{
    internal class Quote
    {
        private decimal baseQuote = 50m;
        private decimal DuiPercentage = 0.25m;
        private decimal fullCoverage = 0.5m;
        internal Quote() { }

        internal decimal CalculateQuote(DateTime dateOfBirth, int CarYear, string CarMake, string carModel, int QuantityOfSpeedingTicket, bool DUI)
        {
            #region Age
            if (calculateAge(dateOfBirth) <= 18)
                baseQuote += 100;
            else if (calculateAge(dateOfBirth) > 18 && calculateAge(dateOfBirth) <= 25)
                baseQuote += 50;
            else //26 or older 
                baseQuote += 25;
            #endregion

            #region Car Year
            if (CarYear < 2000)
                baseQuote += 25;
            if (CarYear >= 2015)
                baseQuote += 25;

            #endregion

            #region Car Make and Model
            if (CarMake.ToLower() == "porsche")
                baseQuote += 25;

            if (CarMake.ToLower() == "porsche" && carModel.ToLower() == "911 carrera")
                baseQuote += 25;


            #endregion

            #region Speeding Tickets 
            baseQuote += (10 * QuantityOfSpeedingTicket);
            #endregion

            #region DUI
            baseQuote += baseQuote * DuiPercentage;
            #endregion

            #region Full Coverage
            baseQuote += baseQuote * fullCoverage;
            #endregion

            return baseQuote;
        }

        private int calculateAge(DateTime dateOfBirth)
        {
            DateTime today = DateTime.Now;

            return today.Year - dateOfBirth.Year;
        }
    }
}