using System;

namespace AspNetCoreWeb.Models
{
    public class Content
    {
        /// <summary>
        /// ����
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string content { get; set; }
        /// <summary>
        /// ״̬ 1���� 0ɾ��
        /// </summary>
        public int status { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime add_time { get; set; }
        /// <summary>
        /// �޸�ʱ��
        /// </summary>
        public DateTime modify_time { get; set; }
    }
}