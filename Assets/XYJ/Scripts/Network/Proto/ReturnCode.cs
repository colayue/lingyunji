// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: ClientProto/ReturnCode.proto

using wProtobuf;
using System.Collections;
using System.Collections.Generic;
using wProtobufRPC = wProtobuf.RPC;
using RPCILocalCall = wProtobuf.RPC.ILocalCall;
using RPCIRemoteCall = wProtobuf.RPC.IRemoteCall;

namespace NetProto
{
    public enum ReturnCode
    {
        ReturnCode_OK = 0,
        Material_Error = 1,
        Slider_Error = 2,
        PlayerLevel_Error = 3,
        Pets_Property_Error = 10,
        Pets_Index_Error = 11,
        Pets_FullHoles_Error = 12,
        Pets_PlayerLv_Error = 13,
        Pets_Playing_Error = 14,
        Pets_WashTime_Error = 15,
        Pets_Refinery_Error = 16,
        Pets_LvMax_Error = 17,
        Pets_ItemProperty_Error = 18,
        Pets_LearnSkill_Error = 19,
        Pets_LockSkill_Error = 20,
        Pets_PlayPet_Error = 21,
        Pets_AI_Error = 22,
        Pets_Name_Error = 23,
        Pets_Potential_Error = 24,
        Pets_ItemType_Error = 25,
        Pets_ResetQualification_Error = 26,
        Pets_Savvy_Error = 27,
        Pets_Growth_Error = 28,
        Backage_Full_Error = 40,
        Package_NoItem_Error = 41,
        Package_NotEnoughSpace = 42,
        Package_Decompose_Fail = 43,
        Package_Compound_Fail = 44,
        Package_NotEnoughSpaceToCompound = 45,
        Welfare_SubSignTimes_Error = 60,
        Welfare_Signed_Error = 61,
        Welfare_RwdReceived_Error = 62,
        Welfare_Date_Error = 63,
        Welfare_RwdID_Error = 64,
        Welfare_Lv_Error = 65,
        Welfare_LoginDays_Error = 66,
        Equip_FullEquip_Error = 70,
        Equip_Equiped_Error = 71,
        Equip_ID_Error = 72,
        Equip_PlayerJob_Error = 73,
        Equip_ChangeEnforceVal_MSG = 74,
        Equip_NoneEquip_Error = 75,
        Equip_EnforceVal_Error = 76,
        Equip_Config_Error = 77,
        Equip_Attrs_Error = 78,
        Equip_Times_Error = 79,
        Equip_MaterialID_Error = 80,
        Equip_Index_Error = 81,
        EquipSoul_SubType_Error = 90,
        EquipSoul_ID_Error = 91,
        EquipSoul_Index_Error = 92,
        EquipSoul_InActive_Error = 93,
        EquipSoul_Active_Error = 94,
        EquipSoul_SoulPower_Error = 95,
        EquipSoul_Material_Error = 96,
        EquipSoul_SoulType_Error = 97,
        Level_Unknow = 100,
        Level_NotFind = 101,
        Level_Limit = 102,
        Chat_SendMsgFail = 150,
        Chat_SendMsgFail_Colddown = 152,
        Chat_SendMsgFail_Itemless = 153,
        Chat_SendMsgFail_Channel = 154,
        Chat_SendMsgFail_TextEmpty = 155,
        Chat_SendMsgFail_TextOverStarck = 156,
        Chat_SendMsgFail_User = 157,
        Chat_SendMsgFail_NotFriendship = 158,
        Chat_SendVoiceFail_Drity = 160,
        Chat_SendMsgFail_SaveDB = 159,
        Chat_SendVoiceFail_DurationLess = 162,
        Chat_SendVoiceFail_DutationMore = 163,
        Chat_SendMsgFail_Silver = 164,
        Chat_SendMsgFail_Gold = 165,
        Chat_SendMsgFail_Fairy = 166,
        Chat_SendMsgFail_Jasper = 167,
        Title_Invalid = 201,
        Title_NotGet = 202,
        Title_Equiped = 203,
        Title_TimeOut = 204,
        Demonplot_LvMax = 205,
        Demonplot_Lv_Error = 206,
        Demonplot_Skill_Error = 207,
        Demonplot_Energy_Error = 208,
        Demonplot_SkillProperty_Error = 209,
        Demonplot_Item_Error = 210,
        Demonplot_Durable_Error = 211,
        Trumps_Config_Error = 212,
        Trumps_Create_Error = 213,
        Trumps_EquipPos_Error = 214,
        Trumps_Item_Error = 215,
        Trumps_Lv_Error = 216,
        Trumps_TasteLv_Error = 217,
        Trumps_InfusedLv_Error = 218,
        Trumps_Strengthen_Error = 219,
        Trumps_Skill_Error = 220,
        Ex_UsedTimeError = 300,
        Ex_Currency1Error = 301,
        Ex_Currency2Error = 302,
        Ex_MaterialError = 303,
        Ex_RestError = 304,
        Ex_JobError = 305,
        Ex_LevelError = 306,
        Tr_CurPriceError = 320,
        Tr_BuyItemNumError = 321,
        Tr_BuyItemLimitError = 322,
        Tr_BuyItemError = 323,
        Tr_CurrencyError = 324,
        Tr_SellItemError = 325,
        Tr_SearchError = 326,
        Tr_SellLimit = 327,
        Friend_None = 400,
        Friend_Unknown = 401,
        Friend_Offline = 402,
        Friend_IsSelf = 403,
        Friend_FriendMax = 404,
        Friend_IsBlack = 405,
        Friend_IsExist = 406,
        Friend_IsNotExist = 407,
        Friend_IsCancel = 408,
        Activity_Over_Error = 409,
        Activity_Cannot_Get_Reward = 410,
        Activity_Id_Error = 411,
        Clan_Succeed = 420,
        Clan_IsExist = 421,
        Clan_IsNotExist = 422,
        Clan_IsEmpty = 423,
        Clan_IsOutRange = 424,
        Clan_IsInRespone = 425,
        Clan_MeneyLimit = 426,
        Clan_NameCantUse = 427,
        Clan_DecCanUse = 428,
        Clan_InRespone = 429,
        Clan_InCreate = 430,
        Clan_NameBeUsed = 431,
        Clan_NoPermissed = 432,
        Clan_BuildFullDeque = 433,
        Clan_BuildLevelFull = 434,
        Clan_BuildMainLimit = 435,
        Clan_BuildLevelUpIng = 436,
        Ap_ItemNotExist = 500,
        Ap_ColorFull = 501,
        Ap_OutTime = 502,
        Ap_PresettingFull = 503,
        Task_NotExistError = 550,
        Task_AcceptedError = 551,
        Task_SubmitError = 552,
        Task_GiveupError = 553,
        Skill_ComprehendError = 560,
        Skill_SchemeError = 561,
        Skill_SchemeNumError = 562,
        Skill_SkillError = 563,
    }
    public class ReturnCodeData : IMessage
    {
        public ReturnCode code = ReturnCode.ReturnCode_OK;
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (code != ReturnCode.ReturnCode_OK)
            {
                _total_size_ += 1 + ComputeSize.ComputeEnumSize((int)code);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (code != ReturnCode.ReturnCode_OK)
            {
                output.WriteRawTag(8);
                output.WriteEnum((int)code);
            }
        }
        public void MergeFrom(IReadStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch(tag)
                {
                case 8:
                    {
                        code = (ReturnCode)input.ReadEnum();
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }
}
