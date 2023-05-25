﻿using MetadataConverter2.Converters;

namespace MetadataConverter2.MetaTypes
{
    public record Struct : Blocks
    {
        public Struct(MetaType type, byte[] initVector, double version) : base(type, initVector, version) { }

        public override bool Convert(MemoryStream stream)
        {
            return StructConverter.Convert(stream, Version);
        }
    }
}
