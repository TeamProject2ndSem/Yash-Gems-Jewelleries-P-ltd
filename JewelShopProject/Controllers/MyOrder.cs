﻿
using JewelShopProject.Models;
using Microsoft.AspNetCore.Mvc;
using Razorpay.Api;

namespace credit_card.Controllers
{
    public class MyOrder : Controller
    {
        [BindProperty]
        public EntityOrder _OrderDetails { get; set; }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateOrder()
        {

            string key = "rzp_test_GuoTeNjQD52BlJ";
            string secret = "HE1lapQfySHaIRiI5d9QLDfS";
            Random _random = new Random();
            string transactionId = _random.Next(0, 3000).ToString();

            Dictionary<string, object> input = new Dictionary<string, object>();
            input.Add("amount", Convert.ToDecimal(_OrderDetails.Amount) * 100);  // this amount should be same as transaction amount
            input.Add("currency", "INR");
            input.Add("receipt", transactionId);


            RazorpayClient client = new RazorpayClient(key, secret);

            Razorpay.Api.Order order = client.Order.Create(input);
            ViewBag.orderId = order["id"].ToString();
            return View("Payment", _OrderDetails);
        }
        public IActionResult Payment(string razorpay_payment_id, string razorpay_order_id,
            string razorpay_signature)
        {
            RazorpayClient client = new RazorpayClient("[YOUR_KEY_ID]", "[YOUR_KEY_SECRET]");

            Dictionary<string, string> attributes = new Dictionary<string, string>();

            attributes.Add("razorpay_payment_id", razorpay_payment_id);
            attributes.Add("razorpay_order_id", razorpay_order_id);
            attributes.Add("razorpay_signature", razorpay_signature);

            Utils.verifyPaymentSignature(attributes);

            EntityOrder orderDtl = new EntityOrder();
            orderDtl.TransactionId = razorpay_order_id;
            orderDtl.OrderId = razorpay_order_id;
            return View("PaymentSuccess", orderDtl);
        }
    }
}
