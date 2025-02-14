using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MindTrade.Models;

namespace MindTrade.Data
{
    //Segundo Gemini
    public class MindTradeContext : DbContext
    {
        public MindTradeContext (DbContextOptions<MindTradeContext> options)
            : base(options)
        {
        }

        public DbSet<MindTrade.Models.UsuarioModel> Usuarios { get; set; } = default!;
    }
    
    //Default
    //public class MindTradeContext : DbContext
    //{
    //    public MindTradeContext (DbContextOptions<MindTradeContext> options)
    //        : base(options)
    //    {
    //    }

    //    public DbSet<MindTrade.Models.UsuarioModel> UsuarioModel { get; set; } = default!;
    //}
}
