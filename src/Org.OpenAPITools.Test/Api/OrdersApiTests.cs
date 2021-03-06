/*
 * BITFLEX Public API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
// uncomment below to import models
//using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test.Api
{
    /// <summary>
    ///  Class for testing OrdersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class OrdersApiTests : IDisposable
    {
        private OrdersApi instance;

        public OrdersApiTests()
        {
            instance = new OrdersApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of OrdersApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' OrdersApi
            //Assert.IsType<OrdersApi>(instance);
        }

        /// <summary>
        /// Test OrdersCancelPost
        /// </summary>
        [Fact]
        public void OrdersCancelPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orderId = null;
            //var response = instance.OrdersCancelPost(orderId);
            //Assert.IsType<bool>(response);
        }

        /// <summary>
        /// Test OrdersPairNameGet
        /// </summary>
        [Fact]
        public void OrdersPairNameGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pairName = null;
            //instance.OrdersPairNameGet(pairName);
        }

        /// <summary>
        /// Test OrdersPost
        /// </summary>
        [Fact]
        public void OrdersPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //double? amount = null;
            //double? price = null;
            //TradeType? tradeType = null;
            //string pairId = null;
            //OrderTypes? orderType = null;
            //bool? isMargin = null;
            //int? leverage = null;
            //double? initialAmount = null;
            //double? initialPrice = null;
            //double? stopLossPrice = null;
            //double? takeProfitPrice = null;
            //var response = instance.OrdersPost(amount, price, tradeType, pairId, orderType, isMargin, leverage, initialAmount, initialPrice, stopLossPrice, takeProfitPrice);
            //Assert.IsType<OrderCreateResult>(response);
        }
    }
}
