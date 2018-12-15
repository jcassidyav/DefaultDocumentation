﻿using System.Xml.Linq;
using DefaultDocumentation.Model.Base;

namespace DefaultDocumentation.Model.NonMember
{
    internal sealed class ExampleItem : ATextItem, ITitleDocItem
    {
        public string Title => "Example";

        public ExampleItem(ADocItem parent, XElement element)
            : base(parent, element)
        {
        }
    }
}