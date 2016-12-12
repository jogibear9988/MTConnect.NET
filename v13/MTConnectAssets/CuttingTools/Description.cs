﻿// Copyright (c) 2016 Feenux LLC, All Rights Reserved.

// This file is subject to the terms and conditions defined in
// file 'LICENSE.txt', which is part of this source code package.

using System.Xml;
using System.Xml.Serialization;

namespace MTConnect.v13.MTConnectAssets.CuttingTools
{
    /// <summary>
    /// The description MAY contain mixed content, meaning that an additional XML element or plain text may be provided as part of the content of the description tag. Currently the description contains no additional attributes.
    /// </summary>
    public class Description
    {
        [XmlText]
        public string CDATA { get; set; }
    }
}
