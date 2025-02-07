﻿internal static class Consts
{
    public const string PlatformNotSupportedDescription = "This member is not supported for current platform";

    public const string Product = "NETStandard.WindowsCE";
    public const string Description = "This library includes most of the APIs from the NETStandard specification built on top of Windows CE platform.";
    public const string AssemblyVersion = "1.0.0.0";
    public const string FileVersion = "1.7.0.0";
    public const string ProductVersion = "1.7.0";
    public const string Copyright = "© Fabrício Godoy. All rights reserved.";
    public const string Company = "Fabrício Godoy";

#if NET35_CF
    public const string TargetFramework = ".NETFramework,Version=v3.5,Profile=CompactFramework";
#else
    public const string TargetFramework = ".NETFramework,Version=v3.5";
#endif

#if DEBUG
    public const string Configuration = "Debug";
#else
    public const string Configuration = "Release";
#endif

    public const string SkarllotPublicKey =
        "00240000048000001402000006020000002400005253413100100000010001002d0" +
        "bf3a319ee3ac3bf1e2ab86e68a579d2664e25f90dde08805439e8f2d059d59dc18b" +
        "27edac451faa883c9fbbaf9fadae327d39a5a6c5e2935c9ebe937de28ba4be8c67a" +
        "56195deff13194835558e5d47a735415837cbaed2b68cc67f1842a30802f29f315d" +
        "e5e202123998b172e71970929e38bab7bac164fec07e7a3c55edbc8046d7a347856" +
        "47af0b191a39c324f7d7cc6867e27235ce3817cf4ad24bfd79db2eb7e4536be4f73" +
        "560261b274cc4fd50e7dcd19c6b82e8b0108ae72335e47242953935015bd883735a" +
        "94dbf730027a35e095442703e32db7f233f47933ac3c4674b7d8193059f9ee4044b" +
        "1d91d0a0158cd992e71598bd19b04cedc0adf78f2c46b6b3c3eaf5c7b23cad2785b" +
        "3fa7fa36a39a6408a9af9e834bb308f56c448ef57ee50d58da001ce9914c74201dc" +
        "42331ae1c4257aeaf6ed91efca0578f9e62a9566d3f96341c2fc6bd13628ecc2835" +
        "4f7b35182dfb7b3305e69984122c676e8febeb80ae29a0728b4cb959f4540f46fb1" +
        "b9fca6bb1dae93d2d800f14ea357a953deb16df3f058d335163c5328667a291640d" +
        "4361df02a405eb94f8eee45513660a4063f7a9b3dd3899753f10cdb10c2a337999a" +
        "9ac82d634437958694391ef159ee19588846c5dafdd9669d337f8394ee1aa0042e9" +
        "d6baae88d279ecb2e9007d4e078c2b8763cea6ec8a47030eb2cf4db12462071d854" +
        "2d1c51e2256543e4";

    public static System.Type GetTypeInfo(this System.Type type)
        => type;
}
