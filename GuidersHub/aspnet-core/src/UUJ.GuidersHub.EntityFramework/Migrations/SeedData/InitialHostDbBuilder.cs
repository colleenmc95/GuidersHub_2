﻿using UUJ.GuidersHub.EntityFramework;
using EntityFramework.DynamicFilters;

namespace UUJ.GuidersHub.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly GuidersHubDbContext _context;

        public InitialHostDbBuilder(GuidersHubDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
