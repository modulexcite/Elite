// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Covenant.API.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Grunt
    {
        /// <summary>
        /// Initializes a new instance of the Grunt class.
        /// </summary>
        public Grunt()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Grunt class.
        /// </summary>
        /// <param name="dotNetFrameworkVersion">Possible values include:
        /// 'Net40', 'Net35', 'NetCore21'</param>
        /// <param name="status">Possible values include: 'Uninitialized',
        /// 'Stage0', 'Stage1', 'Stage2', 'Active', 'Lost', 'Killed'</param>
        /// <param name="integrity">Possible values include: 'Untrusted',
        /// 'Low', 'Medium', 'High', 'System'</param>
        public Grunt(int? id = default(int?), string name = default(string), DotNetVersion? dotNetFrameworkVersion = default(DotNetVersion?), int? listenerId = default(int?), string covenantIPAddress = default(string), int? delay = default(int?), int? jitter = default(int?), int? connectAttempts = default(int?), string lastCheckIn = default(string), GruntStatus? status = default(GruntStatus?), IntegrityLevel? integrity = default(IntegrityLevel?), string process = default(string), string userDomainName = default(string), string userName = default(string), string ipAddress = default(string), string operatingSystem = default(string), string gruntSharedSecretPassword = default(string), string gruntRSAPublicKey = default(string), string gruntNegotiatedSessionKey = default(string), string gruntChallenge = default(string), string cookieAuthKey = default(string))
        {
            Id = id;
            Name = name;
            DotNetFrameworkVersion = dotNetFrameworkVersion;
            ListenerId = listenerId;
            CovenantIPAddress = covenantIPAddress;
            Delay = delay;
            Jitter = jitter;
            ConnectAttempts = connectAttempts;
            LastCheckIn = lastCheckIn;
            Status = status;
            Integrity = integrity;
            Process = process;
            UserDomainName = userDomainName;
            UserName = userName;
            IpAddress = ipAddress;
            OperatingSystem = operatingSystem;
            GruntSharedSecretPassword = gruntSharedSecretPassword;
            GruntRSAPublicKey = gruntRSAPublicKey;
            GruntNegotiatedSessionKey = gruntNegotiatedSessionKey;
            GruntChallenge = gruntChallenge;
            CookieAuthKey = cookieAuthKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Net40', 'Net35', 'NetCore21'
        /// </summary>
        [JsonProperty(PropertyName = "dotNetFrameworkVersion")]
        public DotNetVersion? DotNetFrameworkVersion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "listenerId")]
        public int? ListenerId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "covenantIPAddress")]
        public string CovenantIPAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "delay")]
        public int? Delay { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "jitter")]
        public int? Jitter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "connectAttempts")]
        public int? ConnectAttempts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastCheckIn")]
        public string LastCheckIn { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Uninitialized', 'Stage0',
        /// 'Stage1', 'Stage2', 'Active', 'Lost', 'Killed'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public GruntStatus? Status { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Untrusted', 'Low', 'Medium',
        /// 'High', 'System'
        /// </summary>
        [JsonProperty(PropertyName = "integrity")]
        public IntegrityLevel? Integrity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "process")]
        public string Process { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userDomainName")]
        public string UserDomainName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "operatingSystem")]
        public string OperatingSystem { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gruntSharedSecretPassword")]
        public string GruntSharedSecretPassword { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gruntRSAPublicKey")]
        public string GruntRSAPublicKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gruntNegotiatedSessionKey")]
        public string GruntNegotiatedSessionKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gruntChallenge")]
        public string GruntChallenge { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cookieAuthKey")]
        public string CookieAuthKey { get; set; }

    }
}
