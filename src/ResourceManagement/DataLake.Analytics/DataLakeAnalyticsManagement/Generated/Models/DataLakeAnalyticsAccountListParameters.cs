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

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    /// <summary>
    /// DataLakeAnalyticsAccount list parameters.
    /// </summary>
    public partial class DataLakeAnalyticsAccountListParameters
    {
        private bool? _count;
        
        /// <summary>
        /// Optional. Gets or sets a Boolean value of true or false to request
        /// a count of the matching resources included with the resources in
        /// the response, e.g. Categories?$count=true. Optional.
        /// </summary>
        public bool? Count
        {
            get { return this._count; }
            set { this._count = value; }
        }
        
        private string _expand;
        
        /// <summary>
        /// Optional. Gets or sets OData expansion. Expand related resources in
        /// line with the retrieved resources, e.g.
        /// Categories/$expand=Products would expand Product data in line with
        /// each Category entry. Optional.
        /// </summary>
        public string Expand
        {
            get { return this._expand; }
            set { this._expand = value; }
        }
        
        private string _filter;
        
        /// <summary>
        /// Optional. Gets or sets OData filter. Optional.
        /// </summary>
        public string Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }
        
        private string _format;
        
        /// <summary>
        /// Optional. Gets or sets the return format. Return the response in
        /// particular formatxii without access to request headers for
        /// standard content-type negotiation (e.g Orders?$format=json).
        /// Optional.
        /// </summary>
        public string Format
        {
            get { return this._format; }
            set { this._format = value; }
        }
        
        private string _orderBy;
        
        /// <summary>
        /// Optional. Gets or sets the OrderBy clause. One or more
        /// comma-separated expressions with an optional “asc” (the default)
        /// or “desc” depending on the order you’d like the values sorted,
        /// e.g. Categories?$orderby=CategoryName desc. Optional.
        /// </summary>
        public string OrderBy
        {
            get { return this._orderBy; }
            set { this._orderBy = value; }
        }
        
        private string _search;
        
        /// <summary>
        /// Optional. Gets or sets a free form search. A free-text search
        /// expression to match for whether a particular entry should be
        /// included in the feed, e.g. Categories?$search=blue OR green.
        /// Optional.
        /// </summary>
        public string Search
        {
            get { return this._search; }
            set { this._search = value; }
        }
        
        private string _select;
        
        /// <summary>
        /// Optional. Gets or sets OData Select statement. Limits the
        /// properties on each entry to just those requested, e.g.
        /// Categories?$select=CategoryName,Description. Optional.
        /// </summary>
        public string Select
        {
            get { return this._select; }
            set { this._select = value; }
        }
        
        private int? _skip;
        
        /// <summary>
        /// Optional. Gets or sets the number of items to skip over before
        /// returning elements. Optional.
        /// </summary>
        public int? Skip
        {
            get { return this._skip; }
            set { this._skip = value; }
        }
        
        private int? _top;
        
        /// <summary>
        /// Optional. Gets or sets the number of items to return. Optional.
        /// </summary>
        public int? Top
        {
            get { return this._top; }
            set { this._top = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// DataLakeAnalyticsAccountListParameters class.
        /// </summary>
        public DataLakeAnalyticsAccountListParameters()
        {
        }
    }
}