namespace PolymorphicCreationWithFactoryMethod.MyWork
{
    public class XMLBuilderTest: AbstractBuilderTest
    {
        protected override OutputBuilder CreateBuilder(string rootName)
        {
            return new XMLBuilder(rootName);
        }
    }
}