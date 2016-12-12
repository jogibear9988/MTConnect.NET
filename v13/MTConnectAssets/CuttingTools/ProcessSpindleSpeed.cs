﻿// Copyright (c) 2016 Feenux LLC, All Rights Reserved.

// This file is subject to the terms and conditions defined in
// file 'LICENSE.txt', which is part of this source code package.

using System.Xml;
using System.Xml.Serialization;

namespace MTConnect.v13.MTConnectAssets.CuttingTools
{
    public class ProcessSpindleSpeed
    {
        /// <summary>
        /// The upper bound for the tool’s target spindle speed
        /// </summary>
        [XmlAttribute("maximum")]
        public int Maximum { get; set; }

        /// <summary>
        /// The lower bound for the tools spindle speed.
        /// </summary>
        [XmlAttribute("minimum")]
        public int Minimum { get; set; }

        /// <summary>
        /// The nominal speed the tool is designed to operate at.
        /// </summary>
        [XmlText]
        [XmlAttribute("nominal")]
        public int Nominal { get; set; }
    }
}
