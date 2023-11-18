using DAT_Context;
using DAT_Context.Seeding;

DAT_DbContext dat = new DAT_DbContext();
RolesSeeding.SeedData(dat);