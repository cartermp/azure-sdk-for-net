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
using Microsoft.Azure.Management.RemoteApp.Models;
using Microsoft.Azure.Management.RemoteApp.Operations;
using Microsoft.Azure.Management.RemoteApp.Responses.Applications;

namespace Microsoft.Azure.Management.RemoteApp.Operations
{
    public static partial class PublishingOperationsExtensions
    {
        /// <summary>
        /// Gets the details of a published application with given alias (short
        /// unique name) from the collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.Operations.IPublishingOperations.
        /// </param>
        /// <param name='collectionId'>
        /// Required. Collection Id
        /// </param>
        /// <param name='alias'>
        /// Required. Alias of published application
        /// </param>
        /// <returns>
        /// Definition for result of GetPublishedApplication operation.
        /// </returns>
        public static GetPublishedApplicationResult Get(this IPublishingOperations operations, string collectionId, string alias)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPublishingOperations)s).GetAsync(collectionId, alias);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the details of a published application with given alias (short
        /// unique name) from the collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.Operations.IPublishingOperations.
        /// </param>
        /// <param name='collectionId'>
        /// Required. Collection Id
        /// </param>
        /// <param name='alias'>
        /// Required. Alias of published application
        /// </param>
        /// <returns>
        /// Definition for result of GetPublishedApplication operation.
        /// </returns>
        public static Task<GetPublishedApplicationResult> GetAsync(this IPublishingOperations operations, string collectionId, string alias)
        {
            return operations.GetAsync(collectionId, alias, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the list of details for all published applications from the
        /// collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.Operations.IPublishingOperations.
        /// </param>
        /// <param name='collectionId'>
        /// Required. Collection Id
        /// </param>
        /// <returns>
        /// Definition for result of GetPublishedApplicationList operation.
        /// </returns>
        public static GetPublishedApplicationListResult List(this IPublishingOperations operations, string collectionId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPublishingOperations)s).ListAsync(collectionId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the list of details for all published applications from the
        /// collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.Operations.IPublishingOperations.
        /// </param>
        /// <param name='collectionId'>
        /// Required. Collection Id
        /// </param>
        /// <returns>
        /// Definition for result of GetPublishedApplicationList operation.
        /// </returns>
        public static Task<GetPublishedApplicationListResult> ListAsync(this IPublishingOperations operations, string collectionId)
        {
            return operations.ListAsync(collectionId, CancellationToken.None);
        }
        
        /// <summary>
        /// Sets a published application matching the given alias (short unique
        /// name) in the collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.Operations.IPublishingOperations.
        /// </param>
        /// <param name='collectionId'>
        /// Required. Collection Id
        /// </param>
        /// <param name='alias'>
        /// Required. Alias of published application
        /// </param>
        /// <param name='applicationDetails'>
        /// Required. New details for the application
        /// </param>
        /// <returns>
        /// Definition for result of ModifyApplicaton operation.
        /// </returns>
        public static ModifyApplicationResult ModifyApplication(this IPublishingOperations operations, string collectionId, string alias, ApplicationDetailsParameter applicationDetails)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPublishingOperations)s).ModifyApplicationAsync(collectionId, alias, applicationDetails);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Sets a published application matching the given alias (short unique
        /// name) in the collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.Operations.IPublishingOperations.
        /// </param>
        /// <param name='collectionId'>
        /// Required. Collection Id
        /// </param>
        /// <param name='alias'>
        /// Required. Alias of published application
        /// </param>
        /// <param name='applicationDetails'>
        /// Required. New details for the application
        /// </param>
        /// <returns>
        /// Definition for result of ModifyApplicaton operation.
        /// </returns>
        public static Task<ModifyApplicationResult> ModifyApplicationAsync(this IPublishingOperations operations, string collectionId, string alias, ApplicationDetailsParameter applicationDetails)
        {
            return operations.ModifyApplicationAsync(collectionId, alias, applicationDetails, CancellationToken.None);
        }
        
        /// <summary>
        /// Publishes remote applications with given application details in the
        /// collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.Operations.IPublishingOperations.
        /// </param>
        /// <param name='collectionId'>
        /// Required. Collection Id
        /// </param>
        /// <param name='applicationDetailsList'>
        /// Required. List of publishing details
        /// </param>
        /// <returns>
        /// Definition for result of PublishApplications operation.
        /// </returns>
        public static PublishApplicationsResult PublishApplications(this IPublishingOperations operations, string collectionId, ApplicationDetailsListParameter applicationDetailsList)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPublishingOperations)s).PublishApplicationsAsync(collectionId, applicationDetailsList);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Publishes remote applications with given application details in the
        /// collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.Operations.IPublishingOperations.
        /// </param>
        /// <param name='collectionId'>
        /// Required. Collection Id
        /// </param>
        /// <param name='applicationDetailsList'>
        /// Required. List of publishing details
        /// </param>
        /// <returns>
        /// Definition for result of PublishApplications operation.
        /// </returns>
        public static Task<PublishApplicationsResult> PublishApplicationsAsync(this IPublishingOperations operations, string collectionId, ApplicationDetailsListParameter applicationDetailsList)
        {
            return operations.PublishApplicationsAsync(collectionId, applicationDetailsList, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets a start menu application details for the given id from the
        /// collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.Operations.IPublishingOperations.
        /// </param>
        /// <param name='collectionId'>
        /// Required. Collection Id
        /// </param>
        /// <param name='applicationId'>
        /// Required. Start menu application Id
        /// </param>
        /// <returns>
        /// Definition for result of GetStartMenuApplication operation.
        /// </returns>
        public static GetStartMenuApplicationResult StartMenuApplication(this IPublishingOperations operations, string collectionId, string applicationId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPublishingOperations)s).StartMenuApplicationAsync(collectionId, applicationId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets a start menu application details for the given id from the
        /// collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.Operations.IPublishingOperations.
        /// </param>
        /// <param name='collectionId'>
        /// Required. Collection Id
        /// </param>
        /// <param name='applicationId'>
        /// Required. Start menu application Id
        /// </param>
        /// <returns>
        /// Definition for result of GetStartMenuApplication operation.
        /// </returns>
        public static Task<GetStartMenuApplicationResult> StartMenuApplicationAsync(this IPublishingOperations operations, string collectionId, string applicationId)
        {
            return operations.StartMenuApplicationAsync(collectionId, applicationId, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the list of all start menu applications from the collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.Operations.IPublishingOperations.
        /// </param>
        /// <param name='collectionId'>
        /// Required. Collection Id
        /// </param>
        /// <returns>
        /// Definition for result of GetStartMenuApplicationList operation.
        /// </returns>
        public static GetStartMenuApplicationListResult StartMenuApplicationList(this IPublishingOperations operations, string collectionId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPublishingOperations)s).StartMenuApplicationListAsync(collectionId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the list of all start menu applications from the collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.Operations.IPublishingOperations.
        /// </param>
        /// <param name='collectionId'>
        /// Required. Collection Id
        /// </param>
        /// <returns>
        /// Definition for result of GetStartMenuApplicationList operation.
        /// </returns>
        public static Task<GetStartMenuApplicationListResult> StartMenuApplicationListAsync(this IPublishingOperations operations, string collectionId)
        {
            return operations.StartMenuApplicationListAsync(collectionId, CancellationToken.None);
        }
        
        /// <summary>
        /// Unpublishes published applications matching the given list of
        /// application aliases (short unique names) from the collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.Operations.IPublishingOperations.
        /// </param>
        /// <param name='collectionId'>
        /// Required. Collection Id
        /// </param>
        /// <param name='aliasesList'>
        /// Required. List of application aliases to be unpublished
        /// </param>
        /// <returns>
        /// Definition for result of UnpublishApplications operation.
        /// </returns>
        public static UnpublishApplicationsResult Unpublish(this IPublishingOperations operations, string collectionId, AliasesListParameter aliasesList)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPublishingOperations)s).UnpublishAsync(collectionId, aliasesList);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Unpublishes published applications matching the given list of
        /// application aliases (short unique names) from the collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.Operations.IPublishingOperations.
        /// </param>
        /// <param name='collectionId'>
        /// Required. Collection Id
        /// </param>
        /// <param name='aliasesList'>
        /// Required. List of application aliases to be unpublished
        /// </param>
        /// <returns>
        /// Definition for result of UnpublishApplications operation.
        /// </returns>
        public static Task<UnpublishApplicationsResult> UnpublishAsync(this IPublishingOperations operations, string collectionId, AliasesListParameter aliasesList)
        {
            return operations.UnpublishAsync(collectionId, aliasesList, CancellationToken.None);
        }
        
        /// <summary>
        /// Unpublishes all published applications from the collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.Operations.IPublishingOperations.
        /// </param>
        /// <param name='collectionId'>
        /// Required. Collection Id
        /// </param>
        /// <returns>
        /// Definition for result of UnpublishAllApplications operation.
        /// </returns>
        public static UnpublishAllApplicationsResult UnpublishAll(this IPublishingOperations operations, string collectionId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IPublishingOperations)s).UnpublishAllAsync(collectionId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Unpublishes all published applications from the collection.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RemoteApp.Operations.IPublishingOperations.
        /// </param>
        /// <param name='collectionId'>
        /// Required. Collection Id
        /// </param>
        /// <returns>
        /// Definition for result of UnpublishAllApplications operation.
        /// </returns>
        public static Task<UnpublishAllApplicationsResult> UnpublishAllAsync(this IPublishingOperations operations, string collectionId)
        {
            return operations.UnpublishAllAsync(collectionId, CancellationToken.None);
        }
    }
}
