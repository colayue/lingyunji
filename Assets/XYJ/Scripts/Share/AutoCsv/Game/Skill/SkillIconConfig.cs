// this file is gen by program, please do not modify it 
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Config
{
    public partial class SkillIconConfig 
    {
        static Dictionary<int, SkillIconConfig> DataList = new Dictionary<int, SkillIconConfig>();

        static public Dictionary<int, SkillIconConfig> GetAll()
        {
            return DataList;
        }

        static public SkillIconConfig Get(int key)
        {
            SkillIconConfig value = null;
            if (DataList.TryGetValue(key, out value))
                return value;
            CsvCommon.Log.Error("SkillIconConfig.Get({0}) not find!", key);
            return null;
        }



        // 技能ID
        public int id { get; set; }

        // 备注
        public string des { get; set; }

        // 图标
        public string icon { get; set; }


        public static void Load(CsvCommon.ICsvLoad reader)
        {
            if (DataList.Count != 0)
            {
                var type = typeof(SkillIconConfig);
                var method = type.GetMethod("OnReload", BindingFlags.Static | BindingFlags.NonPublic);
                if (method != null)
                    method.Invoke(null, new object[0]);
            }

            DataList.Clear();
            

            MethodInfo lineParseMethod = null;
            {
                var curType = typeof(SkillIconConfig);
                while (null != curType)
                {
                    lineParseMethod = curType.GetMethod("OnLoadEndLine");
                    if (null != lineParseMethod)
                        break;
                    curType = curType.BaseType;
                }
            }

            List<SkillIconConfig> allDatas = new List<SkillIconConfig>();

            {
                string file = "Skill/SkillIconConfig.txt"; 
                if (!reader.LoadFile(file, '	', false))
                    return;
                reader.generateKey(1); 
                int id_index = reader.GetIndex("id");
                int des_index = reader.GetIndex("des");
                int icon_index = reader.GetIndex("icon");
                for (int i = 3; i < reader.YCount; ++i)
                {
                    try
                    {
                        SkillIconConfig data = new SkillIconConfig();
						data.id = reader.getInt(i, id_index, 0);         
						data.des = reader.getStr(i, des_index);         
						data.icon = reader.getStr(i, icon_index);         
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
                    CsvCommon.Log.Error("SkillIconConfig.id :{0} is repeated", data.id);
                }
                else
                {
                    DataList[data.id] = data;
                }
            }

            {
                MethodInfo method = null;
                {
                    var curType = typeof(SkillIconConfig);
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


