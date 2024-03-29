﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CalculateNetWorth.Models
{
    public class CalculateNetWorthDb : ICalculateNetWorth
    {
        public static List<StockTransactionDetails> stdList = new List<StockTransactionDetails>
       {
          new StockTransactionDetails{TStockId=1,CustomerId=1,StockName="Bajaj Finance",StockCount=10,saleStatus=true},
       new StockTransactionDetails{TStockId=2,CustomerId=1,StockName="Asian Paints",StockCount=15,saleStatus=true},
           new StockTransactionDetails{TStockId=3,CustomerId=1,StockName="Adani Ports",StockCount=20,saleStatus=true},
           new StockTransactionDetails{TStockId=4,CustomerId=1,StockName="Bajaj Automobiles",StockCount=16,saleStatus=true},
       new StockTransactionDetails{TStockId=5,CustomerId=1,StockName="Havells India",StockCount=25,saleStatus=true},

 

       new StockTransactionDetails{TStockId=1,CustomerId=2,StockName="Bajaj Finance",StockCount=20,saleStatus=true},
       new StockTransactionDetails{TStockId=2,CustomerId=2,StockName="Asian Paints",StockCount=15,saleStatus=true},
           new StockTransactionDetails{TStockId=3,CustomerId=2,StockName="Adani Ports",StockCount=14,saleStatus=true},
           new StockTransactionDetails{TStockId=4,CustomerId=2,StockName="Bajaj Automobiles",StockCount=30,saleStatus=true},

 

       new StockTransactionDetails{TStockId=2,CustomerId=3,StockName="Asian Paints",StockCount=25,saleStatus=true},
           new StockTransactionDetails{TStockId=3,CustomerId=3,StockName="Adani Ports",StockCount=15,saleStatus=true},
           new StockTransactionDetails{TStockId=4,CustomerId=3,StockName="Bajaj Automobiles",StockCount=16,saleStatus=true},
       new StockTransactionDetails{TStockId=5,CustomerId=3,StockName="Havells India",StockCount=10,saleStatus=true},

 

       new StockTransactionDetails{TStockId=1,CustomerId=4,StockName="Bajaj Finance",StockCount=5,saleStatus=true},
       new StockTransactionDetails{TStockId=2,CustomerId=4,StockName="Asian Paints",StockCount=5,saleStatus=true},
       new StockTransactionDetails{TStockId=4,CustomerId=4,StockName="Bajaj Automobiles",StockCount=6,saleStatus=true},
       new StockTransactionDetails{TStockId=5,CustomerId=4,StockName="Havells India",StockCount=2,saleStatus=true},

 

       new StockTransactionDetails{TStockId=1,CustomerId=5,StockName="Bajaj Finance",StockCount=10,saleStatus=true},
       new StockTransactionDetails{TStockId=3,CustomerId=5,StockName="Adani Ports",StockCount=20,saleStatus=true},
           new StockTransactionDetails{TStockId=4,CustomerId=5,StockName="Bajaj Automobiles",StockCount=26,saleStatus=true},
       new StockTransactionDetails{TStockId=5,CustomerId=5,StockName="Havells India",StockCount=11,saleStatus=true}
        };

        public static List<MutualFundTransactionDetails> mtdList = new List<MutualFundTransactionDetails>
        {
           new MutualFundTransactionDetails{TMutualId=1,CustomerId=1,MutualFundName="Axis Mutual Funds",MutualFundCount=15,saleStatus=true},
           new MutualFundTransactionDetails{TMutualId=2,CustomerId=1,MutualFundName="Reliance Mutual Funds",MutualFundCount=10,saleStatus=true},
           new MutualFundTransactionDetails{TMutualId=3,CustomerId=1,MutualFundName="SBI Mutual Funds",MutualFundCount=14,saleStatus=true},
           new MutualFundTransactionDetails{TMutualId=4,CustomerId=1,MutualFundName="ICICI Mutual Funds",MutualFundCount=12,saleStatus=true},

 

        new MutualFundTransactionDetails{TMutualId=1,CustomerId=2,MutualFundName="Axis Mutual Funds",MutualFundCount=10,saleStatus=true},
           new MutualFundTransactionDetails{TMutualId=2,CustomerId=2,MutualFundName="Reliance Mutual Funds",MutualFundCount=30,saleStatus=true},
           new MutualFundTransactionDetails{TMutualId=3,CustomerId=2,MutualFundName="SBI Mutual Funds",MutualFundCount=25,saleStatus=true},
           new MutualFundTransactionDetails{TMutualId=4,CustomerId=2,MutualFundName="ICICI Mutual Funds",MutualFundCount=24,saleStatus=true},

 

       new MutualFundTransactionDetails{TMutualId=1,CustomerId=3,MutualFundName="Axis Mutual Funds",MutualFundCount=20,saleStatus=true},
           new MutualFundTransactionDetails{TMutualId=2,CustomerId=3,MutualFundName="Reliance Mutual Funds",MutualFundCount=15,saleStatus=true},
           new MutualFundTransactionDetails{TMutualId=3,CustomerId=3,MutualFundName="SBI Mutual Funds",MutualFundCount=15,saleStatus=true},
           new MutualFundTransactionDetails{TMutualId=4,CustomerId=3,MutualFundName="ICICI Mutual Funds",MutualFundCount=20,saleStatus=true},

 

        new MutualFundTransactionDetails{TMutualId=1,CustomerId=4,MutualFundName="Axis Mutual Funds",MutualFundCount=5,saleStatus=true},
           new MutualFundTransactionDetails{TMutualId=2,CustomerId=4,MutualFundName="Reliance Mutual Funds",MutualFundCount=10,saleStatus=true},
           new MutualFundTransactionDetails{TMutualId=3,CustomerId=4,MutualFundName="SBI Mutual Funds",MutualFundCount=5,saleStatus=true},
           new MutualFundTransactionDetails{TMutualId=4,CustomerId=4,MutualFundName="ICICI Mutual Funds",MutualFundCount=1,saleStatus=true},

 

        new MutualFundTransactionDetails{TMutualId=1,CustomerId=5,MutualFundName="Axis Mutual Funds",MutualFundCount=10,saleStatus=true},
           new MutualFundTransactionDetails{TMutualId=2,CustomerId=5,MutualFundName="Reliance Mutual Funds",MutualFundCount=10,saleStatus=true},
           new MutualFundTransactionDetails{TMutualId=3,CustomerId=5,MutualFundName="SBI Mutual Funds",MutualFundCount=10,saleStatus=true},
           new MutualFundTransactionDetails{TMutualId=4,CustomerId=5,MutualFundName="ICICI Mutual Funds",MutualFundCount=10,saleStatus=true}


        };
        public async Task<List<StockTransactionDetails>> GetStockTransactionDetails(Customer customer)
        {
            var StockList = stdList.Where(x => x.CustomerId == customer.CustomerId && x.saleStatus == true).ToList();
            foreach (var item in StockList)
            {
                using (var httpClient = new HttpClient())
                {
                    // using (var response = await httpClient.GetAsync("http://localhost:50195/api/DailySharePrice/" + item.StockName))
                    using (var response = await httpClient.GetAsync("http://52.150.44.236/api/DailySharePrice/" + item.StockName))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        var stockObj = JsonConvert.DeserializeObject<DailyStockDetails>(apiResponse);
                        item.TotalPrice = item.StockCount * stockObj.StockValue;
                    }
                }
            }
            return StockList;
        }
        public async Task<List<MutualFundTransactionDetails>> GetMutualFundTransactionDetails(Customer customer)
        {
            var MutualFundList = mtdList.Where(x => x.CustomerId == customer.CustomerId && x.saleStatus == true).ToList();
            foreach (var item in MutualFundList)
            {
                using (var httpClient = new HttpClient())
                {
                    //using (var response = await httpClient.GetAsync("http://localhost:50374/api/DailyMutualFundNav/" + item.MutualFundName))
                    using (var response = await httpClient.GetAsync("http://52.190.26.226/api/DailyMutualFundNav/" + item.MutualFundName))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        var mutualFundObj = JsonConvert.DeserializeObject<MutualFundDetail>(apiResponse);
                        item.TotalPrice = item.MutualFundCount * mutualFundObj.MutualFundValue;
                    }
                }
            }
            return MutualFundList;
        }

        public void SellStock(int id)
        {
            stdList.Remove(stdList.FirstOrDefault(x => x.TStockId == id));
        }

        public void SellMutualFund(int id)
        {
            mtdList.Remove(mtdList.FirstOrDefault(x => x.TMutualId == id));
        }
    }
}
