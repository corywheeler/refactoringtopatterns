using System;

namespace EncapsulateClassesWithFactory.MyWork.Descriptors
{
    public class ReferenceDescriptor: AttributeDescriptor
    {

        internal ReferenceDescriptor(string descriptorName, Type mapperType, Type forType)
            : base(descriptorName, mapperType, forType)
        {

        }
    }
}