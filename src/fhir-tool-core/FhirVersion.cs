﻿using Hl7.Fhir.Utility;

namespace FhirTool.Core
{
    public enum FhirVersion
    {
        [EnumLiteral("")]
        None = 0,
        [EnumLiteral(FhirConstants.VERSION_R2)]
        R2 = 2,
        [EnumLiteral(FhirConstants.VERSION_R3)]
        R3 = 3,
        [EnumLiteral(FhirConstants.VERSION_R4)]
        R4 = 4,
        [EnumLiteral(FhirConstants.VERSION_R5)]
        R5 = 5,
    }
}