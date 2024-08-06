/*
 * Product Service
 *
 * Introducing our revolutionary Product Management Service! Designed to streamline your product inventory and elevate customer experiences, our cutting-edge protobuf service is a game-changer in the world of efficient product management.  With our service, you can effortlessly create new products, allowing you to quickly bring your ideas to life and expand your catalog. Retrieve product information in a snap, providing accurate and personalized details to your customers based on their specific needs and preferences.  Stay ahead of the competition by easily updating product information, ensuring your catalog is always up-to-date and optimized. Seamlessly remove products from your inventory when needed, maintaining a clean and relevant product selection.  Enhance the visual appeal of your products with our advanced media gallery functionalities. Effortlessly add and update captivating images and videos to showcase your products in the best possible light, engaging your customers and driving conversions.  Personalization is key in today's market, and our service enables you to offer unique options to your customers. Easily create and manage lists of customizable options for your products, providing flexibility and tailoring to individual preferences.  Attributes play a vital role in defining products, and our service empowers you to effectively manage them. From bulk attribute creation to listing and retrieving attribute options, our service ensures your product information is rich and comprehensive.  Our service extends its capabilities to entity management, allowing you to effortlessly handle different entities and create customized options lists associated with them. This provides further flexibility and customization options for your product offerings.  When it comes to bulk updates, our service has you covered. Effortlessly update multiple products simultaneously, saving you time and streamlining your operations.  Finding specific products and variants is a breeze with our service. Quickly locate products based on their unique stock keeping unit (SKU) values, ensuring efficient inventory management and smooth order fulfillment.  Experience a new level of efficiency and productivity with our Product Management Service. Unlock the full potential of streamlined product management and empower your business to thrive in today's competitive market. Try our service today and elevate your product management to new heights!
 *
 * The version of the OpenAPI document: v1
 * Contact: info@gemini-commerce.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = product.Client.OpenAPIDateConverter;

namespace product.Model
{
    /// <summary>
    /// Defines productLanguageCode
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProductLanguageCode
    {
        /// <summary>
        /// Enum UNKNOWN for value: LANGUAGE_CODE_UNKNOWN
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_UNKNOWN")]
        UNKNOWN = 1,

        /// <summary>
        /// Enum AA for value: LANGUAGE_CODE_AA
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_AA")]
        AA = 2,

        /// <summary>
        /// Enum AB for value: LANGUAGE_CODE_AB
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_AB")]
        AB = 3,

        /// <summary>
        /// Enum AE for value: LANGUAGE_CODE_AE
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_AE")]
        AE = 4,

        /// <summary>
        /// Enum AF for value: LANGUAGE_CODE_AF
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_AF")]
        AF = 5,

        /// <summary>
        /// Enum AK for value: LANGUAGE_CODE_AK
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_AK")]
        AK = 6,

        /// <summary>
        /// Enum AM for value: LANGUAGE_CODE_AM
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_AM")]
        AM = 7,

        /// <summary>
        /// Enum AN for value: LANGUAGE_CODE_AN
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_AN")]
        AN = 8,

        /// <summary>
        /// Enum AR for value: LANGUAGE_CODE_AR
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_AR")]
        AR = 9,

        /// <summary>
        /// Enum AS for value: LANGUAGE_CODE_AS
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_AS")]
        AS = 10,

        /// <summary>
        /// Enum AV for value: LANGUAGE_CODE_AV
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_AV")]
        AV = 11,

        /// <summary>
        /// Enum AY for value: LANGUAGE_CODE_AY
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_AY")]
        AY = 12,

        /// <summary>
        /// Enum AZ for value: LANGUAGE_CODE_AZ
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_AZ")]
        AZ = 13,

        /// <summary>
        /// Enum BA for value: LANGUAGE_CODE_BA
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_BA")]
        BA = 14,

        /// <summary>
        /// Enum BE for value: LANGUAGE_CODE_BE
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_BE")]
        BE = 15,

        /// <summary>
        /// Enum BG for value: LANGUAGE_CODE_BG
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_BG")]
        BG = 16,

        /// <summary>
        /// Enum BH for value: LANGUAGE_CODE_BH
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_BH")]
        BH = 17,

        /// <summary>
        /// Enum BM for value: LANGUAGE_CODE_BM
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_BM")]
        BM = 18,

        /// <summary>
        /// Enum BI for value: LANGUAGE_CODE_BI
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_BI")]
        BI = 19,

        /// <summary>
        /// Enum BN for value: LANGUAGE_CODE_BN
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_BN")]
        BN = 20,

        /// <summary>
        /// Enum BO for value: LANGUAGE_CODE_BO
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_BO")]
        BO = 21,

        /// <summary>
        /// Enum BR for value: LANGUAGE_CODE_BR
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_BR")]
        BR = 22,

        /// <summary>
        /// Enum BS for value: LANGUAGE_CODE_BS
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_BS")]
        BS = 23,

        /// <summary>
        /// Enum CA for value: LANGUAGE_CODE_CA
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_CA")]
        CA = 24,

        /// <summary>
        /// Enum CE for value: LANGUAGE_CODE_CE
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_CE")]
        CE = 25,

        /// <summary>
        /// Enum CH for value: LANGUAGE_CODE_CH
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_CH")]
        CH = 26,

        /// <summary>
        /// Enum CO for value: LANGUAGE_CODE_CO
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_CO")]
        CO = 27,

        /// <summary>
        /// Enum CR for value: LANGUAGE_CODE_CR
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_CR")]
        CR = 28,

        /// <summary>
        /// Enum CS for value: LANGUAGE_CODE_CS
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_CS")]
        CS = 29,

        /// <summary>
        /// Enum CU for value: LANGUAGE_CODE_CU
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_CU")]
        CU = 30,

        /// <summary>
        /// Enum CV for value: LANGUAGE_CODE_CV
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_CV")]
        CV = 31,

        /// <summary>
        /// Enum CY for value: LANGUAGE_CODE_CY
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_CY")]
        CY = 32,

        /// <summary>
        /// Enum DA for value: LANGUAGE_CODE_DA
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_DA")]
        DA = 33,

        /// <summary>
        /// Enum DE for value: LANGUAGE_CODE_DE
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_DE")]
        DE = 34,

        /// <summary>
        /// Enum DV for value: LANGUAGE_CODE_DV
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_DV")]
        DV = 35,

        /// <summary>
        /// Enum DZ for value: LANGUAGE_CODE_DZ
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_DZ")]
        DZ = 36,

        /// <summary>
        /// Enum EE for value: LANGUAGE_CODE_EE
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_EE")]
        EE = 37,

        /// <summary>
        /// Enum EL for value: LANGUAGE_CODE_EL
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_EL")]
        EL = 38,

        /// <summary>
        /// Enum EN for value: LANGUAGE_CODE_EN
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_EN")]
        EN = 39,

        /// <summary>
        /// Enum EO for value: LANGUAGE_CODE_EO
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_EO")]
        EO = 40,

        /// <summary>
        /// Enum ES for value: LANGUAGE_CODE_ES
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_ES")]
        ES = 41,

        /// <summary>
        /// Enum ET for value: LANGUAGE_CODE_ET
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_ET")]
        ET = 42,

        /// <summary>
        /// Enum EU for value: LANGUAGE_CODE_EU
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_EU")]
        EU = 43,

        /// <summary>
        /// Enum FA for value: LANGUAGE_CODE_FA
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_FA")]
        FA = 44,

        /// <summary>
        /// Enum FF for value: LANGUAGE_CODE_FF
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_FF")]
        FF = 45,

        /// <summary>
        /// Enum FI for value: LANGUAGE_CODE_FI
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_FI")]
        FI = 46,

        /// <summary>
        /// Enum FJ for value: LANGUAGE_CODE_FJ
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_FJ")]
        FJ = 47,

        /// <summary>
        /// Enum FO for value: LANGUAGE_CODE_FO
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_FO")]
        FO = 48,

        /// <summary>
        /// Enum FR for value: LANGUAGE_CODE_FR
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_FR")]
        FR = 49,

        /// <summary>
        /// Enum FY for value: LANGUAGE_CODE_FY
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_FY")]
        FY = 50,

        /// <summary>
        /// Enum GA for value: LANGUAGE_CODE_GA
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_GA")]
        GA = 51,

        /// <summary>
        /// Enum GD for value: LANGUAGE_CODE_GD
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_GD")]
        GD = 52,

        /// <summary>
        /// Enum GL for value: LANGUAGE_CODE_GL
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_GL")]
        GL = 53,

        /// <summary>
        /// Enum GN for value: LANGUAGE_CODE_GN
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_GN")]
        GN = 54,

        /// <summary>
        /// Enum GU for value: LANGUAGE_CODE_GU
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_GU")]
        GU = 55,

        /// <summary>
        /// Enum GV for value: LANGUAGE_CODE_GV
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_GV")]
        GV = 56,

        /// <summary>
        /// Enum HA for value: LANGUAGE_CODE_HA
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_HA")]
        HA = 57,

        /// <summary>
        /// Enum HE for value: LANGUAGE_CODE_HE
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_HE")]
        HE = 58,

        /// <summary>
        /// Enum HI for value: LANGUAGE_CODE_HI
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_HI")]
        HI = 59,

        /// <summary>
        /// Enum HO for value: LANGUAGE_CODE_HO
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_HO")]
        HO = 60,

        /// <summary>
        /// Enum HR for value: LANGUAGE_CODE_HR
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_HR")]
        HR = 61,

        /// <summary>
        /// Enum HT for value: LANGUAGE_CODE_HT
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_HT")]
        HT = 62,

        /// <summary>
        /// Enum HU for value: LANGUAGE_CODE_HU
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_HU")]
        HU = 63,

        /// <summary>
        /// Enum HY for value: LANGUAGE_CODE_HY
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_HY")]
        HY = 64,

        /// <summary>
        /// Enum HZ for value: LANGUAGE_CODE_HZ
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_HZ")]
        HZ = 65,

        /// <summary>
        /// Enum IA for value: LANGUAGE_CODE_IA
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_IA")]
        IA = 66,

        /// <summary>
        /// Enum ID for value: LANGUAGE_CODE_ID
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_ID")]
        ID = 67,

        /// <summary>
        /// Enum IE for value: LANGUAGE_CODE_IE
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_IE")]
        IE = 68,

        /// <summary>
        /// Enum IG for value: LANGUAGE_CODE_IG
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_IG")]
        IG = 69,

        /// <summary>
        /// Enum II for value: LANGUAGE_CODE_II
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_II")]
        II = 70,

        /// <summary>
        /// Enum IK for value: LANGUAGE_CODE_IK
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_IK")]
        IK = 71,

        /// <summary>
        /// Enum IO for value: LANGUAGE_CODE_IO
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_IO")]
        IO = 72,

        /// <summary>
        /// Enum IS for value: LANGUAGE_CODE_IS
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_IS")]
        IS = 73,

        /// <summary>
        /// Enum IT for value: LANGUAGE_CODE_IT
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_IT")]
        IT = 74,

        /// <summary>
        /// Enum IU for value: LANGUAGE_CODE_IU
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_IU")]
        IU = 75,

        /// <summary>
        /// Enum JA for value: LANGUAGE_CODE_JA
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_JA")]
        JA = 76,

        /// <summary>
        /// Enum JV for value: LANGUAGE_CODE_JV
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_JV")]
        JV = 77,

        /// <summary>
        /// Enum KA for value: LANGUAGE_CODE_KA
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_KA")]
        KA = 78,

        /// <summary>
        /// Enum KG for value: LANGUAGE_CODE_KG
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_KG")]
        KG = 79,

        /// <summary>
        /// Enum KI for value: LANGUAGE_CODE_KI
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_KI")]
        KI = 80,

        /// <summary>
        /// Enum KJ for value: LANGUAGE_CODE_KJ
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_KJ")]
        KJ = 81,

        /// <summary>
        /// Enum KK for value: LANGUAGE_CODE_KK
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_KK")]
        KK = 82,

        /// <summary>
        /// Enum KL for value: LANGUAGE_CODE_KL
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_KL")]
        KL = 83,

        /// <summary>
        /// Enum KM for value: LANGUAGE_CODE_KM
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_KM")]
        KM = 84,

        /// <summary>
        /// Enum KN for value: LANGUAGE_CODE_KN
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_KN")]
        KN = 85,

        /// <summary>
        /// Enum KO for value: LANGUAGE_CODE_KO
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_KO")]
        KO = 86,

        /// <summary>
        /// Enum KR for value: LANGUAGE_CODE_KR
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_KR")]
        KR = 87,

        /// <summary>
        /// Enum KS for value: LANGUAGE_CODE_KS
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_KS")]
        KS = 88,

        /// <summary>
        /// Enum KU for value: LANGUAGE_CODE_KU
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_KU")]
        KU = 89,

        /// <summary>
        /// Enum KV for value: LANGUAGE_CODE_KV
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_KV")]
        KV = 90,

        /// <summary>
        /// Enum KW for value: LANGUAGE_CODE_KW
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_KW")]
        KW = 91,

        /// <summary>
        /// Enum KY for value: LANGUAGE_CODE_KY
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_KY")]
        KY = 92,

        /// <summary>
        /// Enum LA for value: LANGUAGE_CODE_LA
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_LA")]
        LA = 93,

        /// <summary>
        /// Enum LB for value: LANGUAGE_CODE_LB
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_LB")]
        LB = 94,

        /// <summary>
        /// Enum LG for value: LANGUAGE_CODE_LG
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_LG")]
        LG = 95,

        /// <summary>
        /// Enum LI for value: LANGUAGE_CODE_LI
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_LI")]
        LI = 96,

        /// <summary>
        /// Enum LN for value: LANGUAGE_CODE_LN
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_LN")]
        LN = 97,

        /// <summary>
        /// Enum LO for value: LANGUAGE_CODE_LO
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_LO")]
        LO = 98,

        /// <summary>
        /// Enum LT for value: LANGUAGE_CODE_LT
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_LT")]
        LT = 99,

        /// <summary>
        /// Enum LU for value: LANGUAGE_CODE_LU
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_LU")]
        LU = 100,

        /// <summary>
        /// Enum LV for value: LANGUAGE_CODE_LV
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_LV")]
        LV = 101,

        /// <summary>
        /// Enum MG for value: LANGUAGE_CODE_MG
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_MG")]
        MG = 102,

        /// <summary>
        /// Enum MH for value: LANGUAGE_CODE_MH
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_MH")]
        MH = 103,

        /// <summary>
        /// Enum MI for value: LANGUAGE_CODE_MI
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_MI")]
        MI = 104,

        /// <summary>
        /// Enum MK for value: LANGUAGE_CODE_MK
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_MK")]
        MK = 105,

        /// <summary>
        /// Enum ML for value: LANGUAGE_CODE_ML
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_ML")]
        ML = 106,

        /// <summary>
        /// Enum MN for value: LANGUAGE_CODE_MN
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_MN")]
        MN = 107,

        /// <summary>
        /// Enum MR for value: LANGUAGE_CODE_MR
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_MR")]
        MR = 108,

        /// <summary>
        /// Enum MS for value: LANGUAGE_CODE_MS
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_MS")]
        MS = 109,

        /// <summary>
        /// Enum MT for value: LANGUAGE_CODE_MT
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_MT")]
        MT = 110,

        /// <summary>
        /// Enum MY for value: LANGUAGE_CODE_MY
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_MY")]
        MY = 111,

        /// <summary>
        /// Enum NA for value: LANGUAGE_CODE_NA
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_NA")]
        NA = 112,

        /// <summary>
        /// Enum NB for value: LANGUAGE_CODE_NB
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_NB")]
        NB = 113,

        /// <summary>
        /// Enum ND for value: LANGUAGE_CODE_ND
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_ND")]
        ND = 114,

        /// <summary>
        /// Enum NE for value: LANGUAGE_CODE_NE
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_NE")]
        NE = 115,

        /// <summary>
        /// Enum NG for value: LANGUAGE_CODE_NG
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_NG")]
        NG = 116,

        /// <summary>
        /// Enum NL for value: LANGUAGE_CODE_NL
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_NL")]
        NL = 117,

        /// <summary>
        /// Enum NN for value: LANGUAGE_CODE_NN
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_NN")]
        NN = 118,

        /// <summary>
        /// Enum NO for value: LANGUAGE_CODE_NO
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_NO")]
        NO = 119,

        /// <summary>
        /// Enum NR for value: LANGUAGE_CODE_NR
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_NR")]
        NR = 120,

        /// <summary>
        /// Enum NV for value: LANGUAGE_CODE_NV
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_NV")]
        NV = 121,

        /// <summary>
        /// Enum NY for value: LANGUAGE_CODE_NY
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_NY")]
        NY = 122,

        /// <summary>
        /// Enum OC for value: LANGUAGE_CODE_OC
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_OC")]
        OC = 123,

        /// <summary>
        /// Enum OJ for value: LANGUAGE_CODE_OJ
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_OJ")]
        OJ = 124,

        /// <summary>
        /// Enum OM for value: LANGUAGE_CODE_OM
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_OM")]
        OM = 125,

        /// <summary>
        /// Enum OR for value: LANGUAGE_CODE_OR
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_OR")]
        OR = 126,

        /// <summary>
        /// Enum OS for value: LANGUAGE_CODE_OS
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_OS")]
        OS = 127,

        /// <summary>
        /// Enum PA for value: LANGUAGE_CODE_PA
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_PA")]
        PA = 128,

        /// <summary>
        /// Enum PI for value: LANGUAGE_CODE_PI
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_PI")]
        PI = 129,

        /// <summary>
        /// Enum PL for value: LANGUAGE_CODE_PL
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_PL")]
        PL = 130,

        /// <summary>
        /// Enum PS for value: LANGUAGE_CODE_PS
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_PS")]
        PS = 131,

        /// <summary>
        /// Enum PT for value: LANGUAGE_CODE_PT
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_PT")]
        PT = 132,

        /// <summary>
        /// Enum QU for value: LANGUAGE_CODE_QU
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_QU")]
        QU = 133,

        /// <summary>
        /// Enum RM for value: LANGUAGE_CODE_RM
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_RM")]
        RM = 134,

        /// <summary>
        /// Enum RN for value: LANGUAGE_CODE_RN
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_RN")]
        RN = 135,

        /// <summary>
        /// Enum RO for value: LANGUAGE_CODE_RO
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_RO")]
        RO = 136,

        /// <summary>
        /// Enum RU for value: LANGUAGE_CODE_RU
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_RU")]
        RU = 137,

        /// <summary>
        /// Enum RW for value: LANGUAGE_CODE_RW
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_RW")]
        RW = 138,

        /// <summary>
        /// Enum SA for value: LANGUAGE_CODE_SA
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_SA")]
        SA = 139,

        /// <summary>
        /// Enum SC for value: LANGUAGE_CODE_SC
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_SC")]
        SC = 140,

        /// <summary>
        /// Enum SD for value: LANGUAGE_CODE_SD
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_SD")]
        SD = 141,

        /// <summary>
        /// Enum SE for value: LANGUAGE_CODE_SE
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_SE")]
        SE = 142,

        /// <summary>
        /// Enum SG for value: LANGUAGE_CODE_SG
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_SG")]
        SG = 143,

        /// <summary>
        /// Enum SI for value: LANGUAGE_CODE_SI
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_SI")]
        SI = 144,

        /// <summary>
        /// Enum SK for value: LANGUAGE_CODE_SK
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_SK")]
        SK = 145,

        /// <summary>
        /// Enum SL for value: LANGUAGE_CODE_SL
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_SL")]
        SL = 146,

        /// <summary>
        /// Enum SM for value: LANGUAGE_CODE_SM
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_SM")]
        SM = 147,

        /// <summary>
        /// Enum SN for value: LANGUAGE_CODE_SN
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_SN")]
        SN = 148,

        /// <summary>
        /// Enum SO for value: LANGUAGE_CODE_SO
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_SO")]
        SO = 149,

        /// <summary>
        /// Enum SQ for value: LANGUAGE_CODE_SQ
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_SQ")]
        SQ = 150,

        /// <summary>
        /// Enum SR for value: LANGUAGE_CODE_SR
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_SR")]
        SR = 151,

        /// <summary>
        /// Enum SS for value: LANGUAGE_CODE_SS
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_SS")]
        SS = 152,

        /// <summary>
        /// Enum ST for value: LANGUAGE_CODE_ST
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_ST")]
        ST = 153,

        /// <summary>
        /// Enum SU for value: LANGUAGE_CODE_SU
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_SU")]
        SU = 154,

        /// <summary>
        /// Enum SV for value: LANGUAGE_CODE_SV
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_SV")]
        SV = 155,

        /// <summary>
        /// Enum SW for value: LANGUAGE_CODE_SW
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_SW")]
        SW = 156,

        /// <summary>
        /// Enum TA for value: LANGUAGE_CODE_TA
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_TA")]
        TA = 157,

        /// <summary>
        /// Enum TE for value: LANGUAGE_CODE_TE
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_TE")]
        TE = 158,

        /// <summary>
        /// Enum TG for value: LANGUAGE_CODE_TG
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_TG")]
        TG = 159,

        /// <summary>
        /// Enum TH for value: LANGUAGE_CODE_TH
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_TH")]
        TH = 160,

        /// <summary>
        /// Enum TI for value: LANGUAGE_CODE_TI
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_TI")]
        TI = 161,

        /// <summary>
        /// Enum TK for value: LANGUAGE_CODE_TK
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_TK")]
        TK = 162,

        /// <summary>
        /// Enum TL for value: LANGUAGE_CODE_TL
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_TL")]
        TL = 163,

        /// <summary>
        /// Enum TN for value: LANGUAGE_CODE_TN
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_TN")]
        TN = 164,

        /// <summary>
        /// Enum TO for value: LANGUAGE_CODE_TO
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_TO")]
        TO = 165,

        /// <summary>
        /// Enum TR for value: LANGUAGE_CODE_TR
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_TR")]
        TR = 166,

        /// <summary>
        /// Enum TS for value: LANGUAGE_CODE_TS
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_TS")]
        TS = 167,

        /// <summary>
        /// Enum TT for value: LANGUAGE_CODE_TT
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_TT")]
        TT = 168,

        /// <summary>
        /// Enum TW for value: LANGUAGE_CODE_TW
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_TW")]
        TW = 169,

        /// <summary>
        /// Enum TY for value: LANGUAGE_CODE_TY
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_TY")]
        TY = 170,

        /// <summary>
        /// Enum UG for value: LANGUAGE_CODE_UG
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_UG")]
        UG = 171,

        /// <summary>
        /// Enum UK for value: LANGUAGE_CODE_UK
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_UK")]
        UK = 172,

        /// <summary>
        /// Enum UR for value: LANGUAGE_CODE_UR
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_UR")]
        UR = 173,

        /// <summary>
        /// Enum UZ for value: LANGUAGE_CODE_UZ
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_UZ")]
        UZ = 174,

        /// <summary>
        /// Enum VE for value: LANGUAGE_CODE_VE
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_VE")]
        VE = 175,

        /// <summary>
        /// Enum VI for value: LANGUAGE_CODE_VI
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_VI")]
        VI = 176,

        /// <summary>
        /// Enum VO for value: LANGUAGE_CODE_VO
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_VO")]
        VO = 177,

        /// <summary>
        /// Enum WA for value: LANGUAGE_CODE_WA
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_WA")]
        WA = 178,

        /// <summary>
        /// Enum WO for value: LANGUAGE_CODE_WO
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_WO")]
        WO = 179,

        /// <summary>
        /// Enum XH for value: LANGUAGE_CODE_XH
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_XH")]
        XH = 180,

        /// <summary>
        /// Enum YI for value: LANGUAGE_CODE_YI
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_YI")]
        YI = 181,

        /// <summary>
        /// Enum YO for value: LANGUAGE_CODE_YO
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_YO")]
        YO = 182,

        /// <summary>
        /// Enum ZA for value: LANGUAGE_CODE_ZA
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_ZA")]
        ZA = 183,

        /// <summary>
        /// Enum ZH for value: LANGUAGE_CODE_ZH
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_ZH")]
        ZH = 184,

        /// <summary>
        /// Enum ZU for value: LANGUAGE_CODE_ZU
        /// </summary>
        [EnumMember(Value = "LANGUAGE_CODE_ZU")]
        ZU = 185
    }

}
