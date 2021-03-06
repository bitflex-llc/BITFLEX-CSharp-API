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
    ///  Class for testing SignApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SignApiTests : IDisposable
    {
        private SignApi instance;

        public SignApiTests()
        {
            instance = new SignApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SignApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SignApi
            //Assert.IsType<SignApi>(instance);
        }

        /// <summary>
        /// Test ApiSignAffiliatedataPost
        /// </summary>
        [Fact]
        public void ApiSignAffiliatedataPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<CryptoCurrency> cryptoCurrencies = null;
            //List<Order> orders = null;
            //List<DepositAddress> depositAddresses = null;
            //List<Balance> userBalances = null;
            //List<Market> markets = null;
            //List<TradingPair> tradingPairs = null;
            //List<Transaction> transactions = null;
            //List<WithdrawRequest> withdrawRequests = null;
            //List<ManualWithdrawRequest> manualWithdrawRequests = null;
            //List<Trade> trades = null;
            //List<Quote> quotes = null;
            //List<SmsVerificationMessage> smsVerificationMessages = null;
            //List<TradingAmount> tradingAmounts = null;
            //List<RippleDestinationTag> rippleDestinationTags = null;
            //List<BitcoinBasedCurrency> bitcoinBasedCurrencies = null;
            //List<ERC20Token> eRC20Tokens = null;
            //List<BalanceAction> balanceActions = null;
            //List<KeyValue> keysValues = null;
            //List<IApplicationTokenAccess> applicationTokenAccesses = null;
            //List<IApplicationQrCommand> applicationQrCommands = null;
            //List<PushToken> pushTokens = null;
            //List<HealthCheck> healthChecks = null;
            //List<StringIdentityUserRole> userRoles = null;
            //List<IdentityRole> roles = null;
            //List<StringIdentityRoleClaim> roleClaims = null;
            //List<ApplicationUser> users = null;
            //List<StringIdentityUserClaim> userClaims = null;
            //List<StringIdentityUserLogin> userLogins = null;
            //List<StringIdentityUserToken> userTokens = null;
            //Guid? databaseCurrentTransactionTransactionId = null;
            //bool? databaseCurrentTransactionSupportsSavepoints = null;
            //bool? databaseAutoTransactionsEnabled = null;
            //string databaseProviderName = null;
            //bool? changeTrackerAutoDetectChangesEnabled = null;
            //bool? changeTrackerLazyLoadingEnabled = null;
            //QueryTrackingBehavior? changeTrackerQueryTrackingBehavior = null;
            //CascadeTiming? changeTrackerDeleteOrphansTiming = null;
            //CascadeTiming? changeTrackerCascadeDeleteTiming = null;
            //Guid? changeTrackerContextDatabaseCurrentTransactionTransactionId = null;
            //bool? changeTrackerContextDatabaseCurrentTransactionSupportsSavepoints = null;
            //bool? changeTrackerContextDatabaseAutoTransactionsEnabled = null;
            //string changeTrackerContextDatabaseProviderName = null;
            //bool? changeTrackerContextChangeTrackerAutoDetectChangesEnabled = null;
            //bool? changeTrackerContextChangeTrackerLazyLoadingEnabled = null;
            //QueryTrackingBehavior? changeTrackerContextChangeTrackerQueryTrackingBehavior = null;
            //CascadeTiming? changeTrackerContextChangeTrackerDeleteOrphansTiming = null;
            //CascadeTiming? changeTrackerContextChangeTrackerCascadeDeleteTiming = null;
            //DbContext changeTrackerContextChangeTrackerContext = null;
            //string changeTrackerContextChangeTrackerDebugViewLongView = null;
            //string changeTrackerContextChangeTrackerDebugViewShortView = null;
            //Object changeTrackerContextModel = null;
            //Guid? changeTrackerContextContextIdInstanceId = null;
            //int? changeTrackerContextContextIdLease = null;
            //string changeTrackerDebugViewLongView = null;
            //string changeTrackerDebugViewShortView = null;
            //Object model = null;
            //Guid? contextIdInstanceId = null;
            //int? contextIdLease = null;
            //instance.ApiSignAffiliatedataPost(cryptoCurrencies, orders, depositAddresses, userBalances, markets, tradingPairs, transactions, withdrawRequests, manualWithdrawRequests, trades, quotes, smsVerificationMessages, tradingAmounts, rippleDestinationTags, bitcoinBasedCurrencies, eRC20Tokens, balanceActions, keysValues, applicationTokenAccesses, applicationQrCommands, pushTokens, healthChecks, userRoles, roles, roleClaims, users, userClaims, userLogins, userTokens, databaseCurrentTransactionTransactionId, databaseCurrentTransactionSupportsSavepoints, databaseAutoTransactionsEnabled, databaseProviderName, changeTrackerAutoDetectChangesEnabled, changeTrackerLazyLoadingEnabled, changeTrackerQueryTrackingBehavior, changeTrackerDeleteOrphansTiming, changeTrackerCascadeDeleteTiming, changeTrackerContextDatabaseCurrentTransactionTransactionId, changeTrackerContextDatabaseCurrentTransactionSupportsSavepoints, changeTrackerContextDatabaseAutoTransactionsEnabled, changeTrackerContextDatabaseProviderName, changeTrackerContextChangeTrackerAutoDetectChangesEnabled, changeTrackerContextChangeTrackerLazyLoadingEnabled, changeTrackerContextChangeTrackerQueryTrackingBehavior, changeTrackerContextChangeTrackerDeleteOrphansTiming, changeTrackerContextChangeTrackerCascadeDeleteTiming, changeTrackerContextChangeTrackerContext, changeTrackerContextChangeTrackerDebugViewLongView, changeTrackerContextChangeTrackerDebugViewShortView, changeTrackerContextModel, changeTrackerContextContextIdInstanceId, changeTrackerContextContextIdLease, changeTrackerDebugViewLongView, changeTrackerDebugViewShortView, model, contextIdInstanceId, contextIdLease);
        }

        /// <summary>
        /// Test ApiSignCheckIsMobileOnlinePost
        /// </summary>
        [Fact]
        public void ApiSignCheckIsMobileOnlinePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.ApiSignCheckIsMobileOnlinePost();
        }

        /// <summary>
        /// Test ApiSignConfirmemailPost
        /// </summary>
        [Fact]
        public void ApiSignConfirmemailPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PostConfirmRequest postConfirmRequest = null;
            //var response = instance.ApiSignConfirmemailPost(postConfirmRequest);
            //Assert.IsType<EmailConfirmationResult>(response);
        }

        /// <summary>
        /// Test ApiSignEnable2faPost
        /// </summary>
        [Fact]
        public void ApiSignEnable2faPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string deviceName = null;
            //var response = instance.ApiSignEnable2faPost(deviceName);
            //Assert.IsType<bool>(response);
        }

        /// <summary>
        /// Test ApiSignGetRequestsGet
        /// </summary>
        [Fact]
        public void ApiSignGetRequestsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string deviceName = null;
            //string ip = null;
            //var response = instance.ApiSignGetRequestsGet(deviceName, ip);
            //Assert.IsType<List<MobileConfirmationRequest>>(response);
        }

        /// <summary>
        /// Test ApiSignGetreferreremailPost
        /// </summary>
        [Fact]
        public void ApiSignGetreferreremailPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PostGetReferrerEmailRequest postGetReferrerEmailRequest = null;
            //var response = instance.ApiSignGetreferreremailPost(postGetReferrerEmailRequest);
            //Assert.IsType<PostGetReferrerEmailResponse>(response);
        }

        /// <summary>
        /// Test ApiSignMobileConfirmationRequestPost
        /// </summary>
        [Fact]
        public void ApiSignMobileConfirmationRequestPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RequestType? requestType = null;
            //instance.ApiSignMobileConfirmationRequestPost(requestType);
        }

        /// <summary>
        /// Test ApiSignResetpasswordPost
        /// </summary>
        [Fact]
        public void ApiSignResetpasswordPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PostResetPasswordRequest postResetPasswordRequest = null;
            //var response = instance.ApiSignResetpasswordPost(postResetPasswordRequest);
            //Assert.IsType<bool>(response);
        }

        /// <summary>
        /// Test ApiSignRestorepasswordPost
        /// </summary>
        [Fact]
        public void ApiSignRestorepasswordPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PostForgotPasswordRequest postForgotPasswordRequest = null;
            //var response = instance.ApiSignRestorepasswordPost(postForgotPasswordRequest);
            //Assert.IsType<bool>(response);
        }

        /// <summary>
        /// Test ApiSignSetAffiliatePost
        /// </summary>
        [Fact]
        public void ApiSignSetAffiliatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PostSetAffiliateRequest postSetAffiliateRequest = null;
            //instance.ApiSignSetAffiliatePost(postSetAffiliateRequest);
        }

        /// <summary>
        /// Test ApiSignSigninPost
        /// </summary>
        [Fact]
        public void ApiSignSigninPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PostSignInRequest postSignInRequest = null;
            //var response = instance.ApiSignSigninPost(postSignInRequest);
            //Assert.IsType<PostSignInResponse>(response);
        }

        /// <summary>
        /// Test ApiSignSignupPost
        /// </summary>
        [Fact]
        public void ApiSignSignupPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PostSignUpRequest postSignUpRequest = null;
            //var response = instance.ApiSignSignupPost(postSignUpRequest);
            //Assert.IsType<PostSignUpResponse>(response);
        }
    }
}
