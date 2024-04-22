﻿namespace RealEstate_DapperApi_AbdulkadirArslan.Dtos.ProductDtos
{
    public class ResultLast5ProductWithCategoryDto
    {
        public int ProductID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string CoverImage { get; set; }
        public string Type { get; set; }
        public string Address { get; set; }
        public bool DealOfTheDay { get; set; }
        public int ProductCategory { get; set; }   
        public string CategoryName { get; set; }
        public DateTime AdvertisementDate { get; set; }
    }
}