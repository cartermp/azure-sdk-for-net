// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.RemoteApp.Models.Accounts;
using Microsoft.Azure.Management.RemoteApp.Operations;
using Microsoft.Azure.Management.RemoteApp.Responses.Accounts;
using Microsoft.Azure.Management.RemoteApp.Responses.Common;

namespace Microsoft.Azure.Management.RemoteApp.Operations
{
    public static partial class AccountsOperationsExtensions
    {
        /// <summary>
        /// Gets the details of the account.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.Operations.IAccountsOperations.
        /// </param>
        /// <returns>
        /// Definition for result of GetAccount operaton.
        /// </returns>
        public static GetAccountResult Get(this IAccountsOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAccountsOperations)s).GetAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the details of the account.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.Operations.IAccountsOperations.
        /// </param>
        /// <returns>
        /// Definition for result of GetAccount operaton.
        /// </returns>
        public static Task<GetAccountResult> GetAsync(this IAccountsOperations operations)
        {
            return operations.GetAsync(CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the list of available billing plans for the customer.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.Operations.IAccountsOperations.
        /// </param>
        /// <returns>
        /// Definition for result of ListBillingPlans operation.
        /// </returns>
        public static ListBillingPlansResult ListBillingPlans(this IAccountsOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAccountsOperations)s).ListBillingPlansAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the list of available billing plans for the customer.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.Operations.IAccountsOperations.
        /// </param>
        /// <returns>
        /// Definition for result of ListBillingPlans operation.
        /// </returns>
        public static Task<ListBillingPlansResult> ListBillingPlansAsync(this IAccountsOperations operations)
        {
            return operations.ListBillingPlansAsync(CancellationToken.None);
        }
        
        /// <summary>
        /// Sets the new details of the account.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.Operations.IAccountsOperations.
        /// </param>
        /// <param name='accountInfo'>
        /// Required. New details of account.
        /// </param>
        /// <returns>
        /// The response containing the operation tracking id.
        /// </returns>
        public static OperationResultWithTrackingId Set(this IAccountsOperations operations, AccountDetailsParameter accountInfo)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAccountsOperations)s).SetAsync(accountInfo);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Sets the new details of the account.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.Operations.IAccountsOperations.
        /// </param>
        /// <param name='accountInfo'>
        /// Required. New details of account.
        /// </param>
        /// <returns>
        /// The response containing the operation tracking id.
        /// </returns>
        public static Task<OperationResultWithTrackingId> SetAsync(this IAccountsOperations operations, AccountDetailsParameter accountInfo)
        {
            return operations.SetAsync(accountInfo, CancellationToken.None);
        }
    }
}
