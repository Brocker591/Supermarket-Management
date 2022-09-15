using CoreBusiness;
using System;
using System.Collections.Generic;

namespace UseCases.UseCaseInterfaces
{
    public interface IGetTransactionUseCase
    {
        IEnumerable<Transaction> Execute(string cashierName, DateTime startDate, DateTime endDate);
    }
}