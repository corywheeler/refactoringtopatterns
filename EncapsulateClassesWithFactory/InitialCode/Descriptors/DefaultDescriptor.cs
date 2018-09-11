using System;

namespace EncapsulateClassesWithFactory.InitialCode.Descriptors
{
    public class DefaultDescriptor : AttributeDescriptor
    {

        public DefaultDescriptor(string descriptorName, Type mapperType, Type forType)
            : base(descriptorName, mapperType, forType)
        {
        }
    }
}