// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: ClientProto/Trumps/Trumps.proto

using wProtobuf;
using System.Collections;
using System.Collections.Generic;
using wProtobufRPC = wProtobuf.RPC;
using RPCILocalCall = wProtobuf.RPC.ILocalCall;
using RPCIRemoteCall = wProtobuf.RPC.IRemoteCall;

namespace NetProto
{
    public class TrumpSoulData : IMessage
    {
        public int lv = 0;
        public int exp = 0;
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (lv != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(lv);
            }
            if (exp != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(exp);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (lv != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(lv);
            }
            if (exp != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(exp);
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
                        lv = input.ReadInt32();
                    }
                    break;
                case 16:
                    {
                        exp = input.ReadInt32();
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class TrumpSkillData : IMessage
    {
        public int id = 0;
        public int lv = 0;
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (id != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(id);
            }
            if (lv != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(lv);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (id != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(id);
            }
            if (lv != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(lv);
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
                        id = input.ReadInt32();
                    }
                    break;
                case 16:
                    {
                        lv = input.ReadInt32();
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class TrumpAttribute : IMessage
    {
        public class CultivatepointsEntry : IMessage
        {
            public int key = 0;
            public Int32 value = new Int32();
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
                                value = new Int32();
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
        public int id = 0;
        public TrumpSoulData souldata = new TrumpSoulData();
        public int tastelv = 0;
        public TrumpSkillData activeskill = new TrumpSkillData();
        public TrumpSkillData passiveskill = new TrumpSkillData();
        public Dictionary<int , Int32> cultivatepoints = new Dictionary<int , Int32>();
        public List<int> infuseds = new List<int>();
        public int score = 0;
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (id != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(id);
            }
            if (souldata != null)
            {
                _total_size_ += 1 + ComputeSize.ComputeMessageSize(souldata);
            }
            if (tastelv != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(tastelv);
            }
            if (activeskill != null)
            {
                _total_size_ += 1 + ComputeSize.ComputeMessageSize(activeskill);
            }
            if (passiveskill != null)
            {
                _total_size_ += 1 + ComputeSize.ComputeMessageSize(passiveskill);
            }
            if (cultivatepoints != null && cultivatepoints.Count != 0)
            {
                var entry = new CultivatepointsEntry();
                foreach (var itor in cultivatepoints)
                {
                    _total_size_ += 1;
                    entry.key = itor.Key;
                    entry.value = itor.Value;
                    _total_size_ += ComputeSize.ComputeMessageSize(entry);
                }
            }
            if (infuseds != null && infuseds.Count != 0)
            {
                _total_size_ += 1;
                int local_pack_size = 0;
                for (int i = 0; i < infuseds.Count; ++i)
                    local_pack_size += ComputeSize.ComputeInt32Size(infuseds[i]);
                _total_size_ += local_pack_size + ComputeSize.ComputeInt32Size(local_pack_size);
            }
            if (score != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(score);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (id != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(id);
            }
            if (souldata != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(souldata);
            }
            if (tastelv != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(tastelv);
            }
            if (activeskill != null)
            {
                output.WriteRawTag(34);
                output.WriteMessage(activeskill);
            }
            if (passiveskill != null)
            {
                output.WriteRawTag(42);
                output.WriteMessage(passiveskill);
            }
            if (cultivatepoints != null && cultivatepoints.Count != 0)
            {
                var entry = new CultivatepointsEntry();
                foreach (var itor in cultivatepoints)
                {
                    entry.key = itor.Key;
                    entry.value = itor.Value;
                    output.WriteRawTag(50);
                    output.WriteMessage(entry);
                }
            }
            if (infuseds != null && infuseds.Count != 0)
            {
                output.WriteRawTag(58);
                int _total_pack_size_ = 0;
                for (int i = 0; i < infuseds.Count; ++i)
                    _total_pack_size_ += ComputeSize.ComputeInt32Size(infuseds[i]);
                output.WriteInt32(_total_pack_size_);
                for (int i = 0; i < infuseds.Count; ++i)
                {
                    output.WriteInt32(infuseds[i]);
                }
            }
            if (score != 0)
            {
                output.WriteRawTag(64);
                output.WriteInt32(score);
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
                        id = input.ReadInt32();
                    }
                    break;
                case 18:
                    {
                        if (souldata == null)
                            souldata = new TrumpSoulData();
                        input.ReadMessage(souldata);
                    }
                    break;
                case 24:
                    {
                        tastelv = input.ReadInt32();
                    }
                    break;
                case 34:
                    {
                        if (activeskill == null)
                            activeskill = new TrumpSkillData();
                        input.ReadMessage(activeskill);
                    }
                    break;
                case 42:
                    {
                        if (passiveskill == null)
                            passiveskill = new TrumpSkillData();
                        input.ReadMessage(passiveskill);
                    }
                    break;
                case 50:
                    {
                        if (cultivatepoints == null)
                            cultivatepoints = new Dictionary<int, Int32>();
                        var entry = new CultivatepointsEntry();
                        input.ReadMessage(entry);
                        cultivatepoints[entry.key] = entry.value;
                    }
                    break;
                case 58:
                    {
                        if (infuseds == null)
                            infuseds = new List<int>();
                        input.ReadMessage(() => { infuseds.Add(input.ReadInt32()); });
                    }
                    break;
                case 64:
                    {
                        score = input.ReadInt32();
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class TrumpsTable : IMessage
    {
        public class EquiptrumpsEntry : IMessage
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
        public class AttributesEntry : IMessage
        {
            public int key = 0;
            public TrumpAttribute value = new TrumpAttribute();
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
                                value = new TrumpAttribute();
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
        public Dictionary<int , int> equiptrumps = new Dictionary<int , int>();
        public Dictionary<int , TrumpAttribute> attributes = new Dictionary<int , TrumpAttribute>();
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (equiptrumps != null && equiptrumps.Count != 0)
            {
                var entry = new EquiptrumpsEntry();
                foreach (var itor in equiptrumps)
                {
                    _total_size_ += 1;
                    entry.key = itor.Key;
                    entry.value = itor.Value;
                    _total_size_ += ComputeSize.ComputeMessageSize(entry);
                }
            }
            if (attributes != null && attributes.Count != 0)
            {
                var entry = new AttributesEntry();
                foreach (var itor in attributes)
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
            if (equiptrumps != null && equiptrumps.Count != 0)
            {
                var entry = new EquiptrumpsEntry();
                foreach (var itor in equiptrumps)
                {
                    entry.key = itor.Key;
                    entry.value = itor.Value;
                    output.WriteRawTag(10);
                    output.WriteMessage(entry);
                }
            }
            if (attributes != null && attributes.Count != 0)
            {
                var entry = new AttributesEntry();
                foreach (var itor in attributes)
                {
                    entry.key = itor.Key;
                    entry.value = itor.Value;
                    output.WriteRawTag(18);
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
                case 10:
                    {
                        if (equiptrumps == null)
                            equiptrumps = new Dictionary<int, int>();
                        var entry = new EquiptrumpsEntry();
                        input.ReadMessage(entry);
                        equiptrumps[entry.key] = entry.value;
                    }
                    break;
                case 18:
                    {
                        if (attributes == null)
                            attributes = new Dictionary<int, TrumpAttribute>();
                        var entry = new AttributesEntry();
                        input.ReadMessage(entry);
                        attributes[entry.key] = entry.value;
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class TrumpsRespone : IMessage
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

    public class TrumpsExpRequest : IMessage
    {
        public int trumpid = 0;
        public int itemid = 0;
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (trumpid != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(trumpid);
            }
            if (itemid != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(itemid);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (trumpid != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(trumpid);
            }
            if (itemid != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(itemid);
            }
        }
        public void MergeFrom(IReadStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch(tag)
                {
                case 16:
                    {
                        trumpid = input.ReadInt32();
                    }
                    break;
                case 24:
                    {
                        itemid = input.ReadInt32();
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class TrumpsSkillRequest : IMessage
    {
        public int trumpid = 0;
        public int skillType = 0;
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (trumpid != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(trumpid);
            }
            if (skillType != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(skillType);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (trumpid != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(trumpid);
            }
            if (skillType != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(skillType);
            }
        }
        public void MergeFrom(IReadStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch(tag)
                {
                case 16:
                    {
                        trumpid = input.ReadInt32();
                    }
                    break;
                case 24:
                    {
                        skillType = input.ReadInt32();
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class TrumpsEquipRequest : IMessage
    {
        public int trumpid = 0;
        public int equippos = 0;
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (trumpid != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(trumpid);
            }
            if (equippos != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(equippos);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (trumpid != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(trumpid);
            }
            if (equippos != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(equippos);
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
                        trumpid = input.ReadInt32();
                    }
                    break;
                case 16:
                    {
                        equippos = input.ReadInt32();
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class TrumpsAttributeRespone : IMessage
    {
        public ReturnCode code = ReturnCode.ReturnCode_OK;
        public TrumpAttribute attribute = new TrumpAttribute();
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (code != ReturnCode.ReturnCode_OK)
            {
                _total_size_ += 1 + ComputeSize.ComputeEnumSize((int)code);
            }
            if (attribute != null)
            {
                _total_size_ += 1 + ComputeSize.ComputeMessageSize(attribute);
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
            if (attribute != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(attribute);
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
                        if (attribute == null)
                            attribute = new TrumpAttribute();
                        input.ReadMessage(attribute);
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class TrumpStrengthenRequest : IMessage
    {
        public int trumpId = 0;
        public int index = 0;
        public int point = 0;
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (trumpId != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(trumpId);
            }
            if (index != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(index);
            }
            if (point != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(point);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (trumpId != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(trumpId);
            }
            if (index != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(index);
            }
            if (point != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(point);
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
                        trumpId = input.ReadInt32();
                    }
                    break;
                case 16:
                    {
                        index = input.ReadInt32();
                    }
                    break;
                case 24:
                    {
                        point = input.ReadInt32();
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class TrumpsInfusedRequest : IMessage
    {
        public int trumpid = 0;
        public int infusedid = 0;
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (trumpid != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(trumpid);
            }
            if (infusedid != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(infusedid);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (trumpid != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(trumpid);
            }
            if (infusedid != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(infusedid);
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
                        trumpid = input.ReadInt32();
                    }
                    break;
                case 16:
                    {
                        infusedid = input.ReadInt32();
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }
    public class TrumpsModuleRequest
    {
        public TrumpsModuleRequest(RPCILocalCall l)
        {
            local = l;
        }
        RPCILocalCall local;
        public void Create(Int32 input, System.Action<wProtobuf.RPC.Error, TrumpsAttributeRespone> onEnd)
        {
            local.Call("TrumpsModule.Create", input, onEnd);
        }
        public wProtobufRPC.IYieldResult<TrumpsAttributeRespone> CreateYield(Int32 input)
        {
            wProtobufRPC.IYieldResult<TrumpsAttributeRespone> info = wProtobufRPC.YieldFactory.Create<TrumpsAttributeRespone>();
            Create(input, info.OnEnd);
            return info;
        }
        public void AddExp(TrumpsExpRequest input, System.Action<wProtobuf.RPC.Error, TrumpsAttributeRespone> onEnd)
        {
            local.Call("TrumpsModule.AddExp", input, onEnd);
        }
        public wProtobufRPC.IYieldResult<TrumpsAttributeRespone> AddExpYield(TrumpsExpRequest input)
        {
            wProtobufRPC.IYieldResult<TrumpsAttributeRespone> info = wProtobufRPC.YieldFactory.Create<TrumpsAttributeRespone>();
            AddExp(input, info.OnEnd);
            return info;
        }
        public void SkillUpgrade(TrumpsSkillRequest input, System.Action<wProtobuf.RPC.Error, TrumpsAttributeRespone> onEnd)
        {
            local.Call("TrumpsModule.SkillUpgrade", input, onEnd);
        }
        public wProtobufRPC.IYieldResult<TrumpsAttributeRespone> SkillUpgradeYield(TrumpsSkillRequest input)
        {
            wProtobufRPC.IYieldResult<TrumpsAttributeRespone> info = wProtobufRPC.YieldFactory.Create<TrumpsAttributeRespone>();
            SkillUpgrade(input, info.OnEnd);
            return info;
        }
        public void TasteUp(Int32 input, System.Action<wProtobuf.RPC.Error, TrumpsAttributeRespone> onEnd)
        {
            local.Call("TrumpsModule.TasteUp", input, onEnd);
        }
        public wProtobufRPC.IYieldResult<TrumpsAttributeRespone> TasteUpYield(Int32 input)
        {
            wProtobufRPC.IYieldResult<TrumpsAttributeRespone> info = wProtobufRPC.YieldFactory.Create<TrumpsAttributeRespone>();
            TasteUp(input, info.OnEnd);
            return info;
        }
        public void InfusedUp(TrumpsInfusedRequest input, System.Action<wProtobuf.RPC.Error, TrumpsAttributeRespone> onEnd)
        {
            local.Call("TrumpsModule.InfusedUp", input, onEnd);
        }
        public wProtobufRPC.IYieldResult<TrumpsAttributeRespone> InfusedUpYield(TrumpsInfusedRequest input)
        {
            wProtobufRPC.IYieldResult<TrumpsAttributeRespone> info = wProtobufRPC.YieldFactory.Create<TrumpsAttributeRespone>();
            InfusedUp(input, info.OnEnd);
            return info;
        }
        public void Equip(TrumpsEquipRequest input, System.Action<wProtobuf.RPC.Error, TrumpsRespone> onEnd)
        {
            local.Call("TrumpsModule.Equip", input, onEnd);
        }
        public wProtobufRPC.IYieldResult<TrumpsRespone> EquipYield(TrumpsEquipRequest input)
        {
            wProtobufRPC.IYieldResult<TrumpsRespone> info = wProtobufRPC.YieldFactory.Create<TrumpsRespone>();
            Equip(input, info.OnEnd);
            return info;
        }
        public void Strengthen(TrumpStrengthenRequest input, System.Action<wProtobuf.RPC.Error, TrumpsAttributeRespone> onEnd)
        {
            local.Call("TrumpsModule.Strengthen", input, onEnd);
        }
        public wProtobufRPC.IYieldResult<TrumpsAttributeRespone> StrengthenYield(TrumpStrengthenRequest input)
        {
            wProtobufRPC.IYieldResult<TrumpsAttributeRespone> info = wProtobufRPC.YieldFactory.Create<TrumpsAttributeRespone>();
            Strengthen(input, info.OnEnd);
            return info;
        }
    }
    public abstract class TrumpsModuleRespone
    {
        public TrumpsModuleRespone(RPCIRemoteCall r)
        {
            r.Reg<Int32, TrumpsAttributeRespone>("TrumpsModule.Create", OnCreate);
            r.Reg<TrumpsExpRequest, TrumpsAttributeRespone>("TrumpsModule.AddExp", OnAddExp);
            r.Reg<TrumpsSkillRequest, TrumpsAttributeRespone>("TrumpsModule.SkillUpgrade", OnSkillUpgrade);
            r.Reg<Int32, TrumpsAttributeRespone>("TrumpsModule.TasteUp", OnTasteUp);
            r.Reg<TrumpsInfusedRequest, TrumpsAttributeRespone>("TrumpsModule.InfusedUp", OnInfusedUp);
            r.Reg<TrumpsEquipRequest, TrumpsRespone>("TrumpsModule.Equip", OnEquip);
            r.Reg<TrumpStrengthenRequest, TrumpsAttributeRespone>("TrumpsModule.Strengthen", OnStrengthen);
        }

        protected abstract TrumpsAttributeRespone OnCreate(Int32 input);
        protected abstract TrumpsAttributeRespone OnAddExp(TrumpsExpRequest input);
        protected abstract TrumpsAttributeRespone OnSkillUpgrade(TrumpsSkillRequest input);
        protected abstract TrumpsAttributeRespone OnTasteUp(Int32 input);
        protected abstract TrumpsAttributeRespone OnInfusedUp(TrumpsInfusedRequest input);
        protected abstract TrumpsRespone OnEquip(TrumpsEquipRequest input);
        protected abstract TrumpsAttributeRespone OnStrengthen(TrumpStrengthenRequest input);
        public static void Reg(RPCIRemoteCall r, ITrumpsModuleRespone respone)
        {
            r.Reg<Int32, TrumpsAttributeRespone>("TrumpsModule.Create", respone.OnCreate);
            r.Reg<TrumpsExpRequest, TrumpsAttributeRespone>("TrumpsModule.AddExp", respone.OnAddExp);
            r.Reg<TrumpsSkillRequest, TrumpsAttributeRespone>("TrumpsModule.SkillUpgrade", respone.OnSkillUpgrade);
            r.Reg<Int32, TrumpsAttributeRespone>("TrumpsModule.TasteUp", respone.OnTasteUp);
            r.Reg<TrumpsInfusedRequest, TrumpsAttributeRespone>("TrumpsModule.InfusedUp", respone.OnInfusedUp);
            r.Reg<TrumpsEquipRequest, TrumpsRespone>("TrumpsModule.Equip", respone.OnEquip);
            r.Reg<TrumpStrengthenRequest, TrumpsAttributeRespone>("TrumpsModule.Strengthen", respone.OnStrengthen);
        }
    }
    public interface ITrumpsModuleRespone
    {
        TrumpsAttributeRespone OnCreate(Int32 input);
        TrumpsAttributeRespone OnAddExp(TrumpsExpRequest input);
        TrumpsAttributeRespone OnSkillUpgrade(TrumpsSkillRequest input);
        TrumpsAttributeRespone OnTasteUp(Int32 input);
        TrumpsAttributeRespone OnInfusedUp(TrumpsInfusedRequest input);
        TrumpsRespone OnEquip(TrumpsEquipRequest input);
        TrumpsAttributeRespone OnStrengthen(TrumpStrengthenRequest input);
    }
}
