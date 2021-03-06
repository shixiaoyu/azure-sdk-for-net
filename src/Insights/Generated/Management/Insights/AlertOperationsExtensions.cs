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
using Microsoft.Azure.Management.Insights;
using Microsoft.Azure.Management.Insights.Models;
using Microsoft.WindowsAzure;

namespace Microsoft.Azure.Management.Insights
{
    public static partial class AlertOperationsExtensions
    {
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Insights.IAlertOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='parameters'>
        /// Required. The rule to create or update.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse CreateOrUpdateRule(this IAlertOperations operations, string resourceGroupName, RuleCreateOrUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAlertOperations)s).CreateOrUpdateRuleAsync(resourceGroupName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Insights.IAlertOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='parameters'>
        /// Required. The rule to create or update.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> CreateOrUpdateRuleAsync(this IAlertOperations operations, string resourceGroupName, RuleCreateOrUpdateParameters parameters)
        {
            return operations.CreateOrUpdateRuleAsync(resourceGroupName, parameters, CancellationToken.None);
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Insights.IAlertOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='ruleName'>
        /// Required. The name of the rule to delete.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse DeleteRule(this IAlertOperations operations, string resourceGroupName, string ruleName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAlertOperations)s).DeleteRuleAsync(resourceGroupName, ruleName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Insights.IAlertOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='ruleName'>
        /// Required. The name of the rule to delete.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> DeleteRuleAsync(this IAlertOperations operations, string resourceGroupName, string ruleName)
        {
            return operations.DeleteRuleAsync(resourceGroupName, ruleName, CancellationToken.None);
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Insights.IAlertOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='ruleName'>
        /// Required. The name of the rule.
        /// </param>
        /// <param name='incidentName'>
        /// Required. The name of the incident to retrieve.
        /// </param>
        /// <returns>
        /// The Get Incident operation response.
        /// </returns>
        public static IncidentGetResponse GetIncident(this IAlertOperations operations, string resourceGroupName, string ruleName, string incidentName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAlertOperations)s).GetIncidentAsync(resourceGroupName, ruleName, incidentName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Insights.IAlertOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='ruleName'>
        /// Required. The name of the rule.
        /// </param>
        /// <param name='incidentName'>
        /// Required. The name of the incident to retrieve.
        /// </param>
        /// <returns>
        /// The Get Incident operation response.
        /// </returns>
        public static Task<IncidentGetResponse> GetIncidentAsync(this IAlertOperations operations, string resourceGroupName, string ruleName, string incidentName)
        {
            return operations.GetIncidentAsync(resourceGroupName, ruleName, incidentName, CancellationToken.None);
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Insights.IAlertOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='ruleName'>
        /// Required. The name of the rule to retrieve.
        /// </param>
        /// <returns>
        /// The Get Rule operation response.
        /// </returns>
        public static RuleGetResponse GetRule(this IAlertOperations operations, string resourceGroupName, string ruleName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAlertOperations)s).GetRuleAsync(resourceGroupName, ruleName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Insights.IAlertOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='ruleName'>
        /// Required. The name of the rule to retrieve.
        /// </param>
        /// <returns>
        /// The Get Rule operation response.
        /// </returns>
        public static Task<RuleGetResponse> GetRuleAsync(this IAlertOperations operations, string resourceGroupName, string ruleName)
        {
            return operations.GetRuleAsync(resourceGroupName, ruleName, CancellationToken.None);
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Insights.IAlertOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='ruleName'>
        /// Required. The name of the rule.
        /// </param>
        /// <returns>
        /// The List incidents operation response.
        /// </returns>
        public static IncidentListResponse ListIncidentsForRule(this IAlertOperations operations, string resourceGroupName, string ruleName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAlertOperations)s).ListIncidentsForRuleAsync(resourceGroupName, ruleName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Insights.IAlertOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='ruleName'>
        /// Required. The name of the rule.
        /// </param>
        /// <returns>
        /// The List incidents operation response.
        /// </returns>
        public static Task<IncidentListResponse> ListIncidentsForRuleAsync(this IAlertOperations operations, string resourceGroupName, string ruleName)
        {
            return operations.ListIncidentsForRuleAsync(resourceGroupName, ruleName, CancellationToken.None);
        }
        
        /// <summary>
        /// List the alert rules within a resource group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Insights.IAlertOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='targetResourceUri'>
        /// Optional. The resource identifier of the target of the alert rule.
        /// </param>
        /// <returns>
        /// The List Rules operation response.
        /// </returns>
        public static RuleListResponse ListRules(this IAlertOperations operations, string resourceGroupName, string targetResourceUri)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAlertOperations)s).ListRulesAsync(resourceGroupName, targetResourceUri);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// List the alert rules within a resource group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Insights.IAlertOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='targetResourceUri'>
        /// Optional. The resource identifier of the target of the alert rule.
        /// </param>
        /// <returns>
        /// The List Rules operation response.
        /// </returns>
        public static Task<RuleListResponse> ListRulesAsync(this IAlertOperations operations, string resourceGroupName, string targetResourceUri)
        {
            return operations.ListRulesAsync(resourceGroupName, targetResourceUri, CancellationToken.None);
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Insights.IAlertOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='parameters'>
        /// Required. The rule to update.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse UpdateRule(this IAlertOperations operations, string resourceGroupName, RuleCreateOrUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAlertOperations)s).UpdateRuleAsync(resourceGroupName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Insights.IAlertOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='parameters'>
        /// Required. The rule to update.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> UpdateRuleAsync(this IAlertOperations operations, string resourceGroupName, RuleCreateOrUpdateParameters parameters)
        {
            return operations.UpdateRuleAsync(resourceGroupName, parameters, CancellationToken.None);
        }
    }
}
