// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: ClientProto/Battle.proto

using wProtobuf;
using System.Collections;
using System.Collections.Generic;
using wProtobufRPC = wProtobuf.RPC;
using RPCILocalCall = wProtobuf.RPC.ILocalCall;
using RPCIRemoteCall = wProtobuf.RPC.IRemoteCall;

namespace NetProto
{
    public class Battle_MoveToPos : IMessage
    {
        public int charSceneId = 0;
        public Point3 pos = new Point3();
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (charSceneId != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(charSceneId);
            }
            if (pos != null)
            {
                _total_size_ += 1 + ComputeSize.ComputeMessageSize(pos);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (charSceneId != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(charSceneId);
            }
            if (pos != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(pos);
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
                        charSceneId = input.ReadInt32();
                    }
                    break;
                case 18:
                    {
                        if (pos == null)
                            pos = new Point3();
                        input.ReadMessage(pos);
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class Battle_JumpToPos : IMessage
    {
        public int charSceneId = 0;
        public Point3 pos = new Point3();
        public int angle = 0;
        public float changeSpeed = 0F;
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (charSceneId != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(charSceneId);
            }
            if (pos != null)
            {
                _total_size_ += 1 + ComputeSize.ComputeMessageSize(pos);
            }
            if (angle != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(angle);
            }
            if (changeSpeed != 0F)
            {
                _total_size_ += (1 + 4);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (charSceneId != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(charSceneId);
            }
            if (pos != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(pos);
            }
            if (angle != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(angle);
            }
            if (changeSpeed != 0F)
            {
                output.WriteRawTag(37);
                output.WriteFloat(changeSpeed);
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
                        charSceneId = input.ReadInt32();
                    }
                    break;
                case 18:
                    {
                        if (pos == null)
                            pos = new Point3();
                        input.ReadMessage(pos);
                    }
                    break;
                case 24:
                    {
                        angle = input.ReadInt32();
                    }
                    break;
                case 37:
                    {
                        changeSpeed = input.ReadFloat();
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class Battle_PlaySkill : IMessage
    {
        public int sourceid = 0;
        public int targetid = 0;
        public int skillid = 0;
        public int rotate = 0;
        public Point3 pos = new Point3();
        public Point3 targetPos = new Point3();
        public List<int> searchTarget = new List<int>();
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (sourceid != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(sourceid);
            }
            if (targetid != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(targetid);
            }
            if (skillid != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(skillid);
            }
            if (rotate != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(rotate);
            }
            if (pos != null)
            {
                _total_size_ += 1 + ComputeSize.ComputeMessageSize(pos);
            }
            if (targetPos != null)
            {
                _total_size_ += 1 + ComputeSize.ComputeMessageSize(targetPos);
            }
            if (searchTarget != null && searchTarget.Count != 0)
            {
                _total_size_ += 1;
                int local_pack_size = 0;
                for (int i = 0; i < searchTarget.Count; ++i)
                    local_pack_size += ComputeSize.ComputeInt32Size(searchTarget[i]);
                _total_size_ += local_pack_size + ComputeSize.ComputeInt32Size(local_pack_size);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (sourceid != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(sourceid);
            }
            if (targetid != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(targetid);
            }
            if (skillid != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(skillid);
            }
            if (rotate != 0)
            {
                output.WriteRawTag(32);
                output.WriteInt32(rotate);
            }
            if (pos != null)
            {
                output.WriteRawTag(42);
                output.WriteMessage(pos);
            }
            if (targetPos != null)
            {
                output.WriteRawTag(50);
                output.WriteMessage(targetPos);
            }
            if (searchTarget != null && searchTarget.Count != 0)
            {
                output.WriteRawTag(58);
                int _total_pack_size_ = 0;
                for (int i = 0; i < searchTarget.Count; ++i)
                    _total_pack_size_ += ComputeSize.ComputeInt32Size(searchTarget[i]);
                output.WriteInt32(_total_pack_size_);
                for (int i = 0; i < searchTarget.Count; ++i)
                {
                    output.WriteInt32(searchTarget[i]);
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
                        sourceid = input.ReadInt32();
                    }
                    break;
                case 16:
                    {
                        targetid = input.ReadInt32();
                    }
                    break;
                case 24:
                    {
                        skillid = input.ReadInt32();
                    }
                    break;
                case 32:
                    {
                        rotate = input.ReadInt32();
                    }
                    break;
                case 42:
                    {
                        if (pos == null)
                            pos = new Point3();
                        input.ReadMessage(pos);
                    }
                    break;
                case 50:
                    {
                        if (targetPos == null)
                            targetPos = new Point3();
                        input.ReadMessage(targetPos);
                    }
                    break;
                case 58:
                    {
                        if (searchTarget == null)
                            searchTarget = new List<int>();
                        input.ReadMessage(() => { searchTarget.Add(input.ReadInt32()); });
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class Battle_AttackAction : IMessage
    {
        public int damageValue = 0;
        public int damageFlg = 0;
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (damageValue != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(damageValue);
            }
            if (damageFlg != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(damageFlg);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (damageValue != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(damageValue);
            }
            if (damageFlg != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(damageFlg);
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
                        damageValue = input.ReadInt32();
                    }
                    break;
                case 24:
                    {
                        damageFlg = input.ReadInt32();
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class Battle_FastRun : IMessage
    {
        public int fustRun = 0;
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (fustRun != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(fustRun);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (fustRun != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(fustRun);
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
                        fustRun = input.ReadInt32();
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class Battle_TargetAction : IMessage
    {
        public int targetid = 0;
        public int actionid = 0;
        public Point3 topos = new Point3();
        public Point3 firePos = new Point3();
        public int fireAngle = 0;
        public Battle_AttackAction attack = new Battle_AttackAction();
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (targetid != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(targetid);
            }
            if (actionid != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(actionid);
            }
            if (topos != null)
            {
                _total_size_ += 1 + ComputeSize.ComputeMessageSize(topos);
            }
            if (firePos != null)
            {
                _total_size_ += 1 + ComputeSize.ComputeMessageSize(firePos);
            }
            if (fireAngle != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(fireAngle);
            }
            if (attack != null)
            {
                _total_size_ += 1 + ComputeSize.ComputeMessageSize(attack);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (targetid != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(targetid);
            }
            if (actionid != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(actionid);
            }
            if (topos != null)
            {
                output.WriteRawTag(34);
                output.WriteMessage(topos);
            }
            if (firePos != null)
            {
                output.WriteRawTag(42);
                output.WriteMessage(firePos);
            }
            if (fireAngle != 0)
            {
                output.WriteRawTag(48);
                output.WriteInt32(fireAngle);
            }
            if (attack != null)
            {
                output.WriteRawTag(58);
                output.WriteMessage(attack);
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
                        targetid = input.ReadInt32();
                    }
                    break;
                case 24:
                    {
                        actionid = input.ReadInt32();
                    }
                    break;
                case 34:
                    {
                        if (topos == null)
                            topos = new Point3();
                        input.ReadMessage(topos);
                    }
                    break;
                case 42:
                    {
                        if (firePos == null)
                            firePos = new Point3();
                        input.ReadMessage(firePos);
                    }
                    break;
                case 48:
                    {
                        fireAngle = input.ReadInt32();
                    }
                    break;
                case 58:
                    {
                        if (attack == null)
                            attack = new Battle_AttackAction();
                        input.ReadMessage(attack);
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class Battle_SourceActionList : IMessage
    {
        public int sourceid = 0;
        public List<Battle_TargetAction> targets = new List<Battle_TargetAction>();
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (sourceid != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(sourceid);
            }
            if (targets != null && targets.Count != 0)
            {
                _total_size_ += 1 * targets.Count;
                for (int i = 0; i < targets.Count; ++i)
                    _total_size_ += ComputeSize.ComputeMessageSize(targets[i]);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (sourceid != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(sourceid);
            }
            if (targets != null && targets.Count != 0)
            {
                for (int i = 0; i < targets.Count; ++i)
                {
                    output.WriteRawTag(18);
                    output.WriteMessage(targets[i]);
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
                        sourceid = input.ReadInt32();
                    }
                    break;
                case 18:
                    {
                        if (targets == null)
                            targets = new List<Battle_TargetAction>();
                        var local_temp = new Battle_TargetAction();
                        input.ReadMessage(local_temp);
                        targets.Add(local_temp);
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class Battle_Dead : IMessage
    {
        public int sourceid = 0;
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (sourceid != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(sourceid);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (sourceid != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(sourceid);
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
                        sourceid = input.ReadInt32();
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class Battle_StopSkill : IMessage
    {
        public int code = 0;
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (code != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(code);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (code != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(code);
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
                        code = input.ReadInt32();
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class Battle_PlaySkillFail : IMessage
    {
        public int code = 0;
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (code != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(code);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (code != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(code);
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
                        code = input.ReadInt32();
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class Battle_SetPos : IMessage
    {
        public int charSceneId = 0;
        public Point3 pos = new Point3();
        public int angle = 0;
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (charSceneId != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(charSceneId);
            }
            if (pos != null)
            {
                _total_size_ += 1 + ComputeSize.ComputeMessageSize(pos);
            }
            if (angle != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(angle);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (charSceneId != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(charSceneId);
            }
            if (pos != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(pos);
            }
            if (angle != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(angle);
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
                        charSceneId = input.ReadInt32();
                    }
                    break;
                case 18:
                    {
                        if (pos == null)
                            pos = new Point3();
                        input.ReadMessage(pos);
                    }
                    break;
                case 24:
                    {
                        angle = input.ReadInt32();
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class Battle_Attribute : IMessage
    {
        public class ValuesEntry : IMessage
        {
            public int key = 0;
            public double value = 0D;
            public int CalculateSize()
            {
                int _total_size_ = 0;
                if (key != 0)
                {
                    _total_size_ += 1 + ComputeSize.ComputeInt32Size(key);
                }
                if (value != 0D)
                {
                    _total_size_ += (1 + 8);
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
                if (value != 0D)
                {
                    output.WriteRawTag(17);
                    output.WriteDouble(value);
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
                    case 17:
                        {
                            value = input.ReadDouble();
                        }
                        break;
                    default:
                        input.SkipLastField(tag);
                        break;
                    }
                }
            }
        }
        public Dictionary<int , double> values = new Dictionary<int , double>();
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (values != null && values.Count != 0)
            {
                var entry = new ValuesEntry();
                foreach (var itor in values)
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
            if (values != null && values.Count != 0)
            {
                var entry = new ValuesEntry();
                foreach (var itor in values)
                {
                    entry.key = itor.Key;
                    entry.value = itor.Value;
                    output.WriteRawTag(10);
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
                        if (values == null)
                            values = new Dictionary<int, double>();
                        var entry = new ValuesEntry();
                        input.ReadMessage(entry);
                        values[entry.key] = entry.value;
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class Battle_AddBuff : IMessage
    {
        public int sourceid = 0;
        public int targetid = 0;
        public int buffid = 0;
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (sourceid != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(sourceid);
            }
            if (targetid != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(targetid);
            }
            if (buffid != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(buffid);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (sourceid != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(sourceid);
            }
            if (targetid != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(targetid);
            }
            if (buffid != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(buffid);
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
                        sourceid = input.ReadInt32();
                    }
                    break;
                case 16:
                    {
                        targetid = input.ReadInt32();
                    }
                    break;
                case 24:
                    {
                        buffid = input.ReadInt32();
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class Battle_RemoveBuff : IMessage
    {
        public int sourceid = 0;
        public int buffid = 0;
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (sourceid != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(sourceid);
            }
            if (buffid != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(buffid);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (sourceid != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(sourceid);
            }
            if (buffid != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(buffid);
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
                        sourceid = input.ReadInt32();
                    }
                    break;
                case 24:
                    {
                        buffid = input.ReadInt32();
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class Battle_PlayJump : IMessage
    {
        public int sourceid = 0;
        public int skillid = 0;
        public int rotate = 0;
        public Point3 pos = new Point3();
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (sourceid != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(sourceid);
            }
            if (skillid != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(skillid);
            }
            if (rotate != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(rotate);
            }
            if (pos != null)
            {
                _total_size_ += 1 + ComputeSize.ComputeMessageSize(pos);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (sourceid != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(sourceid);
            }
            if (skillid != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(skillid);
            }
            if (rotate != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(rotate);
            }
            if (pos != null)
            {
                output.WriteRawTag(34);
                output.WriteMessage(pos);
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
                        sourceid = input.ReadInt32();
                    }
                    break;
                case 16:
                    {
                        skillid = input.ReadInt32();
                    }
                    break;
                case 24:
                    {
                        rotate = input.ReadInt32();
                    }
                    break;
                case 34:
                    {
                        if (pos == null)
                            pos = new Point3();
                        input.ReadMessage(pos);
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
