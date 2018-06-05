// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: ClientProto/Task/Task.proto

using wProtobuf;
using System.Collections;
using System.Collections.Generic;
using wProtobufRPC = wProtobuf.RPC;
using RPCILocalCall = wProtobuf.RPC.ILocalCall;
using RPCIRemoteCall = wProtobuf.RPC.IRemoteCall;

namespace NetProto
{
    public enum TaskCounterType
    {
        ItemCount = 0,
        NpcDead = 1,
        LevelPass = 2,
    }
    public enum TaskStatus
    {
        Unaccepted = 0,
        Acceptable = 1,
        Accepted = 2,
        Completed = 3,
        Submit = 4,
        Finished = 5,
    }
    public enum TaskType
    {
        Invalid = 0,
        Main = 1,
        Branch = 2,
        Guide = 3,
        Loop = 4,
    }
    public class TaskData : IMessage
    {
        public TaskMainData main = new TaskMainData();
        public List<TaskLoopData> loops = new List<TaskLoopData>();
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (main != null)
            {
                _total_size_ += 1 + ComputeSize.ComputeMessageSize(main);
            }
            if (loops != null && loops.Count != 0)
            {
                _total_size_ += 1 * loops.Count;
                for (int i = 0; i < loops.Count; ++i)
                    _total_size_ += ComputeSize.ComputeMessageSize(loops[i]);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (main != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(main);
            }
            if (loops != null && loops.Count != 0)
            {
                for (int i = 0; i < loops.Count; ++i)
                {
                    output.WriteRawTag(18);
                    output.WriteMessage(loops[i]);
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
                        if (main == null)
                            main = new TaskMainData();
                        input.ReadMessage(main);
                    }
                    break;
                case 18:
                    {
                        if (loops == null)
                            loops = new List<TaskLoopData>();
                        var local_temp = new TaskLoopData();
                        input.ReadMessage(local_temp);
                        loops.Add(local_temp);
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class TaskMainData : IMessage
    {
        public TaskDbRecord curTask = new TaskDbRecord();
        public int chapterOrder = 0;
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (curTask != null)
            {
                _total_size_ += 1 + ComputeSize.ComputeMessageSize(curTask);
            }
            if (chapterOrder != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(chapterOrder);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (curTask != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(curTask);
            }
            if (chapterOrder != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(chapterOrder);
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
                        if (curTask == null)
                            curTask = new TaskDbRecord();
                        input.ReadMessage(curTask);
                    }
                    break;
                case 16:
                    {
                        chapterOrder = input.ReadInt32();
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class TaskLoopData : IMessage
    {
        public TaskDbRecord curTask = new TaskDbRecord();
        public int loopId = 0;
        public int curLoopNum = 0;
        public int curRound = 0;
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (curTask != null)
            {
                _total_size_ += 1 + ComputeSize.ComputeMessageSize(curTask);
            }
            if (loopId != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(loopId);
            }
            if (curLoopNum != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(curLoopNum);
            }
            if (curRound != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(curRound);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (curTask != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(curTask);
            }
            if (loopId != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(loopId);
            }
            if (curLoopNum != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(curLoopNum);
            }
            if (curRound != 0)
            {
                output.WriteRawTag(32);
                output.WriteInt32(curRound);
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
                        if (curTask == null)
                            curTask = new TaskDbRecord();
                        input.ReadMessage(curTask);
                    }
                    break;
                case 16:
                    {
                        loopId = input.ReadInt32();
                    }
                    break;
                case 24:
                    {
                        curLoopNum = input.ReadInt32();
                    }
                    break;
                case 32:
                    {
                        curRound = input.ReadInt32();
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class TaskDbRecord : IMessage
    {
        public int taskId = 0;
        public int groupId = 0;
        public TaskStatus status = TaskStatus.Unaccepted;
        public TaskType type = TaskType.Invalid;
        public long startTime = 0L;
        public long timeLimit = 0L;
        public List<TaskCompletedItem> itemCounts = new List<TaskCompletedItem>();
        public List<TaskCompletedObject> objectCounts = new List<TaskCompletedObject>();
        public List<TaskCompletedLevel> levelCounts = new List<TaskCompletedLevel>();
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (taskId != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(taskId);
            }
            if (groupId != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(groupId);
            }
            if (status != TaskStatus.Unaccepted)
            {
                _total_size_ += 1 + ComputeSize.ComputeEnumSize((int)status);
            }
            if (type != TaskType.Invalid)
            {
                _total_size_ += 1 + ComputeSize.ComputeEnumSize((int)type);
            }
            if (startTime != 0L)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt64Size(startTime);
            }
            if (timeLimit != 0L)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt64Size(timeLimit);
            }
            if (itemCounts != null && itemCounts.Count != 0)
            {
                _total_size_ += 1 * itemCounts.Count;
                for (int i = 0; i < itemCounts.Count; ++i)
                    _total_size_ += ComputeSize.ComputeMessageSize(itemCounts[i]);
            }
            if (objectCounts != null && objectCounts.Count != 0)
            {
                _total_size_ += 1 * objectCounts.Count;
                for (int i = 0; i < objectCounts.Count; ++i)
                    _total_size_ += ComputeSize.ComputeMessageSize(objectCounts[i]);
            }
            if (levelCounts != null && levelCounts.Count != 0)
            {
                _total_size_ += 1 * levelCounts.Count;
                for (int i = 0; i < levelCounts.Count; ++i)
                    _total_size_ += ComputeSize.ComputeMessageSize(levelCounts[i]);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (taskId != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(taskId);
            }
            if (groupId != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(groupId);
            }
            if (status != TaskStatus.Unaccepted)
            {
                output.WriteRawTag(24);
                output.WriteEnum((int)status);
            }
            if (type != TaskType.Invalid)
            {
                output.WriteRawTag(32);
                output.WriteEnum((int)type);
            }
            if (startTime != 0L)
            {
                output.WriteRawTag(40);
                output.WriteInt64(startTime);
            }
            if (timeLimit != 0L)
            {
                output.WriteRawTag(48);
                output.WriteInt64(timeLimit);
            }
            if (itemCounts != null && itemCounts.Count != 0)
            {
                for (int i = 0; i < itemCounts.Count; ++i)
                {
                    output.WriteRawTag(58);
                    output.WriteMessage(itemCounts[i]);
                }
            }
            if (objectCounts != null && objectCounts.Count != 0)
            {
                for (int i = 0; i < objectCounts.Count; ++i)
                {
                    output.WriteRawTag(66);
                    output.WriteMessage(objectCounts[i]);
                }
            }
            if (levelCounts != null && levelCounts.Count != 0)
            {
                for (int i = 0; i < levelCounts.Count; ++i)
                {
                    output.WriteRawTag(74);
                    output.WriteMessage(levelCounts[i]);
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
                        taskId = input.ReadInt32();
                    }
                    break;
                case 16:
                    {
                        groupId = input.ReadInt32();
                    }
                    break;
                case 24:
                    {
                        status = (TaskStatus)input.ReadEnum();
                    }
                    break;
                case 32:
                    {
                        type = (TaskType)input.ReadEnum();
                    }
                    break;
                case 40:
                    {
                        startTime = input.ReadInt64();
                    }
                    break;
                case 48:
                    {
                        timeLimit = input.ReadInt64();
                    }
                    break;
                case 58:
                    {
                        if (itemCounts == null)
                            itemCounts = new List<TaskCompletedItem>();
                        var local_temp = new TaskCompletedItem();
                        input.ReadMessage(local_temp);
                        itemCounts.Add(local_temp);
                    }
                    break;
                case 66:
                    {
                        if (objectCounts == null)
                            objectCounts = new List<TaskCompletedObject>();
                        var local_temp = new TaskCompletedObject();
                        input.ReadMessage(local_temp);
                        objectCounts.Add(local_temp);
                    }
                    break;
                case 74:
                    {
                        if (levelCounts == null)
                            levelCounts = new List<TaskCompletedLevel>();
                        var local_temp = new TaskCompletedLevel();
                        input.ReadMessage(local_temp);
                        levelCounts.Add(local_temp);
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class TaskCompletedCounter : IMessage
    {
        public int itemId = 0;
        public int curCount = 0;
        public int totalCount = 0;
        public TaskCounterType type = TaskCounterType.ItemCount;
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (itemId != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(itemId);
            }
            if (curCount != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(curCount);
            }
            if (totalCount != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(totalCount);
            }
            if (type != TaskCounterType.ItemCount)
            {
                _total_size_ += 1 + ComputeSize.ComputeEnumSize((int)type);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (itemId != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(itemId);
            }
            if (curCount != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(curCount);
            }
            if (totalCount != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(totalCount);
            }
            if (type != TaskCounterType.ItemCount)
            {
                output.WriteRawTag(32);
                output.WriteEnum((int)type);
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
                        itemId = input.ReadInt32();
                    }
                    break;
                case 16:
                    {
                        curCount = input.ReadInt32();
                    }
                    break;
                case 24:
                    {
                        totalCount = input.ReadInt32();
                    }
                    break;
                case 32:
                    {
                        type = (TaskCounterType)input.ReadEnum();
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class TaskCompletedItem : IMessage
    {
        public int itemId = 0;
        public int curCount = 0;
        public int totalCount = 0;
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (itemId != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(itemId);
            }
            if (curCount != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(curCount);
            }
            if (totalCount != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(totalCount);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (itemId != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(itemId);
            }
            if (curCount != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(curCount);
            }
            if (totalCount != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(totalCount);
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
                        itemId = input.ReadInt32();
                    }
                    break;
                case 16:
                    {
                        curCount = input.ReadInt32();
                    }
                    break;
                case 24:
                    {
                        totalCount = input.ReadInt32();
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class TaskCompletedObject : IMessage
    {
        public int objId = 0;
        public int curCount = 0;
        public int totalCount = 0;
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (objId != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(objId);
            }
            if (curCount != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(curCount);
            }
            if (totalCount != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(totalCount);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (objId != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(objId);
            }
            if (curCount != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(curCount);
            }
            if (totalCount != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(totalCount);
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
                        objId = input.ReadInt32();
                    }
                    break;
                case 16:
                    {
                        curCount = input.ReadInt32();
                    }
                    break;
                case 24:
                    {
                        totalCount = input.ReadInt32();
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class TaskCompletedLevel : IMessage
    {
        public int levelId = 0;
        public int curCount = 0;
        public int totalCount = 0;
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (levelId != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(levelId);
            }
            if (curCount != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(curCount);
            }
            if (totalCount != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(totalCount);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (levelId != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(levelId);
            }
            if (curCount != 0)
            {
                output.WriteRawTag(16);
                output.WriteInt32(curCount);
            }
            if (totalCount != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(totalCount);
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
                        levelId = input.ReadInt32();
                    }
                    break;
                case 16:
                    {
                        curCount = input.ReadInt32();
                    }
                    break;
                case 24:
                    {
                        totalCount = input.ReadInt32();
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class TaskStatusChangeRespon : IMessage
    {
        public int taskId = 0;
        public TaskType taskType = TaskType.Invalid;
        public TaskStatus status = TaskStatus.Unaccepted;
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (taskId != 0)
            {
                _total_size_ += 1 + ComputeSize.ComputeInt32Size(taskId);
            }
            if (taskType != TaskType.Invalid)
            {
                _total_size_ += 1 + ComputeSize.ComputeEnumSize((int)taskType);
            }
            if (status != TaskStatus.Unaccepted)
            {
                _total_size_ += 1 + ComputeSize.ComputeEnumSize((int)status);
            }
            return _total_size_;
        }
        public void WriteTo(IWriteStream output)
        {
            if (taskId != 0)
            {
                output.WriteRawTag(8);
                output.WriteInt32(taskId);
            }
            if (taskType != TaskType.Invalid)
            {
                output.WriteRawTag(16);
                output.WriteEnum((int)taskType);
            }
            if (status != TaskStatus.Unaccepted)
            {
                output.WriteRawTag(24);
                output.WriteEnum((int)status);
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
                        taskId = input.ReadInt32();
                    }
                    break;
                case 16:
                    {
                        taskType = (TaskType)input.ReadEnum();
                    }
                    break;
                case 24:
                    {
                        status = (TaskStatus)input.ReadEnum();
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class TaskRecordRespon : IMessage
    {
        public ReturnCode code = ReturnCode.ReturnCode_OK;
        public TaskDbRecord dbRecord = new TaskDbRecord();
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (code != ReturnCode.ReturnCode_OK)
            {
                _total_size_ += 1 + ComputeSize.ComputeEnumSize((int)code);
            }
            if (dbRecord != null)
            {
                _total_size_ += 1 + ComputeSize.ComputeMessageSize(dbRecord);
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
            if (dbRecord != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(dbRecord);
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
                        if (dbRecord == null)
                            dbRecord = new TaskDbRecord();
                        input.ReadMessage(dbRecord);
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }

    public class TaskLoopRecordRespon : IMessage
    {
        public ReturnCode code = ReturnCode.ReturnCode_OK;
        public TaskLoopData loop = new TaskLoopData();
        public int CalculateSize()
        {
            int _total_size_ = 0;
            if (code != ReturnCode.ReturnCode_OK)
            {
                _total_size_ += 1 + ComputeSize.ComputeEnumSize((int)code);
            }
            if (loop != null)
            {
                _total_size_ += 1 + ComputeSize.ComputeMessageSize(loop);
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
            if (loop != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(loop);
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
                        if (loop == null)
                            loop = new TaskLoopData();
                        input.ReadMessage(loop);
                    }
                    break;
                default:
                    input.SkipLastField(tag);
                    break;
                }
            }
        }
    }
    public class C2ATaskRequest
    {
        public C2ATaskRequest(RPCILocalCall l)
        {
            local = l;
        }
        RPCILocalCall local;
        public void GetTaskMainReq(None input, System.Action<wProtobuf.RPC.Error, TaskRecordRespon> onEnd)
        {
            local.Call("C2ATask.GetTaskMainReq", input, onEnd);
        }
        public wProtobufRPC.IYieldResult<TaskRecordRespon> GetTaskMainReqYield(None input)
        {
            wProtobufRPC.IYieldResult<TaskRecordRespon> info = wProtobufRPC.YieldFactory.Create<TaskRecordRespon>();
            GetTaskMainReq(input, info.OnEnd);
            return info;
        }
        public void GetTaskLoopReq(Int32 input, System.Action<wProtobuf.RPC.Error, TaskLoopRecordRespon> onEnd)
        {
            local.Call("C2ATask.GetTaskLoopReq", input, onEnd);
        }
        public wProtobufRPC.IYieldResult<TaskLoopRecordRespon> GetTaskLoopReqYield(Int32 input)
        {
            wProtobufRPC.IYieldResult<TaskLoopRecordRespon> info = wProtobufRPC.YieldFactory.Create<TaskLoopRecordRespon>();
            GetTaskLoopReq(input, info.OnEnd);
            return info;
        }
        public void AcceptedTaskReq(Int32 input, System.Action<wProtobuf.RPC.Error, ReturnCodeData> onEnd)
        {
            local.Call("C2ATask.AcceptedTaskReq", input, onEnd);
        }
        public wProtobufRPC.IYieldResult<ReturnCodeData> AcceptedTaskReqYield(Int32 input)
        {
            wProtobufRPC.IYieldResult<ReturnCodeData> info = wProtobufRPC.YieldFactory.Create<ReturnCodeData>();
            AcceptedTaskReq(input, info.OnEnd);
            return info;
        }
        public void SubmitTaskReq(Int32 input, System.Action<wProtobuf.RPC.Error, ReturnCodeData> onEnd)
        {
            local.Call("C2ATask.SubmitTaskReq", input, onEnd);
        }
        public wProtobufRPC.IYieldResult<ReturnCodeData> SubmitTaskReqYield(Int32 input)
        {
            wProtobufRPC.IYieldResult<ReturnCodeData> info = wProtobufRPC.YieldFactory.Create<ReturnCodeData>();
            SubmitTaskReq(input, info.OnEnd);
            return info;
        }
        public void GiveupTaskReq(Int32 input, System.Action<wProtobuf.RPC.Error, ReturnCodeData> onEnd)
        {
            local.Call("C2ATask.GiveupTaskReq", input, onEnd);
        }
        public wProtobufRPC.IYieldResult<ReturnCodeData> GiveupTaskReqYield(Int32 input)
        {
            wProtobufRPC.IYieldResult<ReturnCodeData> info = wProtobufRPC.YieldFactory.Create<ReturnCodeData>();
            GiveupTaskReq(input, info.OnEnd);
            return info;
        }
    }
    public abstract class C2ATaskRespone
    {
        public C2ATaskRespone(RPCIRemoteCall r)
        {
            r.Reg<None, TaskRecordRespon>("C2ATask.GetTaskMainReq", OnGetTaskMainReq);
            r.Reg<Int32, TaskLoopRecordRespon>("C2ATask.GetTaskLoopReq", OnGetTaskLoopReq);
            r.Reg<Int32, ReturnCodeData>("C2ATask.AcceptedTaskReq", OnAcceptedTaskReq);
            r.Reg<Int32, ReturnCodeData>("C2ATask.SubmitTaskReq", OnSubmitTaskReq);
            r.Reg<Int32, ReturnCodeData>("C2ATask.GiveupTaskReq", OnGiveupTaskReq);
        }

        protected abstract TaskRecordRespon OnGetTaskMainReq(None input);
        protected abstract TaskLoopRecordRespon OnGetTaskLoopReq(Int32 input);
        protected abstract ReturnCodeData OnAcceptedTaskReq(Int32 input);
        protected abstract ReturnCodeData OnSubmitTaskReq(Int32 input);
        protected abstract ReturnCodeData OnGiveupTaskReq(Int32 input);
        public static void Reg(RPCIRemoteCall r, IC2ATaskRespone respone)
        {
            r.Reg<None, TaskRecordRespon>("C2ATask.GetTaskMainReq", respone.OnGetTaskMainReq);
            r.Reg<Int32, TaskLoopRecordRespon>("C2ATask.GetTaskLoopReq", respone.OnGetTaskLoopReq);
            r.Reg<Int32, ReturnCodeData>("C2ATask.AcceptedTaskReq", respone.OnAcceptedTaskReq);
            r.Reg<Int32, ReturnCodeData>("C2ATask.SubmitTaskReq", respone.OnSubmitTaskReq);
            r.Reg<Int32, ReturnCodeData>("C2ATask.GiveupTaskReq", respone.OnGiveupTaskReq);
        }
    }
    public interface IC2ATaskRespone
    {
        TaskRecordRespon OnGetTaskMainReq(None input);
        TaskLoopRecordRespon OnGetTaskLoopReq(Int32 input);
        ReturnCodeData OnAcceptedTaskReq(Int32 input);
        ReturnCodeData OnSubmitTaskReq(Int32 input);
        ReturnCodeData OnGiveupTaskReq(Int32 input);
    }
    public class C2ATaskGMRequest
    {
        public C2ATaskGMRequest(RPCILocalCall l)
        {
            local = l;
        }
        RPCILocalCall local;
        public void ClearAllTasksReq(None input, System.Action<wProtobuf.RPC.Error, ReturnCodeData> onEnd)
        {
            local.Call("C2ATaskGM.ClearAllTasksReq", input, onEnd);
        }
        public wProtobufRPC.IYieldResult<ReturnCodeData> ClearAllTasksReqYield(None input)
        {
            wProtobufRPC.IYieldResult<ReturnCodeData> info = wProtobufRPC.YieldFactory.Create<ReturnCodeData>();
            ClearAllTasksReq(input, info.OnEnd);
            return info;
        }
        public void AddTaskReq(Int32 input, System.Action<wProtobuf.RPC.Error, ReturnCodeData> onEnd)
        {
            local.Call("C2ATaskGM.AddTaskReq", input, onEnd);
        }
        public wProtobufRPC.IYieldResult<ReturnCodeData> AddTaskReqYield(Int32 input)
        {
            wProtobufRPC.IYieldResult<ReturnCodeData> info = wProtobufRPC.YieldFactory.Create<ReturnCodeData>();
            AddTaskReq(input, info.OnEnd);
            return info;
        }
        public void CompletedTaskReq(Int32 input, System.Action<wProtobuf.RPC.Error, ReturnCodeData> onEnd)
        {
            local.Call("C2ATaskGM.CompletedTaskReq", input, onEnd);
        }
        public wProtobufRPC.IYieldResult<ReturnCodeData> CompletedTaskReqYield(Int32 input)
        {
            wProtobufRPC.IYieldResult<ReturnCodeData> info = wProtobufRPC.YieldFactory.Create<ReturnCodeData>();
            CompletedTaskReq(input, info.OnEnd);
            return info;
        }
    }
    public abstract class C2ATaskGMRespone
    {
        public C2ATaskGMRespone(RPCIRemoteCall r)
        {
            r.Reg<None, ReturnCodeData>("C2ATaskGM.ClearAllTasksReq", OnClearAllTasksReq);
            r.Reg<Int32, ReturnCodeData>("C2ATaskGM.AddTaskReq", OnAddTaskReq);
            r.Reg<Int32, ReturnCodeData>("C2ATaskGM.CompletedTaskReq", OnCompletedTaskReq);
        }

        protected abstract ReturnCodeData OnClearAllTasksReq(None input);
        protected abstract ReturnCodeData OnAddTaskReq(Int32 input);
        protected abstract ReturnCodeData OnCompletedTaskReq(Int32 input);
        public static void Reg(RPCIRemoteCall r, IC2ATaskGMRespone respone)
        {
            r.Reg<None, ReturnCodeData>("C2ATaskGM.ClearAllTasksReq", respone.OnClearAllTasksReq);
            r.Reg<Int32, ReturnCodeData>("C2ATaskGM.AddTaskReq", respone.OnAddTaskReq);
            r.Reg<Int32, ReturnCodeData>("C2ATaskGM.CompletedTaskReq", respone.OnCompletedTaskReq);
        }
    }
    public interface IC2ATaskGMRespone
    {
        ReturnCodeData OnClearAllTasksReq(None input);
        ReturnCodeData OnAddTaskReq(Int32 input);
        ReturnCodeData OnCompletedTaskReq(Int32 input);
    }
}
