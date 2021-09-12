using InvestmentChecker.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvestmentChecker.Controllers
{
    public class FinnhubController : Controller
    {
        private readonly IFinnhubService _finnhubService;

        public FinnhubController(IFinnhubService finnhubService)
        {
            _finnhubService = finnhubService;
        }

        [HttpGet]
        public ActionResult GetCurrentStockPriceBySymbol(string symbol)
        {
            var quote = _finnhubService.GetCurrentStockPrice(symbol);

            ViewBag.Symbol = symbol;
            ViewBag.Quote = quote.Result;

            return View("DisplayStockResults");
        }

        [HttpGet]
        public ActionResult GetCryptoPrice(string symbol)
        {
            var quote = _finnhubService.GetCryptoPrice(symbol);

            ViewBag.Symbol = symbol;
            ViewBag.Price = quote.Result.ClosePrice.First();

            return View("DisplayCryptoResults");
        }

        public ActionResult SelectStock()
        {
            return View();
        }

        public ActionResult SelectCrypto()
        {
            return View();
        }
    }
}
