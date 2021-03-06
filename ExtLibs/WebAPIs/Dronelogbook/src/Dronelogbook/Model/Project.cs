/* 
 * Dronelogbook API
 *
 * This is the swagger file that describes Dronelogbook API
 *
 * OpenAPI spec version: 1.0.0
 * Contact: support@dronelogbook.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Dronelogbook.Model
{
    /// <summary>
    /// Project
    /// </summary>
    [DataContract]
    public partial class Project :  IEquatable<Project>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        /// <param name="Archived">Archived.</param>
        /// <param name="CustomerGuid">CustomerGuid.</param>
        /// <param name="Guid">Guid.</param>
        /// <param name="IncomeAmount">IncomeAmount.</param>
        /// <param name="IncomeCurrency">IncomeCurrency.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Notes">Notes.</param>
        /// <param name="Tags">Tags.</param>
        public Project(int? Archived = null, string CustomerGuid = null, string Guid = null, double? IncomeAmount = null, string IncomeCurrency = null, string Name = null, string Notes = null, string Tags = null)
        {
            this.Archived = Archived;
            this.CustomerGuid = CustomerGuid;
            this.Guid = Guid;
            this.IncomeAmount = IncomeAmount;
            this.IncomeCurrency = IncomeCurrency;
            this.Name = Name;
            this.Notes = Notes;
            this.Tags = Tags;
        }
        
        /// <summary>
        /// Gets or Sets Archived
        /// </summary>
        [DataMember(Name="archived", EmitDefaultValue=false)]
        public int? Archived { get; set; }
        /// <summary>
        /// Gets or Sets CustomerGuid
        /// </summary>
        [DataMember(Name="customer_guid", EmitDefaultValue=false)]
        public string CustomerGuid { get; set; }
        /// <summary>
        /// Gets or Sets Guid
        /// </summary>
        [DataMember(Name="guid", EmitDefaultValue=false)]
        public string Guid { get; set; }
        /// <summary>
        /// Gets or Sets IncomeAmount
        /// </summary>
        [DataMember(Name="income_amount", EmitDefaultValue=false)]
        public double? IncomeAmount { get; set; }
        /// <summary>
        /// Gets or Sets IncomeCurrency
        /// </summary>
        [DataMember(Name="income_currency", EmitDefaultValue=false)]
        public string IncomeCurrency { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }
        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public string Tags { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Project {\n");
            sb.Append("  Archived: ").Append(Archived).Append("\n");
            sb.Append("  CustomerGuid: ").Append(CustomerGuid).Append("\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  IncomeAmount: ").Append(IncomeAmount).Append("\n");
            sb.Append("  IncomeCurrency: ").Append(IncomeCurrency).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Project);
        }

        /// <summary>
        /// Returns true if Project instances are equal
        /// </summary>
        /// <param name="other">Instance of Project to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Project other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Archived == other.Archived ||
                    this.Archived != null &&
                    this.Archived.Equals(other.Archived)
                ) && 
                (
                    this.CustomerGuid == other.CustomerGuid ||
                    this.CustomerGuid != null &&
                    this.CustomerGuid.Equals(other.CustomerGuid)
                ) && 
                (
                    this.Guid == other.Guid ||
                    this.Guid != null &&
                    this.Guid.Equals(other.Guid)
                ) && 
                (
                    this.IncomeAmount == other.IncomeAmount ||
                    this.IncomeAmount != null &&
                    this.IncomeAmount.Equals(other.IncomeAmount)
                ) && 
                (
                    this.IncomeCurrency == other.IncomeCurrency ||
                    this.IncomeCurrency != null &&
                    this.IncomeCurrency.Equals(other.IncomeCurrency)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.Equals(other.Notes)
                ) && 
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.Equals(other.Tags)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Archived != null)
                    hash = hash * 59 + this.Archived.GetHashCode();
                if (this.CustomerGuid != null)
                    hash = hash * 59 + this.CustomerGuid.GetHashCode();
                if (this.Guid != null)
                    hash = hash * 59 + this.Guid.GetHashCode();
                if (this.IncomeAmount != null)
                    hash = hash * 59 + this.IncomeAmount.GetHashCode();
                if (this.IncomeCurrency != null)
                    hash = hash * 59 + this.IncomeCurrency.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();
                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
                return hash;
            }
        }
    }

}
