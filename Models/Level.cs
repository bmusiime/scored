using System.ComponentModel;

namespace Scored.Models
{
    public enum Level
    {
        [Description("Unknown")] Unknown = 0, 
        [Description("None")] None=1, 
        [Description("Beginner")] Beginner=2, 
        [Description("Intermediate")] Intermediate=3, 
        [Description("Advanced")] Advanced=4
    }
}