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
    ///  Class for testing AdminApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AdminApiTests : IDisposable
    {
        private AdminApi instance;

        public AdminApiTests()
        {
            instance = new AdminApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AdminApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AdminApi
            //Assert.IsType<AdminApi>(instance);
        }

        /// <summary>
        /// Test ApiAdminAddcointokenPost
        /// </summary>
        [Fact]
        public void ApiAdminAddcointokenPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CoinTokenAddRequest coinTokenAddRequest = null;
            //var response = instance.ApiAdminAddcointokenPost(coinTokenAddRequest);
            //Assert.IsType<bool>(response);
        }

        /// <summary>
        /// Test ApiAdminGetuserdataPost
        /// </summary>
        [Fact]
        public void ApiAdminGetuserdataPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string email = null;
            //var response = instance.ApiAdminGetuserdataPost(email);
            //Assert.IsType<ApplicationUser>(response);
        }

        /// <summary>
        /// Test ApiAdminGetusertradedataPost
        /// </summary>
        [Fact]
        public void ApiAdminGetusertradedataPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string email = null;
            //var response = instance.ApiAdminGetusertradedataPost(email);
            //Assert.IsType<TradeData>(response);
        }

        /// <summary>
        /// Test ApiAdminSearchuserGet
        /// </summary>
        [Fact]
        public void ApiAdminSearchuserGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string searchString = null;
            //var response = instance.ApiAdminSearchuserGet(searchString);
            //Assert.IsType<List<string>>(response);
        }

        /// <summary>
        /// Test ApiAdminUsercommandPost
        /// </summary>
        [Fact]
        public void ApiAdminUsercommandPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string email = null;
            //UserAdminCommand? command = null;
            //var response = instance.ApiAdminUsercommandPost(email, command);
            //Assert.IsType<bool>(response);
        }
    }
}
