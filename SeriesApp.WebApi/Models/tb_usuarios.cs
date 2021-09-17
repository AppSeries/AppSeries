using System;
using Microsoft.EntityFrameworkCore;

namespace SeriesApp.WebApi.Models
{
    public class tb_usuarios
    {
        public int Id_usuario {get;set;}
        public string nome_usuario {get;set;}
        public string email_usuario {get;set;}
        public string apelido_usuario {get;set;}
        public string senha_usuario {get;set;}


    }
}