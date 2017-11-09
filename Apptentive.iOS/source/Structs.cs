using System;
using ObjCRuntime;

namespace ApptentiveSDK.iOS
{
    [Native]
    public enum ApptentiveAuthenticationFailureReason : ulong
    {
        Unknown,
        InvalidAlgorithm,
        MalformedToken,
        InvalidToken,
        MissingSubClaim,
        MismatchedSubClaim,
        InvalidSubClaim,
        ExpiredToken,
        RevokedToken,
        MissingAppKey,
        MissingAppSignature,
        InvalidKeySignaturePair
    }

    [Native]
    public enum ApptentivePushProvider : ulong
    {
        Apptentive,
        UrbanAirship,
        AmazonSNS,
        Parse
    }

    [Native]
    public enum ApptentiveLogLevel : ulong
    {
        Crit = 0,
        Error = 1,
        Warn = 2,
        Info = 3,
        Debug = 4,
        Verbose = 5
    }
}
