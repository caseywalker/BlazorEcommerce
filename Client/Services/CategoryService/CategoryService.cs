namespace BlazorEcommerce.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _client;

        public CategoryService(HttpClient client)
        {
            _client = client;
        }
        public List<Category> Categories { get; set; } = new List<Category>();

        public async Task GetCategories()
        {
            var response = await _client.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/category");
            if(response != null && response.Data != null)
            {
            Categories = response.Data;
            }
        }
    }
}
