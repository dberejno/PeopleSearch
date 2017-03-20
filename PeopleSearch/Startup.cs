using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Infrastructure;
using System.Diagnostics;
using Microsoft.Owin;
using Owin;
using PeopleSearch.Migrations;
using PeopleSearch.Models;

[assembly: OwinStartupAttribute(typeof(PeopleSearch.Startup))]
namespace PeopleSearch
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
		}
    }
}
