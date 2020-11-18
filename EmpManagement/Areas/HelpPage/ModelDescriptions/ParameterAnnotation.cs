using System;

namespace EmpManagement.Areas.HelpPage.ModelDescriptions
{
    /// <summary>
    /// Parameter Annotation
    /// </summary>
    public class ParameterAnnotation
    {
        /// <summary>
        /// Annotation Attribute
        /// </summary>
        public Attribute AnnotationAttribute { get; set; }
        /// <summary>
        /// Documentation
        /// </summary>
        public string Documentation { get; set; }
    }
}