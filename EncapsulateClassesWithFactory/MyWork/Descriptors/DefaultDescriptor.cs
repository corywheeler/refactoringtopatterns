using System;

namespace EncapsulateClassesWithFactory.MyWork.Descriptors
{
    public class DefaultDescriptor : AttributeDescriptor
    {

        internal DefaultDescriptor(string descriptorName, Type mapperType, Type forType)
            : base(descriptorName, mapperType, forType)
        {
        }
    }
}