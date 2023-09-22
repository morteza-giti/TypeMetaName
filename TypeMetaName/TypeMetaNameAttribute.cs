namespace TypeMetaName
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]

    public class TypeMetaNameAttribute:Attribute
    {
        public string TypeName { get; }
        public TypeMetaNameAttribute(string typeName)
        {
            TypeName = typeName;
        }
    }
}