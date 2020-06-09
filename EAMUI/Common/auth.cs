using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EAMUI.Models;
using EAMUI.Common;

namespace EAMUI.Common
{
    public class auth
    {
        public static string DomainName = @"RICHMONDHILL\";
        private static object _syncLock = new object();
        private static System.Security.Principal.IPrincipal GetUser()
        {
            return System.Web.HttpContext.Current.User;
        }

        public static string GetCurrentUserName(bool removeDomainName = true)
        {
            string result = null;

            lock (_syncLock)
            {
                System.Security.Principal.IPrincipal usr = GetUser();

                if (usr == null || usr.Identity == null)
                {
                    result = string.Empty;
                }
                else
                {
                    string userName = usr.Identity.Name;
                    if (removeDomainName)
                        userName = userName.Replace(DomainName, "");

                    result = userName;
                }
            }

            return result;
        }


        public static UserInfo SearchUser(String start)
        {

            TrhWS.WebService testobj = new TrhWS.WebService();

            TrhWS.UserInfo[] temp = testobj.getADUserInfo(start);



            UserInfo userinfo = new UserInfo();

            userinfo.firstName = temp[0].firstName;
            userinfo.lastName = temp[0].lastName;
            userinfo.manager = temp[0].manager;
            userinfo.division = temp[0].division;
            userinfo.department = temp[0].department;
            userinfo.email = temp[0].mail;
            userinfo.mgrEmail = util.getEmailFromName(temp[0].manager);
            userinfo.samusername = temp[0].samAccountName;

            /** TEST **/
            //userinfo.mgrEmail = "jimmy.chao@richmondhill.ca";

            return userinfo;
        }
    }
}