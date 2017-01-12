﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {

            MESSAGE msg = new MESSAGE() {Id_Chatroom = 1, Id_User_Post = 1, Message_text = this.msg.Text };
            HttpClient clint = new HttpClient();
            clint.BaseAddress = new Uri("http://localhost:53098/");
            // var json = JsonConvert.SerializeObject(msg);
            // var stringContent = new Http
            var myContent = JsonConvert.SerializeObject(msg);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            HttpResponseMessage response = clint.PostAsync("/api/MESSAGEs/", byteContent).Result;
        }
    }
}
