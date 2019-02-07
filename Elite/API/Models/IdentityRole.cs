// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Covenant.API.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class IdentityRole
    {
        /// <summary>
        /// Initializes a new instance of the IdentityRole class.
        /// </summary>
        public IdentityRole()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IdentityRole class.
        /// </summary>
        public IdentityRole(string id = default(string), string name = default(string), string normalizedName = default(string), string concurrencyStamp = default(string))
        {
            Id = id;
            Name = name;
            NormalizedName = normalizedName;
            ConcurrencyStamp = concurrencyStamp;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "normalizedName")]
        public string NormalizedName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "concurrencyStamp")]
        public string ConcurrencyStamp { get; set; }

    }
}
