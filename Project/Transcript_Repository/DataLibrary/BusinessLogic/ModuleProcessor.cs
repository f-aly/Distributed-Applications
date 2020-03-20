using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class ModuleProcessor
    {
        public static int CreateModule(int moduleId, string moduleTitle,
                int moduleResult, string moduleTrimester, string moduleComment)
        {

            ModuleModel data = new ModuleModel
            {
                ModuleId = moduleId,
                ModuleTitle = moduleTitle,
                ModuleResult = moduleResult,
                ModuleTrimester = moduleTrimester,
                ModuleComment = moduleComment
            };

            string sql = @"insert into dbo.Module (ModuleId, ModuleTitle, ModuleResult, ModuleTrimester, ModuleComment)
                            values (@ModuleId, @ModuleTitle, @ModuleResult, @ModuleTrimester, @ModuleComment);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<ModuleModel> LoadModules()
        {
            string sql = @"select Id, ModuleId, ModuleTitle, ModuleResult, ModuleTrimester, ModuleComment
                            from dbo.Module;";

            return SqlDataAccess.LoadData<ModuleModel>(sql);
        }
    }
}
