using System;

namespace EncapsulateClassesWithFactory.InitialCode.Descriptors
{
    public class BooleanDescriptor : AttributeDescriptor
    {

        public BooleanDescriptor(string descriptorName, Type mapperType, Type forType) 
            : base(descriptorName, mapperType, forType)
        {
        }
    }
}