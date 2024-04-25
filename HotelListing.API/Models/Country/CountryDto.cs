using HotelListing.API.Models.Hotel;

namespace HotelListing.API.Models.Country
{
    public class CountryDto : GetCountryDto
    {
        public List<HotelDto> Hotels { get; set; }
    }
}
