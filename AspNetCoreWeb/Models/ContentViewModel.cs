using System;
using System.Collections.Generic;

namespace AspNetCoreWeb.Models
{
    public class ContentViewModel
    {
        /// <summary>
        /// �����б�
        /// </summary>
        public List<Content> Contents { get; set; }
        public DateTime modify_time { get; set; }
    }
}