﻿namespace RealEstate_DapperApi_AbdulkadirArslan.Dtos.ContactDtos
{
    public class GetByIDContactDto
    {
        public int ContactID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime SendDate { get; set; }
    }
}
