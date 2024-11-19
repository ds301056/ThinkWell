using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

public class ResourcesViewModel {
	private const string GooglePlacesApiUrl = "https://maps.googleapis.com/maps/api/place/nearbysearch/json";
	private const string GoogleApiKey = "AIzaSyD2qfEIPNdyf3dSqRdSxB6gZ4W2rZ8giAE";

	public List<Facility> Facilities { get; set; }

	public ResourcesViewModel() {
		Facilities = new List<Facility>();
	}

	public async Task FindNearbyMentalHealthFacilitiesAsync(double latitude, double longitude) {
		try {
			using (HttpClient client = new HttpClient()) {
				var response = await client.GetStringAsync(
					$"{GooglePlacesApiUrl}?location={latitude},{longitude}&radius=5000&keyword=therapist|psychologist&key={GoogleApiKey}");

				var result = JsonConvert.DeserializeObject<GooglePlacesApiResponse>(response);

				if (result.status == "OK") {
					Facilities = result.results;
				}
			}
		}
		catch (Exception ex) {
			// Handle exceptions
		}
	}
}

public class GooglePlacesApiResponse {
	public string status { get; set; }
	public List<Facility> results { get; set; }
}
