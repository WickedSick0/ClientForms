﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientForms
{
    public class MESSAGE
    {
        public int Id { get; set; }

        public int Id_Chatroom { get; set; }

        public int Id_User_Post { get; set; }

        public string Message_text { get; set; }

        public DateTime Send_time { get; set; }
    }
}
