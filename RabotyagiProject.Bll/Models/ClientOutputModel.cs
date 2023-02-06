﻿namespace RabotyagiProject.Bll.Models
{
    public class ClientOutputModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public List<OrderOutputModel> Orders { get; set; }
    }
}
