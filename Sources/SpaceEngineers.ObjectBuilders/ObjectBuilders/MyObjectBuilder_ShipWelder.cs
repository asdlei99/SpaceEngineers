﻿using ProtoBuf;
using System.ComponentModel;
using VRage.ObjectBuilders;

namespace Sandbox.Common.ObjectBuilders
{
    [ProtoContract]
    [MyObjectBuilderDefinition]
    [System.Xml.Serialization.XmlSerializerAssembly("SpaceEngineers.ObjectBuilders.XmlSerializers")]
    public class MyObjectBuilder_ShipWelder : MyObjectBuilder_ShipToolBase
    {
        [ProtoMember, DefaultValue(false)]
        public bool HelpOthers = false;
    }
}
