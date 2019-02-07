// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Covenant.API.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for GruntTaskingStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GruntTaskingStatus
    {
        [EnumMember(Value = "Uninitialized")]
        Uninitialized,
        [EnumMember(Value = "Tasked")]
        Tasked,
        [EnumMember(Value = "Progressed")]
        Progressed,
        [EnumMember(Value = "Completed")]
        Completed
    }
    internal static class GruntTaskingStatusEnumExtension
    {
        internal static string ToSerializedValue(this GruntTaskingStatus? value)
        {
            return value == null ? null : ((GruntTaskingStatus)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this GruntTaskingStatus value)
        {
            switch( value )
            {
                case GruntTaskingStatus.Uninitialized:
                    return "Uninitialized";
                case GruntTaskingStatus.Tasked:
                    return "Tasked";
                case GruntTaskingStatus.Progressed:
                    return "Progressed";
                case GruntTaskingStatus.Completed:
                    return "Completed";
            }
            return null;
        }

        internal static GruntTaskingStatus? ParseGruntTaskingStatus(this string value)
        {
            switch( value )
            {
                case "Uninitialized":
                    return GruntTaskingStatus.Uninitialized;
                case "Tasked":
                    return GruntTaskingStatus.Tasked;
                case "Progressed":
                    return GruntTaskingStatus.Progressed;
                case "Completed":
                    return GruntTaskingStatus.Completed;
            }
            return null;
        }
    }
}
