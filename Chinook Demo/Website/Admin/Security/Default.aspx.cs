using Chinook.Framework.BLL.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Security_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected List<string> GetRoleNames()
    {
        var mgr = new RoleManager();
        List<string> data = mgr.Roles.Select(r => r.Name).ToList();
        return data;
    }
}