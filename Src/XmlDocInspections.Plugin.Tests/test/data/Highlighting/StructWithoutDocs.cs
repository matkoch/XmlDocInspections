﻿// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local
// ReSharper disable UnusedParameter.Global
// ReSharper disable UnusedType.Global

namespace XmlDocInspections.Sample.Highlighting
{
    public struct PublicStructWithoutDocs
    {
        public string PublicProperty { get; set; }

        internal string InternalProperty { get; set; }

        private string PrivateProperty { get; set; }

        //

        public void PublicMethod(string a)
        {
        }

        internal void InternalMethod()
        {
        }

        private void PrivateMethod()
        {
        }
    }

    internal struct InternalStructWithoutDocs
    {
        public string PublicProperty { get; set; }

        internal string InternalProperty { get; set; }
    }
}
