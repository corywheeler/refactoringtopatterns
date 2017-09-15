using System;

namespace EncapsulateClassesWithFactory.InitialCode.Descriptors
{
    public class BooleanDescriptor : AttributeDescriptor
    {
        readonly string descriptorName;
        readonly Type mapperType;
        readonly Type forType;

        public BooleanDescriptor(string descriptorName, Type mapperType, Type forType) 
            : base(descriptorName, mapperType, forType)
        {
            this.forType = forType;
            this.mapperType = mapperType;
            this.descriptorName = descriptorName;
        }
    }
}