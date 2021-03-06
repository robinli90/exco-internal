﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExcoUtility;

namespace MvcApplication1.Financial_Reports.Income_Statement.Categories.Sales
{
    public class Colombia_Sales : Group
    {
        public Colombia_Sales(int fiscalYear, int fiscalMonth)
        {
            name = "COLOMBIA SALES";
            // add accounts
            plant04.accountList.Add(new Account("441", "206010"));
            plant41.accountList.Add(new Account("4141", "206010"));
            plant48.accountList.Add(new Account("4841", "206010"));
            plant49.accountList.Add(new Account("4941", "206010"));
            // process accounts
            //plant01.GetAccountsData(fiscalYear, fiscalMonth);
            //plant03.GetAccountsData(fiscalYear, fiscalMonth);
            // plant05.GetAccountsData(fiscalYear, fiscalMonth);
            plant04.GetAccountsData(fiscalYear, fiscalMonth);
            plant41.GetAccountsData(fiscalYear, fiscalMonth);
            plant48.GetAccountsData(fiscalYear, fiscalMonth);
            plant49.GetAccountsData(fiscalYear, fiscalMonth);
        }
    }
}
