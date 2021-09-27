﻿using Microsoft.AspNetCore.Mvc;
using SourceStacks.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SourceStacks.Pages.Entities
{
    public class Component
    {

        public IList<List<Keyword>> Keywords { get; set; }
        public IViewComponentResult Invoke()
        {
            Keywords = new List<List<Keyword>>
            {
                new List<Keyword>
                {
                new Keyword{ Name="工具软件"},
                new Keyword{ Name="顾问咨询"},
                new Keyword{ Name="Linq"},
                },
                new List<Keyword>
                {
                new Keyword{ Name="Vue"},
                new Keyword{ Name="数据库"},
                new Keyword{ Name="后端"},
                },
                new List<Keyword>
                {

                new Keyword{ Name="前端"},
                new Keyword{ Name="Html"},
                new Keyword{ Name="操作系统"},
                },
                new List<Keyword>
                {
                new Keyword{ Name="前端"},
                new Keyword{ Name="Html"},
                new Keyword{ Name="操作系统"},
                },
                new List<Keyword>
                {
                new Keyword{ Name="前端"},
                new Keyword{ Name="Html"},
                new Keyword{ Name="操作系统"},
                }

                            };
            return View(Keywords);
        }

        private IViewComponentResult View(IList<List<Keyword>> keywords)
        {
            throw new NotImplementedException();
        }
    }
}
