﻿namespace HotelProject.WebUI.Dtos.Followers
{
    public class ResultLinkedinFollowersDto
    {
        public Data data { get; set; }
        public class Data
        {
            public int followers_count { get; set; }
        }
    }
}