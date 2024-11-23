using HotelProject.WebUI.Dtos.Followers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardSubscribeCountPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofile/atacanguzelkaya"),
                Headers =
    {
        { "x-rapidapi-key", "7d4d381d99mshe5918e75b67b15ap1f1272jsnf639ac9d84dc" },
        { "x-rapidapi-host", "instagram-profile1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                ResultInstagramFollowersDto resultInstagramFollowers = JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body);
                ViewBag.InstagramFollowers = resultInstagramFollowers.followers;
                ViewBag.InstagramFollowing = resultInstagramFollowers.following;
            }

            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://fresh-linkedin-profile-data.p.rapidapi.com/get-linkedin-profile?linkedin_url=https%3A%2F%2Fwww.linkedin.com%2Fin%2Fatacan-guzelkaya%2F&include_skills=false&include_certifications=false&include_publications=false&include_honors=false&include_volunteers=false&include_projects=false&include_patents=false&include_courses=false&include_organizations=false&include_profile_status=false&include_company_public_url=false"),
                Headers =
    {
        { "x-rapidapi-key", "7d4d381d99mshe5918e75b67b15ap1f1272jsnf639ac9d84dc" },
        { "x-rapidapi-host", "fresh-linkedin-profile-data.p.rapidapi.com" },
    },
            };
            using (var response2 = await client2.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body2 = await response2.Content.ReadAsStringAsync();
                ResultLinkedinFollowersDto resultLinkedinFollowers = JsonConvert.DeserializeObject<ResultLinkedinFollowersDto>(body2);
                ViewBag.LinkedinFollowers = resultLinkedinFollowers.data.followers_count;
            }

            return View();
        }
    }
}
