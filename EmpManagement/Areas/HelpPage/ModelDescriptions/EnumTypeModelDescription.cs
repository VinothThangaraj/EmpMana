using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EmpManagement.Areas.HelpPage.ModelDescriptions
{
    /// <summary>
    /// Enum Type Model Description
    /// </summary>
    public class EnumTypeModelDescription : ModelDescription
    {
        /// <summary>
        /// EnumTypeModelDescription - contructor
        /// </summary>
        public EnumTypeModelDescription()
        {
            Values = new Collection<EnumValueDescription>();
        }
        /// <summary>
        /// Values
        /// </summary>
        public Collection<EnumValueDescription> Values { get; private set; }
    }
}