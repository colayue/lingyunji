// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: ClientProto/Mail/Mail.proto

using wProtobuf;
using System.Collections;
using System.Collections.Generic;
using wProtobufRPC = wProtobuf.RPC;
using RPCILocalCall = wProtobuf.RPC.ILocalCall;
using RPCIRemoteCall = wProtobuf.RPC.IRemoteCall;

namespace NetProto
{
    public enum MailSource
    {
        MS_Private = 0,
        MS_Global = 1,
    }
    public enum MailDbOperate
    {
        MailDbOperate_None = 0,
        MailDbOperate_Add = 1,
        MailDbOperate_Remove = 2,
        MailDbOperate_Modify = 3,
        MailDbOperate_Query = 4,
    }
    public enum MailError
    {
        MailError_None = 0,
        MailError_MailNotExist = 1,
        MailError_AttachmentAlreadyFetched = 2,
        MailError_RPCFail = 3,
        MailError_PackageFull = 4,
    }
    public class MailRecords : IMessage
    {
        public List<MailDbRecord> records = new List<MailDbRecord>();
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (records != null && records.Count != 0)
            {
                _total_size_ += 1 * records.Count;
                for (int i = 0; i < records.Count; ++i)
                    _total_size_ += ComputeSize.ComputeMessageSize(records[i]);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (records != null && records.Count != 0)
            {
                for (int i = 0; i < records.Count; ++i)
                {
                    output.WriteRawTag(10);
                    output.WriteMessage(records[i]);
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
                        if (records == null)
                            records = new List<MailDbRecord>();
                        var local_temp = new MailDbRecord();
                        input.ReadMessage(local_temp);
                        records.Add(local_temp);
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class MailDbItem : IMessage
    {
        public int id = 0;
        public int num = 0;
        public ByteString extraData = null;
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (id != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(id);
            }
            if (num != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(num);
            }
            if (extraData != null && extraData.Length != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeBytesSize(extraData);
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
            if (num != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(num);
            }
            if (extraData != null && extraData.Length != 0)
            {
                output.WriteRawTag(26);
                output.WriteBytes(extraData);
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
                        num = input.ReadInt32();
                    }
                    break;
                case 26:
                    {
                        extraData = input.ReadBytes();
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class MailDbRecord : IMessage
    {
        public long id = 0L;
        public string title = null;
        public string content = null;
        public List<MailDbItem> attachments = new List<MailDbItem>();
        public bool isRead = false;
        public bool isFetchedAttachments = false;
        public MailSource mailSource = MailSource.MS_Private;
        public long mailSourceParam = 0L;
        public long createTick = 0L;
        public string sender = null;
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (id != 0L)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt64Size(id);
            }
            if (!string.IsNullOrEmpty(title))
            {
                _total_size_ += 1 + ComputeSize.ComputeStringSize(title);
            }
            if (!string.IsNullOrEmpty(content))
            {
                _total_size_ += 1 + ComputeSize.ComputeStringSize(content);
            }
            if (attachments != null && attachments.Count != 0)
            {
                _total_size_ += 1 * attachments.Count;
                for (int i = 0; i < attachments.Count; ++i)
                    _total_size_ += ComputeSize.ComputeMessageSize(attachments[i]);
            }
            if (isRead != false)
            {
                _total_size_ += (1 + 1);
            }
            if (isFetchedAttachments != false)
            {
                _total_size_ += (1 + 1);
            }
            if (mailSource != MailSource.MS_Private)
            {
                _total_size_ += 1 + ComputeSize.ComputeEnumSize((int)mailSource);
            }
            if (mailSourceParam != 0L)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt64Size(mailSourceParam);
            }
            if (createTick != 0L)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt64Size(createTick);
            }
            if (!string.IsNullOrEmpty(sender))
            {
                _total_size_ += 1 + ComputeSize.ComputeStringSize(sender);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (id != 0L)
            {
                output.WriteRawTag(8);
                output.WriteInt64(id);
            }
            if (!string.IsNullOrEmpty(title))
            {
                output.WriteRawTag(18);
                output.WriteString(title);
            }
            if (!string.IsNullOrEmpty(content))
            {
                output.WriteRawTag(26);
                output.WriteString(content);
            }
            if (attachments != null && attachments.Count != 0)
            {
                for (int i = 0; i < attachments.Count; ++i)
                {
                    output.WriteRawTag(34);
                    output.WriteMessage(attachments[i]);
                }
            }
            if (isRead != false)
            {
                output.WriteRawTag(40);
                output.WriteBool(isRead);
            }
            if (isFetchedAttachments != false)
            {
                output.WriteRawTag(48);
                output.WriteBool(isFetchedAttachments);
            }
            if (mailSource != MailSource.MS_Private)
            {
                output.WriteRawTag(56);
                output.WriteEnum((int)mailSource);
            }
            if (mailSourceParam != 0L)
            {
                output.WriteRawTag(64);
                output.WriteInt64(mailSourceParam);
            }
            if (createTick != 0L)
            {
                output.WriteRawTag(72);
                output.WriteInt64(createTick);
            }
            if (!string.IsNullOrEmpty(sender))
            {
                output.WriteRawTag(82);
                output.WriteString(sender);
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
                        id = input.ReadInt64();
                    }
                    break;
                case 18:
                    {
                        title = input.ReadString();
                    }
                    break;
                case 26:
                    {
                        content = input.ReadString();
                    }
                    break;
                case 34:
                    {
                        if (attachments == null)
                            attachments = new List<MailDbItem>();
                        var local_temp = new MailDbItem();
                        input.ReadMessage(local_temp);
                        attachments.Add(local_temp);
                    }
                    break;
                case 40:
                    {
                        isRead = input.ReadBool();
                    }
                    break;
                case 48:
                    {
                        isFetchedAttachments = input.ReadBool();
                    }
                    break;
                case 56:
                    {
                        mailSource = (MailSource)input.ReadEnum();
                    }
                    break;
                case 64:
                    {
                        mailSourceParam = input.ReadInt64();
                    }
                    break;
                case 72:
                    {
                        createTick = input.ReadInt64();
                    }
                    break;
                case 82:
                    {
                        sender = input.ReadString();
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class MailDbAllData : IMessage
    {
        public List<MailDbRecord> records = new List<MailDbRecord>();
        public List<long> globalMailHistory = new List<long>();
        public long lastRecordId = 0L;
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (records != null && records.Count != 0)
            {
                _total_size_ += 1 * records.Count;
                for (int i = 0; i < records.Count; ++i)
                    _total_size_ += ComputeSize.ComputeMessageSize(records[i]);
            }
            if (globalMailHistory != null && globalMailHistory.Count != 0)
            {
                _total_size_ += 1;
                int local_pack_size = 0;
                for (int i = 0; i < globalMailHistory.Count; ++i)
                    local_pack_size += ComputeSize.ComputeInt64Size(globalMailHistory[i]);
                _total_size_ += local_pack_size + ComputeSize.ComputeInt32Size(local_pack_size);
            }
            if (lastRecordId != 0L)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt64Size(lastRecordId);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (records != null && records.Count != 0)
            {
                for (int i = 0; i < records.Count; ++i)
                {
                    output.WriteRawTag(10);
                    output.WriteMessage(records[i]);
                }
            }
            if (globalMailHistory != null && globalMailHistory.Count != 0)
            {
                output.WriteRawTag(18);
                int _total_pack_size_ = 0;
                for (int i = 0; i < globalMailHistory.Count; ++i)
                    _total_pack_size_ += ComputeSize.ComputeInt64Size(globalMailHistory[i]);
                output.WriteInt32(_total_pack_size_);
                for (int i = 0; i < globalMailHistory.Count; ++i)
                {
                    output.WriteInt64(globalMailHistory[i]);
                }
            }
            if (lastRecordId != 0L)
            {
                output.WriteRawTag(24);
                output.WriteInt64(lastRecordId);
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
                        if (records == null)
                            records = new List<MailDbRecord>();
                        var local_temp = new MailDbRecord();
                        input.ReadMessage(local_temp);
                        records.Add(local_temp);
                    }
                    break;
                case 18:
                    {
                        if (globalMailHistory == null)
                            globalMailHistory = new List<long>();
                        input.ReadMessage(() => { globalMailHistory.Add(input.ReadInt64()); });
                    }
                    break;
                case 24:
                    {
                        lastRecordId = input.ReadInt64();
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class MailDbOfflineRecord : IMessage
    {
        public string title = null;
        public string content = null;
        public List<MailDbItem> attachments = new List<MailDbItem>();
        public long createTick = 0L;
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (!string.IsNullOrEmpty(title))
            {
                _total_size_ += 1 + ComputeSize.ComputeStringSize(title);
            }
            if (!string.IsNullOrEmpty(content))
            {
                _total_size_ += 1 + ComputeSize.ComputeStringSize(content);
            }
            if (attachments != null && attachments.Count != 0)
            {
                _total_size_ += 1 * attachments.Count;
                for (int i = 0; i < attachments.Count; ++i)
                    _total_size_ += ComputeSize.ComputeMessageSize(attachments[i]);
            }
            if (createTick != 0L)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt64Size(createTick);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (!string.IsNullOrEmpty(title))
            {
                output.WriteRawTag(18);
                output.WriteString(title);
            }
            if (!string.IsNullOrEmpty(content))
            {
                output.WriteRawTag(26);
                output.WriteString(content);
            }
            if (attachments != null && attachments.Count != 0)
            {
                for (int i = 0; i < attachments.Count; ++i)
                {
                    output.WriteRawTag(34);
                    output.WriteMessage(attachments[i]);
                }
            }
            if (createTick != 0L)
            {
                output.WriteRawTag(48);
                output.WriteInt64(createTick);
            }
        }
        public void MergeFrom(IReadStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch(tag)
                {
                case 18:
                    {
                        title = input.ReadString();
                    }
                    break;
                case 26:
                    {
                        content = input.ReadString();
                    }
                    break;
                case 34:
                    {
                        if (attachments == null)
                            attachments = new List<MailDbItem>();
                        var local_temp = new MailDbItem();
                        input.ReadMessage(local_temp);
                        attachments.Add(local_temp);
                    }
                    break;
                case 48:
                    {
                        createTick = input.ReadInt64();
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class MailFetchAttachmentResult : IMessage
    {
        public MailError ret = MailError.MailError_None;
        public bool isFetchAttachmentVal = false;
        public long mailId = 0L;
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (ret != MailError.MailError_None)
            {
                _total_size_ += 1 + ComputeSize.ComputeEnumSize((int)ret);
            }
            if (isFetchAttachmentVal != false)
            {
                _total_size_ += (1 + 1);
            }
            if (mailId != 0L)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt64Size(mailId);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (ret != MailError.MailError_None)
            {
                output.WriteRawTag(8);
                output.WriteEnum((int)ret);
            }
            if (isFetchAttachmentVal != false)
            {
                output.WriteRawTag(16);
                output.WriteBool(isFetchAttachmentVal);
            }
            if (mailId != 0L)
            {
                output.WriteRawTag(24);
                output.WriteInt64(mailId);
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
                        ret = (MailError)input.ReadEnum();
                    }
                    break;
                case 16:
                    {
                        isFetchAttachmentVal = input.ReadBool();
                    }
                    break;
                case 24:
                    {
                        mailId = input.ReadInt64();
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class MailDbGlobalMailRecord : IMessage
    {
        public long id = 0L;
        public string title = null;
        public string content = null;
        public List<MailDbItem> attachments = new List<MailDbItem>();
        public long createTick = 0L;
        public string sender = null;
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (id != 0L)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt64Size(id);
            }
            if (!string.IsNullOrEmpty(title))
            {
                _total_size_ += 1 + ComputeSize.ComputeStringSize(title);
            }
            if (!string.IsNullOrEmpty(content))
            {
                _total_size_ += 1 + ComputeSize.ComputeStringSize(content);
            }
            if (attachments != null && attachments.Count != 0)
            {
                _total_size_ += 1 * attachments.Count;
                for (int i = 0; i < attachments.Count; ++i)
                    _total_size_ += ComputeSize.ComputeMessageSize(attachments[i]);
            }
            if (createTick != 0L)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt64Size(createTick);
            }
            if (!string.IsNullOrEmpty(sender))
            {
                _total_size_ += 1 + ComputeSize.ComputeStringSize(sender);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (id != 0L)
            {
                output.WriteRawTag(8);
                output.WriteInt64(id);
            }
            if (!string.IsNullOrEmpty(title))
            {
                output.WriteRawTag(18);
                output.WriteString(title);
            }
            if (!string.IsNullOrEmpty(content))
            {
                output.WriteRawTag(26);
                output.WriteString(content);
            }
            if (attachments != null && attachments.Count != 0)
            {
                for (int i = 0; i < attachments.Count; ++i)
                {
                    output.WriteRawTag(34);
                    output.WriteMessage(attachments[i]);
                }
            }
            if (createTick != 0L)
            {
                output.WriteRawTag(40);
                output.WriteInt64(createTick);
            }
            if (!string.IsNullOrEmpty(sender))
            {
                output.WriteRawTag(50);
                output.WriteString(sender);
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
                        id = input.ReadInt64();
                    }
                    break;
                case 18:
                    {
                        title = input.ReadString();
                    }
                    break;
                case 26:
                    {
                        content = input.ReadString();
                    }
                    break;
                case 34:
                    {
                        if (attachments == null)
                            attachments = new List<MailDbItem>();
                        var local_temp = new MailDbItem();
                        input.ReadMessage(local_temp);
                        attachments.Add(local_temp);
                    }
                    break;
                case 40:
                    {
                        createTick = input.ReadInt64();
                    }
                    break;
                case 50:
                    {
                        sender = input.ReadString();
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class DbOperateGlobalMailReq : IMessage
    {
        public MailDbOperate operate = MailDbOperate.MailDbOperate_None;
        public long queryBeginMailId = 0L;
        public long queryEndMailId = 0L;
        public List<long> removeMailIds = new List<long>();
        public MailDbGlobalMailRecord newRecord = new MailDbGlobalMailRecord();
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (operate != MailDbOperate.MailDbOperate_None)
            {
                _total_size_ += 1 + ComputeSize.ComputeEnumSize((int)operate);
            }
            if (queryBeginMailId != 0L)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt64Size(queryBeginMailId);
            }
            if (queryEndMailId != 0L)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt64Size(queryEndMailId);
            }
            if (removeMailIds != null && removeMailIds.Count != 0)
            {
                _total_size_ += 1;
                int local_pack_size = 0;
                for (int i = 0; i < removeMailIds.Count; ++i)
                    local_pack_size += ComputeSize.ComputeInt64Size(removeMailIds[i]);
                _total_size_ += local_pack_size + ComputeSize.ComputeInt32Size(local_pack_size);
            }
            if (newRecord != null)
            {
                _total_size_ += 1 + ComputeSize.ComputeMessageSize(newRecord);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (operate != MailDbOperate.MailDbOperate_None)
            {
                output.WriteRawTag(8);
                output.WriteEnum((int)operate);
            }
            if (queryBeginMailId != 0L)
            {
                output.WriteRawTag(16);
                output.WriteInt64(queryBeginMailId);
            }
            if (queryEndMailId != 0L)
            {
                output.WriteRawTag(24);
                output.WriteInt64(queryEndMailId);
            }
            if (removeMailIds != null && removeMailIds.Count != 0)
            {
                output.WriteRawTag(34);
                int _total_pack_size_ = 0;
                for (int i = 0; i < removeMailIds.Count; ++i)
                    _total_pack_size_ += ComputeSize.ComputeInt64Size(removeMailIds[i]);
                output.WriteInt32(_total_pack_size_);
                for (int i = 0; i < removeMailIds.Count; ++i)
                {
                    output.WriteInt64(removeMailIds[i]);
                }
            }
            if (newRecord != null)
            {
                output.WriteRawTag(42);
                output.WriteMessage(newRecord);
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
                        operate = (MailDbOperate)input.ReadEnum();
                    }
                    break;
                case 16:
                    {
                        queryBeginMailId = input.ReadInt64();
                    }
                    break;
                case 24:
                    {
                        queryEndMailId = input.ReadInt64();
                    }
                    break;
                case 34:
                    {
                        if (removeMailIds == null)
                            removeMailIds = new List<long>();
                        input.ReadMessage(() => { removeMailIds.Add(input.ReadInt64()); });
                    }
                    break;
                case 42:
                    {
                        if (newRecord == null)
                            newRecord = new MailDbGlobalMailRecord();
                        input.ReadMessage(newRecord);
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class DbOperateGlobalMailRsp : IMessage
    {
        public enum ErrorNum
        {
            None = 0,
            Fail = 1,
        }
        public MailDbOperate operate = MailDbOperate.MailDbOperate_None;
        public ErrorNum errNum = ErrorNum.None;
        public List<MailDbGlobalMailRecord> records = new List<MailDbGlobalMailRecord>();
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (operate != MailDbOperate.MailDbOperate_None)
            {
                _total_size_ += 1 + ComputeSize.ComputeEnumSize((int)operate);
            }
            if (errNum != ErrorNum.None)
            {
                _total_size_ += 1 + ComputeSize.ComputeEnumSize((int)errNum);
            }
            if (records != null && records.Count != 0)
            {
                _total_size_ += 1 * records.Count;
                for (int i = 0; i < records.Count; ++i)
                    _total_size_ += ComputeSize.ComputeMessageSize(records[i]);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (operate != MailDbOperate.MailDbOperate_None)
            {
                output.WriteRawTag(8);
                output.WriteEnum((int)operate);
            }
            if (errNum != ErrorNum.None)
            {
                output.WriteRawTag(16);
                output.WriteEnum((int)errNum);
            }
            if (records != null && records.Count != 0)
            {
                for (int i = 0; i < records.Count; ++i)
                {
                    output.WriteRawTag(26);
                    output.WriteMessage(records[i]);
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
                        operate = (MailDbOperate)input.ReadEnum();
                    }
                    break;
                case 16:
                    {
                        errNum = (ErrorNum)input.ReadEnum();
                    }
                    break;
                case 26:
                    {
                        if (records == null)
                            records = new List<MailDbGlobalMailRecord>();
                        var local_temp = new MailDbGlobalMailRecord();
                        input.ReadMessage(local_temp);
                        records.Add(local_temp);
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class MailErrorCode : IMessage
    {
        public MailError error = MailError.MailError_None;
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (error != MailError.MailError_None)
            {
                _total_size_ += 1 + ComputeSize.ComputeEnumSize((int)error);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (error != MailError.MailError_None)
            {
                output.WriteRawTag(8);
                output.WriteEnum((int)error);
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
                        error = (MailError)input.ReadEnum();
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class MailReqAddGlobalMail : IMessage
    {
        public MailDbGlobalMailRecord mail = new MailDbGlobalMailRecord();
        public string sendReason = null;
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (mail != null)
            {
                _total_size_ += 1 + ComputeSize.ComputeMessageSize(mail);
            }
            if (!string.IsNullOrEmpty(sendReason))
            {
                _total_size_ += 1 + ComputeSize.ComputeStringSize(sendReason);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (mail != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(mail);
            }
            if (!string.IsNullOrEmpty(sendReason))
            {
                output.WriteRawTag(18);
                output.WriteString(sendReason);
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
                        if (mail == null)
                            mail = new MailDbGlobalMailRecord();
                        input.ReadMessage(mail);
                    }
                    break;
                case 18:
                    {
                        sendReason = input.ReadString();
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class MailReqAddPrivateMail : IMessage
    {
        public List<long> receiverUids = new List<long>();
        public MailDbRecord mail = new MailDbRecord();
        public string sendReason = null;
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (receiverUids != null && receiverUids.Count != 0)
            {
                _total_size_ += 1;
                int local_pack_size = 0;
                for (int i = 0; i < receiverUids.Count; ++i)
                    local_pack_size += ComputeSize.ComputeInt64Size(receiverUids[i]);
                _total_size_ += local_pack_size + ComputeSize.ComputeInt32Size(local_pack_size);
            }
            if (mail != null)
            {
                _total_size_ += 1 + ComputeSize.ComputeMessageSize(mail);
            }
            if (!string.IsNullOrEmpty(sendReason))
            {
                _total_size_ += 1 + ComputeSize.ComputeStringSize(sendReason);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (receiverUids != null && receiverUids.Count != 0)
            {
                output.WriteRawTag(10);
                int _total_pack_size_ = 0;
                for (int i = 0; i < receiverUids.Count; ++i)
                    _total_pack_size_ += ComputeSize.ComputeInt64Size(receiverUids[i]);
                output.WriteInt32(_total_pack_size_);
                for (int i = 0; i < receiverUids.Count; ++i)
                {
                    output.WriteInt64(receiverUids[i]);
                }
            }
            if (mail != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(mail);
            }
            if (!string.IsNullOrEmpty(sendReason))
            {
                output.WriteRawTag(26);
                output.WriteString(sendReason);
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
                        if (receiverUids == null)
                            receiverUids = new List<long>();
                        input.ReadMessage(() => { receiverUids.Add(input.ReadInt64()); });
                    }
                    break;
                case 18:
                    {
                        if (mail == null)
                            mail = new MailDbRecord();
                        input.ReadMessage(mail);
                    }
                    break;
                case 26:
                    {
                        sendReason = input.ReadString();
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }
    public class C2WMailRequest
    {
        public C2WMailRequest(RPCILocalCall l)
        {
            local = l;
        }
        RPCILocalCall local;
        public void QueryMails(Int64 input, System.Action<wProtobuf.RPC.Error, MailRecords> onEnd)
        {
            local.Call("C2WMail.QueryMails", input, onEnd);
        }
        public wProtobufRPC.IYieldResult<MailRecords> QueryMailsYield(Int64 input)
        {
            wProtobufRPC.IYieldResult<MailRecords> info = wProtobufRPC.YieldFactory.Create<MailRecords>();
            QueryMails(input, info.OnEnd);
            return info;
        }
        public void SetReadMark(Int64 input, System.Action<wProtobuf.RPC.Error> onEnd)
        {
            local.Call("C2WMail.SetReadMark", input, onEnd);
        }
        public wProtobufRPC.IYieldResult SetReadMarkYield(Int64 input)
        {
            wProtobufRPC.IYieldResult info = wProtobufRPC.YieldFactory.Create();
            SetReadMark(input, info.OnEnd);
            return info;
        }
        public void RemoveMail(Int64 input, System.Action<wProtobuf.RPC.Error> onEnd)
        {
            local.Call("C2WMail.RemoveMail", input, onEnd);
        }
        public wProtobufRPC.IYieldResult RemoveMailYield(Int64 input)
        {
            wProtobufRPC.IYieldResult info = wProtobufRPC.YieldFactory.Create();
            RemoveMail(input, info.OnEnd);
            return info;
        }
        public void FetchAttachment(Int64 input, System.Action<wProtobuf.RPC.Error> onEnd)
        {
            local.Call("C2WMail.FetchAttachment", input, onEnd);
        }
        public wProtobufRPC.IYieldResult FetchAttachmentYield(Int64 input)
        {
            wProtobufRPC.IYieldResult info = wProtobufRPC.YieldFactory.Create();
            FetchAttachment(input, info.OnEnd);
            return info;
        }
    }
    public abstract class C2WMailRespone
    {
        public C2WMailRespone(RPCIRemoteCall r)
        {
            r.Reg<Int64, MailRecords>("C2WMail.QueryMails", OnQueryMails);
            r.Reg<Int64>("C2WMail.SetReadMark", OnSetReadMark);
            r.Reg<Int64>("C2WMail.RemoveMail", OnRemoveMail);
            r.Reg<Int64>("C2WMail.FetchAttachment", OnFetchAttachment);
        }

        protected abstract MailRecords OnQueryMails(Int64 input);
        protected abstract void OnSetReadMark(Int64 input);
        protected abstract void OnRemoveMail(Int64 input);
        protected abstract void OnFetchAttachment(Int64 input);
        public static void Reg(RPCIRemoteCall r, IC2WMailRespone respone)
        {
            r.Reg<Int64, MailRecords>("C2WMail.QueryMails", respone.OnQueryMails);
            r.Reg<Int64>("C2WMail.SetReadMark", respone.OnSetReadMark);
            r.Reg<Int64>("C2WMail.RemoveMail", respone.OnRemoveMail);
            r.Reg<Int64>("C2WMail.FetchAttachment", respone.OnFetchAttachment);
        }
    }
    public interface IC2WMailRespone
    {
        MailRecords OnQueryMails(Int64 input);
        void OnSetReadMark(Int64 input);
        void OnRemoveMail(Int64 input);
        void OnFetchAttachment(Int64 input);
    }
}