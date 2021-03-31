﻿using farmers_market_rest_api.Domain.Models.Area;
using farmers_market_rest_api.Domain.Models.User;
using System;
using System.Collections.Generic;

namespace farmers_market_rest_api.Domain.Models.Business
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public float Price { get; set; }

        public int Quantity { get; set; }

        public string ImageUrl1 { get; set; }

        public string ImageUrl2 { get; set; }

        public string FarmerId { get; set; }

        public ApplicationUser Farmer { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public int? DivisionId { get; set; }

        public Division Division { get; set; }

        public string DivisionName { get; set; }


        public int? DistrictId { get; set; }

        public District District { get; set; }

        public string DistrictName { get; set; }


        public int? UpozilaId { get; set; }

        public Upozila Upozilla { get; set; }

        public string UpozilaName { get; set; }


        public int? UnionOrWardId { get; set; }

        public UnionOrWard UnionOrWard { get; set; }

        public string UnionOrWardName { get; set; }


        public int? MarketId { get; set; }

        public Market Market { get; set; }

        public string MarketName { get; set; }

        public string MarketCode { get; set; }


        public virtual List<OrderDetails> OrderDetails { get; set; }
    }
}
