﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace XIIRPL2_18_Ticketing
{
    internal class koneksi
    {
        public static NpgsqlConnection conn = new NpgsqlConnection("Server = 127.0.0.1;Port=5432;Database=db_tiket_xii_rpl2_18;" + "User Id=postgres;Password=admin;");


    }
}
