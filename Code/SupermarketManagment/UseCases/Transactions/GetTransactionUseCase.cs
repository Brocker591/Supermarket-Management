﻿using CoreBusiness;
using System;
using System.Collections.Generic;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces;

namespace UseCases.Transactions
{
    public class GetTransactionUseCase : IGetTransactionUseCase
    {
        private readonly ITransactionRepository transactionRepository;

        public GetTransactionUseCase(ITransactionRepository transactionRepository)
        {
            this.transactionRepository = transactionRepository;
        }

        public IEnumerable<Transaction> Execute(string cashierName, DateTime startDate, DateTime endDate)
        {
            return transactionRepository.Search(cashierName, startDate, endDate);
        }
    }
}
