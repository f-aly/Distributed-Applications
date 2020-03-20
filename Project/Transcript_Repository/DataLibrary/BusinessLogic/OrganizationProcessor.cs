using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class OrganizationProcessor
    {
        public static int CreateOrganization(int organizationId, string organizationName, string organizationEmail)
        {
            OrganizationModel data = new OrganizationModel
            {
                OrganizationId = organizationId,
                OrganizationName = organizationName,
                OrganizationEmail = organizationEmail
            };

            // @ tells it it's a variable.  it's teh data you're paassign with the statment. 
            // e.g @ModuleId's value is going to be stored in moduleId
            string sql = @"insert into dbo.Organization (OrganizationId, OrganizationName, OrganizationEmail)
                            values (@OrganizationId, @OrganizationName, @OrganizationEmail);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<OrganizationModel> LoadOrganizations()
        {
            string sql = @"select Id, OrganizationId, OrganizationName, OrganizationEmail
                            from dbo.Organization;";

            return SqlDataAccess.LoadData<OrganizationModel>(sql);
        }

    }
}
