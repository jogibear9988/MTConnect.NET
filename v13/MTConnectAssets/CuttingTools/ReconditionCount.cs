﻿// Copyright (c) 2016 Feenux LLC, All Rights Reserved.

// This file is subject to the terms and conditions defined in
// file 'LICENSE.txt', which is part of this source code package.

using System.Xml;
using System.Xml.Serialization;

namespace MTConnect.v13.MTConnectAssets.CuttingTools
{
    public class ReconditionCount
    {
        /// <summary>
        /// The maximum number of times this tool may be reconditioned
        /// </summary>
        [XmlAttribute("maximumCount")]
        public int MaximumCount { get; set; }

        /// <summary>
        /// CDATA that represents the number of times the cutter has been reconditioned.
        /// </summary>
        [XmlText]
        public int CDATA { get; set; }
    }
}
