// this file is gen by program, please do not modify it 
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Config
{
    public partial class GameMailTemplate 
    {
        static Dictionary<int, GameMailTemplate> DataList = new Dictionary<int, GameMailTemplate>();

        static public Dictionary<int, GameMailTemplate> GetAll()
        {
            return DataList;
        }

        static public GameMailTemplate Get(int key)
        {
            GameMailTemplate value = null;
            if (DataList.TryGetValue(key, out value))
                return value;
            CsvCommon.Log.Error("GameMailTemplate.Get({0}) not find!", key);
            return null;
        }



        // ID
        public int id { get; set; }

        // 标题
        public string title { get; set; }

        // 内容
        public string content { get; set; }

        // 附件
        public string attachementStr { get; set; }

        // 发送者
        public string sender { get; set; }


        public static void Load(CsvCommon.ICsvLoad reader)
        {
            if (DataList.Count != 0)
            {
                var type = typeof(GameMailTemplate);
                var method = type.GetMethod("OnReload", BindingFlags.Static | BindingFlags.NonPublic);
                if (method != null)
                    method.Invoke(null, new object[0]);
            }

            DataList.Clear();
            

            MethodInfo lineParseMethod = null;
            {
                var curType = typeof(GameMailTemplate);
                while (null != curType)
                {
                    lineParseMethod = curType.GetMethod("OnLoadEndLine");
                    if (null != lineParseMethod)
                        break;
                    curType = curType.BaseType;
                }
            }

            List<GameMailTemplate> allDatas = new List<GameMailTemplate>();

            {
                string file = "Mail/GameMailTemplate.txt"; 
                if (!reader.LoadFile(file, '	', false))
                    return;
                reader.generateKey(1); 
                int id_index = reader.GetIndex("id");
                int title_index = reader.GetIndex("title");
                int content_index = reader.GetIndex("content");
                int attachementStr_index = reader.GetIndex("attachementStr");
                int sender_index = reader.GetIndex("sender");
                for (int i = 3; i < reader.YCount; ++i)
                {
                    try
                    {
                        GameMailTemplate data = new GameMailTemplate();
						data.id = reader.getInt(i, id_index, 0);         
						data.title = reader.getStr(i, title_index);         
						data.content = reader.getStr(i, content_index);         
						data.attachementStr = reader.getStr(i, attachementStr_index);         
						data.sender = reader.getStr(i, sender_index);         
                        if (lineParseMethod != null)
                            lineParseMethod.Invoke(null, new object[3] {data, reader, i });
                        allDatas.Add(data);
                    }
                    catch (System.Exception ex)
                    {
                        CsvCommon.Log.Error("file:{0} line:{1} error!", file, i);
                        CsvCommon.Log.Exception(ex);
                    }
                }
            }
            
            foreach(var data in allDatas)
            {
                if (DataList.ContainsKey(data.id))
                {
                    CsvCommon.Log.Error("GameMailTemplate.id :{0} is repeated", data.id);
                }
                else
                {
                    DataList[data.id] = data;
                }
            }

            {
                MethodInfo method = null;
                {
                    var curType = typeof(GameMailTemplate);
                    while (null != curType)
                    {
                        method = curType.GetMethod("OnLoadEnd", BindingFlags.Static | BindingFlags.NonPublic);
                        if (null != method)
                            break;
                        curType = curType.BaseType;
                    }
                }
                if (method != null)
                    method.Invoke(null, new object[0]);
            }
        }
    }
}


