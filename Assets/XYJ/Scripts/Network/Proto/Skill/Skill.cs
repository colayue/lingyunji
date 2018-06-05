// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: ClientProto/Skill/Skill.proto

using wProtobuf;
using System.Collections;
using System.Collections.Generic;
using wProtobufRPC = wProtobuf.RPC;
using RPCILocalCall = wProtobuf.RPC.ILocalCall;
using RPCIRemoteCall = wProtobuf.RPC.IRemoteCall;

namespace NetProto
{
    public enum SkillSchemeType
    {
        SST_Default = 0,
        SST_PVE = 1,
        SST_PVP = 2,
        SST_Custom_A = 3,
        SST_Custom_B = 4,
        SST_All = 5,
    }
    public class SkillSchemeDBData : IMessage
    {
        public class AllSchemeEntry : IMessage
        {
            public int key = 0;
            public SkillSchemeData value = new SkillSchemeData();
            public int CalculateSize()
            {
                int _total_size_ = 0;
                if (key != 0)
                {
                    _total_size_ += 1 + ComputeSize.ComputeInt32Size(key);
                }
                if (value != null)
                {
                    _total_size_ += 1 + ComputeSize.ComputeMessageSize(value);
                }
                return _total_size_;
            }
            public void WriteTo(IWriteStream output)
            {
                if (key != 0)
                {
                    output.WriteRawTag(8);
                    output.WriteInt32(key);
                }
                if (value != null)
                {
                    output.WriteRawTag(18);
                    output.WriteMessage(value);
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
                            key = input.ReadInt32();
                        }
                        break;
                    case 18:
                        {
                            if (value == null)
                                value = new SkillSchemeData();
                            input.ReadMessage(value);
                        }
                        break;
                    default:
                        input.SkipLastField(tag);
                        break;
                    }
                }
            }
        }
        public class AllSkillsEntry : IMessage
        {
            public int key = 0;
            public int value = 0;
            public int CalculateSize()
            {
                int _total_size_ = 0;
                if (key != 0)
                {
                    _total_size_ += 1 + ComputeSize.ComputeInt32Size(key);
                }
                if (value != 0)
                {
                    _total_size_ += 1 + ComputeSize.ComputeInt32Size(value);
                }
                return _total_size_;
            }
            public void WriteTo(IWriteStream output)
            {
                if (key != 0)
                {
                    output.WriteRawTag(8);
                    output.WriteInt32(key);
                }
                if (value != 0)
                {
                    output.WriteRawTag(16);
                    output.WriteInt32(value);
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
                            key = input.ReadInt32();
                        }
                        break;
                    case 16:
                        {
                            value = input.ReadInt32();
                        }
                        break;
                    default:
                        input.SkipLastField(tag);
                        break;
                    }
                }
            }
        }
        public int curSchemeId = 0;
        public Dictionary<int , SkillSchemeData> allScheme = new Dictionary<int , SkillSchemeData>();
        public Dictionary<int , int> allSkills = new Dictionary<int , int>();
        public List<int> comprehendItems = new List<int>();
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (curSchemeId != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(curSchemeId);
            }
            if (allScheme != null && allScheme.Count != 0)
            {
                var entry = new AllSchemeEntry();
                foreach (var itor in allScheme)
                {
                    _total_size_ += 1;
                    entry.key = itor.Key;
                    entry.value = itor.Value;
                    _total_size_ += ComputeSize.ComputeMessageSize(entry);
                }
            }
            if (allSkills != null && allSkills.Count != 0)
            {
                var entry = new AllSkillsEntry();
                foreach (var itor in allSkills)
                {
                    _total_size_ += 1;
                    entry.key = itor.Key;
                    entry.value = itor.Value;
                    _total_size_ += ComputeSize.ComputeMessageSize(entry);
                }
            }
            if (comprehendItems != null && comprehendItems.Count != 0)
            {
                _total_size_ += 1;
                int local_pack_size = 0;
                for (int i = 0; i < comprehendItems.Count; ++i)
                    local_pack_size += ComputeSize.ComputeInt32Size(comprehendItems[i]);
                _total_size_ += local_pack_size + ComputeSize.ComputeInt32Size(local_pack_size);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (curSchemeId != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(curSchemeId);
            }
            if (allScheme != null && allScheme.Count != 0)
            {
                var entry = new AllSchemeEntry();
                foreach (var itor in allScheme)
                {
                    entry.key = itor.Key;
                    entry.value = itor.Value;
                    output.WriteRawTag(18);
                    output.WriteMessage(entry);
                }
            }
            if (allSkills != null && allSkills.Count != 0)
            {
                var entry = new AllSkillsEntry();
                foreach (var itor in allSkills)
                {
                    entry.key = itor.Key;
                    entry.value = itor.Value;
                    output.WriteRawTag(26);
                    output.WriteMessage(entry);
                }
            }
            if (comprehendItems != null && comprehendItems.Count != 0)
            {
                output.WriteRawTag(34);
                int _total_pack_size_ = 0;
                for (int i = 0; i < comprehendItems.Count; ++i)
                    _total_pack_size_ += ComputeSize.ComputeInt32Size(comprehendItems[i]);
                output.WriteInt32(_total_pack_size_);
                for (int i = 0; i < comprehendItems.Count; ++i)
                {
                    output.WriteInt32(comprehendItems[i]);
                }
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
                        curSchemeId = input.ReadInt32();
                    }
                    break;
                case 18:
                    {
                        if (allScheme == null)
                            allScheme = new Dictionary<int, SkillSchemeData>();
                        var entry = new AllSchemeEntry();
                        input.ReadMessage(entry);
                        allScheme[entry.key] = entry.value;
                    }
                    break;
                case 26:
                    {
                        if (allSkills == null)
                            allSkills = new Dictionary<int, int>();
                        var entry = new AllSkillsEntry();
                        input.ReadMessage(entry);
                        allSkills[entry.key] = entry.value;
                    }
                    break;
                case 34:
                    {
                        if (comprehendItems == null)
                            comprehendItems = new List<int>();
                        input.ReadMessage(() => { comprehendItems.Add(input.ReadInt32()); });
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class SkillSchemeName : IMessage
    {
        public int schemeId = 0;
        public string skillSchemeName = null;
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (schemeId != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(schemeId);
            }
            if (!string.IsNullOrEmpty(skillSchemeName))
            {
                _total_size_ += 1 + ComputeSize.ComputeStringSize(skillSchemeName);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (schemeId != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(schemeId);
            }
            if (!string.IsNullOrEmpty(skillSchemeName))
            {
                output.WriteRawTag(18);
                output.WriteString(skillSchemeName);
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
                        schemeId = input.ReadInt32();
                    }
                    break;
                case 18:
                    {
                        skillSchemeName = input.ReadString();
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class SkillSchemeData : IMessage
    {
        public class SkillsEntry : IMessage
        {
            public int key = 0;
            public int value = 0;
            public int CalculateSize()
            {
                int _total_size_ = 0;
                if (key != 0)
                {
                    _total_size_ += 1 + ComputeSize.ComputeInt32Size(key);
                }
                if (value != 0)
                {
                    _total_size_ += 1 + ComputeSize.ComputeInt32Size(value);
                }
                return _total_size_;
            }
            public void WriteTo(IWriteStream output)
            {
                if (key != 0)
                {
                    output.WriteRawTag(8);
                    output.WriteInt32(key);
                }
                if (value != 0)
                {
                    output.WriteRawTag(16);
                    output.WriteInt32(value);
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
                            key = input.ReadInt32();
                        }
                        break;
                    case 16:
                        {
                            value = input.ReadInt32();
                        }
                        break;
                    default:
                        input.SkipLastField(tag);
                        break;
                    }
                }
            }
        }
        public int schemeId = 0;
        public string skillSchemeName = null;
        public Dictionary<int , int> skills = new Dictionary<int , int>();
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (schemeId != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(schemeId);
            }
            if (!string.IsNullOrEmpty(skillSchemeName))
            {
                _total_size_ += 1 + ComputeSize.ComputeStringSize(skillSchemeName);
            }
            if (skills != null && skills.Count != 0)
            {
                var entry = new SkillsEntry();
                foreach (var itor in skills)
                {
                    _total_size_ += 1;
                    entry.key = itor.Key;
                    entry.value = itor.Value;
                    _total_size_ += ComputeSize.ComputeMessageSize(entry);
                }
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (schemeId != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(schemeId);
            }
            if (!string.IsNullOrEmpty(skillSchemeName))
            {
                output.WriteRawTag(18);
                output.WriteString(skillSchemeName);
            }
            if (skills != null && skills.Count != 0)
            {
                var entry = new SkillsEntry();
                foreach (var itor in skills)
                {
                    entry.key = itor.Key;
                    entry.value = itor.Value;
                    output.WriteRawTag(26);
                    output.WriteMessage(entry);
                }
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
                        schemeId = input.ReadInt32();
                    }
                    break;
                case 18:
                    {
                        skillSchemeName = input.ReadString();
                    }
                    break;
                case 26:
                    {
                        if (skills == null)
                            skills = new Dictionary<int, int>();
                        var entry = new SkillsEntry();
                        input.ReadMessage(entry);
                        skills[entry.key] = entry.value;
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class SkillScheme : IMessage
    {
        public ReturnCode code = ReturnCode.ReturnCode_OK;
        public SkillSchemeData skillScheme = new SkillSchemeData();
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (code != ReturnCode.ReturnCode_OK)
            {
                _total_size_ += 1 + ComputeSize.ComputeEnumSize((int)code);
            }
            if (skillScheme != null)
            {
                _total_size_ += 1 + ComputeSize.ComputeMessageSize(skillScheme);
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
            if (skillScheme != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(skillScheme);
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
                case 18:
                    {
                        if (skillScheme == null)
                            skillScheme = new SkillSchemeData();
                        input.ReadMessage(skillScheme);
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class SkillComprehend : IMessage
    {
        public class SkillsEntry : IMessage
        {
            public int key = 0;
            public int value = 0;
            public int CalculateSize()
            {
                int _total_size_ = 0;
                if (key != 0)
                {
                    _total_size_ += 1 + ComputeSize.ComputeInt32Size(key);
                }
                if (value != 0)
                {
                    _total_size_ += 1 + ComputeSize.ComputeInt32Size(value);
                }
                return _total_size_;
            }
            public void WriteTo(IWriteStream output)
            {
                if (key != 0)
                {
                    output.WriteRawTag(8);
                    output.WriteInt32(key);
                }
                if (value != 0)
                {
                    output.WriteRawTag(16);
                    output.WriteInt32(value);
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
                            key = input.ReadInt32();
                        }
                        break;
                    case 16:
                        {
                            value = input.ReadInt32();
                        }
                        break;
                    default:
                        input.SkipLastField(tag);
                        break;
                    }
                }
            }
        }
        public ReturnCode code = ReturnCode.ReturnCode_OK;
        public int itemId = 0;
        public Dictionary<int , int> skills = new Dictionary<int , int>();
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (code != ReturnCode.ReturnCode_OK)
            {
                _total_size_ += 1 + ComputeSize.ComputeEnumSize((int)code);
            }
            if (itemId != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(itemId);
            }
            if (skills != null && skills.Count != 0)
            {
                var entry = new SkillsEntry();
                foreach (var itor in skills)
                {
                    _total_size_ += 1;
                    entry.key = itor.Key;
                    entry.value = itor.Value;
                    _total_size_ += ComputeSize.ComputeMessageSize(entry);
                }
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
            if (itemId != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(itemId);
            }
            if (skills != null && skills.Count != 0)
            {
                var entry = new SkillsEntry();
                foreach (var itor in skills)
                {
                    entry.key = itor.Key;
                    entry.value = itor.Value;
                    output.WriteRawTag(26);
                    output.WriteMessage(entry);
                }
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
                case 16:
                    {
                        itemId = input.ReadInt32();
                    }
                    break;
                case 26:
                    {
                        if (skills == null)
                            skills = new Dictionary<int, int>();
                        var entry = new SkillsEntry();
                        input.ReadMessage(entry);
                        skills[entry.key] = entry.value;
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class SkillSchemeSave : IMessage
    {
        public ReturnCode code = ReturnCode.ReturnCode_OK;
        public int schemeId = 0;
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (code != ReturnCode.ReturnCode_OK)
            {
                _total_size_ += 1 + ComputeSize.ComputeEnumSize((int)code);
            }
            if (schemeId != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(schemeId);
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
            if (schemeId != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(schemeId);
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
                case 16:
                    {
                        schemeId = input.ReadInt32();
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class SkillSave : IMessage
    {
        public int skillPointId = 0;
        public int skillId = 0;
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (skillPointId != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(skillPointId);
            }
            if (skillId != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(skillId);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (skillPointId != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(skillPointId);
            }
            if (skillId != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(skillId);
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
                        skillPointId = input.ReadInt32();
                    }
                    break;
                case 16:
                    {
                        skillId = input.ReadInt32();
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }
    public class C2ASkillModuleRequest
    {
        public C2ASkillModuleRequest(RPCILocalCall l)
        {
            local = l;
        }
        RPCILocalCall local;
        public void SaveSkill(SkillSave input, System.Action<wProtobuf.RPC.Error, ReturnCodeData> onEnd)
        {
            local.Call("C2ASkillModule.SaveSkill", input, onEnd);
        }
        public wProtobufRPC.IYieldResult<ReturnCodeData> SaveSkillYield(SkillSave input)
        {
            wProtobufRPC.IYieldResult<ReturnCodeData> info = wProtobufRPC.YieldFactory.Create<ReturnCodeData>();
            SaveSkill(input, info.OnEnd);
            return info;
        }
        public void SaveSkillScheme(SkillSchemeData input, System.Action<wProtobuf.RPC.Error, SkillSchemeSave> onEnd)
        {
            local.Call("C2ASkillModule.SaveSkillScheme", input, onEnd);
        }
        public wProtobufRPC.IYieldResult<SkillSchemeSave> SaveSkillSchemeYield(SkillSchemeData input)
        {
            wProtobufRPC.IYieldResult<SkillSchemeSave> info = wProtobufRPC.YieldFactory.Create<SkillSchemeSave>();
            SaveSkillScheme(input, info.OnEnd);
            return info;
        }
        public void UseSkillScheme(Int32 input, System.Action<wProtobuf.RPC.Error, SkillScheme> onEnd)
        {
            local.Call("C2ASkillModule.UseSkillScheme", input, onEnd);
        }
        public wProtobufRPC.IYieldResult<SkillScheme> UseSkillSchemeYield(Int32 input)
        {
            wProtobufRPC.IYieldResult<SkillScheme> info = wProtobufRPC.YieldFactory.Create<SkillScheme>();
            UseSkillScheme(input, info.OnEnd);
            return info;
        }
        public void SetSkillSchemeName(SkillSchemeName input, System.Action<wProtobuf.RPC.Error, ReturnCodeData> onEnd)
        {
            local.Call("C2ASkillModule.SetSkillSchemeName", input, onEnd);
        }
        public wProtobufRPC.IYieldResult<ReturnCodeData> SetSkillSchemeNameYield(SkillSchemeName input)
        {
            wProtobufRPC.IYieldResult<ReturnCodeData> info = wProtobufRPC.YieldFactory.Create<ReturnCodeData>();
            SetSkillSchemeName(input, info.OnEnd);
            return info;
        }
    }
    public abstract class C2ASkillModuleRespone
    {
        public C2ASkillModuleRespone(RPCIRemoteCall r)
        {
            r.Reg<SkillSave, ReturnCodeData>("C2ASkillModule.SaveSkill", OnSaveSkill);
            r.Reg<SkillSchemeData, SkillSchemeSave>("C2ASkillModule.SaveSkillScheme", OnSaveSkillScheme);
            r.Reg<Int32, SkillScheme>("C2ASkillModule.UseSkillScheme", OnUseSkillScheme);
            r.Reg<SkillSchemeName, ReturnCodeData>("C2ASkillModule.SetSkillSchemeName", OnSetSkillSchemeName);
        }

        protected abstract ReturnCodeData OnSaveSkill(SkillSave input);
        protected abstract SkillSchemeSave OnSaveSkillScheme(SkillSchemeData input);
        protected abstract SkillScheme OnUseSkillScheme(Int32 input);
        protected abstract ReturnCodeData OnSetSkillSchemeName(SkillSchemeName input);
        public static void Reg(RPCIRemoteCall r, IC2ASkillModuleRespone respone)
        {
            r.Reg<SkillSave, ReturnCodeData>("C2ASkillModule.SaveSkill", respone.OnSaveSkill);
            r.Reg<SkillSchemeData, SkillSchemeSave>("C2ASkillModule.SaveSkillScheme", respone.OnSaveSkillScheme);
            r.Reg<Int32, SkillScheme>("C2ASkillModule.UseSkillScheme", respone.OnUseSkillScheme);
            r.Reg<SkillSchemeName, ReturnCodeData>("C2ASkillModule.SetSkillSchemeName", respone.OnSetSkillSchemeName);
        }
    }
    public interface IC2ASkillModuleRespone
    {
        ReturnCodeData OnSaveSkill(SkillSave input);
        SkillSchemeSave OnSaveSkillScheme(SkillSchemeData input);
        SkillScheme OnUseSkillScheme(Int32 input);
        ReturnCodeData OnSetSkillSchemeName(SkillSchemeName input);
    }
}