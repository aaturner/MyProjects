﻿using MoneyTracker.Models.Allocations;
using MoneyTracker.Utilities;


namespace MoneyTracker.AppModels
{
    public class BudgetRow 
    {

        public BudgetRow()
        {
        }

        public BudgetRow(string column1, string column2, Enums.TableRowType rowType)
        {
            Column1 = column1;
            Column2 = column2;
            RowType = rowType;
        }
        public BudgetRow(string column1, string column2, string column3, string column4, decimal moneyCol1, decimal moneyCol2, 
            Enums.TableRowType rowType, int allocationId, decimal residual = 0)
        {
            Column1 = column1;
            Column2 = column2;
            Column3 = column3;
            Colomn4 = column4;
            MoneyCol1 = moneyCol1;
            MoneyCol2 = moneyCol2;
            RowType = rowType;
            AllocationId = allocationId;
            MoneyCol3 = residual;
        }
        //TODO: Chain Constructors




        public BudgetRow(string column1, string loanName, string rowType, string column4, string moneyCol1, Enums.TableRowType moneyCol2)
        {
            throw new System.NotImplementedException();
        }

        public int AllocationId { get; set; }
        public string Column1 { get; set; }
        public string Column2 { get; set; }
        public string Column3 { get; set; }
        public string Colomn4 { get; set; }
        public decimal? MoneyCol1 { get; set; }
        public decimal? MoneyCol2 { get; set; }   
        public decimal? MoneyCol3 { get; set; }  //Residual
        public ForecastRow ForecastRow { get; set; }
        public Enums.TableRowType RowType { get; set; }
       

    }
}